using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using KompasTabl.Presentor;

namespace KompasTabl
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IForm1 form = new Form1();
            Presentor.Presentor presentor = new Presentor.Presentor(form);

            Application.Run((Form)form);
        }
    }
}
