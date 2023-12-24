namespace TranskriptUygulamasi
{
    partial class OgrenciEkrani
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
            label2 = new Label();
            label3 = new Label();
            txtOgrenciAd = new TextBox();
            txtOgrenciSoyad = new TextBox();
            txtNumara = new TextBox();
            lstOgrenciler = new ListBox();
            btnEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 52);
            label1.Name = "label1";
            label1.Size = new Size(62, 34);
            label1.TabIndex = 0;
            label1.Text = "AD:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 106);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 1;
            label2.Text = "SOYAD:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(17, 152);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 2;
            label3.Text = "NUMARA:";
            // 
            // txtOgrenciAd
            // 
            txtOgrenciAd.Location = new Point(123, 52);
            txtOgrenciAd.Multiline = true;
            txtOgrenciAd.Name = "txtOgrenciAd";
            txtOgrenciAd.Size = new Size(264, 34);
            txtOgrenciAd.TabIndex = 3;
            // 
            // txtOgrenciSoyad
            // 
            txtOgrenciSoyad.Location = new Point(123, 97);
            txtOgrenciSoyad.Multiline = true;
            txtOgrenciSoyad.Name = "txtOgrenciSoyad";
            txtOgrenciSoyad.Size = new Size(264, 34);
            txtOgrenciSoyad.TabIndex = 4;
            // 
            // txtNumara
            // 
            txtNumara.Location = new Point(123, 149);
            txtNumara.Multiline = true;
            txtNumara.Name = "txtNumara";
            txtNumara.Size = new Size(264, 34);
            txtNumara.TabIndex = 5;
            // 
            // lstOgrenciler
            // 
            lstOgrenciler.FormattingEnabled = true;
            lstOgrenciler.ItemHeight = 20;
            lstOgrenciler.Location = new Point(414, 51);
            lstOgrenciler.Name = "lstOgrenciler";
            lstOgrenciler.Size = new Size(374, 324);
            lstOgrenciler.TabIndex = 6;
            lstOgrenciler.SelectedIndexChanged += lstOgrenciler_SelectedIndexChanged;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.PaleGreen;
            btnEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.Location = new Point(17, 207);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(182, 59);
            btnEkle.TabIndex = 7;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.IndianRed;
            btnSil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.Location = new Point(205, 207);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(182, 59);
            btnSil.TabIndex = 8;
            btnSil.Text = "SIL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.LightSkyBlue;
            btnGuncelle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuncelle.Location = new Point(17, 290);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(370, 55);
            btnGuncelle.TabIndex = 9;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(17, 9);
            label4.Name = "label4";
            label4.Size = new Size(771, 40);
            label4.TabIndex = 10;
            label4.Text = "ÖGRENCI ISLEMLERI";
            // 
            // OgrenciEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 400);
            Controls.Add(label4);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(lstOgrenciler);
            Controls.Add(txtNumara);
            Controls.Add(txtOgrenciSoyad);
            Controls.Add(txtOgrenciAd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OgrenciEkrani";
            Text = "OgrenciEkrani";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtOgrenciAd;
        private TextBox txtOgrenciSoyad;
        private TextBox txtNumara;
        private ListBox lstOgrenciler;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
        private Label label4;
    }
}