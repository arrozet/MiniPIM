using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPIM.Account
{
    internal class FileManager
    {
        private Cuenta cuenta;
        
        public FileManager(Cuenta cuenta)
        {
            this.cuenta = cuenta;
      
        }
        public void ExportToJson()
        {
            try
            {
                // Construir el path completo en Documents/MiniPIM
                string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MiniPIM");
                string filePath = Path.Combine(folderPath, "cuenta.json");

                // Crear la carpeta si no existe
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                // Crear un objeto anónimo con los datos requeridos
                var cuentaJson = new
                {
                    id = cuenta.id,
                    nombre = cuenta.nombre,
                    fecha_creacion = cuenta.fecha_creacion,
                    email = cuenta.email,
                    numero_atributos_personalizados = cuenta.AtributoPersonalizado?.Count ?? 0,
                    numero_categorias = cuenta.Categoria?.Count ?? 0,
                    numero_productos = cuenta.Producto?.Count ?? 0,
                    numero_relaciones = cuenta.Relacion?.Count ?? 0
                };

                // Convertir el objeto a JSON con formato legible
                var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(cuentaJson, jsonOptions);

                // Escribir el JSON en el archivo
                File.WriteAllText(filePath, jsonString);

                MessageBox.Show($"Datos exportados exitosamente a: {filePath}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al exportar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
