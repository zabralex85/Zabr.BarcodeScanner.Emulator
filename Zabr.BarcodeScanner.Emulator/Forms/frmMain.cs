using System;
using System.Windows.Forms;

namespace Zabr.BarcodeScanner.Emulator.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void btnOpenSendForm_Click(object sender, EventArgs e)
        {
            frmSender frmSender = new frmSender();
            frmSender.Show();
        }

        private void btnReadData_Click(object sender, EventArgs e)
        {
            frmReader reader = new frmReader();
            reader.Show();
        }
    }
}
