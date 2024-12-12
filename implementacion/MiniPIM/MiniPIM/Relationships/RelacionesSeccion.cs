using MiniPIM.Attribute;
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

namespace MiniPIM.Relationships
{
    public partial class RelacionesSeccion : Form
    {
        public RelacionesSeccion()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.RelacionesSeccion_Load);
        }

        private void RelacionesSeccion_Load(object sender, EventArgs e)
        {

            try
            {
                // Crear una instancia del contexto de Entity Framework
                using (var context = new grupo07DBEntities())
                {
                    // Cargar los datos de la tabla Producto
                    var relaciones = context.AtributoPersonalizado
                        .Select(r => new
                        {
                            r.nombre,
                            CantidadRelacionados = context.ProductoAtributo
                            .Where(pa => pa.atributo_id == r.id)  // Relaciona con ProductoAtributo usando atributo_id
                            .Count()  // Cuenta las relaciones
                        })
                        .ToList();
                    Console.WriteLine($"Se han recuperado {relaciones.Count} productos.");


                    // Asignar los datos al DataGridView
                    listRelations.AutoGenerateColumns = false;

                    // Configurar las columnas del DataGridView
                    listRelations.Columns["Label"].DataPropertyName = "nombre";
                    listRelations.Columns["NumberOfProducts"].DataPropertyName = "CantidadRelacionados";

                    listRelations.DataSource = relaciones;

                    // Verificar si hay datos y mostrar/ocultar la etiqueta
                    if (relaciones.Count > 0)
                    {
                        listRelations.Visible = true;  // Mostrar el DataGridView
                        NoRelationships.Visible = false;  // Ocultar el Label
                    }
                    else
                    {
                        listRelations.Visible = false; // Ocultar el DataGridView
                        NoRelationships.Visible = true;   // Mostrar el Label
                    }


                }
            }
            catch (Exception ex)
            {
                // Mostrar cualquier error que ocurra
                MessageBox.Show($"Error al cargar los datos: {ex.Message}");
            }
        }

        public void RecargarRelaciones()
        {
            try
            {
                using (var context = new grupo07DBEntities())
                {
                    // Consulta los datos actualizados
                    var relaciones = context.AtributoPersonalizado
                        .Select(r => new
                        {
                            r.nombre,
                            CantidadRelacionados = context.ProductoAtributo
                            .Where(pa => pa.atributo_id == r.id)  // Relaciona con ProductoAtributo usando atributo_id
                            .Count()  // Cuenta las relaciones
                        })
                        .ToList();

                    // Asignar los datos actualizados al DataGridView
                    listRelations.DataSource = null; // Limpia los datos anteriores
                    listRelations.DataSource = relaciones;

                    // Verificar si hay datos y mostrar/ocultar la etiqueta
                    if (relaciones.Count > 0)
                    {
                        listRelations.Visible = true;  // Mostrar el DataGridView
                        NoRelationships.Visible = false;  // Ocultar el Label
                    }
                    else
                    {
                        listRelations.Visible = false; // Ocultar el DataGridView
                        NoRelationships.Visible = true;   // Mostrar el Label
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al recargar los datos: {ex.Message}");
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

        private void Attributes_Click_1(object sender, EventArgs e)
        {
            AtributosSeccion atributosForm = new AtributosSeccion();
            // Asignar la posición y el tamaño del formulario actual
            atributosForm.StartPosition = FormStartPosition.Manual; // Para permitir personalizar la posición
            atributosForm.Location = this.Location; // Misma posición que el formulario actual
            atributosForm.Size = this.Size; // Mismo tamaño que el formulario actual
            atributosForm.Show();
            this.Close(); // Ocultar este formulario
        }

        private void Relationships_Click(object sender, EventArgs e)
        {
            Relationships.Enabled = false;
        }


        private void Categories_Click(object sender, EventArgs e)
        {
            CategoriaSeccion categoriaForm = new CategoriaSeccion();
            categoriaForm.StartPosition = FormStartPosition.Manual; // Para permitir personalizar la posición
            categoriaForm.Location = this.Location; // Misma posición que el formulario actual
            categoriaForm.Size = this.Size; // Mismo tamaño que el formulario actual
            categoriaForm.Show();
            this.Close(); // Ocultar este formulario
        }


        private void NewRelation_Click(object sender, EventArgs e)
        {
            if (listRelations.Rows.Count >= 5)
            {
                // Mostrar un mensaje indicando que no se pueden añadir más productos
                MessageBox.Show("You cannot add more attributes. The limit is 5.",
                                "Limit reached",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            //NewAttributeForm crearAtributosForm = new NewAttributeForm();

            //Esto recarga el datagrid cuando se cierre el nuevo form

            /*crearAtributosForm.FormClosed += (s, args) =>
            {
                // Recargar el DataGridView
                AtributosSeccion_Load(this, EventArgs.Empty);
            };

            crearAtributosForm.Show();*/
        }


        private void listRelations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Meter el update y delete
            if (e.ColumnIndex == listRelations.Columns["pencil"].Index && e.RowIndex >= 0)
            {
                // Validar que no sea un clic en el encabezado de columna
                // Obtener el atributo seleccionado
                var selectedRow = listRelations.Rows[e.RowIndex];
                string RelationName = selectedRow.Cells["label"].Value.ToString();

                // Crear un formulario que contendrá el UserControl
                /*Form attributeForm = new Form
                {
                    Text = "Edit Relation",
                    Size = new System.Drawing.Size(450, 300),
                    StartPosition = FormStartPosition.CenterParent
                };

                // Crear la instancia del UserControl
                UserControl1 attributeControl = new UserControl1(attributeId, this)
                {
                    Dock = DockStyle.Fill,
                };

                // Establecer los valores en el UserControl usando los setters
                attributeControl.AttributeName = attributeName; // Establecer el nombre del atributo
                attributeControl.Attributetype = attributeType;  // Establecer el tipo del atributo

                // Agregar el UserControl al formulario
                attributeForm.Controls.Add(attributeControl);

                // Mostrar el formulario como modal
                attributeForm.ShowDialog(); // Mostrar el formulario de manera modal
                
                attributeForm.FormClosed += (s, args) => RelacionesSeccion_Load(this, EventArgs.Empty);
                */
            }

            if (e.ColumnIndex == listRelations.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                // Validar que no sea un clic en el encabezado de columna
                // Obtener el atributo seleccionado
                var selectedRow = listRelations.Rows[e.RowIndex];
                string relationName = selectedRow.Cells["label"].Value.ToString();

                // Borrar: confirmar antes de eliminar
                var confirmDelete = MessageBox.Show($"Are you sure you want to delete '{relationName}'?",
                                                    "Confirm Delete",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);

                if (confirmDelete == DialogResult.Yes)
                {
                    // Eliminar de la base de datos
                    using (var context = new grupo07DBEntities())
                    {
                        var relationToDelete = context.AtributoPersonalizado.Find(relationName); // antes era relationId
                        if (relationToDelete != null)
                        {
                            context.AtributoPersonalizado.Remove(relationToDelete);
                            context.SaveChanges();
                        }
                    }

                    // Refrescar el DataGridView
                    RelacionesSeccion_Load(sender, e);
                }


            }
        }
    }
}
