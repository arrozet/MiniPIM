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
            this.Close();
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
                        MessageBox.Show("Please, fill in all the fields.");
                        return;
                    }

                    Categoria newCategory = new Categoria
                    {
                        nombre = CategoryNameText.Text,
                    };

                    context.Categoria.Add(newCategory);
                    context.SaveChanges();

                    //Borramos las textbox
                    CategoryNameText.Text = "";

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
