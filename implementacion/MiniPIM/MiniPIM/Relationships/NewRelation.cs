using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPIM.Relationships
{
    public partial class NewRelation : Form
    {
        public NewRelation()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Crear una instancia del contexto de Entity Framework
                using (var context = new grupo07DBEntities())
                {

                    // Configurar el DataSource para los ListBox
                    lProduct.DataSource = context.Producto.ToList();
                    lRelated.DataSource = context.Producto.ToList();
                }
            }
            catch (Exception ex)
            {
                // Mostrar cualquier error que ocurra
                MessageBox.Show($"Error al cargar los datos: {ex.Message}");
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
                    if (string.IsNullOrEmpty(tName.Text))
                    {
                        MessageBox.Show("You must complete the required fields");
                        return;
                    }

                    // Verificar si el nombre de la relacion ya existe en la base de datos
                    bool relacionExistente = context.Relacion
                        .Any(r => r.nombre == tName.Text);

                    if (relacionExistente)
                    {
                        MessageBox.Show("The relationship name already exists. Please choose a different name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (lRelated.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("You have not selected any related products.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (lProduct.SelectedItem == null){
                        MessageBox.Show("You must select one main product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    
                    //Creamos la nueva relacion
                    Relacion nuevaRelacion = new Relacion
                    {
                        nombre = tName.Text,
                        cuenta_id = context.Cuenta.FirstOrDefault().id
                    };

                    Producto productoPrincipal = (Producto)lProduct.SelectedItem;

                    // Insertamos el objeto Relacion
                    context.Relacion.Add(nuevaRelacion);

                    // Insertamos las relaciones con los productos
                    foreach (Producto relacionado in lRelated.SelectedItems)
                    {
                        if (productoPrincipal.sku == relacionado.sku)
                        {
                            MessageBox.Show("You cannot relate a product with itself.");
                            return;
                        }

                        Console.WriteLine(relacionado.ToString());
                        RelacionProducto rp = new RelacionProducto
                        {
                            producto_sku_principal = productoPrincipal.sku,
                            nombre_relacion = nuevaRelacion.nombre,
                            producto_sku_relacionado = relacionado.sku
                        };
                        
                        context.RelacionProducto.Add(rp);
                    }
                    context.SaveChanges();

                    //Borramos las textbox
                    tName.Text = "";

                    this.Hide();

                    MessageBox.Show("The relationship has been successfully created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}
