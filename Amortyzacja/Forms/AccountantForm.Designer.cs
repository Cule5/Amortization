namespace Amortyzacja
{
    partial class AccountantForm
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
            this.addWorker = new System.Windows.Forms.Button();
            this.deleteWorker = new System.Windows.Forms.Button();
            this.amortization = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.registerHardware = new System.Windows.Forms.Button();
            this.registerSoftware = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addWorker
            // 
            this.addWorker.Location = new System.Drawing.Point(3, 3);
            this.addWorker.Name = "addWorker";
            this.addWorker.Size = new System.Drawing.Size(294, 40);
            this.addWorker.TabIndex = 0;
            this.addWorker.Text = "DODAJ PRACOWNIKA";
            this.addWorker.UseVisualStyleBackColor = true;
            this.addWorker.Click += new System.EventHandler(this.addWorker_Click);
            // 
            // deleteWorker
            // 
            this.deleteWorker.Location = new System.Drawing.Point(3, 49);
            this.deleteWorker.Name = "deleteWorker";
            this.deleteWorker.Size = new System.Drawing.Size(294, 40);
            this.deleteWorker.TabIndex = 1;
            this.deleteWorker.Text = "USUŃ PRACOWNIKA";
            this.deleteWorker.UseVisualStyleBackColor = true;
            this.deleteWorker.Click += new System.EventHandler(this.deleteWorker_Click);
            // 
            // amortization
            // 
            this.amortization.Location = new System.Drawing.Point(3, 95);
            this.amortization.Name = "amortization";
            this.amortization.Size = new System.Drawing.Size(294, 40);
            this.amortization.TabIndex = 4;
            this.amortization.Text = "WYSOKOŚĆ AMORTYZACJI";
            this.amortization.UseVisualStyleBackColor = true;
            this.amortization.Click += new System.EventHandler(this.amortization_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(3, 233);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(294, 40);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Text = "WYLOGUJ";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.addWorker);
            this.flowLayoutPanel1.Controls.Add(this.deleteWorker);
            this.flowLayoutPanel1.Controls.Add(this.amortization);
            this.flowLayoutPanel1.Controls.Add(this.registerHardware);
            this.flowLayoutPanel1.Controls.Add(this.registerSoftware);
            this.flowLayoutPanel1.Controls.Add(this.logoutButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(266, 64);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(297, 310);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // registerHardware
            // 
            this.registerHardware.Location = new System.Drawing.Point(3, 141);
            this.registerHardware.Name = "registerHardware";
            this.registerHardware.Size = new System.Drawing.Size(294, 40);
            this.registerHardware.TabIndex = 5;
            this.registerHardware.Text = "REJESTRACJA SPRZĘTU";
            this.registerHardware.UseVisualStyleBackColor = true;
            this.registerHardware.Click += new System.EventHandler(this.registerHardware_Click);
            // 
            // registerSoftware
            // 
            this.registerSoftware.Location = new System.Drawing.Point(3, 187);
            this.registerSoftware.Name = "registerSoftware";
            this.registerSoftware.Size = new System.Drawing.Size(294, 40);
            this.registerSoftware.TabIndex = 6;
            this.registerSoftware.Text = "REJESTRACJA OPROGRAMOWANIA";
            this.registerSoftware.UseVisualStyleBackColor = true;
            this.registerSoftware.Click += new System.EventHandler(this.registerSoftware_Click);
            // 
            // AccountantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "AccountantForm";
            this.Text = "AccountantForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addWorker;
        private System.Windows.Forms.Button deleteWorker;
        private System.Windows.Forms.Button amortization;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button registerHardware;
        private System.Windows.Forms.Button registerSoftware;
    }
}