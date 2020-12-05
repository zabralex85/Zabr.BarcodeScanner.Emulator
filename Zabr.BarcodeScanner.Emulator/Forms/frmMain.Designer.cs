namespace Zabr.BarcodeScanner.Emulator.Forms
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
            this.btnReadData = new System.Windows.Forms.Button();
            this.btnOpenSendForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReadData
            // 
            this.btnReadData.Location = new System.Drawing.Point(319, 12);
            this.btnReadData.Name = "btnReadData";
            this.btnReadData.Size = new System.Drawing.Size(148, 52);
            this.btnReadData.TabIndex = 20;
            this.btnReadData.Text = "Open Read Form";
            this.btnReadData.UseVisualStyleBackColor = true;
            this.btnReadData.Click += new System.EventHandler(this.btnReadData_Click);
            // 
            // btnOpenSendForm
            // 
            this.btnOpenSendForm.Location = new System.Drawing.Point(12, 12);
            this.btnOpenSendForm.Name = "btnOpenSendForm";
            this.btnOpenSendForm.Size = new System.Drawing.Size(148, 52);
            this.btnOpenSendForm.TabIndex = 21;
            this.btnOpenSendForm.Text = "Open Send Form";
            this.btnOpenSendForm.UseVisualStyleBackColor = true;
            this.btnOpenSendForm.Click += new System.EventHandler(this.btnOpenSendForm_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 76);
            this.Controls.Add(this.btnOpenSendForm);
            this.Controls.Add(this.btnReadData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zabr.BarcodeScanner.Emulator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReadData;
        private System.Windows.Forms.Button btnOpenSendForm;
    }
}

