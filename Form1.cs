using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace _12_4_вариант
{
    public partial class Form1 : Form
    {
        private Bitmap? _originalImage;
        private Bitmap? _processedImage;

        public Form1()
        {
            InitializeComponent();
            radioButtonR.Checked = true;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _originalImage = new Bitmap(dialog.FileName);
                        pictureBoxOriginal.Image = _originalImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}");
                    }
                }
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (_originalImage == null)
            {
                MessageBox.Show("Сначала загрузите изображение!");
                return;
            }

            string selectedChannel = "R";
            if (radioButtonG.Checked) selectedChannel = "G";
            if (radioButtonB.Checked) selectedChannel = "B";

            _processedImage = ApplyChannelFilter(_originalImage, selectedChannel);
            pictureBoxProcessed.Image = _processedImage;
        }

        private Bitmap ApplyChannelFilter(Bitmap source, string channel)
        {
            Bitmap result = new Bitmap(source.Width, source.Height);

            for (int y = 0; y < source.Height; y++)
            {
                for (int x = 0; x < source.Width; x++)
                {
                    Color pixel = source.GetPixel(x, y);

                    Color newPixel = channel switch
                    {
                        "R" => Color.FromArgb(pixel.R, 0, 0),
                        "G" => Color.FromArgb(0, pixel.G, 0),
                        "B" => Color.FromArgb(0, 0, pixel.B),
                        _ => throw new ArgumentException("Недопустимый канал")
                    };

                    result.SetPixel(x, y, newPixel);
                }
            }

            return result;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_processedImage == null)
            {
                MessageBox.Show("Нет обработанного изображения!");
                return;
            }

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "PNG Image|*.png";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _processedImage.Save(dialog.FileName, ImageFormat.Png);
                }
            }
        }

        private void btnApply_Click_1(object sender, EventArgs e)
        {
            if (_originalImage == null)
            {
                MessageBox.Show("Сначала загрузите изображение!");
                return;
            }

            string selectedChannel = "R";
            if (radioButtonG.Checked) selectedChannel = "G";
            if (radioButtonB.Checked) selectedChannel = "B";

            _processedImage = ApplyChannelFilter(_originalImage, selectedChannel);

            if (_processedImage != null)
            {
                pictureBoxProcessed.Image = _processedImage;
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (_processedImage == null)
            {
                MessageBox.Show("Нет обработанного изображения для сохранения.");
                return;
            }

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "PNG Image|*.png";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _processedImage.Save(dialog.FileName, ImageFormat.Png);
                        MessageBox.Show("Изображение успешно сохранено!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении: {ex.Message}");
                    }
                }
            }
        }
    }
}