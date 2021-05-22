using LogicalSchemeManager;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestUnit
{

    [TestClass]
    public class ProgramManagerTest
    {
        #region Fields
        /// <summary>
        /// This field is the main program that is tested
        /// </summary>
        private ProgramManager _programManager;

        /// <summary>
        /// The terminal on which the test will be conducted
        /// </summary>
        private Logger _logger = new Logger();
        #endregion

        #region Properties
        /// <summary>
        /// This propery makes the StartingPoint more accessible 
        /// </summary>
        private ICommand StartPoint => _programManager.Connections.StartPoint;

        /// <summary>
        /// This property makes the EndingPoint more accessible
        /// </summary>
        private ICommand EndPoint => _programManager.Connections.EndPoint;

        /// <summary>
        /// This property makes the command configuration more accessible
        /// </summary>
        private ICommandConfiguration Connections => _programManager.Connections;

        /// <summary>
        /// This property makes the variable configuration more accessible
        /// </summary>
        private IVariableConfiguration AllVariables => _programManager.AllVariables;

        #endregion Properties

        #region TestInitializer

        /// <summary>
        /// This method is called before each test
        /// In this we assure the prerequisite of the tests
        /// </summary>
        [TestInitialize]
        public void TestInitialization()
        {
            // Create starting and ending commands
            ICommand startCommand = new Command(new Eticheta("Start"));
            ICommand endCommand = new Command(new Eticheta("End"));

            // Create the program manager to use for the test
            _programManager = new ProgramManager(startCommand, endCommand);
        }

        #endregion TestInitializer

        #region TestMethods
        /// <summary>
        /// This test checks if the followinf program:
        /// Start:
        /// WriteText("Hello world")
        /// End:
        /// </summary>
        [TestMethod]
        public void Hello_world_test()
        {
            // Expected output
            string expected = "Hello world!";

            // Create write text command
            ICommand writeTextCommand = new Command(new WriteText("Hello world!", _logger));

            // Append the new command 
            Connections.AddElement(writeTextCommand);

            // Create the bindings
            Connections.BindElementFirst(StartPoint, writeTextCommand);
            Connections.BindElementFirst(writeTextCommand, EndPoint);


            // Execute program
            _programManager.RunProgram();

            // Test the output
            Assert.AreEqual(expected, _logger.LoggerText);
        }

        /// <summary>
        /// This test check the following programe
        /// Start:
        /// ReadValue(a);
        /// ReadValue(b);
        /// sum = a + b;
        /// WriteVariable(sum);
        /// End:
        /// </summary>
        [TestMethod]
        public void Sum_of_two_variables()
        {
            // Expected output
            string expected = "sum(5.85)";

            // User input for the logger
            string[] userInput = { "3.14", "2.71" };

            // Update the logger user input
            _logger.UserInput = userInput;

            // Create and add variables
            Variable a = new Variable("a");
            Variable b = new Variable("b");
            Variable sum = new Variable("sum");

            // Add variables
            AllVariables.AddElement(a);
            AllVariables.AddElement(b);
            AllVariables.AddElement(sum);

            // Create commands
            ICommand readA = new Command(new ReadVariable(a, _logger));
            ICommand readB = new Command(new ReadVariable(b, _logger));
            ICommand atribSum = new Command(new Atribuire(sum, new Expression(a, new Operator("+"), b)));
            ICommand writeSum = new Command(new WriteVariableValue(sum, _logger));

            // Add commands
            Connections.AddElement(readA);
            Connections.AddElement(readB);
            Connections.AddElement(atribSum);
            Connections.AddElement(writeSum);

            // Bind commands
            Connections.BindElementFirst(StartPoint, readA);
            Connections.BindElementFirst(readA, readB);
            Connections.BindElementFirst(readB, atribSum);
            Connections.BindElementFirst(atribSum, writeSum);
            Connections.BindElementFirst(writeSum, EndPoint);

            // Run program
            _programManager.RunProgram();

            // Check expected output
            Assert.AreEqual(expected, _logger.LoggerText);
        }


        /// <summary>
        /// This test check the following programe
        /// Start:
        /// sum = a / b;
        /// WriteVariable(sum);
        /// End:
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Check_divide_by_zero()
        {
            // Create and add variables
            Variable a = new Variable("a");
            Variable b = new Variable("b");
            Variable sum = new Variable("sum");

            // Add variables
            AllVariables.AddElement(a);
            AllVariables.AddElement(b);
            AllVariables.AddElement(sum);

            // Create commands
            ICommand atribSum = new Command(new Atribuire(sum, new Expression(a, new Operator("/"), b)));
            ICommand writeSum = new Command(new WriteVariableValue(sum, _logger));

            // Add commands
            Connections.AddElement(atribSum);
            Connections.AddElement(writeSum);

            // Bind commands
            Connections.BindElementFirst(StartPoint, atribSum);
            Connections.BindElementFirst(atribSum, writeSum);
            Connections.BindElementFirst(writeSum, EndPoint);

            // Run program
            _programManager.RunProgram();

        }

        /// <summary>
        /// This test checks if the following program:
        /// Start:
        /// ReadVariable(a);
        /// if(a > 10)
        /// WriteText("True")
        /// else
        /// WriteTexT("False")
        /// End:
        /// </summary>
        [TestMethod]
        public void Decision_command_check()
        {
            // Expected output
            string expected = "True";

            // User input
            string[] userInput = { "20" };

            // Update the logger user input
            _logger.UserInput = userInput;

            // Create and add variables
            Variable a = new Variable("a");

            // Add variables
            AllVariables.AddElement(a);

            // Create write text command
            ICommand readA = new Command(new ReadVariable(a, _logger));
            ICommand decision = new Command(new Decision(new Condition(a, new RelationalOperator(">"), new ConstValue(10))));
            ICommand writeTrue = new Command(new WriteText("True", _logger));
            ICommand writeFalse = new Command(new WriteText("False", _logger));

            // Append the new command 
            Connections.AddElement(readA);
            Connections.AddElement(decision);
            Connections.AddElement(writeTrue);
            Connections.AddElement(writeFalse);

            // Create the bindings
            Connections.BindElementFirst(StartPoint, readA);
            Connections.BindElementFirst(readA, decision);
            Connections.BindElementFirst(decision, writeTrue);
            Connections.BindElementSecond(decision, writeFalse);
            Connections.BindElementFirst(writeTrue, EndPoint);
            Connections.BindElementFirst(writeFalse, EndPoint);

            // Execute program
            _programManager.RunProgram();

            // Test the output
            Assert.AreEqual(expected, _logger.LoggerText);
        }

        /// <summary>
        /// This test checks if the following program:
        /// Start:
        /// ReadVariable(n);
        /// Loop:
        /// if(i < n)
        /// {
        ///     WriteVariable(i);
        ///     i = i + 1;
        ///     JumpTo(Loop);
        /// }
        /// End:
        /// </summary>
        [TestMethod]
        public void Loop_program_test()
        {
            // Setting the number of loops
            int nValue = 10;

            // Expected output
            string expected = "";

            // Setting expected output
            for(int index = 0; index < nValue; index++)
            {
                expected += "i(" + index + ")";
            }

            // User input
            string[] userInput = { nValue.ToString() };

            // Update the logger user input
            _logger.UserInput = userInput;

            // Add variables
            AllVariables.AddElement(new Variable("i"));
            AllVariables.AddElement(new Variable("n"));

            // Create write text command
            ICommand readN = new Command(new ReadVariable(AllVariables.GetVariableByName("n"), _logger));
            ICommand loopEtc = new Command(new Eticheta("Loop"));
            ICommand decision = new Command(new Decision(
                new Condition(
                    AllVariables.GetVariableByName("i"), 
                    new RelationalOperator("<"), 
                    AllVariables.GetVariableByName("n")
                    )
                ));
            ICommand writeIndex = new Command(new WriteVariableValue(AllVariables.GetVariableByName("i"), _logger));
            ICommand incIndex = new Command(new Atribuire(AllVariables.GetVariableByName("i"), new Expression(
                AllVariables.GetVariableByName("i"), 
                new Operator("+"),
                new ConstValue(1)
                )));

            // Append the new command 
            Connections.AddElement(readN);
            Connections.AddElement(decision);
            Connections.AddElement(writeIndex);
            Connections.AddElement(incIndex);
            Connections.AddElement(loopEtc);

            // Create the bindings
            Connections.BindElementFirst(StartPoint, readN);
            Connections.BindElementFirst(readN, loopEtc);
            Connections.BindElementFirst(loopEtc, decision);
            Connections.BindElementFirst(decision, writeIndex);
            Connections.BindElementFirst(writeIndex, incIndex);
            Connections.BindElementFirst(incIndex, loopEtc);
            Connections.BindElementSecond(decision, EndPoint);

            // Execute program
            _programManager.RunProgram();

            // Test the output
            Assert.AreEqual(expected, _logger.LoggerText);
        }
        #endregion TestMethods

        #region TestCleanup
        [TestCleanup]
        public void TestCleanup()
        {
            // Clean the logger
            _logger.CleanLogger();

        }

        #endregion TestCleanup
    }


}

