namespace TranskriptUygulamasi
{
    partial class AnaForm
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
            menuStrip1 = new MenuStrip();
            ögrenciEkraniToolStripMenuItem = new ToolStripMenuItem();
            dönemEkraniToolStripMenuItem = new ToolStripMenuItem();
            dersEkraniToolStripMenuItem = new ToolStripMenuItem();
            dersEklemeEkraniToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ögrenciEkraniToolStripMenuItem, dönemEkraniToolStripMenuItem, dersEkraniToolStripMenuItem, dersEklemeEkraniToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // ögrenciEkraniToolStripMenuItem
            // 
            ögrenciEkraniToolStripMenuItem.Name = "ögrenciEkraniToolStripMenuItem";
            ögrenciEkraniToolStripMenuItem.Size = new Size(119, 24);
            ögrenciEkraniToolStripMenuItem.Text = "Ögrenci Ekrani";
            ögrenciEkraniToolStripMenuItem.Click += ögrenciEkraniToolStripMenuItem_Click;
            // 
            // dönemEkraniToolStripMenuItem
            // 
            dönemEkraniToolStripMenuItem.Name = "dönemEkraniToolStripMenuItem";
            dönemEkraniToolStripMenuItem.Size = new Size(116, 24);
            dönemEkraniToolStripMenuItem.Text = "Dönem Ekrani";
            dönemEkraniToolStripMenuItem.Click += dönemEkraniToolStripMenuItem_Click;
            // 
            // dersEkraniToolStripMenuItem
            // 
            dersEkraniToolStripMenuItem.Name = "dersEkraniToolStripMenuItem";
            dersEkraniToolStripMenuItem.Size = new Size(97, 24);
            dersEkraniToolStripMenuItem.Text = "Ders Ekrani";
            dersEkraniToolStripMenuItem.Click += dersEkraniToolStripMenuItem_Click;
            // 
            // dersEklemeEkraniToolStripMenuItem
            // 
            dersEklemeEkraniToolStripMenuItem.Name = "dersEklemeEkraniToolStripMenuItem";
            dersEklemeEkraniToolStripMenuItem.Size = new Size(149, 24);
            dersEklemeEkraniToolStripMenuItem.Text = "Ders Ekleme Ekrani";
            dersEklemeEkraniToolStripMenuItem.Click += dersEklemeEkraniToolStripMenuItem_Click;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Name = "AnaForm";
            Text = "AnaForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ögrenciEkraniToolStripMenuItem;
        private ToolStripMenuItem dönemEkraniToolStripMenuItem;
        private ToolStripMenuItem dersEkraniToolStripMenuItem;
        private ToolStripMenuItem dersEklemeEkraniToolStripMenuItem;
    }
}