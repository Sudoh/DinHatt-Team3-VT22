namespace DinHatt_CodeFirst.LeverantorMeny
{
    partial class LeverantorForm
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
            this.grpbxLeverantorKontroll = new System.Windows.Forms.GroupBox();
            this.grpbxLeverantorList = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnVisaLeverantorer = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.grpbxLeverantorKontroll.SuspendLayout();
            this.grpbxLeverantorList.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxLeverantorKontroll
            // 
            this.grpbxLeverantorKontroll.Controls.Add(this.btnVisaLeverantorer);
            this.grpbxLeverantorKontroll.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbxLeverantorKontroll.Location = new System.Drawing.Point(3, 3);
            this.grpbxLeverantorKontroll.Name = "grpbxLeverantorKontroll";
            this.grpbxLeverantorKontroll.Size = new System.Drawing.Size(786, 53);
            this.grpbxLeverantorKontroll.TabIndex = 0;
            this.grpbxLeverantorKontroll.TabStop = false;
            this.grpbxLeverantorKontroll.Text = "Leverantörer";
            // 
            // grpbxLeverantorList
            // 
            this.grpbxLeverantorList.Controls.Add(this.listView1);
            this.grpbxLeverantorList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbxLeverantorList.Location = new System.Drawing.Point(3, 56);
            this.grpbxLeverantorList.Name = "grpbxLeverantorList";
            this.grpbxLeverantorList.Size = new System.Drawing.Size(786, 365);
            this.grpbxLeverantorList.TabIndex = 1;
            this.grpbxLeverantorList.TabStop = false;
            this.grpbxLeverantorList.Text = "Lista på leverantörer";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpbxLeverantorList);
            this.tabPage1.Controls.Add(this.grpbxLeverantorKontroll);
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
            this.tabPage2.Size = new System.Drawing.Size(786, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnVisaLeverantorer
            // 
            this.btnVisaLeverantorer.Location = new System.Drawing.Point(6, 19);
            this.btnVisaLeverantorer.Name = "btnVisaLeverantorer";
            this.btnVisaLeverantorer.Size = new System.Drawing.Size(125, 23);
            this.btnVisaLeverantorer.TabIndex = 0;
            this.btnVisaLeverantorer.Text = "Hämta leverantörer";
            this.btnVisaLeverantorer.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 16);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(780, 346);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // LeverantorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "LeverantorForm";
            this.Text = "LeverantorForm";
            this.grpbxLeverantorKontroll.ResumeLayout(false);
            this.grpbxLeverantorList.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxLeverantorKontroll;
        private System.Windows.Forms.GroupBox grpbxLeverantorList;
        private System.Windows.Forms.Button btnVisaLeverantorer;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listView1;
    }
}