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
            this.txbSökArtikel = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lstbxArtikel = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxTotPris = new System.Windows.Forms.TextBox();
            this.tbxAntalLager = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grbxAntalLager = new System.Windows.Forms.GroupBox();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.grbxAntalLager.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNyOrder
            // 
            this.btnNyOrder.Location = new System.Drawing.Point(321, 556);
            this.btnNyOrder.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnNyOrder.Name = "btnNyOrder";
            this.btnNyOrder.Size = new System.Drawing.Size(130, 40);
            this.btnNyOrder.TabIndex = 1;
            this.btnNyOrder.Text = "Skapa ny order";
            this.btnNyOrder.UseVisualStyleBackColor = true;
            this.btnNyOrder.Click += new System.EventHandler(this.btnNyOrder_Click);
            // 
            // tbKundNamn
            // 
            this.tbKundNamn.Location = new System.Drawing.Point(230, 20);
            this.tbKundNamn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbKundNamn.Name = "tbKundNamn";
            this.tbKundNamn.Size = new System.Drawing.Size(226, 26);
            this.tbKundNamn.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kund namn";
            // 
            // lbOrderBeskrivning
            // 
            this.lbOrderBeskrivning.AutoSize = true;
            this.lbOrderBeskrivning.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderBeskrivning.Location = new System.Drawing.Point(37, 368);
            this.lbOrderBeskrivning.Name = "lbOrderBeskrivning";
            this.lbOrderBeskrivning.Size = new System.Drawing.Size(149, 20);
            this.lbOrderBeskrivning.TabIndex = 4;
            this.lbOrderBeskrivning.Text = "Order beskrivning";
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(233, 298);
            this.tbxDescription.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(392, 149);
            this.tbxDescription.TabIndex = 5;
            this.tbxDescription.Text = "";
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(233, 488);
            this.tbxPrice.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(166, 26);
            this.tbxPrice.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Preliminärt pris";
            // 
            // cbxPayed
            // 
            this.cbxPayed.AutoSize = true;
            this.cbxPayed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxPayed.Location = new System.Drawing.Point(676, 318);
            this.cbxPayed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxPayed.Name = "cbxPayed";
            this.cbxPayed.Size = new System.Drawing.Size(85, 24);
            this.cbxPayed.TabIndex = 9;
            this.cbxPayed.Text = "Betalad";
            this.cbxPayed.UseVisualStyleBackColor = true;
            // 
            // cbxDelivered
            // 
            this.cbxDelivered.AutoSize = true;
            this.cbxDelivered.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxDelivered.Location = new System.Drawing.Point(676, 385);
            this.cbxDelivered.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxDelivered.Name = "cbxDelivered";
            this.cbxDelivered.Size = new System.Drawing.Size(86, 24);
            this.cbxDelivered.TabIndex = 10;
            this.cbxDelivered.Text = "Skickad";
            this.cbxDelivered.UseVisualStyleBackColor = true;
            // 
            // rdBtnJudith
            // 
            this.rdBtnJudith.AutoSize = true;
            this.rdBtnJudith.Location = new System.Drawing.Point(20, 24);
            this.rdBtnJudith.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdBtnJudith.Name = "rdBtnJudith";
            this.rdBtnJudith.Size = new System.Drawing.Size(77, 24);
            this.rdBtnJudith.TabIndex = 11;
            this.rdBtnJudith.TabStop = true;
            this.rdBtnJudith.Text = "Judith";
            this.rdBtnJudith.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdBtnJudith.UseVisualStyleBackColor = true;
            // 
            // rdBtnOtto
            // 
            this.rdBtnOtto.AutoSize = true;
            this.rdBtnOtto.Location = new System.Drawing.Point(133, 26);
            this.rdBtnOtto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdBtnOtto.Name = "rdBtnOtto";
            this.rdBtnOtto.Size = new System.Drawing.Size(65, 24);
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
            this.label3.Location = new System.Drawing.Point(37, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Orderbeställare";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(614, 238);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 26);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBtnOtto);
            this.groupBox1.Controls.Add(this.rdBtnJudith);
            this.groupBox1.Location = new System.Drawing.Point(226, 216);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(230, 65);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // btnSökKund
            // 
            this.btnSökKund.Location = new System.Drawing.Point(499, 8);
            this.btnSökKund.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSökKund.Name = "btnSökKund";
            this.btnSökKund.Size = new System.Drawing.Size(130, 52);
            this.btnSökKund.TabIndex = 16;
            this.btnSökKund.Text = "Sök kund ID";
            this.btnSökKund.UseVisualStyleBackColor = true;
            this.btnSökKund.Click += new System.EventHandler(this.btnSökKund_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(485, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Orderdatum";
            // 
            // txSökKund
            // 
            this.txSökKund.Location = new System.Drawing.Point(656, 20);
            this.txSökKund.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txSökKund.Name = "txSökKund";
            this.txSökKund.Size = new System.Drawing.Size(162, 26);
            this.txSökKund.TabIndex = 18;
            // 
            // txbSökArtikel
            // 
            this.txbSökArtikel.Location = new System.Drawing.Point(656, 88);
            this.txbSökArtikel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbSökArtikel.Name = "txbSökArtikel";
            this.txbSökArtikel.Size = new System.Drawing.Size(162, 26);
            this.txbSökArtikel.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 75);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 52);
            this.button1.TabIndex = 19;
            this.button1.Text = "Add artikel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Artikel list";
            // 
            // lstbxArtikel
            // 
            this.lstbxArtikel.FormattingEnabled = true;
            this.lstbxArtikel.ItemHeight = 20;
            this.lstbxArtikel.Location = new System.Drawing.Point(226, 71);
            this.lstbxArtikel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstbxArtikel.Name = "lstbxArtikel";
            this.lstbxArtikel.Size = new System.Drawing.Size(224, 124);
            this.lstbxArtikel.TabIndex = 23;
            this.lstbxArtikel.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(459, 491);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Total pris";
            // 
            // tbxTotPris
            // 
            this.tbxTotPris.Location = new System.Drawing.Point(588, 488);
            this.tbxTotPris.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbxTotPris.Name = "tbxTotPris";
            this.tbxTotPris.Size = new System.Drawing.Size(168, 26);
            this.tbxTotPris.TabIndex = 24;
            // 
            // tbxAntalLager
            // 
            this.tbxAntalLager.Location = new System.Drawing.Point(157, 16);
            this.tbxAntalLager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxAntalLager.Name = "tbxAntalLager";
            this.tbxAntalLager.Size = new System.Drawing.Size(162, 26);
            this.tbxAntalLager.TabIndex = 26;
            this.tbxAntalLager.TextChanged += new System.EventHandler(this.tbxAntalLager_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Antal i lager:";
            // 
            // grbxAntalLager
            // 
            this.grbxAntalLager.Controls.Add(this.label7);
            this.grbxAntalLager.Controls.Add(this.tbxAntalLager);
            this.grbxAntalLager.Location = new System.Drawing.Point(499, 135);
            this.grbxAntalLager.Name = "grbxAntalLager";
            this.grbxAntalLager.Size = new System.Drawing.Size(360, 52);
            this.grbxAntalLager.TabIndex = 28;
            this.grbxAntalLager.TabStop = false;
            this.grbxAntalLager.Visible = false;
            // 
            // NyOrderTabUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbxAntalLager);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxTotPris);
            this.Controls.Add(this.lstbxArtikel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbSökArtikel);
            this.Controls.Add(this.button1);
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
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "NyOrderTabUserControl";
            this.Size = new System.Drawing.Size(862, 649);
            this.Load += new System.EventHandler(this.NyOrderTabUserControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbxAntalLager.ResumeLayout(false);
            this.grbxAntalLager.PerformLayout();
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
        private System.Windows.Forms.TextBox txbSökArtikel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstbxArtikel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxTotPris;
        private System.Windows.Forms.TextBox tbxAntalLager;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grbxAntalLager;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
    }
}
