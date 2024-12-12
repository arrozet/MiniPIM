using System;
using System.Threading;
using System.Windows.Forms;

namespace MiniPIM
{
    internal class Program
    {
        private static Mutex mutex = null;

        [STAThread]
        static void Main()
        {
            const string appName = "MiniPIMApp"; // Nombre único para tu aplicación
            bool createdNew;

            // Crear el mutex
            mutex = new Mutex(true, appName, out createdNew);

            if (!createdNew)
            {
                // Ya hay una instancia corriendo
                MessageBox.Show("Another instance of MiniPIM is already running.", "Instance Running", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir del programa
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Iniciar el formulario principal
            Application.Run(new Product.ProductosResumen());

            // Liberar el mutex al cerrar
            GC.KeepAlive(mutex);
        }
    }
}
