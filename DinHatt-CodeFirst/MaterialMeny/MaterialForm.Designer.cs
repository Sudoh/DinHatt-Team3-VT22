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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grpbxMaterialKontroll = new System.Windows.Forms.GroupBox();
            this.btnMateriallista = new System.Windows.Forms.Button();
            this.grpbxMateriallista = new System.Windows.Forms.GroupBox();
            this.lvMaterial = new System.Windows.Forms.ListView();
            this.tabMaterial.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpbxMaterialKontroll.SuspendLayout();
            this.grpbxMateriallista.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMaterial
            // 
            this.tabMaterial.Controls.Add(this.tabPage1);
            this.tabMaterial.Controls.Add(this.tabPage2);
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
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.grpbxMaterialKontroll.ResumeLayout(false);
            this.grpbxMateriallista.ResumeLayout(false);
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
    }
}