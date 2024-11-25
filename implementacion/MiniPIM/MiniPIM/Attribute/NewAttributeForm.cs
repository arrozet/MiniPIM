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
    public partial class NewAttributeForm : Form
    {

        public enum AttributeType
        {
            text,
            number,
            boolean,
            video,
            photo
        }

        private static readonly Dictionary<string, AttributeType> TypeMapping = new Dictionary<string, AttributeType>
        {
            { "Text", AttributeType.text },
            { "Number", AttributeType.number },
            { "Boolean", AttributeType.boolean },
            { "Video", AttributeType.video },
            { "Photo", AttributeType.photo }
        };

        public NewAttributeForm()
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
                    if (string.IsNullOrEmpty(AttributeNameText.Text) || string.IsNullOrEmpty(AttributeTypeText.Text))
                    {
                        MessageBox.Show("You must complete the required fields");
                        return;
                    }

                    // Verificar si el nombre del atributo ya existe en la base de datos
                    bool atributoExistente = context.AtributoPersonalizado
                        .Any(a => a.nombre == AttributeNameText.Text);

                    if (atributoExistente)
                    {
                        MessageBox.Show("The attribute name already exists. Please choose a different name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                        this.Hide();

                        MessageBox.Show("The attribute has been successfully created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
