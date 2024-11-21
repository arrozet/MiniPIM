using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPIM
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.TestForm_Load); // Asigna el evento Load
        }

        private void TestForm_Load(object sender, EventArgs e)
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
                            p.gtin,
                            p.label,
                            p.fechaCreacion,
                            p.ultimaModificacion,
                            p.descripcionCorta,
                            p.descripcionLarga,
                            p.espacioOcupado,
                            p.thumbnail
                        })
                        .ToList();
                    Console.WriteLine($"Se han recuperado {productos.Count} productos.");

                    // Asignar los datos al DataGridView
                    dataGridViewProductos.AutoGenerateColumns = true;
                    dataGridViewProductos.DataSource = productos;

                }
            }
            catch (Exception ex)
            {
                // Mostrar cualquier error que ocurra
                MessageBox.Show($"Error al cargar los datos: {ex.Message}");
            }
        }
    }
}
