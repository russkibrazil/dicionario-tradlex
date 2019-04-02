namespace dicionario
{
    partial class frm_conjuga
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnDescarta = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPreterito = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPresente = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFuturo = new System.Windows.Forms.TextBox();
            this.txtCPassado = new System.Windows.Forms.TextBox();
            this.txtCPresente = new System.Windows.Forms.TextBox();
            this.txtCFuturo = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(692, 44);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(96, 31);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDescarta
            // 
            this.btnDescarta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescarta.Location = new System.Drawing.Point(692, 113);
            this.btnDescarta.Name = "btnDescarta";
            this.btnDescarta.Size = new System.Drawing.Size(96, 31);
            this.btnDescarta.TabIndex = 16;
            this.btnDescarta.Text = "Descartar";
            this.btnDescarta.UseVisualStyleBackColor = true;
            this.btnDescarta.Click += new System.EventHandler(this.btnDescarta_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(674, 484);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtCPassado);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtPreterito);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(666, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Passado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Construção";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Exemplos";
            // 
            // txtPreterito
            // 
            this.txtPreterito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreterito.Location = new System.Drawing.Point(209, 34);
            this.txtPreterito.Multiline = true;
            this.txtPreterito.Name = "txtPreterito";
            this.txtPreterito.Size = new System.Drawing.Size(450, 410);
            this.txtPreterito.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtCPresente);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtPresente);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(666, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Presente";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Construção";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Exemplos";
            // 
            // txtPresente
            // 
            this.txtPresente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresente.Location = new System.Drawing.Point(210, 35);
            this.txtPresente.Multiline = true;
            this.txtPresente.Name = "txtPresente";
            this.txtPresente.Size = new System.Drawing.Size(450, 410);
            this.txtPresente.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtCFuturo);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.txtFuturo);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(666, 451);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Futuro";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Construção";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Exemplos";
            // 
            // txtFuturo
            // 
            this.txtFuturo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuturo.Location = new System.Drawing.Point(210, 35);
            this.txtFuturo.Multiline = true;
            this.txtFuturo.Name = "txtFuturo";
            this.txtFuturo.Size = new System.Drawing.Size(450, 410);
            this.txtFuturo.TabIndex = 6;
            // 
            // txtCPassado
            // 
            this.txtCPassado.Location = new System.Drawing.Point(10, 34);
            this.txtCPassado.Multiline = true;
            this.txtCPassado.Name = "txtCPassado";
            this.txtCPassado.Size = new System.Drawing.Size(190, 410);
            this.txtCPassado.TabIndex = 23;
            // 
            // txtCPresente
            // 
            this.txtCPresente.Location = new System.Drawing.Point(6, 31);
            this.txtCPresente.Multiline = true;
            this.txtCPresente.Name = "txtCPresente";
            this.txtCPresente.Size = new System.Drawing.Size(190, 410);
            this.txtCPresente.TabIndex = 23;
            // 
            // txtCFuturo
            // 
            this.txtCFuturo.Location = new System.Drawing.Point(6, 35);
            this.txtCFuturo.Multiline = true;
            this.txtCFuturo.Name = "txtCFuturo";
            this.txtCFuturo.Size = new System.Drawing.Size(190, 410);
            this.txtCFuturo.TabIndex = 21;
            // 
            // frm_conjuga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 502);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnDescarta);
            this.Controls.Add(this.btnSalvar);
            this.MinimumSize = new System.Drawing.Size(820, 540);
            this.Name = "frm_conjuga";
            this.Text = "Formulário de conjugações";
            this.Load += new System.EventHandler(this.frm_conjuga_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnDescarta;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPreterito;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPresente;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFuturo;
        private System.Windows.Forms.TextBox txtCPassado;
        private System.Windows.Forms.TextBox txtCPresente;
        private System.Windows.Forms.TextBox txtCFuturo;
    }
}