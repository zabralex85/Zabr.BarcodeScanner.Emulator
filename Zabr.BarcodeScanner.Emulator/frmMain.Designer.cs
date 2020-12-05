namespace ZEP.Scanner
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnScan = new System.Windows.Forms.Button();
            this.txtScanCode = new System.Windows.Forms.TextBox();
            this.cmbPresets = new System.Windows.Forms.ComboBox();
            this.cmbPresetFilter = new System.Windows.Forms.ComboBox();
            this.pctBarCode = new System.Windows.Forms.PictureBox();
            this.lblTimeOut = new System.Windows.Forms.Label();
            this.numScanTimeOut = new System.Windows.Forms.NumericUpDown();
            this.numScanTimeoutLag = new System.Windows.Forms.NumericUpDown();
            this.lblScanSimTimeout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctBarCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScanTimeOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScanTimeoutLag)).BeginInit();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(12, 477);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(681, 53);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "Do Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // txtScanCode
            // 
            this.txtScanCode.Location = new System.Drawing.Point(12, 39);
            this.txtScanCode.Multiline = true;
            this.txtScanCode.Name = "txtScanCode";
            this.txtScanCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtScanCode.Size = new System.Drawing.Size(681, 220);
            this.txtScanCode.TabIndex = 1;
            this.txtScanCode.WordWrap = false;
            // 
            // cmbPresets
            // 
            this.cmbPresets.FormattingEnabled = true;
            this.cmbPresets.Location = new System.Drawing.Point(12, 12);
            this.cmbPresets.Name = "cmbPresets";
            this.cmbPresets.Size = new System.Drawing.Size(114, 21);
            this.cmbPresets.TabIndex = 2;
            // 
            // cmbPresetFilter
            // 
            this.cmbPresetFilter.FormattingEnabled = true;
            this.cmbPresetFilter.Location = new System.Drawing.Point(132, 12);
            this.cmbPresetFilter.Name = "cmbPresetFilter";
            this.cmbPresetFilter.Size = new System.Drawing.Size(209, 21);
            this.cmbPresetFilter.TabIndex = 3;
            // 
            // pctBarCode
            // 
            this.pctBarCode.Location = new System.Drawing.Point(12, 265);
            this.pctBarCode.Name = "pctBarCode";
            this.pctBarCode.Size = new System.Drawing.Size(681, 206);
            this.pctBarCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctBarCode.TabIndex = 4;
            this.pctBarCode.TabStop = false;
            // 
            // lblTimeOut
            // 
            this.lblTimeOut.AutoSize = true;
            this.lblTimeOut.Location = new System.Drawing.Point(410, 15);
            this.lblTimeOut.Name = "lblTimeOut";
            this.lblTimeOut.Size = new System.Drawing.Size(50, 13);
            this.lblTimeOut.TabIndex = 5;
            this.lblTimeOut.Text = "TimeOut:";
            // 
            // numScanTimeOut
            // 
            this.numScanTimeOut.Location = new System.Drawing.Point(466, 13);
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
            this.numScanTimeOut.TabIndex = 6;
            this.numScanTimeOut.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // numScanTimeoutLag
            // 
            this.numScanTimeoutLag.Location = new System.Drawing.Point(640, 13);
            this.numScanTimeoutLag.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numScanTimeoutLag.Name = "numScanTimeoutLag";
            this.numScanTimeoutLag.Size = new System.Drawing.Size(51, 20);
            this.numScanTimeoutLag.TabIndex = 8;
            // 
            // lblScanSimTimeout
            // 
            this.lblScanSimTimeout.AutoSize = true;
            this.lblScanSimTimeout.Location = new System.Drawing.Point(562, 15);
            this.lblScanSimTimeout.Name = "lblScanSimTimeout";
            this.lblScanSimTimeout.Size = new System.Drawing.Size(73, 13);
            this.lblScanSimTimeout.TabIndex = 7;
            this.lblScanSimTimeout.Text = "TimeOut (lag):";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 544);
            this.Controls.Add(this.numScanTimeoutLag);
            this.Controls.Add(this.lblScanSimTimeout);
            this.Controls.Add(this.numScanTimeOut);
            this.Controls.Add(this.lblTimeOut);
            this.Controls.Add(this.pctBarCode);
            this.Controls.Add(this.cmbPresetFilter);
            this.Controls.Add(this.cmbPresets);
            this.Controls.Add(this.txtScanCode);
            this.Controls.Add(this.btnScan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "zep-scanner";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctBarCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScanTimeOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScanTimeoutLag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.TextBox txtScanCode;
        private System.Windows.Forms.ComboBox cmbPresets;
        private System.Windows.Forms.ComboBox cmbPresetFilter;
        private System.Windows.Forms.PictureBox pctBarCode;
        private System.Windows.Forms.Label lblTimeOut;
        private System.Windows.Forms.NumericUpDown numScanTimeOut;
        private System.Windows.Forms.NumericUpDown numScanTimeoutLag;
        private System.Windows.Forms.Label lblScanSimTimeout;
    }
}

