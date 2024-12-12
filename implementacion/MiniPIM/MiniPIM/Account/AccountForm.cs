using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniPIM.Attribute;
using MiniPIM.Product;

namespace MiniPIM.Account
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(Account_Load);
        }
        private void Account_Load(object sender, EventArgs e)
        {
            try
            {
                // Crear una instancia del contexto de Entity Framework
                using (var context = new grupo07DBEntities())
                {
                    Cuenta cuenta = context.Cuenta.FirstOrDefault();
                    lblUsernameValue.Text = cuenta.nombre;
                    lblEmailValue.Text = cuenta.email;
                    lblCreationDateValue.Text = cuenta.fecha_creacion.ToString("yyyy-MM-dd");
                    lblProductsValue.Text = context.Producto.Where(p => p.cuenta_id == cuenta.id).Count().ToString();
                    lblAttributesValue.Text = context.AtributoPersonalizado.Where(a => a.cuenta_id == cuenta.id).Count().ToString();
                    lblCategoriesValue.Text = context.Categoria.Where(c => c.cuenta_id == cuenta.id).Count().ToString();
                    lblRelationshipsValue.Text = context.Relacion.Where(r => r.cuenta_id == cuenta.id).Count().ToString();
                }
            }
            catch (Exception ex)
            {
                // Mostrar cualquier error que ocurra
                MessageBox.Show($"Error al cargar los datos: {ex.Message}");
            }
        }

        private void lblCategories_Click(object sender, EventArgs e)
        {
            // esto porque esta 
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using(var context = new grupo07DBEntities())
            {
                Cuenta cuenta = context.Cuenta.FirstOrDefault();
                FileManager fm = new FileManager(cuenta);
                fm.ExportToJson();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Crear instancia del formulario de atributos
            ProductosResumen productosForm = new ProductosResumen();

            // Asignar la posición y el tamaño del formulario actual
            productosForm.StartPosition = FormStartPosition.Manual; // Para permitir personalizar la posición
            productosForm.Location = this.Location; // Misma posición que el formulario actual
            productosForm.Size = this.Size; // Mismo tamaño que el formulario actual

            // Mostrar el nuevo formulario y ocultar el actual
            this.Hide();
            productosForm.Show();
        }
    }
}
