using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageMagick;
using Zabr.BarcodeScanner.Emulator.BLL.Utils;

namespace Zabr.BarcodeScanner.Emulator.Forms
{
    public partial class frmReader : Form
    {
        public frmReader()
        {
            InitializeComponent();

            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
        }

        private void btnReadData_Click(object sender, EventArgs e)
        {
            var dialog = openFileDialog1.ShowDialog();
            
            if (dialog == DialogResult.OK)
            {
                txtPath.Text = openFileDialog1.FileName;

                if (!string.IsNullOrEmpty(txtPath.Text))
                {
                    pctImage.Image = Image.FromFile(txtPath.Text);
                }
            }
        }

        private void btnReadImage_Click(object sender, EventArgs e)
        {
            var task = Task.Run(async () =>
            {
                var imgMag = new MagickImage(txtPath.Text);

                byte[] dataBytes = imgMag.ToByteArray();
                var aamvaData = await DecoderUtils.DecodeGlobalAsync(dataBytes);

                if (!string.IsNullOrEmpty(aamvaData))
                {
                    txtData.Text = aamvaData;
                }
            });
            task.Wait();
        }
    }
}
