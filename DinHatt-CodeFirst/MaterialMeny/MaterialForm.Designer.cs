namespace DinHatt_CodeFirst.MaterialMeny
{
    partial class MaterialForm
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
            this.tabMaterial = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpbxMateriallista = new System.Windows.Forms.GroupBox();
            this.lvMaterial = new System.Windows.Forms.ListView();
            this.grpbxMaterialKontroll = new System.Windows.Forms.GroupBox();
            this.btnMateriallista = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.colMaterialId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaterial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLangd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBredd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFarg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabMaterial.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpbxMateriallista.SuspendLayout();
            this.grpbxMaterialKontroll.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMaterial
            // 
            this.tabMaterial.Controls.Add(this.tabPage1);
            this.tabMaterial.Controls.Add(this.tabPage2);
            this.tabMaterial.Controls.Add(this.tabPage3);
            this.tabMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMaterial.Location = new System.Drawing.Point(0, 0);
            this.tabMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.tabMaterial.Name = "tabMaterial";
            this.tabMaterial.SelectedIndex = 0;
            this.tabMaterial.Size = new System.Drawing.Size(1067, 554);
            this.tabMaterial.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpbxMateriallista);
            this.tabPage1.Controls.Add(this.grpbxMaterialKontroll);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1059, 525);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Material";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpbxMateriallista
            // 
            this.grpbxMateriallista.Controls.Add(this.lvMaterial);
            this.grpbxMateriallista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbxMateriallista.Location = new System.Drawing.Point(4, 70);
            this.grpbxMateriallista.Margin = new System.Windows.Forms.Padding(4);
            this.grpbxMateriallista.Name = "grpbxMateriallista";
            this.grpbxMateriallista.Padding = new System.Windows.Forms.Padding(4);
            this.grpbxMateriallista.Size = new System.Drawing.Size(1051, 451);
            this.grpbxMateriallista.TabIndex = 1;
            this.grpbxMateriallista.TabStop = false;
            this.grpbxMateriallista.Text = "Materiallista";
            // 
            // lvMaterial
            // 
            this.lvMaterial.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaterialId,
            this.colMaterial,
            this.colLangd,
            this.colBredd,
            this.colFarg});
            this.lvMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMaterial.FullRowSelect = true;
            this.lvMaterial.GridLines = true;
            this.lvMaterial.HideSelection = false;
            this.lvMaterial.Location = new System.Drawing.Point(4, 19);
            this.lvMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.lvMaterial.Name = "lvMaterial";
            this.lvMaterial.Size = new System.Drawing.Size(1043, 428);
            this.lvMaterial.TabIndex = 0;
            this.lvMaterial.UseCompatibleStateImageBehavior = false;
            this.lvMaterial.View = System.Windows.Forms.View.Details;
            // 
            // grpbxMaterialKontroll
            // 
            this.grpbxMaterialKontroll.Controls.Add(this.btnMateriallista);
            this.grpbxMaterialKontroll.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbxMaterialKontroll.Location = new System.Drawing.Point(4, 4);
            this.grpbxMaterialKontroll.Margin = new System.Windows.Forms.Padding(4);
            this.grpbxMaterialKontroll.Name = "grpbxMaterialKontroll";
            this.grpbxMaterialKontroll.Padding = new System.Windows.Forms.Padding(4);
            this.grpbxMaterialKontroll.Size = new System.Drawing.Size(1051, 66);
            this.grpbxMaterialKontroll.TabIndex = 0;
            this.grpbxMaterialKontroll.TabStop = false;
            this.grpbxMaterialKontroll.Text = "Material";
            // 
            // btnMateriallista
            // 
            this.btnMateriallista.Location = new System.Drawing.Point(8, 23);
            this.btnMateriallista.Margin = new System.Windows.Forms.Padding(4);
            this.btnMateriallista.Name = "btnMateriallista";
            this.btnMateriallista.Size = new System.Drawing.Size(165, 28);
            this.btnMateriallista.TabIndex = 0;
            this.btnMateriallista.Text = "Hämta Materiallista";
            this.btnMateriallista.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1059, 525);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lägg Till Material";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1059, 525);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hantera Material";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // colMaterialId
            // 
            this.colMaterialId.Text = "Material Id";
            this.colMaterialId.Width = 100;
            // 
            // colMaterial
            // 
            this.colMaterial.Text = "Material";
            this.colMaterial.Width = 100;
            // 
            // colLangd
            // 
            this.colLangd.Text = "Längd";
            this.colLangd.Width = 100;
            // 
            // colBredd
            // 
            this.colBredd.Text = "Bredd";
            this.colBredd.Width = 100;
            // 
            // colFarg
            // 
            this.colFarg.Text = "Färg";
            this.colFarg.Width = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(337, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 361);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // MaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabMaterial);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MaterialForm";
            this.Text = "MaterialForm";
            this.tabMaterial.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpbxMateriallista.ResumeLayout(false);
            this.grpbxMaterialKontroll.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMaterial;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grpbxMateriallista;
        private System.Windows.Forms.ListView lvMaterial;
        private System.Windows.Forms.GroupBox grpbxMaterialKontroll;
        private System.Windows.Forms.Button btnMateriallista;
        private System.Windows.Forms.ColumnHeader colMaterialId;
        private System.Windows.Forms.ColumnHeader colMaterial;
        private System.Windows.Forms.ColumnHeader colLangd;
        private System.Windows.Forms.ColumnHeader colBredd;
        private System.Windows.Forms.ColumnHeader colFarg;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}