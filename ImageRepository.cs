using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageToGray
{
    public class ImageRepository : IImageRepository
    {
        public async Task<string[]> GetImageAsync()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imagenes (*.jpg, jpeg, *.png)| *.jpg;*.jpeg;*.png| Todos los archivos(*.*)|*.*";
                ofd.Multiselect = true;
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    return await Task.FromResult(ofd.FileNames);
                }
                else
                {
                    return new string[0];
                }
            }
        }
        public async Task ProcessImageAsync(List<string> imagePaths)
        {
            var tasks = new List<Task>();
            var successfulImages = new List<string>();
            var errorMessages = new List<string>();

            foreach (string imagePath in imagePaths)
            {
                tasks.Add(Task.Run(async () =>
                {
                    try
                    {
                        // Lógica para aplicar el filtro
                        using (Bitmap originalImage = new Bitmap(imagePath))
                        {
                            // Crear una nueva imagen filtrada
                            using (Bitmap filteredImage = new Bitmap(originalImage.Width, originalImage.Height))
                            {
                                for (int y = 0; y < originalImage.Height; y++)
                                {
                                    for (int x = 0; x < originalImage.Width; x++)
                                    {
                                        Color pixel = originalImage.GetPixel(x, y);
                                        int avg = (pixel.R + pixel.G + pixel.B) / 3;
                                        Color grayColor = Color.FromArgb(avg, avg, avg);
                                        filteredImage.SetPixel(x, y, grayColor);
                                    }
                                }

                                // Obtener el nombre del archivo sin la extensión
                                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(imagePath);

                                // Obtener la extensión del archivo
                                string fileExtension = Path.GetExtension(imagePath);

                                // Generar el nombre del archivo filtrado
                                string filteredFileName = $"filtered_{fileNameWithoutExtension}{fileExtension}";

                                // Obtener la ruta completa del archivo filtrado
                                string filteredImagePath = Path.Combine(Path.GetDirectoryName(imagePath), filteredFileName);

                                // Verificar si el archivo ya existe antes de intentar sobrescribirlo
                                if (!Path.GetFileName(imagePath).StartsWith("filtered_") && !File.Exists(filteredImagePath))
                                {
                                    // Guardar la imagen filtrada solo si el archivo no existe o si la ruta original no comienza con "filtered_"
                                    await Task.Run(() =>
                                    {
                                        filteredImage.Save(filteredImagePath);
                                    });

                                    successfulImages.Add(imagePath);
                                }
                                else
                                {
                                    errorMessages.Add($"Error al procesar la imagen {imagePath}: El archivo filtrado ya existe.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        errorMessages.Add($"Error al procesar la imagen {imagePath}: {ex.Message}");
                    }
                }));
            }

            await Task.WhenAll(tasks);

            // Construir el mensaje final
            StringBuilder message = new StringBuilder();
            message.AppendLine("Imágenes procesadas exitosamente:");
            foreach (string imagePath in successfulImages)
            {
                message.AppendLine(imagePath);
            }
            message.AppendLine();
            message.AppendLine("Errores:");
            foreach (string errorMessage in errorMessages)
            {
                message.AppendLine(errorMessage);
            }

            // Mostrar el mensaje
            MessageBox.Show(message.ToString(), "Resultado del Procesamiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
