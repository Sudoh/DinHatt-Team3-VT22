namespace DinHatt_CodeFirst
{
    partial class Artikelform
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
            this.tabArtikel = new System.Windows.Forms.TabControl();
            this.tabNyArtikel = new System.Windows.Forms.TabPage();
            this.tabAllaArtiklar = new System.Windows.Forms.TabPage();
            this.tabArtikel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabArtikel
            // 
            this.tabArtikel.Controls.Add(this.tabNyArtikel);
            this.tabArtikel.Controls.Add(this.tabAllaArtiklar);
            this.tabArtikel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabArtikel.Location = new System.Drawing.Point(0, 0);
            this.tabArtikel.Name = "tabArtikel";
            this.tabArtikel.SelectedIndex = 0;
            this.tabArtikel.Size = new System.Drawing.Size(764, 361);
            this.tabArtikel.TabIndex = 0;
            // 
            // tabNyArtikel
            // 
            this.tabNyArtikel.Location = new System.Drawing.Point(4, 22);
            this.tabNyArtikel.Name = "tabNyArtikel";
            this.tabNyArtikel.Padding = new System.Windows.Forms.Padding(3);
            this.tabNyArtikel.Size = new System.Drawing.Size(756, 335);
            this.tabNyArtikel.TabIndex = 0;
            this.tabNyArtikel.Text = "Ny Artikel";
            this.tabNyArtikel.UseVisualStyleBackColor = true;
            this.tabNyArtikel.Click += new System.EventHandler(this.tabNyArtikel_Click);
            // 
            // tabAllaArtiklar
            // 
            this.tabAllaArtiklar.Location = new System.Drawing.Point(4, 22);
            this.tabAllaArtiklar.Name = "tabAllaArtiklar";
            this.tabAllaArtiklar.Padding = new System.Windows.Forms.Padding(3);
            this.tabAllaArtiklar.Size = new System.Drawing.Size(792, 424);
            this.tabAllaArtiklar.TabIndex = 1;
            this.tabAllaArtiklar.Text = "Alla Artiklar";
            this.tabAllaArtiklar.UseVisualStyleBackColor = true;
            // 
            // Artikelform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(764, 361);
            this.Controls.Add(this.tabArtikel);
            this.Name = "Artikelform";
            this.ShowIcon = false;
            this.Text = "Artiklar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Artikelform_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Artikelform_FormClosed);
            this.Load += new System.EventHandler(this.Artikelform_Load);
            this.tabArtikel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabArtikel;
        private System.Windows.Forms.TabPage tabNyArtikel;
        private System.Windows.Forms.TabPage tabAllaArtiklar;
    }
}