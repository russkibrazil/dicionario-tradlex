namespace dicionario
{
    partial class frm_controledeusuario
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
            this.txtusr = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRSoc = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.comboPermissao = new System.Windows.Forms.ComboBox();
            this.btnincluir = new System.Windows.Forms.Button();
            this.label_usr = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_tel = new System.Windows.Forms.Label();
            this.label_permit = new System.Windows.Forms.Label();
            this.label_social = new System.Windows.Forms.Label();
            this.label_CPF = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.txtBuscaCpf = new System.Windows.Forms.Button();
            this.btnMostraSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtusr
            // 
            this.txtusr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtusr.Location = new System.Drawing.Point(25, 38);
            this.txtusr.MaxLength = 15;
            this.txtusr.Name = "txtusr";
            this.txtusr.Size = new System.Drawing.Size(182, 26);
            this.txtusr.TabIndex = 0;
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtpass.Location = new System.Drawing.Point(24, 88);
            this.txtpass.MaxLength = 45;
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(183, 26);
            this.txtpass.TabIndex = 1;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTelefone.Location = new System.Drawing.Point(24, 238);
            this.txtTelefone.MaxLength = 13;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(183, 26);
            this.txtTelefone.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(24, 138);
            this.txtEmail.MaxLength = 45;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(183, 26);
            this.txtEmail.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNome.Location = new System.Drawing.Point(24, 188);
            this.txtNome.MaxLength = 45;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(183, 26);
            this.txtNome.TabIndex = 3;
            // 
            // txtRSoc
            // 
            this.txtRSoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRSoc.Location = new System.Drawing.Point(285, 88);
            this.txtRSoc.MaxLength = 11;
            this.txtRSoc.Name = "txtRSoc";
            this.txtRSoc.Size = new System.Drawing.Size(183, 26);
            this.txtRSoc.TabIndex = 7;
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCpf.Location = new System.Drawing.Point(285, 138);
            this.txtCpf.MaxLength = 45;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(183, 26);
            this.txtCpf.TabIndex = 6;
            // 
            // comboPermissao
            // 
            this.comboPermissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboPermissao.FormattingEnabled = true;
            this.comboPermissao.Items.AddRange(new object[] {
            "ADM",
            "EDT",
            "USR"});
            this.comboPermissao.Location = new System.Drawing.Point(285, 38);
            this.comboPermissao.Name = "comboPermissao";
            this.comboPermissao.Size = new System.Drawing.Size(183, 28);
            this.comboPermissao.TabIndex = 5;
            // 
            // btnincluir
            // 
            this.btnincluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnincluir.Location = new System.Drawing.Point(285, 273);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(85, 33);
            this.btnincluir.TabIndex = 9;
            this.btnincluir.Text = "Salvar";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // label_usr
            // 
            this.label_usr.AutoSize = true;
            this.label_usr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_usr.Location = new System.Drawing.Point(22, 17);
            this.label_usr.Name = "label_usr";
            this.label_usr.Size = new System.Drawing.Size(60, 18);
            this.label_usr.TabIndex = 9;
            this.label_usr.Text = "Usuário";
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_pass.Location = new System.Drawing.Point(22, 67);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(50, 18);
            this.label_pass.TabIndex = 10;
            this.label_pass.Text = "Senha";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_email.Location = new System.Drawing.Point(21, 117);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(50, 18);
            this.label_email.TabIndex = 11;
            this.label_email.Text = "E-mail";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_name.Location = new System.Drawing.Point(22, 167);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(49, 18);
            this.label_name.TabIndex = 12;
            this.label_name.Text = "Nome";
            // 
            // label_tel
            // 
            this.label_tel.AutoSize = true;
            this.label_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_tel.Location = new System.Drawing.Point(21, 217);
            this.label_tel.Name = "label_tel";
            this.label_tel.Size = new System.Drawing.Size(65, 18);
            this.label_tel.TabIndex = 13;
            this.label_tel.Text = "Telefone";
            // 
            // label_permit
            // 
            this.label_permit.AutoSize = true;
            this.label_permit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_permit.Location = new System.Drawing.Point(282, 17);
            this.label_permit.Name = "label_permit";
            this.label_permit.Size = new System.Drawing.Size(136, 18);
            this.label_permit.TabIndex = 14;
            this.label_permit.Text = "Nível de Permissão";
            this.label_permit.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_social
            // 
            this.label_social.AutoSize = true;
            this.label_social.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_social.Location = new System.Drawing.Point(282, 69);
            this.label_social.Name = "label_social";
            this.label_social.Size = new System.Drawing.Size(88, 18);
            this.label_social.TabIndex = 15;
            this.label_social.Text = "Rede Social";
            // 
            // label_CPF
            // 
            this.label_CPF.AutoSize = true;
            this.label_CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_CPF.Location = new System.Drawing.Point(282, 119);
            this.label_CPF.Name = "label_CPF";
            this.label_CPF.Size = new System.Drawing.Size(38, 18);
            this.label_CPF.TabIndex = 16;
            this.label_CPF.Text = "CPF";
            this.label_CPF.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(282, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Contato";
            // 
            // txtContato
            // 
            this.txtContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtContato.Location = new System.Drawing.Point(285, 190);
            this.txtContato.MaxLength = 45;
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(183, 26);
            this.txtContato.TabIndex = 8;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.Location = new System.Drawing.Point(380, 233);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(88, 33);
            this.BtnLimpar.TabIndex = 19;
            this.BtnLimpar.Text = "Remover";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovo.Location = new System.Drawing.Point(285, 233);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(85, 34);
            this.BtnNovo.TabIndex = 21;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // txtBuscaCpf
            // 
            this.txtBuscaCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaCpf.Location = new System.Drawing.Point(474, 140);
            this.txtBuscaCpf.Name = "txtBuscaCpf";
            this.txtBuscaCpf.Size = new System.Drawing.Size(76, 26);
            this.txtBuscaCpf.TabIndex = 22;
            this.txtBuscaCpf.Text = "Buscar";
            this.txtBuscaCpf.UseVisualStyleBackColor = true;
            this.txtBuscaCpf.Click += new System.EventHandler(this.txtBuscaCpf_Click);
            // 
            // btnMostraSenha
            // 
            this.btnMostraSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostraSenha.Location = new System.Drawing.Point(213, 88);
            this.btnMostraSenha.Name = "btnMostraSenha";
            this.btnMostraSenha.Size = new System.Drawing.Size(42, 26);
            this.btnMostraSenha.TabIndex = 23;
            this.btnMostraSenha.Text = "Ver";
            this.btnMostraSenha.UseVisualStyleBackColor = true;
            this.btnMostraSenha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMostraSenha_MouseDown);
            this.btnMostraSenha.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMostraSenha_MouseUp);
            // 
            // frm_controledeusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 331);
            this.Controls.Add(this.btnMostraSenha);
            this.Controls.Add(this.txtBuscaCpf);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContato);
            this.Controls.Add(this.label_CPF);
            this.Controls.Add(this.label_social);
            this.Controls.Add(this.label_permit);
            this.Controls.Add(this.label_tel);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.label_usr);
            this.Controls.Add(this.btnincluir);
            this.Controls.Add(this.comboPermissao);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtRSoc);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtusr);
            this.Name = "frm_controledeusuario";
            this.Text = "Controle de Usuários";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusr;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtRSoc;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.ComboBox comboPermissao;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.Label label_usr;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_tel;
        private System.Windows.Forms.Label label_permit;
        private System.Windows.Forms.Label label_social;
        private System.Windows.Forms.Label label_CPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button txtBuscaCpf;
        private System.Windows.Forms.Button btnMostraSenha;
    }
}