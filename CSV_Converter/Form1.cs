using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSV_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargarArchivos_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // 1. Permitir la selección de múltiples archivos
                openFileDialog.Multiselect = true;

                // 2. Opcional: Establecer un filtro (ej. imágenes, documentos, etc.)
                openFileDialog.Filter = "Todos los archivos (*.*)|*.*|Archivos de texto (*.txt)|*.txt";
                openFileDialog.Title = "Selecciona uno o más archivos";

                // 3. Mostrar el diálogo y verificar si el usuario presionó "Abrir"
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // 4. Recorrer cada archivo seleccionado utilizando FileNames (en plural)
                    foreach (string filePath in openFileDialog.FileNames)
                    {
                        // Ejemplo: Mostrar la ruta de cada archivo en la consola o agregarlos a una lista
                        Console.WriteLine(filePath);
                    }

                    // Mensaje opcional para confirmar
                    MessageBox.Show($"Se seleccionaron {openFileDialog.FileNames.Length} archivos.", "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void procesarArchivos()
        {
            /*TODO:antes de importar siempre se vacian las tablas de encabezados y detalles
             recibos.csv va primero en encabezados
            el resto va en detalles
            -descuentos
            -haber sin aportes
            -haber con aportes
             */
        }
    }
}
