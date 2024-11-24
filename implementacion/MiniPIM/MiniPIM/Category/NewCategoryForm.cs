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

        public enum AttributeType
        {
            texto,
            numero,
            booleano,
            video,
            foto
        }

        private static readonly Dictionary<string, AttributeType> TypeMapping = new Dictionary<string, AttributeType>
        {
            { "Text", AttributeType.texto },
            { "Number", AttributeType.numero },
            { "Boolean", AttributeType.booleano },
            { "Video", AttributeType.video },
            { "Photo", AttributeType.foto }
        };

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
                    if (string.IsNullOrEmpty(AttributeNameText.Text) || string.IsNullOrEmpty(AttributeTypeText.Text))
                    {
                        MessageBox.Show("Por favor, complete todos los campos.");
                        return;
                    }

                    //Si el tipo esta permitido por la base de datos
                    if (TypeMapping.TryGetValue(AttributeTypeText.Text, out AttributeType attributeType))
                    {
                        //Creamos el nuevo atributo
                        AtributoPersonalizado nuevoAtributo = new AtributoPersonalizado
                        {
                            nombre = AttributeNameText.Text,
                            tipo = attributeType.ToString()
                        };

                        //Lo insertamos en la base de datos
                        context.AtributoPersonalizado.Add(nuevoAtributo);
                        context.SaveChanges();

                        //Borramos las textbox
                        AttributeNameText.Text = "";
                        AttributeTypeText.Text = "";

                        //Cerramos el form
                        this.Close();
                    }
                    else
                    {
                        // Manejar error de tipo desconocido
                        MessageBox.Show("Invalid attribute type. Please enter a valid type.");
                    }

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
