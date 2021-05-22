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
        private Logger _logger;
        #endregion

        #region Properties
        private ICommand StartPoint => _programManager.Connections.StartPoint;
        private ICommand EndPoint => _programManager.Connections.EndPoint;
        private ICommandConfiguration Connections => _programManager.Connections;

        #endregion Properties

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

            // Create the logger
            _logger = new Logger();

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

            // Create the logger
            _logger = new Logger(userInput);

            // Create and add variables
            Variable a = new Variable("a");
            Variable b = new Variable("b");
            Variable sum = new Variable("sum");

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
            // Create the logger
            _logger = new Logger();

            // Create and add variables
            Variable a = new Variable("a");
            Variable b = new Variable("b");
            Variable sum = new Variable("sum");

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
        /// This test checks if the followinf program:
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

            // Create the logger
            _logger = new Logger(userInput);

            // Create and add variables
            Variable a = new Variable("a");

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
    }

}

