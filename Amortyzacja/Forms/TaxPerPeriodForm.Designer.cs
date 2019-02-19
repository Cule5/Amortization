namespace Amortyzacja.Forms
{
    partial class TaxPerPeriodForm
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
            this.pass = new System.Windows.Forms.Button();
            this.year = new System.Windows.Forms.TextBox();
            this.lastForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(248, 314);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(120, 40);
            this.pass.TabIndex = 0;
            this.pass.Text = "ZATWIERDŹ";
            this.pass.UseVisualStyleBackColor = true;
            this.pass.Click += new System.EventHandler(this.pass_Click);
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(332, 251);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(170, 22);
            this.year.TabIndex = 1;
            // 
            // lastForm
            // 
            this.lastForm.Location = new System.Drawing.Point(474, 314);
            this.lastForm.Name = "lastForm";
            this.lastForm.Size = new System.Drawing.Size(120, 40);
            this.lastForm.TabIndex = 2;
            this.lastForm.Text = "POWRÓT";
            this.lastForm.UseVisualStyleBackColor = true;
            this.lastForm.Click += new System.EventHandler(this.lastForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "ROK";
            // 
            // TaxPerPeriodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastForm);
            this.Controls.Add(this.year);
            this.Controls.Add(this.pass);
            this.Name = "TaxPerPeriodForm";
            this.Text = "TaxPerPeriodForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pass;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.Button lastForm;
        private System.Windows.Forms.Label label1;
    }
}