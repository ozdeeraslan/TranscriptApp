namespace TranskriptUygulamasi
{
    partial class DersEklemeEkrani
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
            cmbOgrenci = new ComboBox();
            cmbDers = new ComboBox();
            label2 = new Label();
            cmbDonem = new ComboBox();
            label3 = new Label();
            cmbHarfNotu = new ComboBox();
            label4 = new Label();
            btnTranskriptGoster = new Button();
            btnEkle = new Button();
            lblTranskriptBilgileri = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(19, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(605, 39);
            label1.TabIndex = 0;
            label1.Text = "ÖGRENCI SECINIZ:";
            // 
            // cmbOgrenci
            // 
            cmbOgrenci.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOgrenci.FormattingEnabled = true;
            cmbOgrenci.Location = new Point(15, 65);
            cmbOgrenci.Margin = new Padding(4, 4, 4, 4);
            cmbOgrenci.Name = "cmbOgrenci";
            cmbOgrenci.Size = new Size(604, 33);
            cmbOgrenci.TabIndex = 1;
            // 
            // cmbDers
            // 
            cmbDers.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDers.FormattingEnabled = true;
            cmbDers.Location = new Point(19, 274);
            cmbDers.Margin = new Padding(4, 4, 4, 4);
            cmbDers.Name = "cmbDers";
            cmbDers.Size = new Size(600, 33);
            cmbDers.TabIndex = 3;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(15, 124);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(605, 39);
            label2.TabIndex = 2;
            label2.Text = "DÖNEM SECINIZ:";
            // 
            // cmbDonem
            // 
            cmbDonem.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDonem.FormattingEnabled = true;
            cmbDonem.Location = new Point(15, 166);
            cmbDonem.Margin = new Padding(4, 4, 4, 4);
            cmbDonem.Name = "cmbDonem";
            cmbDonem.Size = new Size(604, 33);
            cmbDonem.TabIndex = 5;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(15, 230);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(605, 40);
            label3.TabIndex = 4;
            label3.Text = "DERS SECINIZ:";
            // 
            // cmbHarfNotu
            // 
            cmbHarfNotu.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHarfNotu.FormattingEnabled = true;
            cmbHarfNotu.Location = new Point(15, 379);
            cmbHarfNotu.Margin = new Padding(4, 4, 4, 4);
            cmbHarfNotu.Name = "cmbHarfNotu";
            cmbHarfNotu.Size = new Size(604, 33);
            cmbHarfNotu.TabIndex = 7;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(15, 336);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(605, 39);
            label4.TabIndex = 6;
            label4.Text = "HARF NOTU SECINIZ:";
            // 
            // btnTranskriptGoster
            // 
            btnTranskriptGoster.BackColor = Color.DarkGray;
            btnTranskriptGoster.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTranskriptGoster.Location = new Point(636, 280);
            btnTranskriptGoster.Margin = new Padding(4, 4, 4, 4);
            btnTranskriptGoster.Name = "btnTranskriptGoster";
            btnTranskriptGoster.Size = new Size(389, 136);
            btnTranskriptGoster.TabIndex = 21;
            btnTranskriptGoster.Text = "TRANSKRIPT GÖSTER";
            btnTranskriptGoster.UseVisualStyleBackColor = false;
            btnTranskriptGoster.Click += btnTranskriptGoster_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.PaleGreen;
            btnEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.Location = new Point(644, 65);
            btnEkle.Margin = new Padding(4, 4, 4, 4);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(389, 136);
            btnEkle.TabIndex = 20;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // lblTranskriptBilgileri
            // 
            lblTranskriptBilgileri.BorderStyle = BorderStyle.Fixed3D;
            lblTranskriptBilgileri.ForeColor = Color.DarkRed;
            lblTranskriptBilgileri.Location = new Point(19, 510);
            lblTranskriptBilgileri.Margin = new Padding(4, 0, 4, 0);
            lblTranskriptBilgileri.Name = "lblTranskriptBilgileri";
            lblTranskriptBilgileri.Size = new Size(1006, 405);
            lblTranskriptBilgileri.TabIndex = 23;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Brown;
            label5.Location = new Point(19, 454);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(605, 39);
            label5.TabIndex = 24;
            label5.Text = "SECTIGINIZ ÖGRENCIYE AIT BILGILER";
            // 
            // DersEklemeEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 939);
            Controls.Add(label5);
            Controls.Add(lblTranskriptBilgileri);
            Controls.Add(btnTranskriptGoster);
            Controls.Add(btnEkle);
            Controls.Add(cmbHarfNotu);
            Controls.Add(label4);
            Controls.Add(cmbDonem);
            Controls.Add(label3);
            Controls.Add(cmbDers);
            Controls.Add(label2);
            Controls.Add(cmbOgrenci);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "DersEklemeEkrani";
            Text = "DersEklemeEkrani";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ComboBox cmbOgrenci;
        private ComboBox cmbDers;
        private Label label2;
        private ComboBox cmbDonem;
        private Label label3;
        private ComboBox cmbHarfNotu;
        private Label label4;
        private Button btnTranskriptGoster;
        private Button btnEkle;
        private Label lblTranskriptBilgileri;
        private Label label5;
    }
}