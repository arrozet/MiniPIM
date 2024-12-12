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
using MiniPIM.Relationships;

namespace MiniPIM.Relationships
{
    public partial class UpdateRelation : UserControl
    {
        private RelacionesSeccion seccionRelaciones;
        private string _skuPrincipal; // Campo privado para almacenar el SKU
        grupo07DBEntities context = new grupo07DBEntities();

        public string nombre
        {
            get => tName.Text;
            set => tName.Text = value;
        }

        public string SKU_Principal
        {
            get => _skuPrincipal; // Devuelve el valor del campo privado
            set => _skuPrincipal = value; // Asigna el valor al campo privado
        }

        public UpdateRelation(string nombre, RelacionesSeccion seccionRelaciones, string SKU)
        {
            InitializeComponent();
            this.nombre = nombre;
            this.seccionRelaciones = seccionRelaciones;
            MessageBox.Show(SKU);

            // Configurar el DataSource para los ListBox
            lProduct.DataSource = context.Producto.ToList();
            lRelated.DataSource = context.Producto.ToList();
            MessageBox.Show(context.Producto.Where(p => p.sku == SKU).FirstOrDefault().ToString());
            lProduct.SelectedItem = context.Producto.Where(p => p.sku == SKU).FirstOrDefault();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una instancia del contexto de Entity Framework
                using (var context = new grupo07DBEntities())
                {

                    if (string.IsNullOrEmpty(tName.Text))
                    {
                        MessageBox.Show("Please, fill in all the fields.");
                        return;
                    }

                    // Verificar si el nombre del atributo ya existe en la base de datos
                    bool relacionExistente = context.Relacion
                        .Any(r => r.nombre == tName.Text);

                    if (relacionExistente)
                    {
                        MessageBox.Show("The relation name already exists. Please choose a different name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    /*
                    
                    var relacion = context.Relacion.SingleOrDefault(r => r.nombre == nombre);

                    //Lo actualizamos en la base de datos
                    relacion.nombre = tName.Text;
                    context.SaveChanges();

                    //Borramos las textbox
                    tName.Text = "";

                    //Cerramos el form
                    this.ParentForm.Close();

                    seccionRelaciones.RecargarRelaciones();

                    MessageBox.Show("The relationship has been successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                    */
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
