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
            this.colMaterialId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaterial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLangd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBredd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFarg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpbxMaterialKontroll = new System.Windows.Forms.GroupBox();
            this.btnMateriallista = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.txtLangd = new System.Windows.Forms.TextBox();
            this.txtBredd = new System.Windows.Forms.TextBox();
            this.txtFarg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLaggTill = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHamtaInfo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaterialId = new System.Windows.Forms.TextBox();
            this.tabMaterial.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpbxMateriallista.SuspendLayout();
            this.grpbxMaterialKontroll.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMaterial
            // 
            this.tabMaterial.Controls.Add(this.tabPage1);
            this.tabMaterial.Controls.Add(this.tabPage2);
            this.tabMaterial.Controls.Add(this.tabPage3);
            this.tabMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMaterial.Location = new System.Drawing.Point(0, 0);
            this.tabMaterial.Name = "tabMaterial";
            this.tabMaterial.SelectedIndex = 0;
            this.tabMaterial.Size = new System.Drawing.Size(800, 450);
            this.tabMaterial.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpbxMateriallista);
            this.tabPage1.Controls.Add(this.grpbxMaterialKontroll);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Material";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpbxMateriallista
            // 
            this.grpbxMateriallista.Controls.Add(this.lvMaterial);
            this.grpbxMateriallista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbxMateriallista.Location = new System.Drawing.Point(3, 57);
            this.grpbxMateriallista.Name = "grpbxMateriallista";
            this.grpbxMateriallista.Size = new System.Drawing.Size(786, 364);
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
            this.lvMaterial.Location = new System.Drawing.Point(3, 16);
            this.lvMaterial.Name = "lvMaterial";
            this.lvMaterial.Size = new System.Drawing.Size(780, 345);
            this.lvMaterial.TabIndex = 0;
            this.lvMaterial.UseCompatibleStateImageBehavior = false;
            this.lvMaterial.View = System.Windows.Forms.View.Details;
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
            // grpbxMaterialKontroll
            // 
            this.grpbxMaterialKontroll.Controls.Add(this.btnMateriallista);
            this.grpbxMaterialKontroll.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbxMaterialKontroll.Location = new System.Drawing.Point(3, 3);
            this.grpbxMaterialKontroll.Name = "grpbxMaterialKontroll";
            this.grpbxMaterialKontroll.Size = new System.Drawing.Size(786, 54);
            this.grpbxMaterialKontroll.TabIndex = 0;
            this.grpbxMaterialKontroll.TabStop = false;
            this.grpbxMaterialKontroll.Text = "Material";
            // 
            // btnMateriallista
            // 
            this.btnMateriallista.Location = new System.Drawing.Point(6, 19);
            this.btnMateriallista.Name = "btnMateriallista";
            this.btnMateriallista.Size = new System.Drawing.Size(124, 23);
            this.btnMateriallista.TabIndex = 0;
            this.btnMateriallista.Text = "Hämta Materiallista";
            this.btnMateriallista.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lägg Till Material";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLaggTill);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFarg);
            this.groupBox1.Controls.Add(this.txtBredd);
            this.groupBox1.Controls.Add(this.txtLangd);
            this.groupBox1.Controls.Add(this.txtMaterial);
            this.groupBox1.Location = new System.Drawing.Point(7, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(304, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lägg Till Material";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtMaterialId);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.btnHamtaInfo);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hantera Material";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtMaterial
            // 
            this.txtMaterial.Location = new System.Drawing.Point(87, 40);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(100, 20);
            this.txtMaterial.TabIndex = 0;
            // 
            // txtLangd
            // 
            this.txtLangd.Location = new System.Drawing.Point(87, 93);
            this.txtLangd.Name = "txtLangd";
            this.txtLangd.Size = new System.Drawing.Size(100, 20);
            this.txtLangd.TabIndex = 1;
            // 
            // txtBredd
            // 
            this.txtBredd.Location = new System.Drawing.Point(87, 146);
            this.txtBredd.Name = "txtBredd";
            this.txtBredd.Size = new System.Drawing.Size(100, 20);
            this.txtBredd.TabIndex = 2;
            // 
            // txtFarg
            // 
            this.txtFarg.Location = new System.Drawing.Point(87, 210);
            this.txtFarg.Name = "txtFarg";
            this.txtFarg.Size = new System.Drawing.Size(100, 20);
            this.txtFarg.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Material";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Längd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bredd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Färg";
            // 
            // btnLaggTill
            // 
            this.btnLaggTill.Location = new System.Drawing.Point(87, 252);
            this.btnLaggTill.Name = "btnLaggTill";
            this.btnLaggTill.Size = new System.Drawing.Size(100, 23);
            this.btnLaggTill.TabIndex = 8;
            this.btnLaggTill.Text = "Lägg till";
            this.btnLaggTill.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(151, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 282);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Material-information";
            // 
            // btnHamtaInfo
            // 
            this.btnHamtaInfo.Location = new System.Drawing.Point(18, 93);
            this.btnHamtaInfo.Name = "btnHamtaInfo";
            this.btnHamtaInfo.Size = new System.Drawing.Size(103, 23);
            this.btnHamtaInfo.TabIndex = 1;
            this.btnHamtaInfo.Text = "Hämta information";
            this.btnHamtaInfo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ange Material ID";
            // 
            // txtMaterialId
            // 
            this.txtMaterialId.Location = new System.Drawing.Point(18, 54);
            this.txtMaterialId.Name = "txtMaterialId";
            this.txtMaterialId.Size = new System.Drawing.Size(100, 20);
            this.txtMaterialId.TabIndex = 3;
            // 
            // MaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabMaterial);
            this.Name = "MaterialForm";
            this.Text = "MaterialForm";
            this.tabMaterial.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpbxMateriallista.ResumeLayout(false);
            this.grpbxMaterialKontroll.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private System.Windows.Forms.TextBox txtFarg;
        private System.Windows.Forms.TextBox txtBredd;
        private System.Windows.Forms.TextBox txtLangd;
        private System.Windows.Forms.TextBox txtMaterial;
        private System.Windows.Forms.Button btnLaggTill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHamtaInfo;
        private System.Windows.Forms.TextBox txtMaterialId;
    }
}