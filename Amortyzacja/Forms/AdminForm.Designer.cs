namespace Amortyzacja.Forms
{
    partial class AdminForm
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
            this.occupiedHardware = new System.Windows.Forms.Button();
            this.occupiedSoftware = new System.Windows.Forms.Button();
            this.freeHardware = new System.Windows.Forms.Button();
            this.assetsCosts = new System.Windows.Forms.Button();
            this.registerHardware = new System.Windows.Forms.Button();
            this.registerSoftware = new System.Windows.Forms.Button();
            this.freeSoftware = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tax = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // occupiedHardware
            // 
            this.occupiedHardware.Location = new System.Drawing.Point(3, 49);
            this.occupiedHardware.Name = "occupiedHardware";
            this.occupiedHardware.Size = new System.Drawing.Size(283, 40);
            this.occupiedHardware.TabIndex = 0;
            this.occupiedHardware.Text = "ZAJĘTY SPRZĘT";
            this.occupiedHardware.UseVisualStyleBackColor = true;
            this.occupiedHardware.Click += new System.EventHandler(this.occupiedHardware_Click);
            // 
            // occupiedSoftware
            // 
            this.occupiedSoftware.Location = new System.Drawing.Point(3, 95);
            this.occupiedSoftware.Name = "occupiedSoftware";
            this.occupiedSoftware.Size = new System.Drawing.Size(283, 40);
            this.occupiedSoftware.TabIndex = 1;
            this.occupiedSoftware.Text = "ZAJĘTE OPROGRAMOWANIE";
            this.occupiedSoftware.UseVisualStyleBackColor = true;
            this.occupiedSoftware.Click += new System.EventHandler(this.occupiedSoftware_Click);
            // 
            // freeHardware
            // 
            this.freeHardware.Location = new System.Drawing.Point(3, 3);
            this.freeHardware.Name = "freeHardware";
            this.freeHardware.Size = new System.Drawing.Size(283, 40);
            this.freeHardware.TabIndex = 2;
            this.freeHardware.Text = "WOLNY SPRZĘT";
            this.freeHardware.UseVisualStyleBackColor = true;
            this.freeHardware.Click += new System.EventHandler(this.freeHardware_Click);
            // 
            // assetsCosts
            // 
            this.assetsCosts.Location = new System.Drawing.Point(3, 233);
            this.assetsCosts.Name = "assetsCosts";
            this.assetsCosts.Size = new System.Drawing.Size(283, 40);
            this.assetsCosts.TabIndex = 3;
            this.assetsCosts.Text = "KOSZTY ZASOBÓW";
            this.assetsCosts.UseVisualStyleBackColor = true;
            this.assetsCosts.Click += new System.EventHandler(this.assetsCosts_Click);
            // 
            // registerHardware
            // 
            this.registerHardware.Location = new System.Drawing.Point(3, 279);
            this.registerHardware.Name = "registerHardware";
            this.registerHardware.Size = new System.Drawing.Size(283, 40);
            this.registerHardware.TabIndex = 5;
            this.registerHardware.Text = "REJESTRACJA SPRZĘTU";
            this.registerHardware.UseVisualStyleBackColor = true;
            this.registerHardware.Click += new System.EventHandler(this.registerHardware_Click);
            // 
            // registerSoftware
            // 
            this.registerSoftware.Location = new System.Drawing.Point(3, 325);
            this.registerSoftware.Name = "registerSoftware";
            this.registerSoftware.Size = new System.Drawing.Size(283, 40);
            this.registerSoftware.TabIndex = 6;
            this.registerSoftware.Text = "REJESTRACJA OPROGRAMOWANIA";
            this.registerSoftware.UseVisualStyleBackColor = true;
            this.registerSoftware.Click += new System.EventHandler(this.registerSoftware_Click);
            // 
            // freeSoftware
            // 
            this.freeSoftware.Location = new System.Drawing.Point(3, 141);
            this.freeSoftware.Name = "freeSoftware";
            this.freeSoftware.Size = new System.Drawing.Size(283, 40);
            this.freeSoftware.TabIndex = 7;
            this.freeSoftware.Text = "WOLNE OPROGRAMOWANIE";
            this.freeSoftware.UseVisualStyleBackColor = true;
            this.freeSoftware.Click += new System.EventHandler(this.freeSoftware_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.freeHardware);
            this.flowLayoutPanel1.Controls.Add(this.occupiedHardware);
            this.flowLayoutPanel1.Controls.Add(this.occupiedSoftware);
            this.flowLayoutPanel1.Controls.Add(this.freeSoftware);
            this.flowLayoutPanel1.Controls.Add(this.tax);
            this.flowLayoutPanel1.Controls.Add(this.assetsCosts);
            this.flowLayoutPanel1.Controls.Add(this.registerHardware);
            this.flowLayoutPanel1.Controls.Add(this.registerSoftware);
            this.flowLayoutPanel1.Controls.Add(this.logoutButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(260, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(286, 426);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // tax
            // 
            this.tax.Location = new System.Drawing.Point(3, 187);
            this.tax.Name = "tax";
            this.tax.Size = new System.Drawing.Size(283, 40);
            this.tax.TabIndex = 10;
            this.tax.Text = "PODATEK ZA OKRES";
            this.tax.UseVisualStyleBackColor = true;
            this.tax.Click += new System.EventHandler(this.tax_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(3, 371);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(283, 40);
            this.logoutButton.TabIndex = 11;
            this.logoutButton.Text = "WYLOGUJ";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button occupiedHardware;
        private System.Windows.Forms.Button occupiedSoftware;
        private System.Windows.Forms.Button freeHardware;
        private System.Windows.Forms.Button assetsCosts;
        private System.Windows.Forms.Button registerHardware;
        private System.Windows.Forms.Button registerSoftware;
        private System.Windows.Forms.Button freeSoftware;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button tax;
        private System.Windows.Forms.Button logoutButton;
    }
}