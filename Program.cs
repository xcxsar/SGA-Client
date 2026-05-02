using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGA_Client
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ManejadorDeFuentes.Initialize();

            Application.Run(new InicioDeSesionView());

            ManejadorDeFuentes.Dispose();
        }
    }
}
