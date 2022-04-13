namespace DinHatt_CodeFirst
{
    partial class OrderForm
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
            this.tabOrder = new System.Windows.Forms.TabControl();
            this.tabAllaOrder = new System.Windows.Forms.TabPage();
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.orderNummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabNyOrder = new System.Windows.Forms.TabPage();
            this.btnLadda = new System.Windows.Forms.Button();
            this.tabOrder.SuspendLayout();
            this.tabAllaOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabOrder
            // 
            this.tabOrder.Controls.Add(this.tabAllaOrder);
            this.tabOrder.Controls.Add(this.tabNyOrder);
            this.tabOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabOrder.Location = new System.Drawing.Point(0, 0);
            this.tabOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabOrder.Name = "tabOrder";
            this.tabOrder.SelectedIndex = 0;
            this.tabOrder.Size = new System.Drawing.Size(1146, 555);
            this.tabOrder.TabIndex = 0;
            this.tabOrder.SelectedIndexChanged += new System.EventHandler(this.tabOrder_SelectedIndexChanged);
            // 
            // tabAllaOrder
            // 
            this.tabAllaOrder.Controls.Add(this.btnLadda);
            this.tabAllaOrder.Controls.Add(this.listViewOrder);
            this.tabAllaOrder.Location = new System.Drawing.Point(4, 29);
            this.tabAllaOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabAllaOrder.Name = "tabAllaOrder";
            this.tabAllaOrder.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabAllaOrder.Size = new System.Drawing.Size(1138, 522);
            this.tabAllaOrder.TabIndex = 0;
            this.tabAllaOrder.Text = "Alla Order";
            this.tabAllaOrder.UseVisualStyleBackColor = true;
            // 
            // listViewOrder
            // 
            this.listViewOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orderNummer,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewOrder.GridLines = true;
            this.listViewOrder.HideSelection = false;
            this.listViewOrder.Location = new System.Drawing.Point(4, 5);
            this.listViewOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(1130, 512);
            this.listViewOrder.TabIndex = 0;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            this.listViewOrder.View = System.Windows.Forms.View.Details;
            // 
            // orderNummer
            // 
            this.orderNummer.Text = "Order nummer";
            this.orderNummer.Width = 115;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Order beställare";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Order prise";
            this.columnHeader3.Width = 131;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Leveransstatus";
            this.columnHeader4.Width = 141;
            // 
            // tabNyOrder
            // 
            this.tabNyOrder.Location = new System.Drawing.Point(4, 29);
            this.tabNyOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabNyOrder.Name = "tabNyOrder";
            this.tabNyOrder.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabNyOrder.Size = new System.Drawing.Size(1138, 522);
            this.tabNyOrder.TabIndex = 1;
            this.tabNyOrder.Text = "Ny Order";
            this.tabNyOrder.UseVisualStyleBackColor = true;
            // 
            // btnLadda
            // 
            this.btnLadda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnLadda.Location = new System.Drawing.Point(962, 40);
            this.btnLadda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLadda.Name = "btnLadda";
            this.btnLadda.Size = new System.Drawing.Size(134, 35);
            this.btnLadda.TabIndex = 2;
            this.btnLadda.Text = "Visa ordrar";
            this.btnLadda.UseVisualStyleBackColor = true;
            this.btnLadda.Click += new System.EventHandler(this.btnLadda_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 555);
            this.Controls.Add(this.tabOrder);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrderForm";
            this.Text = "Order";
            this.TopMost = true;
            this.tabOrder.ResumeLayout(false);
            this.tabAllaOrder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabOrder;
        private System.Windows.Forms.TabPage tabAllaOrder;
        private System.Windows.Forms.TabPage tabNyOrder;
        private System.Windows.Forms.ColumnHeader orderNummer;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.Button btnLadda;
    }
}