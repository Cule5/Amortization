namespace Amortyzacja.Forms
{
    partial class DeleteAssetsForm
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
            this.pesel = new System.Windows.Forms.TextBox();
            this.serialNumber = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.Button();
            this.lastForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pesel
            // 
            this.pesel.Location = new System.Drawing.Point(207, 276);
            this.pesel.Name = "pesel";
            this.pesel.Size = new System.Drawing.Size(170, 22);
            this.pesel.TabIndex = 0;
            // 
            // serialNumber
            // 
            this.serialNumber.Location = new System.Drawing.Point(464, 276);
            this.serialNumber.Name = "serialNumber";
            this.serialNumber.Size = new System.Drawing.Size(170, 22);
            this.serialNumber.TabIndex = 1;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(233, 364);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(120, 40);
            this.pass.TabIndex = 2;
            this.pass.Text = "ZATWIERDŹ";
            this.pass.UseVisualStyleBackColor = true;
            this.pass.Click += new System.EventHandler(this.pass_Click);
            // 
            // lastForm
            // 
            this.lastForm.Location = new System.Drawing.Point(485, 364);
            this.lastForm.Name = "lastForm";
            this.lastForm.Size = new System.Drawing.Size(120, 40);
            this.lastForm.TabIndex = 3;
            this.lastForm.Text = "POWRÓT";
            this.lastForm.UseVisualStyleBackColor = true;
            this.lastForm.Click += new System.EventHandler(this.lastForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "PESEL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "NUMER SERYJNY";
            // 
            // DeleteAssetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastForm);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.serialNumber);
            this.Controls.Add(this.pesel);
            this.Name = "DeleteAssetsForm";
            this.Text = "DeleteAssetsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pesel;
        private System.Windows.Forms.TextBox serialNumber;
        private System.Windows.Forms.Button pass;
        private System.Windows.Forms.Button lastForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}