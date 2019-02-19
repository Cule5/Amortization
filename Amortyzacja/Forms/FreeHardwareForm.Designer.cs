namespace Amortyzacja.Forms
{
    partial class FreeHardwareForm
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
            this.lastForm = new System.Windows.Forms.Button();
            this.freeHardware = new System.Windows.Forms.ListView();
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serialNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lastForm
            // 
            this.lastForm.Location = new System.Drawing.Point(325, 389);
            this.lastForm.Name = "lastForm";
            this.lastForm.Size = new System.Drawing.Size(120, 40);
            this.lastForm.TabIndex = 0;
            this.lastForm.Text = "POWRÓT";
            this.lastForm.UseVisualStyleBackColor = true;
            this.lastForm.Click += new System.EventHandler(this.lastForm_Click);
            // 
            // freeHardware
            // 
            this.freeHardware.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.type,
            this.serialNumber,
            this.price});
            this.freeHardware.Location = new System.Drawing.Point(138, 12);
            this.freeHardware.Name = "freeHardware";
            this.freeHardware.Size = new System.Drawing.Size(520, 350);
            this.freeHardware.TabIndex = 1;
            this.freeHardware.UseCompatibleStateImageBehavior = false;
            this.freeHardware.View = System.Windows.Forms.View.Details;
            // 
            // type
            // 
            this.type.Text = "TYP";
            this.type.Width = 117;
            // 
            // serialNumber
            // 
            this.serialNumber.Text = "NUMER SERYJNY";
            this.serialNumber.Width = 154;
            // 
            // price
            // 
            this.price.Text = "CENA";
            this.price.Width = 114;
            // 
            // FreeHardwareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.freeHardware);
            this.Controls.Add(this.lastForm);
            this.Name = "FreeHardwareForm";
            this.Text = "FreeHardwareForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lastForm;
        private System.Windows.Forms.ListView freeHardware;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader serialNumber;
        private System.Windows.Forms.ColumnHeader price;
    }
}