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

namespace MiniPIM.Category
{
    public partial class CategoriaSeccion : Form
    {
        public CategoriaSeccion()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.CategoriaSeccion_Load);
        }

        private void CategoriaSeccion_Load(object sender, EventArgs e)
        {

            try
            {
                // Crear una instancia del contexto de Entity Framework
                using (var context = new grupo07DBEntities())
                {
                    // Cargar los datos de la tabla Producto
                    var categorias = context.Categoria
                        .Select(c => new
                        {
                            c.id,
                            c.nombre,
                            CantidadRelacionados = c.Producto.Count()
                        })
                        .ToList();
                   

                    // Asignar los datos al DataGridView
                    listCategories.AutoGenerateColumns = false;

                    // Configurar las columnas del DataGridView
                    listCategories.Columns["Label"].DataPropertyName = "nombre";
                    listCategories.Columns["ID"].DataPropertyName = "id";
                    listCategories.Columns["NumberOfProducts"].DataPropertyName = "CantidadRelacionados";

                    listCategories.DataSource = categorias;

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
            // Asignar la posición y el tamaño del formulario actual
            productosForm.StartPosition = FormStartPosition.Manual; // Para permitir personalizar la posición
            productosForm.Location = this.Location; // Misma posición que el formulario actual
            productosForm.Size = this.Size; // Mismo tamaño que el formulario actual
            productosForm.Show();
            this.Close(); // Ocultar este formulario
        }

        private void Attributes_Click(object sender, EventArgs e)
        {
            //No hace nada
            menuStrip1.Enabled = false;
        }


        private void Categories_Click(object sender, EventArgs e)
        {
            CategoriaSeccion categoriaForm = new CategoriaSeccion();
            categoriaForm.Show();
            this.Close(); // Ocultar este formulario
        }


        private void NewAttribute_Click_1(object sender, EventArgs e)
        {
            NewCategoryForm crearCategoriaForm = new NewCategoryForm();

            //Esto recarga el datagrid cuando se cierre el nuevo form
            crearCategoriaForm.FormClosed += (s, args) => CategoriaSeccion_Load(this, EventArgs.Empty);

            crearCategoriaForm.Show();
        }


        private void listCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Meter el update y delete

            // Validar que no sea un clic en el encabezado de columna
            if (e.RowIndex >= 0)
            {
                // Obtener el atributo seleccionado
                var selectedRow = listCategories.Rows[e.RowIndex];
                int cattegoryId = (int)selectedRow.Cells["id"].Value;
                string categoryName = selectedRow.Cells["label"].Value.ToString();

                // Mostrar cuadro de diálogo para elegir acción
                var result = MessageBox.Show($"{categoryName}",
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
                    var confirmDelete = MessageBox.Show($"Are you sure you want to delete '{categoryName}'?",
                                                        "Confirm Delete",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);

                    if (confirmDelete == DialogResult.Yes)
                    {
                        // Eliminar de la base de datos
                        using (var context = new grupo07DBEntities())
                        {
                            var categoryToDelete = context.Categoria.Find(cattegoryId);
                            if (categoryToDelete != null)
                            {
                                context.Categoria.Remove(categoryToDelete);
                                context.SaveChanges();
                            }
                        }

                        // Refrescar el DataGridView
                        CategoriaSeccion_Load(sender, e);
                    }
                }
            }
        }

        
    }
}
