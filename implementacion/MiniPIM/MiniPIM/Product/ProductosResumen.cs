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
using MiniPIM.Attribute;
using MiniPIM.Category;
using MiniPIM.Relationships;
using MiniPIM.Product;
using MiniPIM.Account;
using System.Runtime.Remoting.Contexts;

namespace MiniPIM.Product
{
    public partial class ProductosResumen : Form
    {
        grupo07DBEntities contextGlobalFeo = new grupo07DBEntities();
        public ProductosResumen()
        {
            InitializeComponent();
            this.Load += new EventHandler(ProductosResumen_Load);
            dataGridView1.CellContentClick += dataGridView1_CellContentClick; // pa pode elimina y modifica

        }

        private void ProductosResumen_Load(object sender, EventArgs e)
        {
            CargarCategories();
            productsToolStripMenuItem.Enabled = false; // esto lo podríamos poner directamente en el 
            dataGridView1.AutoGenerateColumns = false; // no se generan columnas nuevas feas
            New_Product_Button.Visible = true; // para que no muera
            dataGridView1.Columns["Pencil"].Visible = true;
            dataGridView1.Columns["Delete"].Visible = true;
            productsToolStripMenuItem.Enabled = false;
            exportToolStripMenuItem.Enabled = true;
            categoriesListBox.Visible = false;
            btnExportCSV.Visible = false;
            All_Products_label.Text = "All Products";

            cargarProductos();
            dataGridView1.ClearSelection(); // para que no aparezca selecionada la priemera columna
        }

        private void cargarProductos()
        {
            try
            {
                // Crear una instancia del contexto de Entity Framework
                using (var context = new grupo07DBEntities())
                {
                    // Sin usar Include, Entity Framework no cargará las categorías relacionadas al ejecutar la consulta inicial
                    // Esto es como hacer un JOIN, ahora sí tendré la tabla categorías a mi disposición
                    var productos = context.Producto
                        .Include("Categoria") // Cargar las categorías relacionadas (además de los productos)
                        .ToList();

                    // Procesar los datos para el DataGridView
                    var productosParaMostrar = productos
                        .Select(p => new
                        {
                            p.sku,
                            p.label,
                            p.descripcionCorta,
                            p.thumbnail,
                            // Concatenar los nombres de las categorías
                            Categories = p.Categoria != null && p.Categoria.Any()
                                ? string.Join(", ", p.Categoria.Select(c => c.nombre))
                                : ""
                        })
                        .ToList();
                    // Reescalar imagen

                    // Configurar las columnas del DataGridView
                    dataGridView1.Columns["SKU"].DataPropertyName = "sku";
                    dataGridView1.Columns["ProductTitle"].DataPropertyName = "label";
                    dataGridView1.Columns["ShortDescription"].DataPropertyName = "descripcionCorta";
                    dataGridView1.Columns["Thumbnail"].DataPropertyName = "thumbnail";
                    dataGridView1.Columns["Categories"].DataPropertyName = "Categories";

                    // Asignar los datos procesados al DataGridView
                    dataGridView1.DataSource = productosParaMostrar;
                    // MUESTRA LA ETIQUETA SI NO HAY PRODUCTOS
                    if (productosParaMostrar.Count > 0)
                    {
                        dataGridView1.Visible = true;  // Mostrar el DataGridView
                        NoAttributes.Visible = false;  // Ocultar el Label
                    }
                    else
                    {
                        dataGridView1.Visible = false; // Ocultar el DataGridView
                        NoAttributes.Visible = true;   // Mostrar el Label
                    }
                }

            }
            catch (Exception ex)
            {
                // Mostrar cualquier error que ocurra
                MessageBox.Show($"Error al cargar los datos: {ex.Message}");
            }
        }


        private void productsToolStripMenuItem_Click(object sender, EventArgs e) //PRODUCTS
        {
            ProductosResumen_Load(sender, e);   
        }

        private void attributesToolStripMenuItem_Click(object sender, EventArgs e) // ATTRIBUTES
        {
            // Crear instancia del formulario de atributos
            AtributosSeccion atributosForm = new AtributosSeccion();

            // Asignar la posición y el tamaño del formulario actual
            atributosForm.StartPosition = FormStartPosition.Manual; // Para permitir personalizar la posición
            atributosForm.Location = this.Location; // Misma posición que el formulario actual
            atributosForm.Size = this.Size; // Mismo tamaño que el formulario actual

            // Mostrar el nuevo formulario y ocultar el actual
            this.Hide();
            atributosForm.Show();
            
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e) // CATEGORIES
        {
            // Crear instancia del formulario de categorías
            CategoriaSeccion categoriasForm = new CategoriaSeccion();

            // Asignar la posición y el tamaño del formulario actual
            categoriasForm.StartPosition = FormStartPosition.Manual;
            categoriasForm.Location = this.Location;
            categoriasForm.Size = this.Size;

            // Mostrar el nuevo formulario y ocultar el actual
            categoriasForm.Show();
            this.Hide();
        }

        private void relationshipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear instancia del formulario de categorías
            RelacionesSeccion relacionesForm = new RelacionesSeccion();

            // Asignar la posición y el tamaño del formulario actual
            relacionesForm.StartPosition = FormStartPosition.Manual;
            relacionesForm.Location = this.Location;
            relacionesForm.Size = this.Size;

            // Mostrar el nuevo formulario y ocultar el actual
            relacionesForm.Show();
            this.Hide();
        }

        private Image ResizeImage(Image image, int width, int height)
        {
            // Crear un nuevo Bitmap con el tamaño deseado
            Bitmap resizedImage = new Bitmap(width, height);

            // Dibujar la imagen original en el nuevo Bitmap
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, width, height);
            }

            return resizedImage;
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) // LAPIZ Y X
        {
            // Verificar que no se ha hecho clic en el encabezado (rowIndex >= 0)
            if (e.RowIndex >= 0)
            {
                // Obtener el nombre de la columna clicada
                string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

                if (columnName.Equals("Pencil")) // Botón de modificar
                {

                    // Obtener el índice de la fila seleccionada
                    int rowIndex = e.RowIndex;

                    // Obtener datos asociados a la fila
                    var sku = dataGridView1.Rows[rowIndex].Cells["sku"].Value.ToString();
                    //faltan datos
                    Producto productoSeleccionado;
                    using (var context = new grupo07DBEntities())
                    {
                        productoSeleccionado = context.Producto.FirstOrDefault(p => p.sku == sku);
                    }
                    UpdateProductControl upc = new UpdateProductControl(productoSeleccionado, true);
                    this.Controls.Clear();

                    // Configurar y agregar el nuevo UserControl
                    upc.Dock = DockStyle.Fill; // Ajustar el UserControl al tamaño del contenedor
                    this.Controls.Add(upc); // Agregar el nuevo UserControl al contenedor

                    // Abrir el formulario de modificación (Form2)
                    // var form2 = new Form2(sku); // Suponiendo que pasas el SKU al constructor de Form2
                    // form2.ShowDialog(); // Mostrar como un cuadro modal
                }
                else if (columnName.Equals("Delete")) // Botón de eliminar
                {
                    // Obtener el índice de la fila seleccionada
                    int rowIndex = e.RowIndex;

                    // Obtener datos asociados a la fila
                    var sku = dataGridView1.Rows[rowIndex].Cells["sku"].Value.ToString();

                    // Mostrar un mensaje de confirmación
                    var result = MessageBox.Show($"Are you sure you want to delete product {sku}?",
                                                 "Confirmar eliminación",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Error);

                    if (result == DialogResult.Yes)
                    {
                        // Aquí va el código para eliminar el producto de la base de datos
                        //var p = dataGridView1.CurrentRow.DataBoundItem;
                        using (var context = new grupo07DBEntities())
                        {
                            var producto = context.Producto.SingleOrDefault(p => p.sku == sku);
                            if (producto != null)
                            {
                                // Eliminar el producto
                                context.Producto.Remove(producto);

                                // Guardar cambios en la base de datos
                                context.SaveChanges();
                                cargarProductos(); // recarga los productos
                                dataGridView1.ClearSelection();
                                MessageBox.Show("Product successfully deleted", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            // Mostrar un mensaje de éxito

                        }


                    }
                } else if (columnName.Equals("SKU"))
                {

                    // Obtener el índice de la fila seleccionada
                    int rowIndex = e.RowIndex;

                    // Obtener datos asociados a la fila
                    var sku = dataGridView1.Rows[rowIndex].Cells["sku"].Value.ToString();
                    //faltan datos
                    Producto productoSeleccionado;
                    using (var context = new grupo07DBEntities())
                    {
                        productoSeleccionado = context.Producto.FirstOrDefault(p => p.sku == sku);
                    }
                    UpdateProductControl upc = new UpdateProductControl(productoSeleccionado, false);
                    this.Controls.Clear();

                    // Configurar y agregar el nuevo UserControl
                    upc.Dock = DockStyle.Fill; // Ajustar el UserControl al tamaño del contenedor
                    this.Controls.Add(upc); // Agregar el nuevo UserControl al contenedor
                }
            }

         

    }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void New_Product_Button_Click(object sender, EventArgs e) //  + NEW PRODUCT
        {
            
            // Crear una instancia del UserControl "AddProduct"
            AddProductControl addProductControl = new AddProductControl();

            // Obtener el formulario principal (padre del UserControl actual)
            // Limpiar el contenido actual del contenedor

            this.Controls.Clear();

            // Configurar y agregar el nuevo UserControl
            addProductControl.Dock = DockStyle.Fill; // Ajustar el UserControl al tamaño del contenedor
            this.Controls.Add(addProductControl); // Agregar el nuevo UserControl al contenedor
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NoAttributes_Click(object sender, EventArgs e)
        {

        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountForm acForm = new AccountForm();
            acForm.StartPosition = this.StartPosition;
            acForm.Location = this.Location;
            acForm.Size = Size;

            acForm.Show();
            this.Hide();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Product_Button.Visible = false;
            dataGridView1.Columns["Delete"].Visible = false;
            dataGridView1.Columns["Pencil"].Visible = false;
            productsToolStripMenuItem.Enabled = true;
            exportToolStripMenuItem.Enabled = false;
            categoriesListBox.Visible = true;
            btnExportCSV.Visible = true;
            All_Products_label.Text = "Filtered Products";
        }
        private void CargarCategories()
        {
            
            var categorias = contextGlobalFeo.Categoria.ToList();
            categoriesListBox.DataSource = categorias;
            categoriesListBox.ClearSelected();
            

            
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            List<Producto> toExport = new List<Producto>();
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                string sku = row.Cells["SKU"].Value.ToString();
                toExport.Add(contextGlobalFeo.Producto.Where(p => p.sku.Equals(sku)).FirstOrDefault());
            }
            ExportarA_CSV(toExport);
        }
        private void ExportarA_CSV(List<Producto> productos)
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MiniPIM");
            string filePath = Path.Combine(folderPath, "amazonCSV.json");
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                // Escribir la cabecera del archivo CSV
                sw.WriteLine("SKU,Title,FulfilledBy,Amazon_SKU,Price,OfferPrimer");

                // Escribir los productos al archivo
                foreach (Producto producto in productos)
                {
                    // Obtener el precio del producto
                    decimal price = ObtenerPrecioValido(producto.ProductoAtributo);

                    // Si no tiene un precio válido, lo omitimos
                    if (price == -1)
                    {
                        MessageBox.Show($"No se pudo exportar el producto {producto.label} ya que no contiene un atributo numérico");
                        continue;
                    }
                    Cuenta cuenta = contextGlobalFeo.Cuenta.Where(c => c.id == producto.cuenta_id).FirstOrDefault();

                    // Escribir la línea del producto en el CSV
                    sw.WriteLine($"{producto.sku},{producto.label},{cuenta.nombre},{producto.gtin},{price},false");
                }
            }
            MessageBox.Show($"Exportación a CSV completa en {filePath}");
        }
        private decimal ObtenerPrecioValido(ICollection<ProductoAtributo> productoAtributos)
        {
            // Buscar el primer atributo que sea de tipo numérico (number)
            foreach (var productoAtributo in productoAtributos)
            {
                if (productoAtributo.AtributoPersonalizado.tipo == "number")
                {
                    // Convertir el valor del atributo a decimal si es un precio
                    decimal precio;
                    if (Decimal.TryParse(productoAtributo.valor.ToString(), out precio))
                    {
                        return precio;
                    }
                }
            }

            // Si no se encuentra un precio válido, retornar -1
            return -1;
        }


        private void categoriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            Categoria categoria = (Categoria)categoriesListBox.SelectedItem;
            if (categoria != null) //se ejecuta al cargar por algun motivo, sin esto hace caput
            {
                var productos = contextGlobalFeo.Producto
                .Include("Categoria") // Cargar la relación con Categoria
                .ToList();


                productos = productos.Where(p => p.Categoria.Any(c => c.id == categoria.id)).ToList(); // seleccionar solo los gormitis que son de la categoria seleccionada

                // Procesar los datos para el DataGridView
                var productosParaMostrar = productos
                    .Select(p => new
                    {
                        p.sku,
                        p.label,
                        p.descripcionCorta,
                        p.thumbnail,
                        // Concatenar los nombres de las categorías
                        Categories = p.Categoria != null && p.Categoria.Any()
                            ? string.Join(", ", p.Categoria.Select(c => c.nombre))
                            : ""
                    })
                    .ToList();
                // Reescalar imagen

                // Configurar las columnas del DataGridView
                dataGridView1.Columns["SKU"].DataPropertyName = "sku";
                dataGridView1.Columns["ProductTitle"].DataPropertyName = "label";
                dataGridView1.Columns["ShortDescription"].DataPropertyName = "descripcionCorta";
                dataGridView1.Columns["Thumbnail"].DataPropertyName = "thumbnail";
                dataGridView1.Columns["Categories"].DataPropertyName = "Categories";

                // Asignar los datos procesados al DataGridView
                dataGridView1.DataSource = productosParaMostrar;
                // MUESTRA LA ETIQUETA SI NO HAY PRODUCTOS
                if (productosParaMostrar.Count > 0)
                {
                    dataGridView1.Visible = true;  // Mostrar el DataGridView
                    NoAttributes.Visible = false;  // Ocultar el Label
                }
                else
                {
                    dataGridView1.Visible = false; // Ocultar el DataGridView
                    NoAttributes.Visible = true;   // Mostrar el Label
                }
            }
            
        }
    }
}
