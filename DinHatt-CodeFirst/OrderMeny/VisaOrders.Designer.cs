namespace DinHatt_CodeFirst.OrderMeny
{
    partial class VisaOrders
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDeletOrder = new System.Windows.Forms.Button();
            this.tbxOrderId = new System.Windows.Forms.TextBox();
            this.tbxOrderDes = new System.Windows.Forms.RichTextBox();
            this.lbOrderBsk2 = new System.Windows.Forms.Label();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.tbxTotalPrice = new System.Windows.Forms.TextBox();
            this.lblTatalPrice = new System.Windows.Forms.Label();
            this.cbxSkickad = new System.Windows.Forms.CheckBox();
            this.cbxBetalad = new System.Windows.Forms.CheckBox();
            this.btnSökOrderId = new System.Windows.Forms.Button();
            this.tbSökOrderId = new System.Windows.Forms.TextBox();
            this.btnÄndraOrder = new System.Windows.Forms.Button();
            this.ArtikelList = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDeletOrder
            // 
            this.btnDeletOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeletOrder.Location = new System.Drawing.Point(636, 379);
            this.btnDeletOrder.Name = "btnDeletOrder";
            this.btnDeletOrder.Size = new System.Drawing.Size(126, 46);
            this.btnDeletOrder.TabIndex = 0;
            this.btnDeletOrder.Text = "Delet order";
            this.btnDeletOrder.UseVisualStyleBackColor = false;
            this.btnDeletOrder.Click += new System.EventHandler(this.btnDeletOrder_Click);
            // 
            // tbxOrderId
            // 
            this.tbxOrderId.Location = new System.Drawing.Point(177, 31);
            this.tbxOrderId.Name = "tbxOrderId";
            this.tbxOrderId.Size = new System.Drawing.Size(130, 22);
            this.tbxOrderId.TabIndex = 1;
            // 
            // tbxOrderDes
            // 
            this.tbxOrderDes.Location = new System.Drawing.Point(177, 201);
            this.tbxOrderDes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxOrderDes.Name = "tbxOrderDes";
            this.tbxOrderDes.Size = new System.Drawing.Size(349, 120);
            this.tbxOrderDes.TabIndex = 6;
            this.tbxOrderDes.Text = "";
            // 
            // lbOrderBsk2
            // 
            this.lbOrderBsk2.AutoSize = true;
            this.lbOrderBsk2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderBsk2.Location = new System.Drawing.Point(30, 261);
            this.lbOrderBsk2.Name = "lbOrderBsk2";
            this.lbOrderBsk2.Size = new System.Drawing.Size(130, 16);
            this.lbOrderBsk2.TabIndex = 7;
            this.lbOrderBsk2.Text = "Order beskrivning";
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderId.Location = new System.Drawing.Point(30, 37);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(65, 16);
            this.lblOrderId.TabIndex = 8;
            this.lblOrderId.Text = "Order ID";
            // 
            // tbxTotalPrice
            // 
            this.tbxTotalPrice.Location = new System.Drawing.Point(177, 344);
            this.tbxTotalPrice.Name = "tbxTotalPrice";
            this.tbxTotalPrice.Size = new System.Drawing.Size(130, 22);
            this.tbxTotalPrice.TabIndex = 9;
            // 
            // lblTatalPrice
            // 
            this.lblTatalPrice.AutoSize = true;
            this.lblTatalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTatalPrice.Location = new System.Drawing.Point(30, 344);
            this.lblTatalPrice.Name = "lblTatalPrice";
            this.lblTatalPrice.Size = new System.Drawing.Size(83, 16);
            this.lblTatalPrice.TabIndex = 10;
            this.lblTatalPrice.Text = "Total Price";
            // 
            // cbxSkickad
            // 
            this.cbxSkickad.AutoSize = true;
            this.cbxSkickad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxSkickad.Location = new System.Drawing.Point(594, 290);
            this.cbxSkickad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxSkickad.Name = "cbxSkickad";
            this.cbxSkickad.Size = new System.Drawing.Size(74, 20);
            this.cbxSkickad.TabIndex = 12;
            this.cbxSkickad.Text = "Skickad";
            this.cbxSkickad.UseVisualStyleBackColor = true;
            // 
            // cbxBetalad
            // 
            this.cbxBetalad.AutoSize = true;
            this.cbxBetalad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxBetalad.Location = new System.Drawing.Point(594, 239);
            this.cbxBetalad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxBetalad.Name = "cbxBetalad";
            this.cbxBetalad.Size = new System.Drawing.Size(72, 20);
            this.cbxBetalad.TabIndex = 11;
            this.cbxBetalad.Text = "Betalad";
            this.cbxBetalad.UseVisualStyleBackColor = true;
            // 
            // btnSökOrderId
            // 
            this.btnSökOrderId.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSökOrderId.Location = new System.Drawing.Point(529, 19);
            this.btnSökOrderId.Name = "btnSökOrderId";
            this.btnSökOrderId.Size = new System.Drawing.Size(126, 46);
            this.btnSökOrderId.TabIndex = 13;
            this.btnSökOrderId.Text = "Sök order ID";
            this.btnSökOrderId.UseVisualStyleBackColor = false;
            this.btnSökOrderId.Click += new System.EventHandler(this.btnSökOrderId_Click);
            // 
            // tbSökOrderId
            // 
            this.tbSökOrderId.Location = new System.Drawing.Point(691, 31);
            this.tbSökOrderId.Name = "tbSökOrderId";
            this.tbSökOrderId.Size = new System.Drawing.Size(130, 22);
            this.tbSökOrderId.TabIndex = 14;
            // 
            // btnÄndraOrder
            // 
            this.btnÄndraOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnÄndraOrder.Location = new System.Drawing.Point(417, 379);
            this.btnÄndraOrder.Name = "btnÄndraOrder";
            this.btnÄndraOrder.Size = new System.Drawing.Size(126, 46);
            this.btnÄndraOrder.TabIndex = 15;
            this.btnÄndraOrder.Text = "Ändra order";
            this.btnÄndraOrder.UseVisualStyleBackColor = false;
            this.btnÄndraOrder.Click += new System.EventHandler(this.btnÄndraOrder_Click);
            // 
            // ArtikelList
            // 
            this.ArtikelList.FormattingEnabled = true;
            this.ArtikelList.ItemHeight = 16;
            this.ArtikelList.Location = new System.Drawing.Point(177, 77);
            this.ArtikelList.Name = "ArtikelList";
            this.ArtikelList.Size = new System.Drawing.Size(200, 100);
            this.ArtikelList.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Artikel list";
            // 
            // VisaOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ArtikelList);
            this.Controls.Add(this.btnÄndraOrder);
            this.Controls.Add(this.tbSökOrderId);
            this.Controls.Add(this.btnSökOrderId);
            this.Controls.Add(this.cbxSkickad);
            this.Controls.Add(this.cbxBetalad);
            this.Controls.Add(this.lblTatalPrice);
            this.Controls.Add(this.tbxTotalPrice);
            this.Controls.Add(this.lblOrderId);
            this.Controls.Add(this.lbOrderBsk2);
            this.Controls.Add(this.tbxOrderDes);
            this.Controls.Add(this.tbxOrderId);
            this.Controls.Add(this.btnDeletOrder);
            this.Name = "VisaOrders";
            this.Size = new System.Drawing.Size(865, 460);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeletOrder;
        private System.Windows.Forms.TextBox tbxOrderId;
        private System.Windows.Forms.RichTextBox tbxOrderDes;
        private System.Windows.Forms.Label lbOrderBsk2;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.TextBox tbxTotalPrice;
        private System.Windows.Forms.Label lblTatalPrice;
        private System.Windows.Forms.CheckBox cbxSkickad;
        private System.Windows.Forms.CheckBox cbxBetalad;
        private System.Windows.Forms.Button btnSökOrderId;
        private System.Windows.Forms.TextBox tbSökOrderId;
        private System.Windows.Forms.Button btnÄndraOrder;
        private System.Windows.Forms.ListBox ArtikelList;
        private System.Windows.Forms.Label label5;
    }
}
