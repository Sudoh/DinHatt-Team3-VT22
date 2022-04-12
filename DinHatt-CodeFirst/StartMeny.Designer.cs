namespace DinHatt_CodeFirst
{
    partial class StartMenyForm
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
            this.pnlSystemKnappar = new System.Windows.Forms.Panel();
            this.pnlExtraFunktioner = new System.Windows.Forms.Panel();
            this.btnStatistikMeny = new System.Windows.Forms.Button();
            this.btnExportMeny = new System.Windows.Forms.Button();
            this.btnArtikelMeny = new System.Windows.Forms.Button();
            this.btnNyKundMeny = new System.Windows.Forms.Button();
            this.btnNyOrderMeny = new System.Windows.Forms.Button();
            this.pnlStart = new System.Windows.Forms.Panel();
            this.pnlSystemKnappar.SuspendLayout();
            this.pnlExtraFunktioner.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSystemKnappar
            // 
            this.pnlSystemKnappar.Controls.Add(this.pnlExtraFunktioner);
            this.pnlSystemKnappar.Controls.Add(this.btnArtikelMeny);
            this.pnlSystemKnappar.Controls.Add(this.btnNyKundMeny);
            this.pnlSystemKnappar.Controls.Add(this.btnNyOrderMeny);
            this.pnlSystemKnappar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSystemKnappar.Location = new System.Drawing.Point(0, 0);
            this.pnlSystemKnappar.Name = "pnlSystemKnappar";
            this.pnlSystemKnappar.Size = new System.Drawing.Size(784, 81);
            this.pnlSystemKnappar.TabIndex = 0;
            // 
            // pnlExtraFunktioner
            // 
            this.pnlExtraFunktioner.Controls.Add(this.btnStatistikMeny);
            this.pnlExtraFunktioner.Controls.Add(this.btnExportMeny);
            this.pnlExtraFunktioner.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlExtraFunktioner.Location = new System.Drawing.Point(618, 0);
            this.pnlExtraFunktioner.Name = "pnlExtraFunktioner";
            this.pnlExtraFunktioner.Size = new System.Drawing.Size(166, 81);
            this.pnlExtraFunktioner.TabIndex = 1;
            // 
            // btnStatistikMeny
            // 
            this.btnStatistikMeny.Location = new System.Drawing.Point(3, 13);
            this.btnStatistikMeny.Name = "btnStatistikMeny";
            this.btnStatistikMeny.Size = new System.Drawing.Size(75, 59);
            this.btnStatistikMeny.TabIndex = 4;
            this.btnStatistikMeny.Text = "Statistik";
            this.btnStatistikMeny.UseVisualStyleBackColor = true;
            this.btnStatistikMeny.Click += new System.EventHandler(this.btnStatistikMeny_Click);
            // 
            // btnExportMeny
            // 
            this.btnExportMeny.Enabled = false;
            this.btnExportMeny.Location = new System.Drawing.Point(84, 13);
            this.btnExportMeny.Name = "btnExportMeny";
            this.btnExportMeny.Size = new System.Drawing.Size(75, 59);
            this.btnExportMeny.TabIndex = 3;
            this.btnExportMeny.Text = "Export";
            this.btnExportMeny.UseVisualStyleBackColor = true;
            // 
            // btnArtikelMeny
            // 
            this.btnArtikelMeny.Location = new System.Drawing.Point(173, 13);
            this.btnArtikelMeny.Name = "btnArtikelMeny";
            this.btnArtikelMeny.Size = new System.Drawing.Size(75, 59);
            this.btnArtikelMeny.TabIndex = 2;
            this.btnArtikelMeny.Text = "Artiklar";
            this.btnArtikelMeny.UseVisualStyleBackColor = true;
            this.btnArtikelMeny.Click += new System.EventHandler(this.btnArtikelMeny_Click);
            // 
            // btnNyKundMeny
            // 
            this.btnNyKundMeny.Location = new System.Drawing.Point(94, 13);
            this.btnNyKundMeny.Name = "btnNyKundMeny";
            this.btnNyKundMeny.Size = new System.Drawing.Size(73, 59);
            this.btnNyKundMeny.TabIndex = 1;
            this.btnNyKundMeny.Text = "Kunder";
            this.btnNyKundMeny.UseVisualStyleBackColor = true;
            this.btnNyKundMeny.Click += new System.EventHandler(this.btnNyKundMeny_Click);
            // 
            // btnNyOrderMeny
            // 
            this.btnNyOrderMeny.AutoSize = true;
            this.btnNyOrderMeny.Location = new System.Drawing.Point(12, 12);
            this.btnNyOrderMeny.Name = "btnNyOrderMeny";
            this.btnNyOrderMeny.Size = new System.Drawing.Size(75, 60);
            this.btnNyOrderMeny.TabIndex = 0;
            this.btnNyOrderMeny.Text = "Ordrar";
            this.btnNyOrderMeny.UseVisualStyleBackColor = true;
            this.btnNyOrderMeny.Click += new System.EventHandler(this.btnNyOrderMeny_Click);
            // 
            // pnlStart
            // 
            this.pnlStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlStart.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStart.Location = new System.Drawing.Point(0, 81);
            this.pnlStart.Name = "pnlStart";
            this.pnlStart.Size = new System.Drawing.Size(784, 480);
            this.pnlStart.TabIndex = 1;
            // 
            // StartMenyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnlStart);
            this.Controls.Add(this.pnlSystemKnappar);
            this.Name = "StartMenyForm";
            this.Text = "DinHatt Order System";
            this.pnlSystemKnappar.ResumeLayout(false);
            this.pnlSystemKnappar.PerformLayout();
            this.pnlExtraFunktioner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSystemKnappar;
        public System.Windows.Forms.Button btnNyOrderMeny;
        public System.Windows.Forms.Button btnArtikelMeny;
        public System.Windows.Forms.Button btnNyKundMeny;
        public System.Windows.Forms.Button btnExportMeny;
        private System.Windows.Forms.Panel pnlExtraFunktioner;
        public System.Windows.Forms.Button btnStatistikMeny;
        private System.Windows.Forms.Panel pnlStart;
    }
}

