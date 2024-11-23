using MiniPIM.Category;
using MiniPIM.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPIM.Attribute
{
    public partial class AtributosSeccion : Form
    {
        public AtributosSeccion()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.AtributosSeccion_Load);
        }

        private void AtributosSeccion_Load(object sender, EventArgs e)
        {

            try
            {
                // Crear una instancia del contexto de Entity Framework
                using (var context = new grupo07DBEntities())
                {
                    // Cargar los datos de la tabla Producto
                    var atributos = context.AtributoPersonalizado
                        .Select(a => new
                        {
                            a.id,
                            a.nombre,
                            a.tipo,
                            CantidadRelacionados = context.ProductoAtributo
                            .Where(pa => pa.atributo_id == a.id)  // Relaciona con ProductoAtributo usando atributo_id
                            .Count()  // Cuenta las relaciones
                        })
                        .ToList();
                    Console.WriteLine($"Se han recuperado {atributos.Count} productos.");

                    // Asignar los datos al DataGridView
                    listAttributes.AutoGenerateColumns = true;
                    listAttributes.DataSource = atributos;

                }
            }
            catch (Exception ex)
            {
                // Mostrar cualquier error que ocurra
                MessageBox.Show($"Error al cargar los datos: {ex.Message}");
            }
        }

        private void Products_Click(object sender, EventArgs e)
        {
            ProductosResumen productosForm = new ProductosResumen();
            productosForm.Show();
            this.Hide(); // Ocultar este formulario
        }

        private void Attributes_Click(object sender, EventArgs e)
        {
            //No hace nada
        }


        private void Categories_Click(object sender, EventArgs e)
        {
            CategoriaSeccion categoriaForm = new CategoriaSeccion();
            categoriaForm.Show();
            this.Hide(); // Ocultar este formulario
        }


        private void NewAttribute_Click(object sender, EventArgs e)
        {
            NewAttributeForm crearAtributosForm  = new NewAttributeForm();

            //Esto recarga el datagrid cuando se cierre el nuevo form
            crearAtributosForm.FormClosed += (s, args) => AtributosSeccion_Load(this, EventArgs.Empty);

            crearAtributosForm.Show();
        }

        private void listAttributes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Meter el update y delete

            // Validar que no sea un clic en el encabezado de columna
            if (e.RowIndex >= 0)
            {
                // Obtener el atributo seleccionado
                var selectedRow = listAttributes.Rows[e.RowIndex];
                int attributeId = (int)selectedRow.Cells["id"].Value;
                string attributeName = selectedRow.Cells["nombre"].Value.ToString();
                string attributeType = selectedRow.Cells["tipo"].Value.ToString();

                // Mostrar cuadro de diálogo para elegir acción
                var result = MessageBox.Show($"'{attributeName}'",
                                             "Choose Action",
                                             MessageBoxButtons.YesNoCancel,
                                             MessageBoxIcon.Question,
                                             MessageBoxDefaultButton.Button3);

                if (result == DialogResult.Yes)
                {
                    // Actualizar: abrir el formulario para editar
                    //Abrir formulario para actualizar
                    
                }
                else if (result == DialogResult.No)
                {
                    // Borrar: confirmar antes de eliminar
                    var confirmDelete = MessageBox.Show($"Are you sure you want to delete '{attributeName}'?",
                                                        "Confirm Delete",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);

                    if (confirmDelete == DialogResult.Yes)
                    {
                        // Eliminar de la base de datos
                        using (var context = new grupo07DBEntities())
                        {
                            var attributeToDelete = context.AtributoPersonalizado.Find(attributeId);
                            if (attributeToDelete != null)
                            {
                                context.AtributoPersonalizado.Remove(attributeToDelete);
                                context.SaveChanges();
                            }
                        }

                        // Refrescar el DataGridView
                        AtributosSeccion_Load(sender, e);
                    }
                }
            }
        }

    }
}
