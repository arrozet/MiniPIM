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
    public partial class UpdateProductControl : UserControl
    {
        public UpdateProductControl(Producto p, bool isUpdate)
        {
            InitializeComponent();
            this.Load += new EventHandler(AddProductControl_Load);
            this.productToUpdate = p;
            this.isUpdate = isUpdate;
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
            txtSKU.ReadOnly = true; // para que no se puedan editar
            txtGTIN.ReadOnly = true;
            // Cargar categorías y atributos personalizados al abrir el control
            using (var context = new grupo07DBEntities())
            {
                var categorias = context.Categoria.ToList();
                checkedListBoxCategories.DataSource = categorias;

               
            }
            checkAttributeBoxes();
             
            txtSKU.Text = productToUpdate.sku.ToString();
            txtGTIN.Text = productToUpdate.gtin.ToString();
            txtProductName.Text = productToUpdate.label.ToString();
            txtShortDescription.Text = productToUpdate.descripcionCorta.ToString();
            txtLongDescription.Text = productToUpdate.descripcionLarga.ToString();

            Image imagen = ConvertirBytesAImagen(productToUpdate.thumbnail);

            if (imagen != null)
            {
                pictureBoxThumbnail.Image = imagen; // Mostrar la imagen en el PictureBox
            }
            else
            {
                pictureBoxThumbnail.Image = null; // Limpia el PictureBox si no hay imagen
            }

            
            //SOLO LECTURA
            if (!this.isUpdate)
            {
                this.txtProductName.ReadOnly = true;
                this.txtShortDescription.ReadOnly = true;
                this.txtLongDescription.ReadOnly = true;
                this.btnLoadThumbnail.Visible = false;
                this.checkedListBoxCategories.Enabled = false;
                this.textBoxA1.ReadOnly = true;
                this.textBoxA2.ReadOnly = true;
                this.textBoxA3.ReadOnly = true;
                this.textBoxA4.ReadOnly = true;
                this.textBoxA5.ReadOnly = true;
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
            if (!string.IsNullOrEmpty(txtSKU.Text) && !string.IsNullOrEmpty(txtGTIN.Text) && !string.IsNullOrEmpty(txtProductName.Text) &&
                !string.IsNullOrEmpty(txtShortDescription.Text) && pictureBoxThumbnail.Image != null && !string.IsNullOrEmpty(txtLongDescription.Text))
            {

                
                string sku = txtSKU.Text;
                string gtin = txtGTIN.Text;
                string name = txtProductName.Text;
                string shortDescription = txtShortDescription.Text;
                string longDescription = txtLongDescription.Text;

                    using (var context = new grupo07DBEntities())
                    {
                        // Crear producto

                        productToUpdate.sku = sku;
                        productToUpdate.gtin = gtin;
                        productToUpdate.label = name;
                        productToUpdate.descripcionCorta = shortDescription;
                        productToUpdate.fechaCreacion = DateTime.Now;
                        productToUpdate.descripcionLarga = longDescription;
                        productToUpdate.thumbnail = ConvertirImagenABytes(pictureBoxThumbnail.Image);


                    // Crear una lista para asociar las categorías seleccionadas al producto
                    var nuevoProducto = context.Producto
                       .Include("Categoria")
                       .FirstOrDefault(p => p.sku == sku); // Filtrar por SKU

                    // Crear una lista para asociar las categorías seleccionadas al producto
                    var categoriaIds = checkedListBoxCategories.CheckedItems
                        .OfType<Categoria>() // Convertir los ítems seleccionados a objetos de tipo Categoria
                        .Select(c => c.id)   // Seleccionar solo la propiedad id
                        .ToList();           // Convertir a una lista


                    foreach (int item_id in categoriaIds)
                    {
                        Categoria c = context.Categoria.FirstOrDefault(cat => cat.id == item_id);
                        nuevoProducto.Categoria.Add(c);
                    };
                    context.SaveChanges();

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
















                        // EDU ESCRIBE

                        var atributosPersonalizados = context.AtributoPersonalizado
                            .Select(a => new
                            {
                                a.id,
                                a.nombre,
                                a.tipo,
                                a.espacioOcupado
                            })
                            .ToList();

                        //guarrada incoming
                        if (textBoxA1.Visible)
                        {

                            var at1 = new ProductoAtributo
                            {

                                producto_sku = sku,
                                atributo_id = atributosPersonalizados[0].id,
                                valor = textBoxA1.Text,

                            };
                            context.ProductoAtributo.Add(at1);
                            if (textBoxA2.Visible)
                            {
                                var at2 = new ProductoAtributo
                                {

                                    producto_sku = sku,
                                    atributo_id = atributosPersonalizados[1].id,
                                    valor = textBoxA2.Text,

                                };
                                context.ProductoAtributo.Add(at2);
                                if (textBoxA3.Visible)
                                {
                                    var at3 = new ProductoAtributo
                                    {

                                        producto_sku = sku,
                                        atributo_id = atributosPersonalizados[2].id,
                                        valor = textBoxA3.Text,

                                    };
                                    context.ProductoAtributo.Add(at3);
                                    if (textBoxA4.Visible)
                                    {
                                        var at4 = new ProductoAtributo
                                        {

                                            producto_sku = sku,
                                            atributo_id = atributosPersonalizados[3].id,
                                            valor = textBoxA4.Text,

                                        };
                                        context.ProductoAtributo.Add(at4);
                                        if (textBoxA5.Visible)
                                        {
                                            var at5 = new ProductoAtributo
                                            {

                                                producto_sku = sku,
                                                atributo_id = atributosPersonalizados[4].id,
                                                valor = textBoxA5.Text,

                                            };
                                            context.ProductoAtributo.Add(at5);
                                        }
                                    }
                                }
                            }
                        }






                        // Agregar y guardar cambios en la base de datos
                        //context.Producto.Add(producto);
                        //context.SaveChanges();

                        MessageBox.Show("Product created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpiar formulario

                        // THUMBNAIL TIENE QUE SER OBLIGATORIO HAY QUE AÑADIR DESCRIPCION LARGA Y ADEMAS NO SE CREAN LOS PRODUCTOS POR LO QUE SEA
                    }


                    // PARA DECIR QUE EL SKU Y EL GTIN SON INVÁLIDOS
                
                


            }
            else
            {
                DialogResult result = MessageBox.Show(
                "All required fields must be completed.",
                "Campos obligatorios",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }









       

        private byte[] ConvertirImagenABytes(Image imagen)
        {
            using (var ms = new MemoryStream())
            {
                // Detectar si la imagen es JPEG o PNG
                if (System.Drawing.Imaging.ImageFormat.Jpeg.Equals(imagen.RawFormat))
                {
                    // Guardar la imagen en formato JPEG
                    imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                else if (System.Drawing.Imaging.ImageFormat.Png.Equals(imagen.RawFormat))
                {
                    // Guardar la imagen en formato PNG
                    imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                }
                else
                {
                    throw new InvalidOperationException("El formato de la imagen no es compatible. Solo se aceptan JPG o PNG.");
                }

                return ms.ToArray();
            }
        }

        private void checkAttributeBoxes()
        {
            using (var context = new grupo07DBEntities())
            {
                var atributosPersonalizados = context.AtributoPersonalizado
            .Select(a => new
            {
                a.id,
                a.nombre,
                a.tipo,
                a.espacioOcupado
            })
            .ToList();
                List<Label> labels = new List<Label>();
                labels.Add(lblA1); labels.Add(lblA2); labels.Add(lblA3); labels.Add(lblA4); labels.Add(lblA5);
                List<System.Windows.Forms.TextBox> textBoxes = new List<System.Windows.Forms.TextBox>();
                textBoxes.Add(textBoxA1); textBoxes.Add(textBoxA2); textBoxes.Add(textBoxA3); textBoxes.Add(textBoxA4); textBoxes.Add(textBoxA5);
                for (int i = 0; i < atributosPersonalizados.Count; i++)
                {
                    Label l = labels[i];
                    System.Windows.Forms.TextBox txt = textBoxes[i];
                    l.Text = atributosPersonalizados[i].nombre;
                    l.Visible = true;
                    l.Enabled = true;
                    txt.Visible = true;
                    txt.Enabled = true;

                }
            }

        }

        private Image ConvertirBytesAImagen(byte[] bytesImagen)
        {
            if (bytesImagen == null || bytesImagen.Length == 0)
                return null; // Si no hay imagen, devolver null

            using (var ms = new MemoryStream(bytesImagen))
            {
                return Image.FromStream(ms); // Crear la imagen desde el stream
            }
        }

    }
}
