using interfaz_2._0.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaz_2._0
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new FormLogin());
=======
            Application.Run(new FormPrincipal());
>>>>>>> 696a9fc (Mejora de rendimiento en interfaz)
        }
    }
}
