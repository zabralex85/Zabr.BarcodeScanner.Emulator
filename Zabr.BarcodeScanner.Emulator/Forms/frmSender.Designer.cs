
namespace Zabr.BarcodeScanner.Emulator.Forms
{
    partial class frmSender
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
            this.numScanTimeoutLag = new System.Windows.Forms.NumericUpDown();
            this.lblScanSimTimeout = new System.Windows.Forms.Label();
            this.numScanTimeOut = new System.Windows.Forms.NumericUpDown();
            this.lblTimeOut = new System.Windows.Forms.Label();
            this.pctBarCode = new System.Windows.Forms.PictureBox();
            this.cmbPresetFilter = new System.Windows.Forms.ComboBox();
            this.cmbPresets = new System.Windows.Forms.ComboBox();
            this.txtScanCode = new System.Windows.Forms.TextBox();
            this.btnScan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numScanTimeoutLag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScanTimeOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBarCode)).BeginInit();
            this.SuspendLayout();
            // 
            // numScanTimeoutLag
            // 
            this.numScanTimeoutLag.Location = new System.Drawing.Point(640, 10);
            this.numScanTimeoutLag.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numScanTimeoutLag.Name = "numScanTimeoutLag";
            this.numScanTimeoutLag.Size = new System.Drawing.Size(51, 20);
            this.numScanTimeoutLag.TabIndex = 18;
            // 
            // lblScanSimTimeout
            // 
            this.lblScanSimTimeout.AutoSize = true;
            this.lblScanSimTimeout.Location = new System.Drawing.Point(562, 12);
            this.lblScanSimTimeout.Name = "lblScanSimTimeout";
            this.lblScanSimTimeout.Size = new System.Drawing.Size(73, 13);
            this.lblScanSimTimeout.TabIndex = 17;
            this.lblScanSimTimeout.Text = "TimeOut (lag):";
            // 
            // numScanTimeOut
            // 
            this.numScanTimeOut.Location = new System.Drawing.Point(466, 10);
            this.numScanTimeOut.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numScanTimeOut.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numScanTimeOut.Name = "numScanTimeOut";
            this.numScanTimeOut.Size = new System.Drawing.Size(82, 20);
            this.numScanTimeOut.TabIndex = 16;
            this.numScanTimeOut.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // lblTimeOut
            // 
            this.lblTimeOut.AutoSize = true;
            this.lblTimeOut.Location = new System.Drawing.Point(410, 12);
            this.lblTimeOut.Name = "lblTimeOut";
            this.lblTimeOut.Size = new System.Drawing.Size(50, 13);
            this.lblTimeOut.TabIndex = 15;
            this.lblTimeOut.Text = "TimeOut:";
            // 
            // pctBarCode
            // 
            this.pctBarCode.Location = new System.Drawing.Point(12, 262);
            this.pctBarCode.Name = "pctBarCode";
            this.pctBarCode.Size = new System.Drawing.Size(681, 206);
            this.pctBarCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctBarCode.TabIndex = 14;
            this.pctBarCode.TabStop = false;
            // 
            // cmbPresetFilter
            // 
            this.cmbPresetFilter.FormattingEnabled = true;
            this.cmbPresetFilter.Location = new System.Drawing.Point(132, 9);
            this.cmbPresetFilter.Name = "cmbPresetFilter";
            this.cmbPresetFilter.Size = new System.Drawing.Size(209, 21);
            this.cmbPresetFilter.TabIndex = 13;
            // 
            // cmbPresets
            // 
            this.cmbPresets.FormattingEnabled = true;
            this.cmbPresets.Location = new System.Drawing.Point(12, 9);
            this.cmbPresets.Name = "cmbPresets";
            this.cmbPresets.Size = new System.Drawing.Size(114, 21);
            this.cmbPresets.TabIndex = 12;
            // 
            // txtScanCode
            // 
            this.txtScanCode.Location = new System.Drawing.Point(12, 36);
            this.txtScanCode.Multiline = true;
            this.txtScanCode.Name = "txtScanCode";
            this.txtScanCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtScanCode.Size = new System.Drawing.Size(681, 220);
            this.txtScanCode.TabIndex = 11;
            this.txtScanCode.WordWrap = false;
            this.txtScanCode.TextChanged += new System.EventHandler(this.txtScanCode_TextChanged);
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(12, 474);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(681, 53);
            this.btnScan.TabIndex = 10;
            this.btnScan.Text = "Send Symbols To System";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // frmSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 543);
            this.Controls.Add(this.numScanTimeoutLag);
            this.Controls.Add(this.lblScanSimTimeout);
            this.Controls.Add(this.numScanTimeOut);
            this.Controls.Add(this.lblTimeOut);
            this.Controls.Add(this.pctBarCode);
            this.Controls.Add(this.cmbPresetFilter);
            this.Controls.Add(this.cmbPresets);
            this.Controls.Add(this.txtScanCode);
            this.Controls.Add(this.btnScan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmSender";
            this.Text = "Zabr.BarcodeScanner.Emulator - Sender";
            this.Load += new System.EventHandler(this.frmSender_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numScanTimeoutLag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScanTimeOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBarCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numScanTimeoutLag;
        private System.Windows.Forms.Label lblScanSimTimeout;
        private System.Windows.Forms.NumericUpDown numScanTimeOut;
        private System.Windows.Forms.Label lblTimeOut;
        private System.Windows.Forms.PictureBox pctBarCode;
        private System.Windows.Forms.ComboBox cmbPresetFilter;
        private System.Windows.Forms.ComboBox cmbPresets;
        private System.Windows.Forms.TextBox txtScanCode;
        private System.Windows.Forms.Button btnScan;
    }
}