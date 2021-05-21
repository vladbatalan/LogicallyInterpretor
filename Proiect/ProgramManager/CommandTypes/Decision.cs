/**************************************************************************
 *                                                                        *
 *  File:        Decision.cs                                              *
 *  Copyright:   (c) 2021, Batalan Vlad                                   *
 *  E-mail:      vlad.batalan@student.tuiasi.ro                           *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description:  A command type which execution changes the value of a   *
 *                Variable to the result of an expression.                *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using System;
namespace LogicalSchemeManager
{
    public class Decision : ICommandType
    {
        private ICondition _condition;
        private Boolean _nextElement;

        public Decision(ICondition conditie)
        {
            _condition = conditie;
        }

        public Decision()
        {
        }

        public ICondition Conditie
        {
            get { return _condition; }
            set { _condition = value; }
        }

        public void Execute()
        {
            _nextElement = _condition.ExecuteCondition();
        }

        public bool GetNext()
        {
            return _nextElement;
        }

        public override string ToString()
        {
            return "Decision( " + _condition.ToString() + " )";
        }
    }
}
