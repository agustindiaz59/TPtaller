using System;
using System.Collections.Generic;
using System.IO;
using Gestion_Gym.Vistas;
using System.Windows.Forms;

namespace Gestion_Gym
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
            Application.Run(new Acceso());
        }
    }
}
