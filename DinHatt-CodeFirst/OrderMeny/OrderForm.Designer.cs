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
            this.tabOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabOrder
            // 
            this.tabOrder.Controls.Add(this.tabAllaOrder);
            this.tabOrder.Controls.Add(this.tabNyOrder);
            this.tabOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabOrder.Location = new System.Drawing.Point(0, 0);
            this.tabOrder.Name = "tabOrder";
            this.tabOrder.SelectedIndex = 0;
            this.tabOrder.Size = new System.Drawing.Size(764, 361);
            this.tabOrder.TabIndex = 0;
            // 
            // tabAllaOrder
            // 
            this.tabAllaOrder.Location = new System.Drawing.Point(4, 22);
            this.tabAllaOrder.Name = "tabAllaOrder";
            this.tabAllaOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabAllaOrder.Size = new System.Drawing.Size(756, 335);
            this.tabAllaOrder.TabIndex = 0;
            this.tabAllaOrder.Text = "Alla Order";
            this.tabAllaOrder.UseVisualStyleBackColor = true;
            // 
            // tabNyOrder
            // 
            this.tabNyOrder.Location = new System.Drawing.Point(4, 22);
            this.tabNyOrder.Name = "tabNyOrder";
            this.tabNyOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabNyOrder.Size = new System.Drawing.Size(792, 424);
            this.tabNyOrder.TabIndex = 1;
            this.tabNyOrder.Text = "Ny Order";
            this.tabNyOrder.UseVisualStyleBackColor = true;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 361);
            this.Controls.Add(this.tabOrder);
            this.Name = "OrderForm";
            this.Text = "Order";
            this.TopMost = true;
            this.tabOrder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabOrder;
        private System.Windows.Forms.TabPage tabAllaOrder;
        private System.Windows.Forms.TabPage tabNyOrder;
    }
}