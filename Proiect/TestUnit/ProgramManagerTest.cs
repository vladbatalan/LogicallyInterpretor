using LogicalSchemeManager;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            _programManager.Connections.AddElement(writeTextCommand);

            // Create the bindings
            _programManager.Connections.BindElementFirst(_programManager.Connections.StartPoint, writeTextCommand);
            _programManager.Connections.BindElementFirst(writeTextCommand, _programManager.Connections.EndPoint);


            // Execute program
            _programManager.RunProgram();

            // Test the output
            Assert.AreEqual(expected, _logger.LoggerText);
        }
    }
}
