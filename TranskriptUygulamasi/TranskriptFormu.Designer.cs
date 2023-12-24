namespace TranskriptUygulamasi
{
    partial class TranskriptFormu
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
            lblDonemAd = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblOgrenciAd = new Label();
            lblOgrenciSoyad = new Label();
            lblOgrenciNo = new Label();
            lblGenelOrtalama = new Label();
            label7 = new Label();
            dgvDersler = new DataGridView();
            lblDonemOrt = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDersler).BeginInit();
            SuspendLayout();
            // 
            // lblDonemAd
            // 
            lblDonemAd.BorderStyle = BorderStyle.Fixed3D;
            lblDonemAd.Location = new Point(40, 9);
            lblDonemAd.Margin = new Padding(4, 0, 4, 0);
            lblDonemAd.Name = "lblDonemAd";
            lblDonemAd.Size = new Size(656, 45);
            lblDonemAd.TabIndex = 0;
            lblDonemAd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(71, 64);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(41, 25);
            label3.TabIndex = 2;
            label3.Text = "Ad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(44, 103);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 3;
            label4.Text = "Soyad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(25, 134);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(85, 25);
            label5.TabIndex = 4;
            label5.Text = "Numara:";
            // 
            // lblOgrenciAd
            // 
            lblOgrenciAd.BorderStyle = BorderStyle.Fixed3D;
            lblOgrenciAd.Location = new Point(122, 66);
            lblOgrenciAd.Margin = new Padding(4, 0, 4, 0);
            lblOgrenciAd.Name = "lblOgrenciAd";
            lblOgrenciAd.Size = new Size(574, 31);
            lblOgrenciAd.TabIndex = 5;
            // 
            // lblOgrenciSoyad
            // 
            lblOgrenciSoyad.BorderStyle = BorderStyle.Fixed3D;
            lblOgrenciSoyad.Location = new Point(122, 97);
            lblOgrenciSoyad.Margin = new Padding(4, 0, 4, 0);
            lblOgrenciSoyad.Name = "lblOgrenciSoyad";
            lblOgrenciSoyad.Size = new Size(574, 31);
            lblOgrenciSoyad.TabIndex = 6;
            // 
            // lblOgrenciNo
            // 
            lblOgrenciNo.BorderStyle = BorderStyle.Fixed3D;
            lblOgrenciNo.Location = new Point(122, 128);
            lblOgrenciNo.Margin = new Padding(4, 0, 4, 0);
            lblOgrenciNo.Name = "lblOgrenciNo";
            lblOgrenciNo.Size = new Size(574, 31);
            lblOgrenciNo.TabIndex = 7;
            // 
            // lblGenelOrtalama
            // 
            lblGenelOrtalama.BorderStyle = BorderStyle.Fixed3D;
            lblGenelOrtalama.Location = new Point(181, 784);
            lblGenelOrtalama.Margin = new Padding(4, 0, 4, 0);
            lblGenelOrtalama.Name = "lblGenelOrtalama";
            lblGenelOrtalama.Size = new Size(154, 31);
            lblGenelOrtalama.TabIndex = 46;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 785);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(138, 25);
            label7.TabIndex = 45;
            label7.Text = "Genel Ortalama:";
            // 
            // dgvDersler
            // 
            dgvDersler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDersler.Location = new Point(25, 199);
            dgvDersler.Name = "dgvDersler";
            dgvDersler.RowHeadersWidth = 62;
            dgvDersler.RowTemplate.Height = 33;
            dgvDersler.Size = new Size(671, 552);
            dgvDersler.TabIndex = 47;
            // 
            // lblDonemOrt
            // 
            lblDonemOrt.BorderStyle = BorderStyle.Fixed3D;
            lblDonemOrt.Location = new Point(533, 783);
            lblDonemOrt.Margin = new Padding(4, 0, 4, 0);
            lblDonemOrt.Name = "lblDonemOrt";
            lblDonemOrt.Size = new Size(154, 31);
            lblDonemOrt.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(381, 784);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(153, 25);
            label2.TabIndex = 48;
            label2.Text = "Dönem Ortalama:";
            // 
            // TranskriptFormu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 975);
            Controls.Add(lblDonemOrt);
            Controls.Add(label2);
            Controls.Add(dgvDersler);
            Controls.Add(lblGenelOrtalama);
            Controls.Add(label7);
            Controls.Add(lblOgrenciNo);
            Controls.Add(lblOgrenciSoyad);
            Controls.Add(lblOgrenciAd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblDonemAd);
            Margin = new Padding(4);
            Name = "TranskriptFormu";
            Text = "Transkript";
            ((System.ComponentModel.ISupportInitialize)dgvDersler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDonemAd;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblOgrenciAd;
        private Label lblOgrenciSoyad;
        private Label lblOgrenciNo;
        private Label lblGenelOrtalama;
        private Label label10;
        private Label lblGenelOrtalama2;
        private Label label7;
        private DataGridView dataGridView1;
        private DataGridView dgvDersler;
        private Label lblDonemOrt;
        private Label label2;
    }
}