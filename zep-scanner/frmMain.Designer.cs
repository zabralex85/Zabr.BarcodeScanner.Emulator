namespace Walli.SweedPos.Utils.Scanner
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
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(12, 385);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(329, 53);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "Do Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            // 
            // txtScanCode
            // 
            this.txtScanCode.Location = new System.Drawing.Point(12, 39);
            this.txtScanCode.Multiline = true;
            this.txtScanCode.Name = "txtScanCode";
            this.txtScanCode.Size = new System.Drawing.Size(329, 340);
            this.txtScanCode.TabIndex = 1;
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 450);
            this.Controls.Add(this.cmbPresetFilter);
            this.Controls.Add(this.cmbPresets);
            this.Controls.Add(this.txtScanCode);
            this.Controls.Add(this.btnScan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Walli.SweedPos.Utils.Scanner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.TextBox txtScanCode;
        private System.Windows.Forms.ComboBox cmbPresets;
        private System.Windows.Forms.ComboBox cmbPresetFilter;
    }
}

