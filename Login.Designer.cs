
namespace LoginRegister
{
    partial class Login
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
            this.user = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.Button();
            this.crt = new System.Windows.Forms.Button();
            this.usert = new System.Windows.Forms.TextBox();
            this.passt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(118, 93);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(55, 13);
            this.user.TabIndex = 0;
            this.user.Text = "Username";
            this.user.Click += new System.EventHandler(this.label1_Click);
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Location = new System.Drawing.Point(121, 126);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(53, 13);
            this.pass.TabIndex = 1;
            this.pass.Text = "Password";
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(177, 177);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(75, 23);
            this.log.TabIndex = 2;
            this.log.Text = "Login";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // crt
            // 
            this.crt.Location = new System.Drawing.Point(124, 217);
            this.crt.Name = "crt";
            this.crt.Size = new System.Drawing.Size(215, 27);
            this.crt.TabIndex = 3;
            this.crt.Text = "Don\'t Have Account? Create";
            this.crt.UseVisualStyleBackColor = true;
            this.crt.Click += new System.EventHandler(this.crt_Click);
            // 
            // usert
            // 
            this.usert.Location = new System.Drawing.Point(197, 93);
            this.usert.Name = "usert";
            this.usert.Size = new System.Drawing.Size(100, 20);
            this.usert.TabIndex = 4;
            // 
            // passt
            // 
            this.passt.Location = new System.Drawing.Point(197, 126);
            this.passt.Name = "passt";
            this.passt.Size = new System.Drawing.Size(100, 20);
            this.passt.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 354);
            this.Controls.Add(this.passt);
            this.Controls.Add(this.usert);
            this.Controls.Add(this.crt);
            this.Controls.Add(this.log);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Button crt;
        private System.Windows.Forms.TextBox usert;
        private System.Windows.Forms.TextBox passt;
    }
}