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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblBetaldaOrdrar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxSumma = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblLevererade = new System.Windows.Forms.Label();
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
            this.btnVisaStatistik.Location = new System.Drawing.Point(12, 12);
            this.btnVisaStatistik.Name = "btnVisaStatistik";
            this.btnVisaStatistik.Size = new System.Drawing.Size(137, 37);
            this.btnVisaStatistik.TabIndex = 1;
            this.btnVisaStatistik.Text = "Visa statistik";
            this.btnVisaStatistik.UseVisualStyleBackColor = true;
            this.btnVisaStatistik.Click += new System.EventHandler(this.btnVisaStatistik_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 107);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(446, 328);
            this.textBox1.TabIndex = 2;
            // 
            // lblBetaldaOrdrar
            // 
            this.lblBetaldaOrdrar.Location = new System.Drawing.Point(28, 79);
            this.lblBetaldaOrdrar.Name = "lblBetaldaOrdrar";
            this.lblBetaldaOrdrar.Size = new System.Drawing.Size(232, 23);
            this.lblBetaldaOrdrar.TabIndex = 3;
            this.lblBetaldaOrdrar.Text = "Betalade ordrar";
            this.lblBetaldaOrdrar.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(28, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total summa";
            // 
            // txtboxSumma
            // 
            this.txtboxSumma.Location = new System.Drawing.Point(173, 440);
            this.txtboxSumma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxSumma.Multiline = true;
            this.txtboxSumma.Name = "txtboxSumma";
            this.txtboxSumma.Size = new System.Drawing.Size(128, 23);
            this.txtboxSumma.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(560, 107);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(446, 328);
            this.textBox2.TabIndex = 6;
            // 
            // lblLevererade
            // 
            this.lblLevererade.Location = new System.Drawing.Point(556, 79);
            this.lblLevererade.Name = "lblLevererade";
            this.lblLevererade.Size = new System.Drawing.Size(232, 23);
            this.lblLevererade.TabIndex = 7;
            this.lblLevererade.Text = "Levererade ordrar";
            // 
            // StatistikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 555);
            this.Controls.Add(this.lblLevererade);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtboxSumma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBetaldaOrdrar);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblBetaldaOrdrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxSumma;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblLevererade;
    }
}