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
    public partial class NewCategoryForm : Form
    {

        public NewCategoryForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Are you sure you want to cancel this procces?",
                                          "Confirm",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            // Si el usuario selecciona 'Sí', cerrar la ventana
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                // Crear una instancia del contexto de Entity Framework
                using (var context = new grupo07DBEntities())
                {
                    //Miramos que los campos esten rellenos
                    if (string.IsNullOrEmpty(CategoryNameText.Text))
                    {
                        MessageBox.Show("Please, fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    bool categoriaExistente = context.Categoria
                        .Any(c => c.nombre == CategoryNameText.Text);

                    if (categoriaExistente)
                    {
                        MessageBox.Show("The category name already exists. Please choose a different name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    Categoria newCategory = new Categoria
                    {
                        nombre = CategoryNameText.Text,
                        cuenta_id = context.Cuenta.FirstOrDefault().id
                    };

                    context.Categoria.Add(newCategory);
                    context.SaveChanges();

                    //Borramos las textbox
                    CategoryNameText.Text = "";

                    this.Hide();

                    MessageBox.Show("The category has been successfully created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Cerramos el form
                    this.Close();
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
