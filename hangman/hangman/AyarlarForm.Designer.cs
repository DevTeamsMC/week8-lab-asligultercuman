namespace hangman
{
    partial class AyarlarForm
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
            label1 = new Label();
            txtSure = new TextBox();
            cmbZorluk = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            cmbGorsel = new ComboBox();
            btnAyarKaydet = new Button();
            cmbSoruTuru = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(50, 52);
            label1.Name = "label1";
            label1.Size = new Size(45, 21);
            label1.TabIndex = 0;
            label1.Text = "Süre:";
            // 
            // txtSure
            // 
            txtSure.Location = new Point(150, 52);
            txtSure.Name = "txtSure";
            txtSure.Size = new Size(125, 29);
            txtSure.TabIndex = 1;
            // 
            // cmbZorluk
            // 
            cmbZorluk.FormattingEnabled = true;
            cmbZorluk.Items.AddRange(new object[] { "Kolay", "Orta", "Zor" });
            cmbZorluk.Location = new Point(150, 116);
            cmbZorluk.Name = "cmbZorluk";
            cmbZorluk.Size = new Size(125, 29);
            cmbZorluk.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(50, 119);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 3;
            label2.Text = "Zorluk:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(50, 236);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 4;
            label3.Text = "Görsel Türü:";
            // 
            // cmbGorsel
            // 
            cmbGorsel.FormattingEnabled = true;
            cmbGorsel.Items.AddRange(new object[] { "Adam", "Çiçek ", "Balon Patlat" });
            cmbGorsel.Location = new Point(150, 233);
            cmbGorsel.Name = "cmbGorsel";
            cmbGorsel.Size = new Size(125, 29);
            cmbGorsel.TabIndex = 5;
            // 
            // btnAyarKaydet
            // 
            btnAyarKaydet.Location = new Point(50, 332);
            btnAyarKaydet.Name = "btnAyarKaydet";
            btnAyarKaydet.Size = new Size(225, 29);
            btnAyarKaydet.TabIndex = 6;
            btnAyarKaydet.Text = "Kaydet";
            btnAyarKaydet.UseVisualStyleBackColor = true;
            btnAyarKaydet.Click += btnAyarKaydet_Click;
            // 
            // cmbSoruTuru
            // 
            cmbSoruTuru.FormattingEnabled = true;
            cmbSoruTuru.Items.AddRange(new object[] { "Tarih", "Matematik", "Coğrafya" });
            cmbSoruTuru.Location = new Point(150, 176);
            cmbSoruTuru.Name = "cmbSoruTuru";
            cmbSoruTuru.Size = new Size(125, 29);
            cmbSoruTuru.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(50, 179);
            label4.Name = "label4";
            label4.Size = new Size(71, 21);
            label4.TabIndex = 7;
            label4.Text = "Kategori:";
            // 
            // AyarlarForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(330, 408);
            Controls.Add(cmbSoruTuru);
            Controls.Add(label4);
            Controls.Add(btnAyarKaydet);
            Controls.Add(cmbGorsel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbZorluk);
            Controls.Add(txtSure);
            Controls.Add(label1);
            Name = "AyarlarForm";
            Text = "AyarlarForm";
            Load += AyarlarForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSure;
        private ComboBox cmbZorluk;
        private Label label2;
        private Label label3;
        private ComboBox cmbGorsel;
        private Button btnAyarKaydet;
        private ComboBox cmbSoruTuru;
        private Label label4;
    }
}