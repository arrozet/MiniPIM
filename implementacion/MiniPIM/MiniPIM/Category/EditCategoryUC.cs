using MiniPIM.Attribute;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPIM.Category
{
    public partial class EditCategoryUC : UserControl
    {
        private int id;
        private CategoriaSeccion seccionCategorias;

        public EditCategoryUC(int categoryId, CategoriaSeccion seccionCategorias)
        {
            this.id = categoryId;
            InitializeComponent();
            this.seccionCategorias = seccionCategorias;
        }

        public string CategoryName
        {
            get => nameText.Text;
            set => nameText.Text = value;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una instancia del contexto de Entity Framework
                using (var context = new grupo07DBEntities())
                {
                    if (string.IsNullOrEmpty(nameText.Text))
                    {
                        MessageBox.Show("Please, fill in all the fields.");
                        return;
                    }

                    var categoria = context.Categoria.SingleOrDefault(c => c.id == id);

                    //Lo actualizamos en la base de datos
                    categoria.nombre = nameText.Text;
                    context.SaveChanges();

                    //Borramos las textbox
                    nameText.Text = "";
                    
                    //Cerramos el form
                    this.ParentForm.Close();

                    seccionCategorias.CategoriaSeccion_Load(sender,e);

                    MessageBox.Show("The category has been successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Mostrar cualquier error que ocurra
                MessageBox.Show($"Error al cargar los datos: {ex.Message}");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel this process?",
                                          "Confirm",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            // Si el usuario selecciona 'Sí', cerrar la ventana
            if (result == DialogResult.Yes)
            {
                this.ParentForm.Close();
            }
        }

    }
}
