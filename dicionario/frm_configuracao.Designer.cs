namespace dicionario
{
    partial class frm_configuracao
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
            this.txtBd = new System.Windows.Forms.TextBox();
            this.ConnNameLabel = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.HostnameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.pswdLabel = new System.Windows.Forms.Label();
            this.usrNameLabel = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.confOkButton = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtBd
            // 
            this.txtBd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBd.Location = new System.Drawing.Point(12, 169);
            this.txtBd.Name = "txtBd";
            this.txtBd.Size = new System.Drawing.Size(482, 26);
            this.txtBd.TabIndex = 0;
            // 
            // ConnNameLabel
            // 
            this.ConnNameLabel.AutoSize = true;
            this.ConnNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnNameLabel.Location = new System.Drawing.Point(12, 146);
            this.ConnNameLabel.Name = "ConnNameLabel";
            this.ConnNameLabel.Size = new System.Drawing.Size(140, 20);
            this.ConnNameLabel.TabIndex = 1;
            this.ConnNameLabel.Text = "Nome da Conexão";
            // 
            // txtHost
            // 
            this.txtHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHost.Location = new System.Drawing.Point(12, 117);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(482, 26);
            this.txtHost.TabIndex = 2;
            // 
            // HostnameLabel
            // 
            this.HostnameLabel.AutoSize = true;
            this.HostnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HostnameLabel.Location = new System.Drawing.Point(9, 94);
            this.HostnameLabel.Name = "HostnameLabel";
            this.HostnameLabel.Size = new System.Drawing.Size(83, 20);
            this.HostnameLabel.TabIndex = 3;
            this.HostnameLabel.Text = "Hostname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(513, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Port";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(243, 231);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(251, 26);
            this.txtPass.TabIndex = 9;
            // 
            // pswdLabel
            // 
            this.pswdLabel.AutoSize = true;
            this.pswdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pswdLabel.Location = new System.Drawing.Point(239, 208);
            this.pswdLabel.Name = "pswdLabel";
            this.pswdLabel.Size = new System.Drawing.Size(56, 20);
            this.pswdLabel.TabIndex = 8;
            this.pswdLabel.Text = "Senha";
            // 
            // usrNameLabel
            // 
            this.usrNameLabel.AutoSize = true;
            this.usrNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrNameLabel.Location = new System.Drawing.Point(8, 208);
            this.usrNameLabel.Name = "usrNameLabel";
            this.usrNameLabel.Size = new System.Drawing.Size(83, 20);
            this.usrNameLabel.TabIndex = 7;
            this.usrNameLabel.Text = "Username";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(13, 231);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(206, 26);
            this.txtUser.TabIndex = 6;
            // 
            // confOkButton
            // 
            this.confOkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confOkButton.Location = new System.Drawing.Point(542, 228);
            this.confOkButton.Name = "confOkButton";
            this.confOkButton.Size = new System.Drawing.Size(75, 29);
            this.confOkButton.TabIndex = 10;
            this.confOkButton.Text = "Ok";
            this.confOkButton.UseVisualStyleBackColor = true;
            this.confOkButton.Click += new System.EventHandler(this.confOkButton_Click);
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(517, 117);
            this.txtPort.Mask = "90000";
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 26);
            this.txtPort.TabIndex = 24;
            this.txtPort.ValidatingType = typeof(int);
            // 
            // frm_configuracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 290);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.confOkButton);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.pswdLabel);
            this.Controls.Add(this.usrNameLabel);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HostnameLabel);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.ConnNameLabel);
            this.Controls.Add(this.txtBd);
            this.Name = "frm_configuracao";
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.frm_configuracao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBd;
        private System.Windows.Forms.Label ConnNameLabel;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label HostnameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label pswdLabel;
        private System.Windows.Forms.Label usrNameLabel;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button confOkButton;
        private System.Windows.Forms.MaskedTextBox txtPort;
    }
}