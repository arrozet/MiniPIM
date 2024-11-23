using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            dataGridView1.AutoGenerateColumns = false; // no se generan columnas nuevas feas
            // dataGridView1.CellClick += DataGridView1_CellClick; // crea el evento de pulsar el lapiz (NO SE SI ESTÁ BIEN)
            cargarProductos();
            dataGridView1.ClearSelection(); // para que no aparezca selecionada la priemera columna
        }

      

        private void cargarProductos()
        {

            try
            {
                // Crear una instancia del contexto de Entity Framework
                using (var context = new grupo07DBEntities())
                {
                    // Cargar los datos de la tabla Producto
                    var productos = context.Producto
                        .Select(p => new
                        {
                            p.sku,
                            p.label,
                            p.descripcionCorta,
                            p.thumbnail,
                            p.gtin
                            //Categorias = p.Categoria.Select(c => c.nombre) // Solo selecciona los nombres de las categorías
                        })
                        .ToList(); // Trae los datos a la memoria
                    
                    dataGridView1.Columns["SKU"].DataPropertyName = "sku";
                    dataGridView1.Columns["ProductTitle"].DataPropertyName = "label";
                    dataGridView1.Columns["ShortDescription"].DataPropertyName = "descripcionCorta";
                    dataGridView1.Columns["Thumbnail"].DataPropertyName = "thumbnail"; // byte[] o null
                    dataGridView1.Columns["Categories"].DataPropertyName = "gtin";
                    // Asignar los datos al DataGridView
                    dataGridView1.DataSource = productos;
                   
                }
            }
            catch (Exception ex)
            {
                // Mostrar cualquier error que ocurra
                MessageBox.Show($"Error al cargar los datos: {ex.Message}");
            }
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e) //PRODUCTS
        {
            // No hace nada porque estamos en el formulario de Productos
        }

        private void attributesToolStripMenuItem_Click(object sender, EventArgs e) // ATTRIBUTES
        {
            // Crear instancia del formulario de atributos
            AtributosSeccion atributosForm = new AtributosSeccion();

            // Asignar la posición y el tamaño del formulario actual
            atributosForm.StartPosition = FormStartPosition.Manual; // Para permitir personalizar la posición
            atributosForm.Location = this.Location; // Misma posición que el formulario actual
            atributosForm.Size = this.Size; // Mismo tamaño que el formulario actual

            // Mostrar el nuevo formulario y ocultar el actual
            atributosForm.Show();
            this.Hide();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e) // CATEGORIES
        {
            // Crear instancia del formulario de categorías
            CategoriaSeccion categoriasForm = new CategoriaSeccion();

            // Asignar la posición y el tamaño del formulario actual
            categoriasForm.StartPosition = FormStartPosition.Manual;
            categoriasForm.Location = this.Location;
            categoriasForm.Size = this.Size;

            // Mostrar el nuevo formulario y ocultar el actual
            categoriasForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e) // + NEW PRODUCT
        {

        }
    }
}
