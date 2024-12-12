using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPIM.Relationships
{
    public partial class NewRelation : Form
    {
        public NewRelation()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Crear una instancia del contexto de Entity Framework
                using (var context = new grupo07DBEntities())
                {
                    var productos = context.Producto.ToList(); // se ha modificado el toString de producto

                    // Configurar el DataSource para los ListBox
                    lProduct.DataSource = productos;
                    lRelated.DataSource = productos;
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
