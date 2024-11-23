using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniPIM.Attribute;
using MiniPIM.Category;

namespace MiniPIM.Product
{
    public partial class ProductosResumen : Form
    {
        public ProductosResumen()
        {
            InitializeComponent();
            this.Load += new EventHandler(ProductosResumen_Load);
        }

        private void ProductosResumen_Load(object sender, EventArgs e)
        {
            //TODO
            productsToolStripMenuItem.Enabled = false; // esto lo podríamos poner directamente en el 
            // Form, lo que hace es deshabilitar el boton de prodcts
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e) //PRODUCTS
        {
            // No hace nada porque estamos en el formulario de Productos
        }

        private void attributesToolStripMenuItem_Click(object sender, EventArgs e) // ATTRIBUTES
        {
            AtributosSeccion atributosForm = new AtributosSeccion();
            atributosForm.Show();
            this.Hide(); // Ocultar este formulario
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e) // CATEGORIES
        {
            // Cambiar al formulario de Categorías
            CategoriaSeccion categoriasForm = new CategoriaSeccion();
            categoriasForm.Show();
            this.Hide(); // Ocultar este formulario
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
