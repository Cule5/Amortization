namespace Amortyzacja.Forms
{
    partial class AmortizationForm
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
            this.serialNumber = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.Button();
            this.hardwareListView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lastForm
            // 
            this.lastForm.Location = new System.Drawing.Point(464, 398);
            this.lastForm.Name = "lastForm";
            this.lastForm.Size = new System.Drawing.Size(120, 40);
            this.lastForm.TabIndex = 0;
            this.lastForm.Text = "POWRÓT";
            this.lastForm.UseVisualStyleBackColor = true;
            this.lastForm.Click += new System.EventHandler(this.lastForm_Click);
            // 
            // serialNumber
            // 
            this.serialNumber.Location = new System.Drawing.Point(195, 370);
            this.serialNumber.Name = "serialNumber";
            this.serialNumber.Size = new System.Drawing.Size(150, 22);
            this.serialNumber.TabIndex = 1;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(448, 370);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(150, 22);
            this.year.TabIndex = 2;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(211, 398);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(120, 40);
            this.pass.TabIndex = 3;
            this.pass.Text = "ZATWIERDŹ";
            this.pass.UseVisualStyleBackColor = true;
            this.pass.Click += new System.EventHandler(this.pass_Click);
            // 
            // hardwareListView
            // 
            this.hardwareListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.number,
            this.type,
            this.price});
            this.hardwareListView.Location = new System.Drawing.Point(85, 12);
            this.hardwareListView.Name = "hardwareListView";
            this.hardwareListView.Size = new System.Drawing.Size(663, 296);
            this.hardwareListView.TabIndex = 4;
            this.hardwareListView.UseCompatibleStateImageBehavior = false;
            this.hardwareListView.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "NUMER SERYJNY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "ILOŚĆ LAT";
            // 
            // number
            // 
            this.number.Text = "NUMER_SERYJNY";
            this.number.Width = 216;
            // 
            // type
            // 
            this.type.Text = "TYP";
            this.type.Width = 204;
            // 
            // price
            // 
            this.price.Text = "CENA";
            this.price.Width = 205;
            // 
            // AmortizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hardwareListView);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.year);
            this.Controls.Add(this.serialNumber);
            this.Controls.Add(this.lastForm);
            this.Name = "AmortizationForm";
            this.Text = "AmortizationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lastForm;
        private System.Windows.Forms.TextBox serialNumber;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.Button pass;
        private System.Windows.Forms.ListView hardwareListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader number;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader price;
    }
}