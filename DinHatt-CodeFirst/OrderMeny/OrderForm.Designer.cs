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
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.tabOrder = new System.Windows.Forms.TabControl();
            this.tabAllaOrder = new System.Windows.Forms.TabPage();
            this.btnLadda = new System.Windows.Forms.Button();
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.Kund = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Orderbeställare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrelimPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Discription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabNyOrder = new System.Windows.Forms.TabPage();
            this.Leveransstatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.tabAllaOrder.Controls.Add(this.btnLadda);
            this.tabAllaOrder.Controls.Add(this.listViewOrder);
            this.tabAllaOrder.Location = new System.Drawing.Point(4, 25);
            this.tabAllaOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAllaOrder.Name = "tabAllaOrder";
            this.tabAllaOrder.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAllaOrder.Size = new System.Drawing.Size(1011, 415);
            this.tabAllaOrder.TabIndex = 0;
            this.tabAllaOrder.Text = "Alla Order";
            this.tabAllaOrder.UseVisualStyleBackColor = true;
            // 
            // btnLadda
            // 
            this.btnLadda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnLadda.Location = new System.Drawing.Point(855, 336);
            this.btnLadda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLadda.Name = "btnLadda";
            this.btnLadda.Size = new System.Drawing.Size(119, 28);
            this.btnLadda.TabIndex = 2;
            this.btnLadda.Text = "Visa ordrar";
            this.btnLadda.UseVisualStyleBackColor = true;
            this.btnLadda.Click += new System.EventHandler(this.btnLadda_Click);
            // 
            // listViewOrder
            // 
            this.listViewOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Kund,
            this.Orderbeställare,
            this.PrelimPrice,
            this.Discription,
            this.Leveransstatus});
            this.listViewOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewOrder.GridLines = true;
            listViewGroup3.Header = "ListViewGroup";
            listViewGroup3.Name = "listViewGroup1";
            listViewGroup4.Header = "ListViewGroup";
            listViewGroup4.Name = "listViewGroup4";
            this.listViewOrder.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3,
            listViewGroup4});
            this.listViewOrder.HideSelection = false;
            this.listViewOrder.Location = new System.Drawing.Point(4, 4);
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(1003, 407);
            this.listViewOrder.TabIndex = 0;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            this.listViewOrder.View = System.Windows.Forms.View.Details;
            // 
            // Kund
            // 
            this.Kund.Text = "Kund ID";
            // 
            // Orderbeställare
            // 
            this.Orderbeställare.Text = "Order beställare";
            this.Orderbeställare.Width = 120;
            // 
            // PrelimPrice
            // 
            this.PrelimPrice.Text = "Order  PrelimPrice";
            this.PrelimPrice.Width = 131;
            // 
            // Discription
            // 
            this.Discription.Text = "Order discription";
            this.Discription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Discription.Width = 272;
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
            // Leveransstatus
            // 
            this.Leveransstatus.Text = "Leveransstatus";
            this.Leveransstatus.Width = 92;
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
        private System.Windows.Forms.ColumnHeader Kund;
        private System.Windows.Forms.ColumnHeader Orderbeställare;
        private System.Windows.Forms.ColumnHeader PrelimPrice;
        private System.Windows.Forms.ColumnHeader Discription;
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.Button btnLadda;
        private System.Windows.Forms.ColumnHeader Leveransstatus;
    }
}