namespace WindowsFormsApp1
{
    partial class Form1
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.HOrt = new System.Windows.Forms.Label();
            this.Ortalama = new System.Windows.Forms.Label();
            this.HNot = new System.Windows.Forms.Label();
            this.Ortalamaniz = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Hesapla = new System.Windows.Forms.Button();
            this.FinalT = new System.Windows.Forms.TextBox();
            this.FinalNotu = new System.Windows.Forms.Label();
            this.VizeT = new System.Windows.Forms.TextBox();
            this.VizeNotu = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(-1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 428);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.HOrt);
            this.panel2.Controls.Add(this.Ortalama);
            this.panel2.Controls.Add(this.HNot);
            this.panel2.Controls.Add(this.Ortalamaniz);
            this.panel2.Location = new System.Drawing.Point(17, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 73);
            this.panel2.TabIndex = 1;
            // 
            // HOrt
            // 
            this.HOrt.AutoSize = true;
            this.HOrt.Location = new System.Drawing.Point(135, 54);
            this.HOrt.Name = "HOrt";
            this.HOrt.Size = new System.Drawing.Size(0, 16);
            this.HOrt.TabIndex = 3;
            // 
            // Ortalama
            // 
            this.Ortalama.AutoSize = true;
            this.Ortalama.Location = new System.Drawing.Point(135, 13);
            this.Ortalama.Name = "Ortalama";
            this.Ortalama.Size = new System.Drawing.Size(0, 16);
            this.Ortalama.TabIndex = 2;
            // 
            // HNot
            // 
            this.HNot.AutoSize = true;
            this.HNot.Location = new System.Drawing.Point(26, 54);
            this.HNot.Name = "HNot";
            this.HNot.Size = new System.Drawing.Size(60, 16);
            this.HNot.TabIndex = 1;
            this.HNot.Text = "Harf notu";
            // 
            // Ortalamaniz
            // 
            this.Ortalamaniz.AutoSize = true;
            this.Ortalamaniz.Location = new System.Drawing.Point(25, 13);
            this.Ortalamaniz.Name = "Ortalamaniz";
            this.Ortalamaniz.Size = new System.Drawing.Size(78, 16);
            this.Ortalamaniz.TabIndex = 0;
            this.Ortalamaniz.Text = "Ortalamaniz";
            this.Ortalamaniz.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Hesapla);
            this.panel1.Controls.Add(this.FinalT);
            this.panel1.Controls.Add(this.FinalNotu);
            this.panel1.Controls.Add(this.VizeT);
            this.panel1.Controls.Add(this.VizeNotu);
            this.panel1.Location = new System.Drawing.Point(17, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 87);
            this.panel1.TabIndex = 0;
            // 
            // Hesapla
            // 
            this.Hesapla.Location = new System.Drawing.Point(281, 26);
            this.Hesapla.Name = "Hesapla";
            this.Hesapla.Size = new System.Drawing.Size(84, 28);
            this.Hesapla.TabIndex = 0;
            this.Hesapla.Text = "Hesapla";
            this.Hesapla.UseVisualStyleBackColor = true;
            this.Hesapla.Click += new System.EventHandler(this.Hesapla_Click);
            // 
            // FinalT
            // 
            this.FinalT.Location = new System.Drawing.Point(150, 47);
            this.FinalT.Name = "FinalT";
            this.FinalT.Size = new System.Drawing.Size(100, 22);
            this.FinalT.TabIndex = 3;
            // 
            // FinalNotu
            // 
            this.FinalNotu.AutoSize = true;
            this.FinalNotu.Location = new System.Drawing.Point(22, 53);
            this.FinalNotu.Name = "FinalNotu";
            this.FinalNotu.Size = new System.Drawing.Size(67, 16);
            this.FinalNotu.TabIndex = 2;
            this.FinalNotu.Text = "Final Notu";
            // 
            // VizeT
            // 
            this.VizeT.Location = new System.Drawing.Point(150, 11);
            this.VizeT.Name = "VizeT";
            this.VizeT.Size = new System.Drawing.Size(100, 22);
            this.VizeT.TabIndex = 1;
            // 
            // VizeNotu
            // 
            this.VizeNotu.AutoSize = true;
            this.VizeNotu.Location = new System.Drawing.Point(22, 17);
            this.VizeNotu.Name = "VizeNotu";
            this.VizeNotu.Size = new System.Drawing.Size(64, 16);
            this.VizeNotu.TabIndex = 0;
            this.VizeNotu.Text = "Vize Notu";
            this.VizeNotu.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 420);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Uni Not Hesaplama";
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label HOrt;
        private System.Windows.Forms.Label Ortalama;
        private System.Windows.Forms.Label HNot;
        private System.Windows.Forms.Label Ortalamaniz;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Hesapla;
        private System.Windows.Forms.TextBox FinalT;
        private System.Windows.Forms.Label FinalNotu;
        private System.Windows.Forms.TextBox VizeT;
        private System.Windows.Forms.Label VizeNotu;
    }
}

