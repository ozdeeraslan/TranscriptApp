namespace TranskriptUygulamasi
{
    partial class DonemEkrani
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
            lstDonemler = new ListBox();
            txtDonemNo = new TextBox();
            txtDonemAd = new TextBox();
            label3 = new Label();
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
            label4.Text = "DÖNEM ISLEMLERI";
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.LightSkyBlue;
            btnGuncelle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuncelle.Location = new Point(15, 269);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(370, 99);
            btnGuncelle.TabIndex = 20;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.IndianRed;
            btnSil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.Location = new Point(203, 181);
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
            btnEkle.Location = new Point(15, 181);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(182, 59);
            btnEkle.TabIndex = 18;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // lstDonemler
            // 
            lstDonemler.FormattingEnabled = true;
            lstDonemler.ItemHeight = 20;
            lstDonemler.Location = new Point(412, 64);
            lstDonemler.Name = "lstDonemler";
            lstDonemler.Size = new Size(374, 304);
            lstDonemler.TabIndex = 17;
            lstDonemler.SelectedIndexChanged += lstDonemler_SelectedIndexChanged;
            // 
            // txtDonemNo
            // 
            txtDonemNo.Location = new Point(121, 65);
            txtDonemNo.Multiline = true;
            txtDonemNo.Name = "txtDonemNo";
            txtDonemNo.Size = new Size(264, 34);
            txtDonemNo.TabIndex = 16;
            // 
            // txtDonemAd
            // 
            txtDonemAd.Location = new Point(121, 120);
            txtDonemAd.Multiline = true;
            txtDonemAd.Name = "txtDonemAd";
            txtDonemAd.Size = new Size(264, 34);
            txtDonemAd.TabIndex = 14;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(15, 68);
            label3.Name = "label3";
            label3.Size = new Size(107, 31);
            label3.TabIndex = 13;
            label3.Text = "DÖNEM NO:";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 123);
            label1.Name = "label1";
            label1.Size = new Size(100, 34);
            label1.TabIndex = 11;
            label1.Text = "DÖNEM ADI:";
            // 
            // DonemEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 394);
            Controls.Add(label4);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(lstDonemler);
            Controls.Add(txtDonemNo);
            Controls.Add(txtDonemAd);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "DonemEkrani";
            Text = "DonemEkrani";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnEkle;
        private ListBox lstDonemler;
        private TextBox txtDonemNo;
        private TextBox txtDonemAd;
        private Label label3;
        private Label label1;
    }
}