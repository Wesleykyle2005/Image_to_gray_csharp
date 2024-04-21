using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageToGray
{
    public partial class ImagesForm : Form
    {
        private readonly IImageRepository _imageRepository;
        string[]? imagePaths;
        public ImagesForm()
        {
            InitializeComponent();
            _imageRepository = new ImageRepository();
            this.Resize += ResizePanels;
        }

        #region Botones
        private async void selectButton_Click(object sender, EventArgs e)
        {
            imagePaths = await _imageRepository.GetImageAsync();
            DisplaySelectedImages();
        }

        private async void convertButton_Click(object sender, EventArgs e)
        {
            if (imagePaths.Length > 0)
            {
                await _imageRepository.ProcessImageAsync(imagePaths.ToList());
                DisplayConvertedImages();
            }
            else
            {
                MessageBox.Show("Seleccione al menos una imagen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        #endregion

        #region Mover_el_formulario
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        private void ImagesForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = this.Location;
            }
        }

        private void ImagesForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = Cursor.Position.X - lastCursor.X;
                int deltaY = Cursor.Position.Y - lastCursor.Y;
                this.Location = new Point(lastForm.X + deltaX, lastForm.Y + deltaY);
            }
        }

        private void ImagesForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        } 
        #endregion

        #region Paneles_imagenes
        private void DisplaySelectedImages()
        {
            originalImagesPanel.Controls.Clear();

            if (imagePaths != null)
            {
                foreach (var imagePath in imagePaths)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Image = Image.FromFile(imagePath);
                    pictureBox.BackColor = Color.White;
                    originalImagesPanel.Controls.Add(pictureBox);
                    AddRoundBorder(pictureBox, Color.FromArgb(46, 95, 77), 5, 15);
                }
            }
        }
        private void DisplayConvertedImages()
        {
            ConvertedImagesPanel.Controls.Clear();

            if (imagePaths.Length != 0)
            {
                foreach (var imagePath in imagePaths)
                {
                    string filteredImagePath = Path.Combine(Path.GetDirectoryName(imagePath), $"filtered_{Path.GetFileName(imagePath)}");
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    if (File.Exists(filteredImagePath))
                    {
                        pictureBox.Image = Image.FromFile(filteredImagePath);
                        ConvertedImagesPanel.Controls.Add(pictureBox);
                        AddRoundBorder(pictureBox, Color.FromArgb(46, 95, 77), 5, 15);
                    }
                    
                }
            }
            
        }

        private void ResizePanels(object sender, EventArgs e)
        {
            int panelWidth = this.ClientSize.Width / 2;
            originalImagesPanel.Width = panelWidth;
            ConvertedImagesPanel.Width = panelWidth;

            originalImagesPanel.Location = new Point(0, 155);
            ConvertedImagesPanel.Location = new Point(panelWidth, 155);
        }
        private void AddRoundBorder(PictureBox pictureBox, Color borderColor, int borderWidth, int borderRadius)
        {
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                // Dibujar la imagen original
                g.DrawImage(pictureBox.Image, new Rectangle(0, 0, pictureBox.Width, pictureBox.Height));

                // Dibujar el borde redondeado
                using (Pen pen = new Pen(borderColor, borderWidth))
                {
                    pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Outset;
                    g.DrawRectangle(pen, 0, 0, pictureBox.Width - 1, pictureBox.Height - 1);

                    // Dibujar las esquinas redondeadas
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.DrawArc(pen, 0, 0, borderRadius, borderRadius, 180, 90); // Esquina superior izquierda
                    g.DrawArc(pen, pictureBox.Width - borderRadius - 1, 0, borderRadius, borderRadius, 270, 90); // Esquina superior derecha
                    g.DrawArc(pen, 0, pictureBox.Height - borderRadius - 1, borderRadius, borderRadius, 90, 90); // Esquina inferior izquierda
                    g.DrawArc(pen, pictureBox.Width - borderRadius - 1, pictureBox.Height - borderRadius - 1, borderRadius, borderRadius, 0, 90); // Esquina inferior derecha
                }
            }
            pictureBox.Image = bmp;
        }
        #endregion

        #region Botones_Esquina
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void maximizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }    
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion    

    }
}
