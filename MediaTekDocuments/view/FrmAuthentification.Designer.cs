namespace MediaTekDocuments.view
{
    partial class FrmAuthentification
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
            this.btnConnecter = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblpwd = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConnecter
            // 
            this.btnConnecter.Location = new System.Drawing.Point(176, 121);
            this.btnConnecter.Name = "btnConnecter";
            this.btnConnecter.Size = new System.Drawing.Size(164, 36);
            this.btnConnecter.TabIndex = 0;
            this.btnConnecter.Text = "Se connecter";
            this.btnConnecter.UseVisualStyleBackColor = true;
            this.btnConnecter.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(12, 32);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(46, 16);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login :";
            // 
            // lblpwd
            // 
            this.lblpwd.AutoSize = true;
            this.lblpwd.Location = new System.Drawing.Point(12, 76);
            this.lblpwd.Name = "lblpwd";
            this.lblpwd.Size = new System.Drawing.Size(76, 16);
            this.lblpwd.TabIndex = 2;
            this.lblpwd.Text = "Password : ";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(99, 29);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(241, 22);
            this.txtLogin.TabIndex = 3;
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(99, 70);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.Size = new System.Drawing.Size(241, 22);
            this.txtpwd.TabIndex = 4;
            // 
            // FrmAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 175);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblpwd);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnConnecter);
            this.Name = "FrmAuthentification";
            this.Text = "Authentification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnecter;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblpwd;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtpwd;
    }
}