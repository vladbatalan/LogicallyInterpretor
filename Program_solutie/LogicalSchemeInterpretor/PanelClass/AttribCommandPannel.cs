using LogicalSchemeManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicalSchemeInterpretor.PanelClass
{
    class AttribCommandPannel : CommandPanel
    {
        ProgramManager _programManager;
        public AttribCommandPannel(ProgramManager pm)
        {
            _programManager = pm;
        }
       
        public void ProcessString(object sender, EventArgs e)
        {
            string text = ((TextBox)sender).Text;

            string[] text_split = text.Split();

            if (text_split.Length == 1)
            {
                Variable var = new Variable(text_split[0]);
                _programManager.AllVariables.AddElement(var);
                this.CommandType = new Atribuire(var, new ConstValue(0));
                ((TextBox)sender).Enabled = false;
                return;
            }
            if(text_split.Length == 3)
            {
                if (text_split[1] != "=")
                {
                    TypingError();
                    return;
                }

                try
                {
                    int value = Int32.Parse(text_split[2]);
                    Variable var = new Variable(text_split[0]);
                    _programManager.AllVariables.AddElement(var);
                    this.CommandType = new Atribuire(var, new ConstValue(value));
                }
                catch
                {
                    Variable temp = _programManager.AllVariables.GetVariableByName(text_split[2]);
                    if (temp == null)
                    {
                        TypingError();
                        return;
                    }

                    Variable var = new Variable(text_split[0]);
                    _programManager.AllVariables.AddElement(var);
                    this.CommandType = new Atribuire(var, temp);
                }
                ((TextBox)sender).Enabled = false;
                return;
            }

            if(text_split.Length == 5)
            {
                if (text_split[1] != "=")
                {
                    TypingError();
                    return;
                }

                if(text_split[3] != "+" || text_split[3] != "-" || text_split[3] != "*" || text_split[3] != "/")
                {
                    TypingError();
                    return;
                }

                try
                {
                    int value1 = Int32.Parse(text_split[2]);
                    try
                    {
                        int value2 = Int32.Parse(text_split[2]);
                        
                        Variable var = new Variable(text_split[0]);
                        _programManager.AllVariables.AddElement(var);
                        this.CommandType = new Atribuire(var, new Expression(new ConstValue(value1), new Operator(text_split[3]), new ConstValue(value2)));
                    }
                    catch
                    {
                        Variable temp = _programManager.AllVariables.GetVariableByName(text_split[2]);
                        if (temp == null)
                        {
                            TypingError();
                            return;
                        }

                        Variable var = new Variable(text_split[0]);
                        _programManager.AllVariables.AddElement(var);
                        this.CommandType = new Atribuire(var, new Expression(new ConstValue(value1), new Operator(text_split[3]), temp));
                    }
                }
                catch
                {
                    Variable temp = _programManager.AllVariables.GetVariableByName(text_split[2]);
                    if (temp == null)
                    {
                        TypingError();
                        return;
                    }

                    try
                    {
                        int value2 = Int32.Parse(text_split[2]);

                        Variable var = new Variable(text_split[0]);
                        _programManager.AllVariables.AddElement(var);
                        this.CommandType = new Atribuire(var, new Expression(temp, new Operator(text_split[3]), new ConstValue(value2)));
                    }
                    catch
                    {
                        Variable temp2 = _programManager.AllVariables.GetVariableByName(text_split[2]);
                        if (temp2 == null)
                        {
                            TypingError();
                            return;
                        }

                        Variable var = new Variable(text_split[0]);
                        _programManager.AllVariables.AddElement(var);
                        this.CommandType = new Atribuire(var, new Expression(temp, new Operator(text_split[3]), temp2));
                    }
                }
                ((TextBox)sender).Enabled = false;
                return;
            }
            TypingError();      
        }

        public void TypingError()
        {
            MessageBox.Show("Typing error! \nCorrect formats: \n\t variable_name \n\t variable_name = variable_name1/value \n\t variable_name = variable_name1/value1 operation variable_name2/value2 \n\n\t Operations: + - / *\n");
        }
    }
}
