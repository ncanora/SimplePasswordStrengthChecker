namespace PasswordStrengthChecker
{
    partial class AboutMe
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
            label1 = new Label();
            label2 = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(100, 9);
            label1.Name = "label1";
            label1.Size = new Size(113, 47);
            label1.TabIndex = 0;
            label1.Text = "Thank You";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += btnClose_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(-1, 56);
            label2.Name = "label2";
            label2.Size = new Size(328, 25);
            label2.TabIndex = 1;
            label2.Text = "Hope you enjoyed the app - Made by @ncanora on github";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.ControlLight;
            btnClose.BackgroundImageLayout = ImageLayout.Center;
            btnClose.Location = new Point(118, 84);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // AboutMe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 119);
            Controls.Add(btnClose);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AboutMe";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AboutMe";
            Load += AboutMe_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnClose;
    }
}