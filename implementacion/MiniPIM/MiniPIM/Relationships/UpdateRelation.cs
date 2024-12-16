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
        grupo07DBEntities context = new grupo07DBEntities();
        private string _nombre; // Campo privado para almacenar el valor

        public string nombre
        {
            get => _nombre; // Devuelve el valor de la variable privada
            set
            {
                _nombre = value; // Asigna el valor a la variable privada
                tName.Text = value; // Actualiza el control visual (si es necesario)
            }
        }


        public UpdateRelation(string nombre, RelacionesSeccion seccionRelaciones, string skuPrincipal)
        {
            InitializeComponent();
            this.nombre = nombre;
            this.seccionRelaciones = seccionRelaciones;

            // Configurar el DataSource para los ListBox
            lProduct.DataSource = context.Producto.ToList();
            lRelated.DataSource = context.Producto.ToList();

            // Selecciono el producto principal
            //MessageBox.Show(context.Producto.Where(p => p.sku == SKU).FirstOrDefault().ToString());
            lProduct.ClearSelected();
            lRelated.ClearSelected();
            lProduct.SelectedItem = context.Producto.Where(p => p.sku == skuPrincipal).FirstOrDefault();

            // Selecciono los productos relacionados
            var relacionProductos = context.RelacionProducto.Where(rp => rp.nombre_relacion == nombre).ToList();

            List<Producto> todosLosProductos = context.Producto.ToList();
            foreach (var relacionado in relacionProductos)
            {
                Producto productoRelacionado = context.Producto.Where(p => p.sku == relacionado.producto_sku_relacionado).FirstOrDefault();
                
                int index = todosLosProductos.IndexOf(productoRelacionado);
                lRelated.SetSelected(index, true);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
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
                        .Any(r => r.nombre == tName.Text && r.nombre != nombre);

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

                    if (lProduct.SelectedItem == null)
                    {
                        MessageBox.Show("You must select one main product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    Producto productoPrincipal = (Producto)lProduct.SelectedItem;
                    foreach (Producto relacionado in lRelated.SelectedItems)
                    {
                        if (productoPrincipal.sku == relacionado.sku)
                        {
                            MessageBox.Show("You cannot relate a product with itself.");
                            return;
                        }

                    }

                    // Hay borrado en cascada. Con esto se borra toda la info
                    Relacion estaRelacion = context.Relacion.FirstOrDefault(r => r.nombre == nombre);
                    context.Relacion.Remove(estaRelacion);
                    context.SaveChanges();
                    // Actualizo la relación
                    Relacion relacionActualizada = new Relacion
                    {
                        nombre = tName.Text,
                        cuenta_id = context.Cuenta.FirstOrDefault().id
                    };
                    context.Relacion.Add(relacionActualizada);

                    // Insertamos las relaciones con los productos
                    foreach (Producto relacionado in lRelated.SelectedItems)
                    {
                        
                        RelacionProducto rp = new RelacionProducto
                        {
                            producto_sku_principal = productoPrincipal.sku,
                            nombre_relacion = relacionActualizada.nombre,
                            producto_sku_relacionado = relacionado.sku
                        };

                        context.RelacionProducto.Add(rp);
                    }

                    context.SaveChanges();
                    seccionRelaciones.RecargarRelaciones();
                    MessageBox.Show("Relationship updated succesfully!");
                    this.ParentForm.Close();
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
