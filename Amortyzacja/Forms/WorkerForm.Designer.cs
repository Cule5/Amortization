namespace Amortyzacja.Forms
{
    partial class WorkerForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.registerHardware = new System.Windows.Forms.Button();
            this.registerSoftware = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.registerHardware);
            this.flowLayoutPanel1.Controls.Add(this.registerSoftware);
            this.flowLayoutPanel1.Controls.Add(this.logoutButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(262, 137);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(282, 145);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // registerHardware
            // 
            this.registerHardware.Location = new System.Drawing.Point(3, 3);
            this.registerHardware.Name = "registerHardware";
            this.registerHardware.Size = new System.Drawing.Size(279, 40);
            this.registerHardware.TabIndex = 0;
            this.registerHardware.Text = "REJESTRACJA SPRZĘTU";
            this.registerHardware.UseVisualStyleBackColor = true;
            this.registerHardware.Click += new System.EventHandler(this.registerHardware_Click);
            // 
            // registerSoftware
            // 
            this.registerSoftware.Location = new System.Drawing.Point(3, 49);
            this.registerSoftware.Name = "registerSoftware";
            this.registerSoftware.Size = new System.Drawing.Size(279, 40);
            this.registerSoftware.TabIndex = 1;
            this.registerSoftware.Text = "REJESTRACJA OPROGRAMOWANIA";
            this.registerSoftware.UseVisualStyleBackColor = true;
            this.registerSoftware.Click += new System.EventHandler(this.registerSoftware_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(3, 95);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(279, 40);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "WYLOGUJ";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "WorkerForm";
            this.Text = "WorkerForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button registerHardware;
        private System.Windows.Forms.Button registerSoftware;
        private System.Windows.Forms.Button logoutButton;
    }
}