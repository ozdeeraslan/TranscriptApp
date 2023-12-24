namespace TranskriptUygulamasi
{
    partial class DersEkrani
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
            label4 = new Label();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            lstDersler = new ListBox();
            txtDersKredisi = new TextBox();
            txtDersAdi = new TextBox();
            txtDersKodu = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(15, 22);
            label4.Name = "label4";
            label4.Size = new Size(771, 40);
            label4.TabIndex = 21;
            label4.Text = "DERS ISLEMLERI";
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.LightSkyBlue;
            btnGuncelle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuncelle.Location = new Point(15, 339);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(370, 89);
            btnGuncelle.TabIndex = 20;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.IndianRed;
            btnSil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.Location = new Point(203, 251);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(182, 59);
            btnSil.TabIndex = 19;
            btnSil.Text = "SIL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.PaleGreen;
            btnEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.Location = new Point(15, 251);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(182, 59);
            btnEkle.TabIndex = 18;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // lstDersler
            // 
            lstDersler.FormattingEnabled = true;
            lstDersler.ItemHeight = 20;
            lstDersler.Location = new Point(412, 64);
            lstDersler.Name = "lstDersler";
            lstDersler.Size = new Size(374, 364);
            lstDersler.TabIndex = 17;
            lstDersler.SelectedIndexChanged += lstDersler_SelectedIndexChanged;
            // 
            // txtDersKredisi
            // 
            txtDersKredisi.Location = new Point(121, 162);
            txtDersKredisi.Multiline = true;
            txtDersKredisi.Name = "txtDersKredisi";
            txtDersKredisi.Size = new Size(264, 34);
            txtDersKredisi.TabIndex = 16;
            // 
            // txtDersAdi
            // 
            txtDersAdi.Location = new Point(121, 110);
            txtDersAdi.Multiline = true;
            txtDersAdi.Name = "txtDersAdi";
            txtDersAdi.Size = new Size(264, 34);
            txtDersAdi.TabIndex = 15;
            // 
            // txtDersKodu
            // 
            txtDersKodu.Location = new Point(121, 65);
            txtDersKodu.Multiline = true;
            txtDersKodu.Name = "txtDersKodu";
            txtDersKodu.Size = new Size(264, 34);
            txtDersKodu.TabIndex = 14;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(15, 165);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 13;
            label3.Text = "KREDI:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(15, 119);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 12;
            label2.Text = "DERS ADI:";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 68);
            label1.Name = "label1";
            label1.Size = new Size(100, 34);
            label1.TabIndex = 11;
            label1.Text = "DERS KODU:";
            // 
            // DersEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(lstDersler);
            Controls.Add(txtDersKredisi);
            Controls.Add(txtDersAdi);
            Controls.Add(txtDersKodu);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DersEkrani";
            Text = "DersEkrani";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnEkle;
        private ListBox lstDersler;
        private TextBox txtDersKredisi;
        private TextBox txtDersAdi;
        private TextBox txtDersKodu;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}