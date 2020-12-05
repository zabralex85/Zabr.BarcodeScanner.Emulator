
namespace Zabr.BarcodeScanner.Emulator.Forms
{
    partial class frmReader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pctImage = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnReadData = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnReadImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pctImage
            // 
            this.pctImage.Location = new System.Drawing.Point(12, 38);
            this.pctImage.Name = "pctImage";
            this.pctImage.Size = new System.Drawing.Size(320, 240);
            this.pctImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctImage.TabIndex = 0;
            this.pctImage.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" +
    " *.png";
            this.openFileDialog1.Title = "Please select an image file";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(531, 20);
            this.txtPath.TabIndex = 1;
            // 
            // btnReadData
            // 
            this.btnReadData.Location = new System.Drawing.Point(549, 10);
            this.btnReadData.Name = "btnReadData";
            this.btnReadData.Size = new System.Drawing.Size(75, 23);
            this.btnReadData.TabIndex = 2;
            this.btnReadData.Text = "Open File";
            this.btnReadData.UseVisualStyleBackColor = true;
            this.btnReadData.Click += new System.EventHandler(this.btnReadData_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(338, 38);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(286, 240);
            this.txtData.TabIndex = 3;
            // 
            // btnReadImage
            // 
            this.btnReadImage.Location = new System.Drawing.Point(13, 285);
            this.btnReadImage.Name = "btnReadImage";
            this.btnReadImage.Size = new System.Drawing.Size(611, 54);
            this.btnReadImage.TabIndex = 4;
            this.btnReadImage.Text = "Read BarCode";
            this.btnReadImage.UseVisualStyleBackColor = true;
            this.btnReadImage.Click += new System.EventHandler(this.btnReadImage_Click);
            // 
            // frmReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 351);
            this.Controls.Add(this.btnReadImage);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnReadData);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.pctImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmReader";
            this.Text = "Zabr.BarcodeScanner.Emulator - Reader";
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnReadData;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnReadImage;
    }
}