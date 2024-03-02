namespace PasswordStrengthChecker
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            lblTitle = new Label();
            txtPassword = new TextBox();
            btnClear = new Button();
            lblStrength = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F);
            lblTitle.Location = new Point(69, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(266, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Check Your Password Strength";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(21, 71);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(362, 23);
            txtPassword.TabIndex = 1;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(165, 100);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblStrength
            // 
            lblStrength.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStrength.Location = new Point(21, 51);
            lblStrength.Name = "lblStrength";
            lblStrength.Size = new Size(362, 19);
            lblStrength.TabIndex = 3;
            lblStrength.Text = "Strength: UNKNOWN";
            lblStrength.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(355, 109);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(63, 15);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "About Me ";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 133);
            Controls.Add(linkLabel1);
            Controls.Add(lblStrength);
            Controls.Add(btnClear);
            Controls.Add(txtPassword);
            Controls.Add(lblTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(443, 172);
            MinimumSize = new Size(443, 172);
            Name = "Main";
            Text = "Password Strength Checker";
            Load += Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtPassword;
        private Button btnClear;
        private Label lblStrength;
        private LinkLabel linkLabel1;
    }
}
