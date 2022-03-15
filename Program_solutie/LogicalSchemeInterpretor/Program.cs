/**************************************************************************
 *                                                                        *
 *  File:        Program.cs                                               *
 *  Copyright:   (c) 2021, Cirstea Lucian Catalin, Mircea Mihai Adrian    *
 *  Copyright:   (c) 2021, Batalan Vlad, Pascu Alexandru Nicolae          *
 *  E-mail:      mihai-adrian.mircea@student.tuiasi.ro                    *
 *  E-mail:      catalin-lucian.cirstea@student.tuiasi.ro                 *
 *  E-mail:      vlad.batalan@student.tuiasi.ro                           *
 *  E-mail:      alexandru-nicolae.pascu@student.tuiasi.ro                *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description:                                                          *
 *                                                                        *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using System;
using System.Windows.Forms;

namespace LogicalSchemeInterpretor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
