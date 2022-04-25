namespace DinHatt_CodeFirst.LeverantorMeny
{
    partial class VisaLeverantorTabUserControl
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
            this.leverantorIdtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sokForebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // leverantorIdtxt
            // 
            this.leverantorIdtxt.Location = new System.Drawing.Point(66, 86);
            this.leverantorIdtxt.Name = "leverantorIdtxt";
            this.leverantorIdtxt.Size = new System.Drawing.Size(100, 20);
            this.leverantorIdtxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ange företagsnummer";
            // 
            // sokForebtn
            // 
            this.sokForebtn.Location = new System.Drawing.Point(66, 132);
            this.sokForebtn.Name = "sokForebtn";
            this.sokForebtn.Size = new System.Drawing.Size(100, 23);
            this.sokForebtn.TabIndex = 2;
            this.sokForebtn.Text = "Sök företag";
            this.sokForebtn.UseVisualStyleBackColor = true;
            this.sokForebtn.Click += new System.EventHandler(this.sokForebtn_Click);
            // 
            // VisaLeverantorTabUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sokForebtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leverantorIdtxt);
            this.Name = "VisaLeverantorTabUserControl";
            this.Size = new System.Drawing.Size(742, 514);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox leverantorIdtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sokForebtn;
    }
}
