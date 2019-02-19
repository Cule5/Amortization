namespace Amortyzacja.Forms
{
    partial class BuyerForm
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
            this.addHardware = new System.Windows.Forms.Button();
            this.addSoftware = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.deleteSoftware = new System.Windows.Forms.Button();
            this.deleteHardware = new System.Windows.Forms.Button();
            this.freeSoftware = new System.Windows.Forms.Button();
            this.freeHardware = new System.Windows.Forms.Button();
            this.registerSoftware = new System.Windows.Forms.Button();
            this.registerHardware = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addHardware
            // 
            this.addHardware.Location = new System.Drawing.Point(3, 3);
            this.addHardware.Name = "addHardware";
            this.addHardware.Size = new System.Drawing.Size(277, 40);
            this.addHardware.TabIndex = 0;
            this.addHardware.Text = "DODAJ SPRZĘT";
            this.addHardware.UseVisualStyleBackColor = true;
            this.addHardware.Click += new System.EventHandler(this.addHardware_Click);
            // 
            // addSoftware
            // 
            this.addSoftware.Location = new System.Drawing.Point(3, 49);
            this.addSoftware.Name = "addSoftware";
            this.addSoftware.Size = new System.Drawing.Size(277, 40);
            this.addSoftware.TabIndex = 1;
            this.addSoftware.Text = "DODAJ OPROGRAMOWANIE";
            this.addSoftware.UseVisualStyleBackColor = true;
            this.addSoftware.Click += new System.EventHandler(this.addSoftware_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.addHardware);
            this.flowLayoutPanel1.Controls.Add(this.addSoftware);
            this.flowLayoutPanel1.Controls.Add(this.deleteSoftware);
            this.flowLayoutPanel1.Controls.Add(this.deleteHardware);
            this.flowLayoutPanel1.Controls.Add(this.freeSoftware);
            this.flowLayoutPanel1.Controls.Add(this.freeHardware);
            this.flowLayoutPanel1.Controls.Add(this.registerSoftware);
            this.flowLayoutPanel1.Controls.Add(this.registerHardware);
            this.flowLayoutPanel1.Controls.Add(this.logoutButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(264, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(281, 417);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // deleteSoftware
            // 
            this.deleteSoftware.Location = new System.Drawing.Point(3, 95);
            this.deleteSoftware.Name = "deleteSoftware";
            this.deleteSoftware.Size = new System.Drawing.Size(277, 40);
            this.deleteSoftware.TabIndex = 9;
            this.deleteSoftware.Text = "USUŃ OPROGRAMOWANIE";
            this.deleteSoftware.UseVisualStyleBackColor = true;
            this.deleteSoftware.Click += new System.EventHandler(this.deleteSoftware_Click);
            // 
            // deleteHardware
            // 
            this.deleteHardware.Location = new System.Drawing.Point(3, 141);
            this.deleteHardware.Name = "deleteHardware";
            this.deleteHardware.Size = new System.Drawing.Size(277, 40);
            this.deleteHardware.TabIndex = 10;
            this.deleteHardware.Text = "USUŃ SPRZĘT";
            this.deleteHardware.UseVisualStyleBackColor = true;
            this.deleteHardware.Click += new System.EventHandler(this.deleteHardware_Click);
            // 
            // freeSoftware
            // 
            this.freeSoftware.Location = new System.Drawing.Point(3, 187);
            this.freeSoftware.Name = "freeSoftware";
            this.freeSoftware.Size = new System.Drawing.Size(277, 40);
            this.freeSoftware.TabIndex = 8;
            this.freeSoftware.Text = "WOLNE OPROGRAMOWANIE";
            this.freeSoftware.UseVisualStyleBackColor = true;
            this.freeSoftware.Click += new System.EventHandler(this.freeSoftware_Click);
            // 
            // freeHardware
            // 
            this.freeHardware.Location = new System.Drawing.Point(3, 233);
            this.freeHardware.Name = "freeHardware";
            this.freeHardware.Size = new System.Drawing.Size(277, 40);
            this.freeHardware.TabIndex = 7;
            this.freeHardware.Text = "WOLNY SPRZĘT";
            this.freeHardware.UseVisualStyleBackColor = true;
            this.freeHardware.Click += new System.EventHandler(this.freeHardware_Click);
            // 
            // registerSoftware
            // 
            this.registerSoftware.Location = new System.Drawing.Point(3, 279);
            this.registerSoftware.Name = "registerSoftware";
            this.registerSoftware.Size = new System.Drawing.Size(277, 40);
            this.registerSoftware.TabIndex = 4;
            this.registerSoftware.Text = "REJESTRACJA OPROGRAMOWANIA";
            this.registerSoftware.UseVisualStyleBackColor = true;
            this.registerSoftware.Click += new System.EventHandler(this.registerSoftware_Click);
            // 
            // registerHardware
            // 
            this.registerHardware.Location = new System.Drawing.Point(3, 325);
            this.registerHardware.Name = "registerHardware";
            this.registerHardware.Size = new System.Drawing.Size(277, 40);
            this.registerHardware.TabIndex = 3;
            this.registerHardware.Text = "REJESTRACJA SPRZĘTU";
            this.registerHardware.UseVisualStyleBackColor = true;
            this.registerHardware.Click += new System.EventHandler(this.registerHardware_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(3, 371);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(277, 40);
            this.logoutButton.TabIndex = 10;
            this.logoutButton.Text = "WYLOGUJ";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // BuyerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "BuyerForm";
            this.Text = "BuyerForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addHardware;
        private System.Windows.Forms.Button addSoftware;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button registerHardware;
        private System.Windows.Forms.Button registerSoftware;
        private System.Windows.Forms.Button freeHardware;
        private System.Windows.Forms.Button freeSoftware;
        private System.Windows.Forms.Button deleteSoftware;
        private System.Windows.Forms.Button deleteHardware;
        private System.Windows.Forms.Button logoutButton;
    }
}