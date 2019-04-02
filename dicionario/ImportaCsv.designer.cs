﻿namespace dicionario
{
    partial class frmImportaCsv
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
            this.AbreArquivoDialog = new System.Windows.Forms.OpenFileDialog();
            this.BtnProcura = new System.Windows.Forms.Button();
            this.LblArquivo = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnGrava = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCancela = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ComboTable = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listErros = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AbreArquivoDialog
            // 
            this.AbreArquivoDialog.DefaultExt = "csv";
            this.AbreArquivoDialog.Filter = "Arquivos de Valores Separados por Vírgula (CSV)|*.csv";
            this.AbreArquivoDialog.ReadOnlyChecked = true;
            // 
            // BtnProcura
            // 
            this.BtnProcura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProcura.Location = new System.Drawing.Point(450, 10);
            this.BtnProcura.Name = "BtnProcura";
            this.BtnProcura.Size = new System.Drawing.Size(108, 27);
            this.BtnProcura.TabIndex = 0;
            this.BtnProcura.Text = "Procurar";
            this.BtnProcura.UseVisualStyleBackColor = true;
            this.BtnProcura.Click += new System.EventHandler(this.BtnProcura_Click);
            // 
            // LblArquivo
            // 
            this.LblArquivo.AutoSize = true;
            this.LblArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblArquivo.Location = new System.Drawing.Point(85, 10);
            this.LblArquivo.Name = "LblArquivo";
            this.LblArquivo.Size = new System.Drawing.Size(192, 17);
            this.LblArquivo.TabIndex = 1;
            this.LblArquivo.TabStop = true;
            this.LblArquivo.Text = "Nenhum arquivo selecionado";
            this.LblArquivo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblArquivo_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(755, 313);
            this.dataGridView1.TabIndex = 2;
            // 
            // BtnGrava
            // 
            this.BtnGrava.Enabled = false;
            this.BtnGrava.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGrava.Location = new System.Drawing.Point(564, 42);
            this.BtnGrava.Name = "BtnGrava";
            this.BtnGrava.Size = new System.Drawing.Size(75, 61);
            this.BtnGrava.TabIndex = 3;
            this.BtnGrava.Text = "Enviar para banco";
            this.BtnGrava.UseVisualStyleBackColor = true;
            this.BtnGrava.Click += new System.EventHandler(this.BtnGrava_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lendo de";
            // 
            // BtnCancela
            // 
            this.BtnCancela.Enabled = false;
            this.BtnCancela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancela.Location = new System.Drawing.Point(450, 43);
            this.BtnCancela.Name = "BtnCancela";
            this.BtnCancela.Size = new System.Drawing.Size(108, 60);
            this.BtnCancela.TabIndex = 5;
            this.BtnCancela.Text = "Descartar importação";
            this.BtnCancela.UseVisualStyleBackColor = true;
            this.BtnCancela.Click += new System.EventHandler(this.BtnCancela_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.Enabled = false;
            this.BtnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.Location = new System.Drawing.Point(564, 10);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 27);
            this.BtnStart.TabIndex = 6;
            this.BtnStart.Text = "Iniciar Leitura";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(645, 10);
            this.progressBar1.MarqueeAnimationSpeed = 0;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(122, 27);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 7;
            // 
            // ComboTable
            // 
            this.ComboTable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboTable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboTable.FormattingEnabled = true;
            this.ComboTable.Items.AddRange(new object[] {
            "Palavra",
            "Classe Gramatical",
            "Rubrica",
            "Referência"});
            this.ComboTable.Location = new System.Drawing.Point(88, 30);
            this.ComboTable.Name = "ComboTable";
            this.ComboTable.Size = new System.Drawing.Size(189, 21);
            this.ComboTable.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Inserir em";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Erros";
            // 
            // listErros
            // 
            this.listErros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listErros.FormattingEnabled = true;
            this.listErros.ItemHeight = 16;
            this.listErros.Location = new System.Drawing.Point(12, 441);
            this.listErros.Name = "listErros";
            this.listErros.Size = new System.Drawing.Size(755, 180);
            this.listErros.TabIndex = 11;
            // 
            // frmImportaCsv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 632);
            this.Controls.Add(this.listErros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboTable);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.BtnCancela);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGrava);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LblArquivo);
            this.Controls.Add(this.BtnProcura);
            this.MinimumSize = new System.Drawing.Size(800, 670);
            this.Name = "frmImportaCsv";
            this.Text = "ImportaCsv";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog AbreArquivoDialog;
        private System.Windows.Forms.Button BtnProcura;
        private System.Windows.Forms.LinkLabel LblArquivo;
        private System.Windows.Forms.Button BtnGrava;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCancela;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox ComboTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listErros;
    }
}