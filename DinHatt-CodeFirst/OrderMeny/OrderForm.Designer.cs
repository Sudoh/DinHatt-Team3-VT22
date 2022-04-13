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
            this.tabNyOrder = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.orderNummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.tabOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabOrder.Name = "tabOrder";
            this.tabOrder.SelectedIndex = 0;
            this.tabOrder.Size = new System.Drawing.Size(1019, 444);
            this.tabOrder.TabIndex = 0;
            this.tabOrder.SelectedIndexChanged += new System.EventHandler(this.tabOrder_SelectedIndexChanged);
            // 
            // tabAllaOrder
            // 
            this.tabAllaOrder.Controls.Add(this.listView1);
            this.tabAllaOrder.Location = new System.Drawing.Point(4, 25);
            this.tabAllaOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAllaOrder.Name = "tabAllaOrder";
            this.tabAllaOrder.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAllaOrder.Size = new System.Drawing.Size(1011, 415);
            this.tabAllaOrder.TabIndex = 0;
            this.tabAllaOrder.Text = "Alla Order";
            this.tabAllaOrder.UseVisualStyleBackColor = true;
            // 
            // tabNyOrder
            // 
            this.tabNyOrder.Location = new System.Drawing.Point(4, 25);
            this.tabNyOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabNyOrder.Name = "tabNyOrder";
            this.tabNyOrder.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabNyOrder.Size = new System.Drawing.Size(1011, 415);
            this.tabNyOrder.TabIndex = 1;
            this.tabNyOrder.Text = "Ny Order";
            this.tabNyOrder.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orderNummer,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1003, 407);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 444);
            this.Controls.Add(this.tabOrder);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.ListView listView1;
    }
}