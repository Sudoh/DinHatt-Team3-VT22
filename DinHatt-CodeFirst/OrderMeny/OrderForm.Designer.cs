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
            this.btnLadda = new System.Windows.Forms.Button();
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colKund = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOrderbeställare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrelimPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiscription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPayed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLeveransstatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDatum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMoms = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabNyOrder = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ArtikelId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabOrder.SuspendLayout();
            this.tabAllaOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabOrder
            // 
            this.tabOrder.Controls.Add(this.tabAllaOrder);
            this.tabOrder.Controls.Add(this.tabNyOrder);
            this.tabOrder.Controls.Add(this.tabPage1);
            this.tabOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabOrder.Location = new System.Drawing.Point(0, 0);
            this.tabOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabOrder.Name = "tabOrder";
            this.tabOrder.SelectedIndex = 0;
            this.tabOrder.Size = new System.Drawing.Size(1202, 444);
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
            this.tabAllaOrder.Size = new System.Drawing.Size(1194, 415);
            this.tabAllaOrder.TabIndex = 0;
            this.tabAllaOrder.Text = "Alla Order";
            this.tabAllaOrder.UseVisualStyleBackColor = true;
            // 
            // btnLadda
            // 
            this.btnLadda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnLadda.Location = new System.Drawing.Point(677, 161);
            this.btnLadda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLadda.Name = "btnLadda";
            this.btnLadda.Size = new System.Drawing.Size(94, 28);
            this.btnLadda.TabIndex = 2;
            this.btnLadda.Text = "Visa ordrar";
            this.btnLadda.UseVisualStyleBackColor = true;
            this.btnLadda.Click += new System.EventHandler(this.btnLadda_Click);
            // 
            // listViewOrder
            // 
            this.listViewOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.colKund,
            this.colOrderbeställare,
            this.colPrelimPrice,
            this.colDiscription,
            this.colPayed,
            this.colLeveransstatus,
            this.colDatum,
            this.colMoms,
            this.ArtikelId});
            this.listViewOrder.FullRowSelect = true;
            this.listViewOrder.GridLines = true;
            this.listViewOrder.HideSelection = false;
            this.listViewOrder.Location = new System.Drawing.Point(4, 4);
            this.listViewOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(1188, 410);
            this.listViewOrder.TabIndex = 0;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            this.listViewOrder.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "-";
            this.columnHeader1.Width = 13;
            // 
            // colKund
            // 
            this.colKund.Text = "Kund ID";
            this.colKund.Width = 51;
            // 
            // colOrderbeställare
            // 
            this.colOrderbeställare.Text = "Order beställare";
            this.colOrderbeställare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colOrderbeställare.Width = 88;
            // 
            // colPrelimPrice
            // 
            this.colPrelimPrice.DisplayIndex = 4;
            this.colPrelimPrice.Text = "Order  PrelimPrice";
            this.colPrelimPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colPrelimPrice.Width = 98;
            // 
            // colDiscription
            // 
            this.colDiscription.DisplayIndex = 5;
            this.colDiscription.Text = "Order discription";
            this.colDiscription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDiscription.Width = 100;
            // 
            // colPayed
            // 
            this.colPayed.DisplayIndex = 6;
            this.colPayed.Text = "Betald";
            this.colPayed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colPayed.Width = 46;
            // 
            // colLeveransstatus
            // 
            this.colLeveransstatus.DisplayIndex = 7;
            this.colLeveransstatus.Text = "Leveransstatus";
            this.colLeveransstatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colLeveransstatus.Width = 86;
            // 
            // colDatum
            // 
            this.colDatum.DisplayIndex = 8;
            this.colDatum.Text = "OrderDatum";
            this.colDatum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDatum.Width = 108;
            // 
            // colMoms
            // 
            this.colMoms.DisplayIndex = 9;
            this.colMoms.Text = "Moms";
            this.colMoms.Width = 85;
            // 
            // tabNyOrder
            // 
            this.tabNyOrder.Location = new System.Drawing.Point(4, 25);
            this.tabNyOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabNyOrder.Name = "tabNyOrder";
            this.tabNyOrder.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabNyOrder.Size = new System.Drawing.Size(1194, 415);
            this.tabNyOrder.TabIndex = 1;
            this.tabNyOrder.Text = "Ny Order";
            this.tabNyOrder.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1194, 415);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Arikel order";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ArtikelId
            // 
            this.ArtikelId.DisplayIndex = 3;
            this.ArtikelId.Text = "ArtikelId";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 444);
            this.Controls.Add(this.tabOrder);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OrderForm";
            this.Text = "Order";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.tabOrder.ResumeLayout(false);
            this.tabAllaOrder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabOrder;
        private System.Windows.Forms.TabPage tabAllaOrder;
        private System.Windows.Forms.TabPage tabNyOrder;
        private System.Windows.Forms.ColumnHeader colKund;
        private System.Windows.Forms.ColumnHeader colOrderbeställare;
        private System.Windows.Forms.ColumnHeader colPrelimPrice;
        private System.Windows.Forms.ColumnHeader colDiscription;
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.Button btnLadda;
        private System.Windows.Forms.ColumnHeader colPayed;
        private System.Windows.Forms.ColumnHeader colLeveransstatus;
        private System.Windows.Forms.ColumnHeader colDatum;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader colMoms;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ColumnHeader ArtikelId;
    }
}