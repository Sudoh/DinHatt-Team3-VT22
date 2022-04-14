namespace DinHatt_CodeFirst.OrderMeny
{
    partial class NyOrderTabUserControl
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
            this.btnNyOrder = new System.Windows.Forms.Button();
            this.tbKundNamn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbOrderBeskrivning = new System.Windows.Forms.Label();
            this.tbxDescription = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxPayed = new System.Windows.Forms.CheckBox();
            this.cbxDelivered = new System.Windows.Forms.CheckBox();
            this.rdBtnJudith = new System.Windows.Forms.RadioButton();
            this.rdBtnOtto = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btnSökKund = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txSökKund = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNyOrder
            // 
            this.btnNyOrder.Location = new System.Drawing.Point(202, 295);
            this.btnNyOrder.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNyOrder.Name = "btnNyOrder";
            this.btnNyOrder.Size = new System.Drawing.Size(87, 34);
            this.btnNyOrder.TabIndex = 1;
            this.btnNyOrder.Text = "Skapa ny order";
            this.btnNyOrder.UseVisualStyleBackColor = true;
            this.btnNyOrder.Click += new System.EventHandler(this.btnNyOrder_Click);
            // 
            // tbKundNamn
            // 
            this.tbKundNamn.Location = new System.Drawing.Point(153, 13);
            this.tbKundNamn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbKundNamn.Name = "tbKundNamn";
            this.tbKundNamn.Size = new System.Drawing.Size(152, 20);
            this.tbKundNamn.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kund namn";
            // 
            // lbOrderBeskrivning
            // 
            this.lbOrderBeskrivning.AutoSize = true;
            this.lbOrderBeskrivning.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderBeskrivning.Location = new System.Drawing.Point(26, 172);
            this.lbOrderBeskrivning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOrderBeskrivning.Name = "lbOrderBeskrivning";
            this.lbOrderBeskrivning.Size = new System.Drawing.Size(107, 13);
            this.lbOrderBeskrivning.TabIndex = 4;
            this.lbOrderBeskrivning.Text = "Order beskrivning";
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(153, 127);
            this.tbxDescription.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(263, 98);
            this.tbxDescription.TabIndex = 5;
            this.tbxDescription.Text = "";
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(157, 262);
            this.tbxPrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(154, 20);
            this.tbxPrice.TabIndex = 6;
            this.tbxPrice.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 267);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Preliminärt pris";
            // 
            // cbxPayed
            // 
            this.cbxPayed.AutoSize = true;
            this.cbxPayed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxPayed.Location = new System.Drawing.Point(325, 262);
            this.cbxPayed.Margin = new System.Windows.Forms.Padding(2);
            this.cbxPayed.Name = "cbxPayed";
            this.cbxPayed.Size = new System.Drawing.Size(59, 17);
            this.cbxPayed.TabIndex = 9;
            this.cbxPayed.Text = "Betalad";
            this.cbxPayed.UseVisualStyleBackColor = true;
            // 
            // cbxDelivered
            // 
            this.cbxDelivered.AutoSize = true;
            this.cbxDelivered.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxDelivered.Location = new System.Drawing.Point(396, 262);
            this.cbxDelivered.Margin = new System.Windows.Forms.Padding(2);
            this.cbxDelivered.Name = "cbxDelivered";
            this.cbxDelivered.Size = new System.Drawing.Size(62, 17);
            this.cbxDelivered.TabIndex = 10;
            this.cbxDelivered.Text = "Skickad";
            this.cbxDelivered.UseVisualStyleBackColor = true;
            // 
            // rdBtnJudith
            // 
            this.rdBtnJudith.AutoSize = true;
            this.rdBtnJudith.Location = new System.Drawing.Point(4, 15);
            this.rdBtnJudith.Margin = new System.Windows.Forms.Padding(2);
            this.rdBtnJudith.Name = "rdBtnJudith";
            this.rdBtnJudith.Size = new System.Drawing.Size(53, 17);
            this.rdBtnJudith.TabIndex = 11;
            this.rdBtnJudith.TabStop = true;
            this.rdBtnJudith.Text = "Judith";
            this.rdBtnJudith.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdBtnJudith.UseVisualStyleBackColor = true;
            // 
            // rdBtnOtto
            // 
            this.rdBtnOtto.AutoSize = true;
            this.rdBtnOtto.Location = new System.Drawing.Point(67, 15);
            this.rdBtnOtto.Margin = new System.Windows.Forms.Padding(2);
            this.rdBtnOtto.Name = "rdBtnOtto";
            this.rdBtnOtto.Size = new System.Drawing.Size(45, 17);
            this.rdBtnOtto.TabIndex = 12;
            this.rdBtnOtto.TabStop = true;
            this.rdBtnOtto.Text = "Otto";
            this.rdBtnOtto.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdBtnOtto.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Orderbeställare";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(153, 95);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBtnOtto);
            this.groupBox1.Controls.Add(this.rdBtnJudith);
            this.groupBox1.Location = new System.Drawing.Point(153, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(153, 42);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // btnSökKund
            // 
            this.btnSökKund.Location = new System.Drawing.Point(322, 24);
            this.btnSökKund.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSökKund.Name = "btnSökKund";
            this.btnSökKund.Size = new System.Drawing.Size(87, 34);
            this.btnSökKund.TabIndex = 16;
            this.btnSökKund.Text = "Sök kund ID";
            this.btnSökKund.UseVisualStyleBackColor = true;
            this.btnSökKund.Click += new System.EventHandler(this.btnSökKund_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Orderdatum";
            // 
            // txSökKund
            // 
            this.txSökKund.Location = new System.Drawing.Point(427, 32);
            this.txSökKund.Margin = new System.Windows.Forms.Padding(2);
            this.txSökKund.Name = "txSökKund";
            this.txSökKund.Size = new System.Drawing.Size(109, 20);
            this.txSökKund.TabIndex = 18;
            // 
            // NyOrderTabUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txSökKund);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSökKund);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxDelivered);
            this.Controls.Add(this.cbxPayed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.lbOrderBeskrivning);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKundNamn);
            this.Controls.Add(this.btnNyOrder);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "NyOrderTabUserControl";
            this.Size = new System.Drawing.Size(575, 386);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNyOrder;
        private System.Windows.Forms.TextBox tbKundNamn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbOrderBeskrivning;
        private System.Windows.Forms.RichTextBox tbxDescription;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbxPayed;
        private System.Windows.Forms.CheckBox cbxDelivered;
        private System.Windows.Forms.RadioButton rdBtnJudith;
        private System.Windows.Forms.RadioButton rdBtnOtto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btnSökKund;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txSökKund;
    }
}
