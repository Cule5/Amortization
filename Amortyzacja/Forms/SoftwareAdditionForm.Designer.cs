namespace Amortyzacja.Forms
{
    partial class SoftwareAdditionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoftwareType = new System.Windows.Forms.TextBox();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.intSoftwarePaymentType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.datSubscriptionBeggining = new System.Windows.Forms.DateTimePicker();
            this.datSubscriptionEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rodzaj";
            // 
            // txtSoftwareType
            // 
            this.txtSoftwareType.Location = new System.Drawing.Point(201, 156);
            this.txtSoftwareType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoftwareType.Name = "txtSoftwareType";
            this.txtSoftwareType.Size = new System.Drawing.Size(132, 22);
            this.txtSoftwareType.TabIndex = 1;
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(201, 247);
            this.txtSerialNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(132, 22);
            this.txtSerialNumber.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numer Seryjny";
            // 
            // intSoftwarePaymentType
            // 
            this.intSoftwarePaymentType.FormattingEnabled = true;
            this.intSoftwarePaymentType.Items.AddRange(new object[] {
            "Subskrypcja",
            "Licencja"});
            this.intSoftwarePaymentType.Location = new System.Drawing.Point(192, 330);
            this.intSoftwarePaymentType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.intSoftwarePaymentType.Name = "intSoftwarePaymentType";
            this.intSoftwarePaymentType.Size = new System.Drawing.Size(160, 24);
            this.intSoftwarePaymentType.TabIndex = 4;
            this.intSoftwarePaymentType.SelectedIndexChanged += new System.EventHandler(this.intSoftwarePaymentType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 310);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rodzaj płatności";
            // 
            // datPurchaseDate
            // 
            this.datPurchaseDate.Location = new System.Drawing.Point(403, 156);
            this.datPurchaseDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datPurchaseDate.Name = "datPurchaseDate";
            this.datPurchaseDate.Size = new System.Drawing.Size(265, 22);
            this.datPurchaseDate.TabIndex = 6;
            // 
            // datSubscriptionBeggining
            // 
            this.datSubscriptionBeggining.Enabled = false;
            this.datSubscriptionBeggining.Location = new System.Drawing.Point(403, 220);
            this.datSubscriptionBeggining.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datSubscriptionBeggining.Name = "datSubscriptionBeggining";
            this.datSubscriptionBeggining.Size = new System.Drawing.Size(265, 22);
            this.datSubscriptionBeggining.TabIndex = 7;
            // 
            // datSubscriptionEnd
            // 
            this.datSubscriptionEnd.Enabled = false;
            this.datSubscriptionEnd.Location = new System.Drawing.Point(403, 279);
            this.datSubscriptionEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datSubscriptionEnd.Name = "datSubscriptionEnd";
            this.datSubscriptionEnd.Size = new System.Drawing.Size(265, 22);
            this.datSubscriptionEnd.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data zakupu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 197);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Początek subskrypcji";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(451, 254);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Koniec subskrypcji";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(403, 330);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(132, 22);
            this.txtPrice.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(447, 309);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cena";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(192, 404);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(447, 402);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(100, 28);
            this.btnPrevious.TabIndex = 15;
            this.btnPrevious.Text = "Powrót";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // SoftwareAdditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datSubscriptionEnd);
            this.Controls.Add(this.datSubscriptionBeggining);
            this.Controls.Add(this.datPurchaseDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.intSoftwarePaymentType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSerialNumber);
            this.Controls.Add(this.txtSoftwareType);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SoftwareAdditionForm";
            this.Text = "SoftwareAdditionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoftwareType;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox intSoftwarePaymentType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datPurchaseDate;
        private System.Windows.Forms.DateTimePicker datSubscriptionBeggining;
        private System.Windows.Forms.DateTimePicker datSubscriptionEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPrevious;
    }
}