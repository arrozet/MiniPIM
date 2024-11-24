using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiniPIM.Product
{
    public partial class AddProductControl : UserControl
    {
        public AddProductControl()
        {
            InitializeComponent();
        }

        private void BtnLoadThumbnail_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg;*.png)|*.jpg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Image img = Image.FromFile(openFileDialog.FileName);

                    // Verificar dimensiones
                    if (img.Width == 200 && img.Height == 200)
                    {
                        pictureBoxThumbnail.Image = img; // Cargar imagen al PictureBox
                    }
                    else
                    {
                        MessageBox.Show(
                            "The image must be 200x200 pixels.",
                            "Invalid Image Dimensions",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void AddProductControl_Load(object sender, EventArgs e)
        {
            // Cargar categorías y atributos personalizados al abrir el control
            using (var context = new grupo07DBEntities())
            {
                var categorias = context.Categoria.Select(c => new { c.id, c.nombre }).ToList();
                cmbCategories.DataSource = categorias;
                cmbCategories.DisplayMember = "nombre";
                cmbCategories.ValueMember = "id";

                var atributos = context.AtributoPersonalizado.Select(a => new { a.id, a.nombre }).ToList();
                cmbAttributes.DataSource = atributos;
                cmbAttributes.DisplayMember = "nombre";
                cmbAttributes.ValueMember = "id";
            }
        }
        private void txtSKU_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGTIN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtShortDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxThumbnail_Click(object sender, EventArgs e)
        {

        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbAttributes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e) // boton cancelar
        {
            // Mostrar el mensaje de confirmación en inglés
            DialogResult result = MessageBox.Show(
                "Are you sure you want to cancel the product creation?",
                "Cancel Product Creation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Si el usuario selecciona Yes
            if (result == DialogResult.Yes)
            {
                
                // Crear una nueva instancia del formulario ProductosResumen
                ProductosResumen productosResumenForm = new ProductosResumen();


                // Asignar la posición y el tamaño del formulario actual
                productosResumenForm.StartPosition = FormStartPosition.Manual; // Para permitir personalizar la posición

                // Calcular la ubicación absoluta de la pantalla para el nuevo formulario
                Point formLocation = this.ParentForm.Location;
                Point controlLocation = this.Location;
                productosResumenForm.Location = new Point(formLocation.X + controlLocation.X, formLocation.Y + controlLocation.Y);

                productosResumenForm.Size = this.Size; // Mismo tamaño que el formulario actual

                // Mostrar el formulario ProductosResumen
                this.Controls.Clear();
                productosResumenForm.Show();

                this.ParentForm.Hide();  // Esto oculta el formulario actual
            }
            // Si el usuario selecciona No, no hace nada y se queda en el UserControl UpdateProduct
        }

        private void btnCreate_Click(object sender, EventArgs e) // BOTON DE CREAR
        {
            if(!string.IsNullOrEmpty(txtSKU.Text) && !string.IsNullOrEmpty(txtGTIN.Text) && !string.IsNullOrEmpty(txtProductName.Text) &&
                !string.IsNullOrEmpty(txtShortDescription.Text)) 
            {

                string sku = txtSKU.Text;
                string gtin = txtGTIN.Text;
                string name = txtProductName.Text;
                string shortDescription = txtShortDescription.Text;

                if (EsGTIN14Valido(gtin) && EsSKUValido(sku))
                {
                    using (var context = new grupo07DBEntities())
                    {
                        // Crear producto
                        var producto = new Producto
                        {
                            sku = sku,
                            gtin = gtin,
                            label = name,
                            descripcionCorta = shortDescription,
                            fechaCreacion = DateTime.Now
                        };

                        // Guardar imagen si existe
                        if (pictureBoxThumbnail.Image != null)
                        {
                            using (var ms = new MemoryStream())
                            {
                                pictureBoxThumbnail.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                                producto.thumbnail = ms.ToArray();
                            }
                        }

                        // Asociar categoría seleccionada
                        if (cmbCategories.SelectedIndex != -1)
                        {
                            int selectedCategoryId = (int)cmbCategories.SelectedValue;
                            var categoria = context.Categoria.FirstOrDefault(c => c.id == selectedCategoryId);
                            if (categoria != null)
                            {
                                producto.Categoria.Add(categoria);
                            }
                        }

                        // Asociar atributo personalizado seleccionado
                        /*
                        if (cmbAttributes.SelectedIndex != -1)
                        {
                            int selectedAttributeId = (int)cmbAttributes.SelectedValue;
                            var atributo = context.AtributoPersonalizado.FirstOrDefault(a => a.id == selectedAttributeId);
                            if (atributo != null)
                            {
                                producto.ProductoAtributo.Add(atributo);
                            }
                        }
                        */
                        // Agregar y guardar cambios en la base de datos
                        context.Producto.Add(producto);
                        context.SaveChanges();

                        MessageBox.Show("Product created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpiar formulario
                        
                        // THUMBNAIL TIENE QUE SER OBLIGATORIO HAY QUE AÑADIR DESCRIPCION LARGA Y ADEMAS NO SE CREAN LOS PRODUCTOS POR LO QUE SEA
                    }

                    // PARA DECIR QUE EL SKU Y EL GTIN SON INVÁLIDOS
                } else if (!EsGTIN14Valido(gtin) && !EsSKUValido(sku)) // si el sku y gtin no son válidos
                {
                    DialogResult result = MessageBox.Show(
                    "Neither the SKU nor the GTIN is valid.",
                    "Bad GTIN and SKU",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                } else if (!EsGTIN14Valido(gtin)) // si el gtin no es válido
                {
                    DialogResult result = MessageBox.Show(
                    "The GTIN is not valid.",
                    "Bad GTIN",
                    MessageBoxButtons.OK,

                    MessageBoxIcon.Warning);
                } else if (!EsSKUValido(sku)) // si el sku no es válido
                {
                    DialogResult result = MessageBox.Show(
                    "The SKU is not valid.",
                    "Bad SKU",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                }


            } else
            {
                DialogResult result = MessageBox.Show(
                "All required fields must be completed.",
                "Campos obligatorios",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }




        // FUNCIONES PARA COMPROBAR QUE EL SKU ES VALIDO
        public static bool EsGTIN14Valido(string gtin)
        {
            // Verificamos si el GTIN tiene exactamente 14 caracteres numéricos
            if (string.IsNullOrEmpty(gtin) || gtin.Length != 14 || !ulong.TryParse(gtin, out _))
            {
                return false;
            }

            // Validar con el algoritmo de Luhn
            if (!EsValidoConLuhn(gtin))
            {
                return false;
            }

            // Verificar si el GTIN ya existe en la base de datos
            using (var context = new grupo07DBEntities())
            {
                // Comprobamos si ya existe un producto con ese GTIN en la base de datos
                bool existe = context.Producto.Any(p => p.gtin == gtin);
                if (existe)
                {
                    return false; // El GTIN ya existe en la base de datos
                }
            }

            return true; // El GTIN es válido y no existe en la base de datos
        }

        // Función auxiliar para verificar si el GTIN es válido según el algoritmo de Luhn
        private static bool EsValidoConLuhn(string gtin)
        {
            int suma = 0;

            // Iteramos sobre cada dígito del GTIN-14, desde el último hasta el primero
            for (int i = 0; i < 14; i++)
            {
                // Tomamos el dígito en la posición i (empezamos desde la derecha)
                int digito = gtin[13 - i] - '0';

                // Aplicamos el algoritmo de Luhn: multiplicamos los dígitos en posiciones impares por 3
                // y los dígitos en posiciones pares por 1
                if (i % 2 == 0)
                {
                    suma += digito; // posición impar (empezando desde el 1)
                }
                else
                {
                    suma += digito * 3; // posición par
                }
            }

            // Verificamos si la suma es divisible por 10
            return suma % 10 == 0;
        }





        // FUNCION PARA VERIFICAR QUE EL SKU ES VALIDO
        public static bool EsSKUValido(string sku)
        {
            // Verificamos si el SKU tiene una longitud válida (por ejemplo, entre 5 y 20 caracteres)
            if (string.IsNullOrEmpty(sku) || sku.Length < 5 || sku.Length > 20)
            {
                return false; // El SKU no tiene una longitud válida
            }

            // Verificamos si el SKU contiene solo caracteres alfanuméricos
            if (!sku.All(char.IsLetterOrDigit))
            {
                return false; // El SKU contiene caracteres no alfanuméricos
            }

            // Verificar si el SKU ya existe en la base de datos
            using (var context = new grupo07DBEntities())
            {
                // Comprobamos si ya existe un producto con ese SKU en la base de datos
                bool existe = context.Producto.Any(p => p.sku == sku);
                if (existe)
                {
                    return false; // El SKU ya existe en la base de datos
                }
            }

            return true; // El SKU es válido y no existe en la base de datos
        }

    }
}
