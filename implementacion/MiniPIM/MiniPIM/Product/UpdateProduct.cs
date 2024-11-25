using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

                var nuevoProducto = context.Producto
                           .Include("Categoria")
                           .FirstOrDefault(np => np.sku == productToUpdate.sku); // Filtrar por SKU

                var categoriasProducto = nuevoProducto.Categoria;

                // Checkear las categorias que tiene el producto
                foreach(Categoria item in categoriasProducto)
                {
                    //Console.WriteLine("NOMBRE DE CATEGORIA DE PRODUCTO:"+item.nombre);
                    int index = checkedListBoxCategories.Items.IndexOf(item);
                    checkedListBoxCategories.SetItemChecked(index, true);
                }
            }
            checkAttributeBoxes();
             
            

            txtSKU.Text = productToUpdate.sku.ToString();
            txtGTIN.Text = productToUpdate.gtin.ToString();
            txtProductName.Text = productToUpdate.label.ToString();
            txtShortDescription.Text = productToUpdate.descripcionCorta.ToString();
            txtLongDescription.Text = productToUpdate.descripcionLarga.ToString();
            

            Image imagen = ConvertirBytesAImagen(productToUpdate.thumbnail);
            this.imagenOriginal = imagen;
            this.nombreOG = productToUpdate.label;
            this.dcOG = productToUpdate.descripcionCorta;
            this.dlOG = productToUpdate.descripcionLarga;
            
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

                    //productToUpdate.sku = sku;
                    //productToUpdate.gtin = gtin;
                    Producto updatableProduct = context.Producto.Where(x => x.sku == productToUpdate.sku).FirstOrDefault();

                    updatableProduct.label = name;
                    updatableProduct.descripcionCorta = shortDescription;
                    updatableProduct.ultimaModificacion = DateTime.Now;
                    updatableProduct.descripcionLarga = longDescription;

                    if (!imagenOriginal.Equals(pictureBoxThumbnail.Image)) // PA QUE NO DE ERROR
                    {
                        updatableProduct.thumbnail = ConvertirImagenABytes(pictureBoxThumbnail.Image);
                    }


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

                    if (!nombreOG.Equals(name) || !dcOG.Equals(shortDescription) || !dlOG.Equals(longDescription))
                    {
                        context.SaveChanges();
                    }
                }
                using (var context = new grupo07DBEntities())
                {
                    // pa que se modifiquen los atrbutos NO PREGUNTEN COMO FUNCIONA
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
                        var atributos = context.ProductoAtributo.Where(p => p.producto_sku == productToUpdate.sku).ToList();

                        foreach (ProductoAtributo pa in atributos)
                        {
                            if (atributosPersonalizados[i].id.Equals(pa.atributo_id))
                            {
                                pa.valor = txt.Text;
                            }
                        }

                    }
                    context.SaveChanges();
                }  
                    // Agregar y guardar cambios en la base de datos
                    //context.Producto.Add(producto);
                    //context.SaveChanges();

                    MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        // Limpiar formulario
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
                    var atributos = context.ProductoAtributo.Where(p => p.producto_sku == productToUpdate.sku).ToList();
                    
                    foreach (ProductoAtributo pa in atributos)
                    {
                        if (atributosPersonalizados[i].id.Equals(pa.atributo_id))
                        {
                            txt.Text = pa.valor.ToString();
                        }
                    }
                    
                }
            }

        }

        private Image ConvertirBytesAImagen(byte[] bytesImagen)
        {
            if (bytesImagen == null || bytesImagen.Length == 0)
                return null; // Si no hay imagen, devolver null

            using (var ms = new MemoryStream(bytesImagen))
            {
                // Crear la imagen desde el stream
                Image imagenOriginal = Image.FromStream(ms);

                // Redimensionar la imagen a 200x200
                Image imagenRedimensionada = RedimensionarImagen(imagenOriginal, 200, 200);

                // Convertir la imagen redimensionada a formato PNG o JPG
                return imagenRedimensionada;
            }
        }

        private Image RedimensionarImagen(Image imagenOriginal, int ancho, int alto)
        {
            // Crear una nueva imagen con las dimensiones deseadas
            Bitmap imagenRedimensionada = new Bitmap(ancho, alto);

            // Usar el objeto Graphics para dibujar la imagen redimensionada
            using (Graphics g = Graphics.FromImage(imagenRedimensionada))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent); // Fondo transparente si es PNG

                // Dibujar la imagen original redimensionada
                g.DrawImage(imagenOriginal, 0, 0, ancho, alto);
            }

            return imagenRedimensionada;
        }


    }
}
