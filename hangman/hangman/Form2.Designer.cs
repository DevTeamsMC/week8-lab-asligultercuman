namespace hangman
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            buttonEndGame = new Button();
            label3 = new Label();
            labelLength = new Label();
            label4 = new Label();
            input = new TextBox();
            lblSoru = new Label();
            label7 = new Label();
            buttonTahmin = new Button();
            labelWrong = new Label();
            groupBox1 = new GroupBox();
            labelTimer = new Label();
            groupBox2 = new GroupBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label5 = new Label();
            lblBilgiler = new Label();
            buttonIpucu = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.man_01;
            pictureBox1.Location = new Point(13, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(308, 282);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 267);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 1;
            label1.Text = "Puan:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 267);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // buttonEndGame
            // 
            buttonEndGame.Location = new Point(269, 296);
            buttonEndGame.Name = "buttonEndGame";
            buttonEndGame.Size = new Size(94, 29);
            buttonEndGame.TabIndex = 3;
            buttonEndGame.Text = "End Game";
            buttonEndGame.UseVisualStyleBackColor = true;
            buttonEndGame.Click += buttonEndGame_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 52);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 4;
            label3.Text = "label3";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelLength
            // 
            labelLength.AutoSize = true;
            labelLength.Location = new Point(155, 198);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(54, 21);
            labelLength.TabIndex = 5;
            labelLength.Text = "length";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 198);
            label4.Name = "label4";
            label4.Size = new Size(135, 21);
            label4.TabIndex = 6;
            label4.Text = "Kelimenin Boyutu:";
            // 
            // input
            // 
            input.Location = new Point(17, 296);
            input.Name = "input";
            input.Size = new Size(125, 29);
            input.TabIndex = 7;
            // 
            // lblSoru
            // 
            lblSoru.AutoSize = true;
            lblSoru.Location = new Point(71, 156);
            lblSoru.Name = "lblSoru";
            lblSoru.Size = new Size(52, 21);
            lblSoru.TabIndex = 9;
            lblSoru.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 156);
            label7.Name = "label7";
            label7.Size = new Size(46, 21);
            label7.TabIndex = 10;
            label7.Text = "Soru:";
            // 
            // buttonTahmin
            // 
            buttonTahmin.Location = new Point(160, 296);
            buttonTahmin.Name = "buttonTahmin";
            buttonTahmin.Size = new Size(94, 29);
            buttonTahmin.TabIndex = 11;
            buttonTahmin.Text = "Tahmin Et";
            buttonTahmin.UseVisualStyleBackColor = true;
            buttonTahmin.Click += button1_Click;
            // 
            // labelWrong
            // 
            labelWrong.AutoSize = true;
            labelWrong.Location = new Point(17, 177);
            labelWrong.Name = "labelWrong";
            labelWrong.Size = new Size(121, 21);
            labelWrong.TabIndex = 12;
            labelWrong.Text = "Yanlış tahminler";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelTimer);
            groupBox1.Controls.Add(buttonIpucu);
            groupBox1.Controls.Add(input);
            groupBox1.Controls.Add(labelWrong);
            groupBox1.Controls.Add(buttonTahmin);
            groupBox1.Controls.Add(lblSoru);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(buttonEndGame);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(labelLength);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(21, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(375, 341);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // labelTimer
            // 
            labelTimer.AutoSize = true;
            labelTimer.Location = new Point(237, 25);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(81, 21);
            labelTimer.TabIndex = 14;
            labelTimer.Text = "kalan süre";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Location = new Point(416, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(327, 341);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(52, 21);
            label5.TabIndex = 15;
            label5.Text = "label5";
            // 
            // lblBilgiler
            // 
            lblBilgiler.AutoSize = true;
            lblBilgiler.Location = new Point(21, 382);
            lblBilgiler.Name = "lblBilgiler";
            lblBilgiler.Size = new Size(87, 21);
            lblBilgiler.TabIndex = 16;
            lblBilgiler.Text = "bilgi ekranı";
            // 
            // buttonIpucu
            // 
            buttonIpucu.Location = new Point(17, 85);
            buttonIpucu.Name = "buttonIpucu";
            buttonIpucu.Size = new Size(94, 29);
            buttonIpucu.TabIndex = 13;
            buttonIpucu.Text = "İpucu Al";
            buttonIpucu.UseVisualStyleBackColor = true;
            buttonIpucu.Click += buttonIpucu_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 424);
            Controls.Add(lblBilgiler);
            Controls.Add(label5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button buttonEndGame;
        private Label label3;
        private Label labelLength;
        private Label label4;
        private TextBox input;
        private Label lblSoru;
        private Label label7;
        private Button buttonTahmin;
        private Label labelWrong;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private System.Windows.Forms.Timer timer1;
        private Label labelTimer;
        private Label label5;
        private Label lblBilgiler;
        private Button buttonIpucu;
    }
}