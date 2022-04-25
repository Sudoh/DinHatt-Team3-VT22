namespace DinHatt_CodeFirst
{
    partial class StatistikForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnVisaStatistik = new System.Windows.Forms.Button();
            this.lblBetaldaOrdrar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxTotalBetal = new System.Windows.Forms.TextBox();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeSlut = new System.Windows.Forms.DateTimePicker();
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOrdNmr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSumma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDatum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxMoms = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1146, 555);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnVisaStatistik
            // 
            this.btnVisaStatistik.Location = new System.Drawing.Point(485, 142);
            this.btnVisaStatistik.Name = "btnVisaStatistik";
            this.btnVisaStatistik.Size = new System.Drawing.Size(137, 37);
            this.btnVisaStatistik.TabIndex = 1;
            this.btnVisaStatistik.Text = "Visa statistik";
            this.btnVisaStatistik.UseVisualStyleBackColor = true;
            this.btnVisaStatistik.Click += new System.EventHandler(this.btnVisaStatistik_Click);
            // 
            // lblBetaldaOrdrar
            // 
            this.lblBetaldaOrdrar.Location = new System.Drawing.Point(8, 9);
            this.lblBetaldaOrdrar.Name = "lblBetaldaOrdrar";
            this.lblBetaldaOrdrar.Size = new System.Drawing.Size(232, 23);
            this.lblBetaldaOrdrar.TabIndex = 3;
            this.lblBetaldaOrdrar.Text = "Betalda och levererade ordrar";
            this.lblBetaldaOrdrar.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total summa";
            // 
            // txtboxTotalBetal
            // 
            this.txtboxTotalBetal.Location = new System.Drawing.Point(173, 352);
            this.txtboxTotalBetal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxTotalBetal.Multiline = true;
            this.txtboxTotalBetal.Name = "txtboxTotalBetal";
            this.txtboxTotalBetal.Size = new System.Drawing.Size(128, 23);
            this.txtboxTotalBetal.TabIndex = 5;
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Location = new System.Drawing.Point(636, 45);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(200, 26);
            this.dateTimeStart.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(481, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Startdatum";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(481, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Slutdatum";
            // 
            // dateTimeSlut
            // 
            this.dateTimeSlut.Location = new System.Drawing.Point(636, 90);
            this.dateTimeSlut.Name = "dateTimeSlut";
            this.dateTimeSlut.Size = new System.Drawing.Size(200, 26);
            this.dateTimeSlut.TabIndex = 9;
            // 
            // listViewOrder
            // 
            this.listViewOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.colOrdNmr,
            this.colSumma,
            this.colDatum});
            this.listViewOrder.FullRowSelect = true;
            this.listViewOrder.GridLines = true;
            this.listViewOrder.HideSelection = false;
            this.listViewOrder.Location = new System.Drawing.Point(12, 45);
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(453, 288);
            this.listViewOrder.TabIndex = 10;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            this.listViewOrder.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "-";
            this.columnHeader1.Width = 13;
            // 
            // colOrdNmr
            // 
            this.colOrdNmr.Text = "Ordernummer";
            this.colOrdNmr.Width = 113;
            // 
            // colSumma
            // 
            this.colSumma.Text = "Summa";
            this.colSumma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSumma.Width = 88;
            // 
            // colDatum
            // 
            this.colDatum.Text = "Datum";
            this.colDatum.Width = 72;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Total moms";
            // 
            // txtboxMoms
            // 
            this.txtboxMoms.Location = new System.Drawing.Point(173, 395);
            this.txtboxMoms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxMoms.Multiline = true;
            this.txtboxMoms.Name = "txtboxMoms";
            this.txtboxMoms.Size = new System.Drawing.Size(128, 23);
            this.txtboxMoms.TabIndex = 12;
            // 
            // StatistikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 555);
            this.Controls.Add(this.txtboxMoms);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listViewOrder);
            this.Controls.Add(this.dateTimeSlut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimeStart);
            this.Controls.Add(this.txtboxTotalBetal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBetaldaOrdrar);
            this.Controls.Add(this.btnVisaStatistik);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StatistikForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "StatistikForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StatistikForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnVisaStatistik;
        private System.Windows.Forms.Label lblBetaldaOrdrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxTotalBetal;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeSlut;
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader colOrdNmr;
        private System.Windows.Forms.ColumnHeader colSumma;
        private System.Windows.Forms.ColumnHeader colDatum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxMoms;
    }
}