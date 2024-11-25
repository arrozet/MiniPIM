using MiniPIM.Category;
using MiniPIM.Product;
using MiniPIM.Attribute;
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

        public void CategoriaSeccion_Load(object sender, EventArgs e)
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

                    // Verificar si hay datos y mostrar/ocultar la etiqueta
                    if (categorias.Count > 0)
                    {
                        listCategories.Visible = true;  // Mostrar el DataGridView
                        NoCategories.Visible = false;  // Ocultar el Label
                    }
                    else
                    {
                        listCategories.Visible = false; // Ocultar el DataGridView
                        NoCategories.Visible = true;   // Mostrar el Label
                    }

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
            AtributosSeccion atributosForm = new AtributosSeccion();
            // Asignar la posición y el tamaño del formulario actual
            atributosForm.StartPosition = FormStartPosition.Manual; // Para permitir personalizar la posición
            atributosForm.Location = this.Location; // Misma posición que el formulario actual
            atributosForm.Size = this.Size; // Mismo tamaño que el formulario actual
            atributosForm.Show();
            this.Close(); // Ocultar este formulario
        }


        private void Categories_Click(object sender, EventArgs e)
        {
            menuStrip1.Enabled = false;
        }


        private void NewAttribute_Click_1(object sender, EventArgs e)
        {
            NewCategoryForm crearCategoriaForm = new NewCategoryForm();

            //Esto recarga el datagrid cuando se cierre el nuevo form
            crearCategoriaForm.FormClosed += (s, args) =>
            {
                // Recargar el DataGridView
                CategoriaSeccion_Load(this, EventArgs.Empty);

            };
            crearCategoriaForm.Show();
        }


        private void listCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validar que no sea un clic en el encabezado de columna
            if (e.ColumnIndex == listCategories.Columns["pencil"].Index && e.RowIndex >= 0)
            {
                // Obtener el atributo seleccionado
                var selectedRow = listCategories.Rows[e.RowIndex];
                int categoryId = (int)selectedRow.Cells["id"].Value;
                string categoryName = selectedRow.Cells["label"].Value.ToString();

                // Crear un formulario que contendrá el UserControl
                Form categoryForm = new Form
                {
                    Text = "Edit Category",
                    Size = new System.Drawing.Size(450, 300),
                    StartPosition = FormStartPosition.CenterParent
                };

                // Crear la instancia del UserControl
                EditCategoryUC categoryControl = new EditCategoryUC(categoryId, this)
                {
                    Dock = DockStyle.Fill,
                };

                // Establecer los valores en el UserControl usando los setters
                categoryControl.CategoryName = categoryName; // Establecer el nombre del atributo

                // Agregar el UserControl al formulario
                categoryForm.Controls.Add(categoryControl);

                // Mostrar el formulario como modal
                categoryForm.ShowDialog(); // Mostrar el formulario de manera modal

                categoryForm.FormClosed += (s, args) => CategoriaSeccion_Load(this, EventArgs.Empty);

            }

            if (e.ColumnIndex == listCategories.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                // Validar que no sea un clic en el encabezado de columna
                // Obtener el atributo seleccionado
                var selectedRow = listCategories.Rows[e.RowIndex];
                int categoryId = (int)selectedRow.Cells["id"].Value;
                string categoryName = selectedRow.Cells["label"].Value.ToString();

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
                        var categoryToDelete = context.Categoria.Find(categoryId);
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
