using System;
using System.Windows.Forms;

namespace MiniPIM
{
    internal class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Iniciar el formulario de productos

            //Application.Run(new TestForm());

            Application.Run(new Product.ProductosResumen());

        }
    }
}
