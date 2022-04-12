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
            this.SuspendLayout();
            // 
            // txtArtikelNamn
            // 
            this.txtArtikelNamn.Location = new System.Drawing.Point(231, 133);
            this.txtArtikelNamn.Name = "txtArtikelNamn";
            this.txtArtikelNamn.Size = new System.Drawing.Size(100, 20);
            this.txtArtikelNamn.TabIndex = 0;
            // 
            // btnSparaNyArtikel
            // 
            this.btnSparaNyArtikel.Location = new System.Drawing.Point(180, 159);
            this.btnSparaNyArtikel.Name = "btnSparaNyArtikel";
            this.btnSparaNyArtikel.Size = new System.Drawing.Size(151, 23);
            this.btnSparaNyArtikel.TabIndex = 1;
            this.btnSparaNyArtikel.Text = "Skapa ny artikel";
            this.btnSparaNyArtikel.UseVisualStyleBackColor = true;
            // 
            // NyArtikelUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSparaNyArtikel);
            this.Controls.Add(this.txtArtikelNamn);
            this.Name = "NyArtikelUserControl";
            this.Size = new System.Drawing.Size(703, 489);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArtikelNamn;
        private System.Windows.Forms.Button btnSparaNyArtikel;
    }
}
