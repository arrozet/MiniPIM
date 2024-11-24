using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPIM.Attribute
{
    public partial class UserControl1 : UserControl
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

        public string AttributeName
        {
            get => nameText.Text;
            set => nameText.Text = value;
        }

        public string Attributetype
        {
            get => typeText.Text; // Obtener el valor seleccionado del ComboBox
            set => typeText.Text = value; // Establecer el valor seleccionado en el ComboBox
        }

        public UserControl1()
        {
            InitializeComponent();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {


            try
            {
                // Crear una instancia del contexto de Entity Framework
                using (var context = new grupo07DBEntities())
                {
                    //int idInt = int.Parse(id);

                    //Producto productoSeleccionado = context.Producto.SingleOrDefault(p => p.ID == idInt);

                    if (TypeMapping.TryGetValue(typeText.Text, out AttributeType attributeType))
                    {
                        //Creamos el nuevo atributo
                        AtributoPersonalizado nuevoAtributo = new AtributoPersonalizado
                        {
                            nombre = nameText.Text,
                            tipo = attributeType.ToString()
                        };

                        //Lo insertamos en la base de datos
                        context.AtributoPersonalizado.AddOrUpdate(nuevoAtributo);
                        context.SaveChanges();

                        //Borramos las textbox
                        nameText.Text = "";
                        typeText.Text = "";

                        //Cerramos el form
                        this.Hide();
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
