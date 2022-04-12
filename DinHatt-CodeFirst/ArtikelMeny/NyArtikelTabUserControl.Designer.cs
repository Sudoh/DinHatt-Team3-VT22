namespace DinHatt_CodeFirst.ArtikelMeny
{
    partial class NyArtikelTabUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtArtikelNamn = new System.Windows.Forms.TextBox();
            this.btnSparaNyArtikel = new System.Windows.Forms.Button();
            this.artikelNamn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBeskrivning = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPris = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAntalILager = new System.Windows.Forms.TextBox();
            this.chkBegagnad = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLaddaInBild = new System.Windows.Forms.Button();
            this.txtBildNamn = new System.Windows.Forms.TextBox();
            this.picboxArtikel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxArtikel)).BeginInit();
            this.SuspendLayout();
            // 
            // txtArtikelNamn
            // 
            this.txtArtikelNamn.Location = new System.Drawing.Point(106, 23);
            this.txtArtikelNamn.Name = "txtArtikelNamn";
            this.txtArtikelNamn.Size = new System.Drawing.Size(241, 20);
            this.txtArtikelNamn.TabIndex = 0;
            // 
            // btnSparaNyArtikel
            // 
            this.btnSparaNyArtikel.Location = new System.Drawing.Point(196, 270);
            this.btnSparaNyArtikel.Name = "btnSparaNyArtikel";
            this.btnSparaNyArtikel.Size = new System.Drawing.Size(151, 23);
            this.btnSparaNyArtikel.TabIndex = 1;
            this.btnSparaNyArtikel.Text = "Spara ny artikel";
            this.btnSparaNyArtikel.UseVisualStyleBackColor = true;
            this.btnSparaNyArtikel.Click += new System.EventHandler(this.btnSparaNyArtikel_Click);
            // 
            // artikelNamn
            // 
            this.artikelNamn.AutoSize = true;
            this.artikelNamn.Location = new System.Drawing.Point(48, 30);
            this.artikelNamn.Name = "artikelNamn";
            this.artikelNamn.Size = new System.Drawing.Size(35, 13);
            this.artikelNamn.TabIndex = 2;
            this.artikelNamn.Text = "Namn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Beskrivning";
            // 
            // txtBeskrivning
            // 
            this.txtBeskrivning.Location = new System.Drawing.Point(106, 49);
            this.txtBeskrivning.Multiline = true;
            this.txtBeskrivning.Name = "txtBeskrivning";
            this.txtBeskrivning.Size = new System.Drawing.Size(241, 102);
            this.txtBeskrivning.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pris";
            // 
            // txtPris
            // 
            this.txtPris.Location = new System.Drawing.Point(106, 157);
            this.txtPris.Name = "txtPris";
            this.txtPris.Size = new System.Drawing.Size(241, 20);
            this.txtPris.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Antal i lager";
            // 
            // txtAntalILager
            // 
            this.txtAntalILager.Location = new System.Drawing.Point(106, 183);
            this.txtAntalILager.Name = "txtAntalILager";
            this.txtAntalILager.Size = new System.Drawing.Size(241, 20);
            this.txtAntalILager.TabIndex = 7;
            // 
            // chkBegagnad
            // 
            this.chkBegagnad.AutoSize = true;
            this.chkBegagnad.Location = new System.Drawing.Point(106, 209);
            this.chkBegagnad.Name = "chkBegagnad";
            this.chkBegagnad.Size = new System.Drawing.Size(37, 17);
            this.chkBegagnad.TabIndex = 9;
            this.chkBegagnad.Text = "Ja";
            this.chkBegagnad.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Begagnad";
            // 
            // btnLaddaInBild
            // 
            this.btnLaddaInBild.Location = new System.Drawing.Point(196, 241);
            this.btnLaddaInBild.Name = "btnLaddaInBild";
            this.btnLaddaInBild.Size = new System.Drawing.Size(151, 23);
            this.btnLaddaInBild.TabIndex = 11;
            this.btnLaddaInBild.Text = "Välj bild";
            this.btnLaddaInBild.UseVisualStyleBackColor = true;
            this.btnLaddaInBild.Click += new System.EventHandler(this.btnLaddaInBild_Click);
            // 
            // txtBildNamn
            // 
            this.txtBildNamn.Location = new System.Drawing.Point(97, 244);
            this.txtBildNamn.Name = "txtBildNamn";
            this.txtBildNamn.Size = new System.Drawing.Size(93, 20);
            this.txtBildNamn.TabIndex = 12;
            // 
            // picboxArtikel
            // 
            this.picboxArtikel.Location = new System.Drawing.Point(354, 23);
            this.picboxArtikel.Name = "picboxArtikel";
            this.picboxArtikel.Size = new System.Drawing.Size(206, 180);
            this.picboxArtikel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxArtikel.TabIndex = 13;
            this.picboxArtikel.TabStop = false;
            // 
            // NyArtikelTabUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picboxArtikel);
            this.Controls.Add(this.txtBildNamn);
            this.Controls.Add(this.btnLaddaInBild);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkBegagnad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAntalILager);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPris);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBeskrivning);
            this.Controls.Add(this.artikelNamn);
            this.Controls.Add(this.btnSparaNyArtikel);
            this.Controls.Add(this.txtArtikelNamn);
            this.Name = "NyArtikelTabUserControl";
            this.Size = new System.Drawing.Size(703, 489);
            ((System.ComponentModel.ISupportInitialize)(this.picboxArtikel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArtikelNamn;
        private System.Windows.Forms.Button btnSparaNyArtikel;
        private System.Windows.Forms.Label artikelNamn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBeskrivning;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPris;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAntalILager;
        private System.Windows.Forms.CheckBox chkBegagnad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLaddaInBild;
        private System.Windows.Forms.TextBox txtBildNamn;
        private System.Windows.Forms.PictureBox picboxArtikel;
    }
}
