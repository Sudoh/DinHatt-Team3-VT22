﻿namespace DinHatt_CodeFirst
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
            this.tabAllaArtiklar = new System.Windows.Forms.TabPage();
            this.btnVisaArtiklar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colArtikelNamn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colArtikelID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBeskrivning = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStorlek = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPris = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabNyArtikel = new System.Windows.Forms.TabPage();
            this.tabArtikel.SuspendLayout();
            this.tabAllaArtiklar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabArtikel
            // 
            this.tabArtikel.Controls.Add(this.tabAllaArtiklar);
            this.tabArtikel.Controls.Add(this.tabNyArtikel);
            this.tabArtikel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabArtikel.Location = new System.Drawing.Point(0, 0);
            this.tabArtikel.Name = "tabArtikel";
            this.tabArtikel.SelectedIndex = 0;
            this.tabArtikel.Size = new System.Drawing.Size(764, 361);
            this.tabArtikel.TabIndex = 0;
            this.tabArtikel.SelectedIndexChanged += new System.EventHandler(this.tabArtikel_SelectedIndexChanged);
            // 
            // tabAllaArtiklar
            // 
            this.tabAllaArtiklar.Controls.Add(this.btnVisaArtiklar);
            this.tabAllaArtiklar.Controls.Add(this.listView1);
            this.tabAllaArtiklar.Location = new System.Drawing.Point(4, 22);
            this.tabAllaArtiklar.Name = "tabAllaArtiklar";
            this.tabAllaArtiklar.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabAllaArtiklar.Size = new System.Drawing.Size(756, 335);
            this.tabAllaArtiklar.TabIndex = 0;
            this.tabAllaArtiklar.Text = "Alla Artiklar";
            this.tabAllaArtiklar.UseVisualStyleBackColor = true;
            this.tabAllaArtiklar.Click += new System.EventHandler(this.tabNyArtikel_Click);
            // 
            // btnVisaArtiklar
            // 
            this.btnVisaArtiklar.Location = new System.Drawing.Point(649, 40);
            this.btnVisaArtiklar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVisaArtiklar.Name = "btnVisaArtiklar";
            this.btnVisaArtiklar.Size = new System.Drawing.Size(97, 25);
            this.btnVisaArtiklar.TabIndex = 1;
            this.btnVisaArtiklar.Text = "Visa Artiklar";
            this.btnVisaArtiklar.UseVisualStyleBackColor = true;
            this.btnVisaArtiklar.Click += new System.EventHandler(this.btnVisaArtiklar_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colArtikelNamn,
            this.colArtikelID,
            this.colBeskrivning,
            this.colStorlek,
            this.colPris});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(750, 329);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colArtikelNamn
            // 
            this.colArtikelNamn.Text = "Artikelnamn";
            this.colArtikelNamn.Width = 100;
            // 
            // colArtikelID
            // 
            this.colArtikelID.Text = "ArtikelID";
            this.colArtikelID.Width = 91;
            // 
            // colBeskrivning
            // 
            this.colBeskrivning.Text = "Beskrivning";
            this.colBeskrivning.Width = 97;
            // 
            // colStorlek
            // 
            this.colStorlek.Text = "Storlek";
            this.colStorlek.Width = 72;
            // 
            // colPris
            // 
            this.colPris.Text = "Pris";
            this.colPris.Width = 67;
            // 
            // tabNyArtikel
            // 
            this.tabNyArtikel.Location = new System.Drawing.Point(4, 22);
            this.tabNyArtikel.Name = "tabNyArtikel";
            this.tabNyArtikel.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabNyArtikel.Size = new System.Drawing.Size(756, 335);
            this.tabNyArtikel.TabIndex = 1;
            this.tabNyArtikel.Text = "Ny Artikel";
            this.tabNyArtikel.UseVisualStyleBackColor = true;
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
            this.tabAllaArtiklar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabArtikel;
        private System.Windows.Forms.TabPage tabAllaArtiklar;
        private System.Windows.Forms.TabPage tabNyArtikel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnVisaArtiklar;
        private System.Windows.Forms.ColumnHeader colArtikelNamn;
        private System.Windows.Forms.ColumnHeader colArtikelID;
        private System.Windows.Forms.ColumnHeader colBeskrivning;
        private System.Windows.Forms.ColumnHeader colStorlek;
        private System.Windows.Forms.ColumnHeader colPris;
    }
}