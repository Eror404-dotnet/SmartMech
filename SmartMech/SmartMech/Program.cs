using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartMech
{
    static class Program
    {
        static public MainForm winm;
        static public Random rnd;
        static public int row;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            winm = new MainForm();
            rnd = new Random();
            row = -1;
            Application.Run(winm);

        }
    }
}
