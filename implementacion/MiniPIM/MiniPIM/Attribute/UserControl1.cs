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
        private int id;
        private AtributosSeccion seccionAtributos;
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

        public UserControl1(int attributeId, AtributosSeccion seccionAtributos)
        {
            id = attributeId;
            InitializeComponent();
            this.seccionAtributos = seccionAtributos;
            
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una instancia del contexto de Entity Framework
                using (var context = new grupo07DBEntities())
                {

                    if (string.IsNullOrEmpty(nameText.Text) || string.IsNullOrEmpty(typeText.Text))
                    {
                        MessageBox.Show("Please, fill in all the fields.");
                        return;
                    }

                    if (TypeMapping.TryGetValue(typeText.Text, out AttributeType attributeType))
                    {
                        var atributo = context.AtributoPersonalizado.SingleOrDefault(a => a.id == id);

                        //Lo actualizamos en la base de datos
                        atributo.nombre = nameText.Text;
                        atributo.tipo = typeText.Text;
                        context.SaveChanges();

                        //Borramos las textbox
                        nameText.Text = "";
                        typeText.Text = "";

                        //Cerramos el form
                        this.ParentForm.Close();

                        seccionAtributos.RecargarAtributos();

                        MessageBox.Show("The attribute has been successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
