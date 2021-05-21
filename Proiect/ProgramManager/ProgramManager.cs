using System;

namespace LogicalSchemeManager
{
    public class ProgramManager
    {
        private IVariableConfiguration _variableConfiguration;
        private ICommandConfiguration _commandConfiguration;
        private ICommand _currentCommand;

        public ProgramManager(ICommand start, ICommand end)
        {
            // initializez cele 2 componente primare
            _variableConfiguration = new GlobalVariables();
            _commandConfiguration = new CommandGraph(start, end);

            // trebuie sa existe o instanta de tip Eticheta cu numele "Start" pentru a incepe
            //ICommand startCmd = new Command(new Eticheta("Start"));

            // adaug comanda in lista de comenzi
            //_commandConfiguration.AddElement(startCmd);
        }

        public ProgramManager(string filePath)
        {
            throw new Exception("Functionality not implemented yet!");
        }

        public IVariableConfiguration AllVariables
        {
            get => _variableConfiguration;
            set => _variableConfiguration = value;
        }

        public ICommandConfiguration Connections
        {
            get => _commandConfiguration;
            set => _commandConfiguration = value;
        }

        public void RunProgram()
        {
            // eticheta cu numele Start
            ICommand startCommand = _commandConfiguration.StartPoint;

            if(startCommand == null)
            {
                throw new Exception("Programul nu contine nicio eticheta cu numele de \"Start\"!");
            }

            // se reseteaza toate variabilele la 0
            _variableConfiguration.ResetVariables();

            // se realizeaza iterarea prin program
            ICommand programCounter = startCommand;

            // pornind din start, iteram
            while(programCounter != null)
            {
                try
                {

                    // a se sterge 
                    //Console.WriteLine("Se executa comanda: " + programCounter.CommandType.ToString());

                    _currentCommand = programCounter;
                    programCounter.Execute();
                    
                    bool isNextTrue = programCounter.CommandType.GetNext();
                    programCounter = _commandConfiguration.GetNextElement(programCounter, isNextTrue);


                }
                catch (Exception ex)
                {
                    // add command responsable for exception
                    throw new Exception(_currentCommand.ToString() + " has generated: " + ex.Message);
                }
            }
            //Console.WriteLine("Executie incheiata.");

            _currentCommand = null;
        }
    }
}
