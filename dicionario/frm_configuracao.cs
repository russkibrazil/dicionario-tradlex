using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace dicionario
{
    public partial class frm_configuracao : Form
    {
        FileStream acesso;
        const string nomeArquivo = "nude.dicio";
        public frm_configuracao()
        {
            InitializeComponent();
            
        }

        private void confOkButton_Click(object sender, EventArgs e)
        {
            string connName = this.txtBd.Text;

        }

        private void ResetPadroes()
        {
            txtHost.Text = "";
            txtPort.Text = "3306";
            txtBd.Text = "dicionario";
            txtUser.Text = "usuario";
            txtPass.Text = String.Empty;
        }
        private void homeButton_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Faz o form pai aparecer
            Owner.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_controledeusuario usr = new frm_controledeusuario();
            usr.ShowDialog();
            
        }

        private void frm_configuracao_Load(object sender, EventArgs e)
        {
            try
            {
                acesso = File.OpenRead(nomeArquivo);
            }
            catch (FileNotFoundException) { File.Create(nomeArquivo);
            }
        }
    }
}
