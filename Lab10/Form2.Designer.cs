
namespace Lab10
{
    partial class PrinterForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPrinterLife = new System.Windows.Forms.TextBox();
            this.tbTexWrite = new System.Windows.Forms.TextBox();
            this.tbSpeedWrite = new System.Windows.Forms.TextBox();
            this.tbPaperSize = new System.Windows.Forms.TextBox();
            this.tbDPI = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbHasWiFi = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPrinterLife);
            this.groupBox1.Controls.Add(this.tbTexWrite);
            this.groupBox1.Controls.Add(this.tbSpeedWrite);
            this.groupBox1.Controls.Add(this.tbPaperSize);
            this.groupBox1.Controls.Add(this.tbDPI);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(39, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загальні дані";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbPrinterLife
            // 
            this.tbPrinterLife.Location = new System.Drawing.Point(242, 238);
            this.tbPrinterLife.Name = "tbPrinterLife";
            this.tbPrinterLife.Size = new System.Drawing.Size(100, 20);
            this.tbPrinterLife.TabIndex = 12;
            // 
            // tbTexWrite
            // 
            this.tbTexWrite.Location = new System.Drawing.Point(242, 197);
            this.tbTexWrite.Name = "tbTexWrite";
            this.tbTexWrite.Size = new System.Drawing.Size(100, 20);
            this.tbTexWrite.TabIndex = 11;
            // 
            // tbSpeedWrite
            // 
            this.tbSpeedWrite.Location = new System.Drawing.Point(242, 153);
            this.tbSpeedWrite.Name = "tbSpeedWrite";
            this.tbSpeedWrite.Size = new System.Drawing.Size(100, 20);
            this.tbSpeedWrite.TabIndex = 10;
            // 
            // tbPaperSize
            // 
            this.tbPaperSize.Location = new System.Drawing.Point(242, 111);
            this.tbPaperSize.Name = "tbPaperSize";
            this.tbPaperSize.Size = new System.Drawing.Size(100, 20);
            this.tbPaperSize.TabIndex = 9;
            // 
            // tbDPI
            // 
            this.tbDPI.Location = new System.Drawing.Point(242, 70);
            this.tbDPI.Name = "tbDPI";
            this.tbDPI.Size = new System.Drawing.Size(100, 20);
            this.tbDPI.TabIndex = 8;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(242, 30);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Строк предатності принтеру";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Технологія печаті";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Швидкість друку";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Підтримуемий формат бумаги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Максимальний dpi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Назва принтеру";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbHasWiFi);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(39, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 72);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Додаткові данні";
            // 
            // chbHasWiFi
            // 
            this.chbHasWiFi.AutoSize = true;
            this.chbHasWiFi.Location = new System.Drawing.Point(36, 34);
            this.chbHasWiFi.Name = "chbHasWiFi";
            this.chbHasWiFi.Size = new System.Drawing.Size(103, 17);
            this.chbHasWiFi.TabIndex = 7;
            this.chbHasWiFi.Text = "Підтримка WiFi";
            this.chbHasWiFi.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Строк предатності принтеру";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(491, 111);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCance_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(491, 63);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // PrinterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "PrinterForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додати принтер";
            this.Load += new System.EventHandler(this.PrinterForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPrinterLife;
        private System.Windows.Forms.TextBox tbTexWrite;
        private System.Windows.Forms.TextBox tbSpeedWrite;
        private System.Windows.Forms.TextBox tbPaperSize;
        private System.Windows.Forms.TextBox tbDPI;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.CheckBox chbHasWiFi;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
    }
}