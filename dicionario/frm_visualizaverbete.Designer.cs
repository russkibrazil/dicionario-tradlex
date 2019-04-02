namespace dicionario
{
    partial class frm_visualizaverbete
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblLema = new System.Windows.Forms.Label();
            this.TrvPalavra = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(539, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "Contato";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(642, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 36);
            this.button3.TabIndex = 5;
            this.button3.Text = "Ajuda";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lblLema
            // 
            this.lblLema.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLema.Location = new System.Drawing.Point(39, 42);
            this.lblLema.Name = "lblLema";
            this.lblLema.Size = new System.Drawing.Size(248, 53);
            this.lblLema.TabIndex = 6;
            this.lblLema.Text = "Palavra";
            // 
            // TrvPalavra
            // 
            this.TrvPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrvPalavra.Location = new System.Drawing.Point(48, 98);
            this.TrvPalavra.Name = "TrvPalavra";
            this.TrvPalavra.Size = new System.Drawing.Size(679, 341);
            this.TrvPalavra.TabIndex = 9;
            // 
            // frm_visualizaverbete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 451);
            this.Controls.Add(this.TrvPalavra);
            this.Controls.Add(this.lblLema);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "frm_visualizaverbete";
            this.Text = "Visualização do Verbete";
            this.Load += new System.EventHandler(this.frm_visualizaverbete_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblLema;
        private System.Windows.Forms.TreeView TrvPalavra;
    }
}