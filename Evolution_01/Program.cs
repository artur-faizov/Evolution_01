using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Evolution_01
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения. Новый первый коммит 5
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
