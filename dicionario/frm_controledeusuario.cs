using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dicionario.Model;
using dicionario.Helpers;

namespace dicionario
{
    public partial class frm_controledeusuario : Form
    {
        public frm_controledeusuario()
        {
            InitializeComponent();
        }
        Usuario usr = new Usuario();
        CRUD c = new CRUD();
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void LimpaCampo() {
            txtEmail.Text = String.Empty;
            txtNome.Text = String.Empty; 
            txtTelefone.Text = String.Empty; 
            txtRSoc.Text = String.Empty; 
            txtCpf.Text = String.Empty; 
            txtContato.Text = String.Empty;
            txtusr.Text= String.Empty;
            txtpass.Text = String.Empty;
        }
        private void LimpaModel()
        {
            usr.contato = "";
            usr.usr = "";
            usr.tel = "";
            usr.nome = "";
            usr.rsocial = "";
            usr.permissao = "";
            usr.pass = "";
            usr.cpf = "";
            usr.email = "";
        }
        private void MostraModel()
        {
            txtEmail.Text = usr.email;
            txtNome.Text = usr.nome;
            txtTelefone.Text = usr.tel;
            txtRSoc.Text = usr.rsocial;
            txtCpf.Text = usr.cpf;
            txtContato.Text = usr.contato;
            txtusr.Text = usr.usr;
            txtpass.Text = usr.pass;
            comboPermissao.Text = usr.permissao;

            switch (usr.permissao)
            {
                case "ADM":
                    comboPermissao.SelectedIndex = 0;
                    break;
                case "EDT":
                    comboPermissao.SelectedIndex = 1;
                    break;
                default:
                    comboPermissao.SelectedIndex = 2;
                    break;
            }
        }
        private string converteAutorizacao()
        {
            switch (comboPermissao.SelectedIndex)
            {
                case 0:
                    return "ADM";
                    
                case 1:
                    return "EDT";
                    
                default:
                    return "USR";
                  
            }
        }
        private void btnincluir_Click(object sender, EventArgs e)
        { 
            //campos não nulos: usuario, senha, nivel de permissão, email e cpf
            if (txtusr.Text == "" || txtpass.Text == "" || txtEmail.Text==""||txtCpf.Text=="")
                InformaDiag.Erro("Campos obrigatórios não foram preenchidos.");
            else
            {
                bool edicao;
                if (usr.cpf != "")
                {
                    edicao = true;
                }
                else
                {
                    edicao = false;
                }
                usr.usr = txtusr.Text;
                usr.pass = txtpass.Text;

                usr.permissao = converteAutorizacao();
                usr.email = txtEmail.Text;
                usr.nome = txtNome.Text;
                usr.tel = txtTelefone.Text;
                usr.rsocial = txtRSoc.Text;
                usr.cpf = txtCpf.Text;
                usr.contato = txtContato.Text;
                if (edicao)
                {
                    c.UpdateLine(tabelasBd.USUARIOS, Usuario.ToListTabela(), usr.ToListValores(), "cpf='" + usr.cpf + "'");
                }
                else
                {
                    c.InsereLinha(tabelasBd.USUARIOS, Usuario.ToListTabela(), usr.ToListValores());
                }
                
                InformaDiag.InformaSalvo();
                LimpaCampo();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (InformaDiag.ConfirmaSN("Tem certeza?") == DialogResult.Yes)
            {
                c.ApagaLinha(tabelasBd.USUARIOS, "usr='" + txtusr.Text+"'");
            }
        }

        private void txtBuscaCpf_Click(object sender, EventArgs e)
        {
            List<Usuario> resultado = Usuario.ConverteObject(c.SelecionarTabela(tabelasBd.USUARIOS, Usuario.ToListTabela(),"cpf='"+txtCpf.Text+"'"));
            if (resultado.Count > 0)
            {
                usr = resultado.First();
                MostraModel();
            }
            else
                InformaDiag.Informa("Nenhum usuário encontrado.");
        }

        private void btnMostraSenha_MouseDown(object sender, MouseEventArgs e)
        {
            txtpass.UseSystemPasswordChar = false;
        }

        private void btnMostraSenha_MouseUp(object sender, MouseEventArgs e)
        {
            txtpass.UseSystemPasswordChar = true;
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            if (txtusr.Text != usr.usr || txtpass.Text != usr.pass || txtEmail.Text != usr.email || converteAutorizacao() != usr.permissao || txtCpf.Text != usr.cpf)
            {
                if (InformaDiag.ConfirmaSN("Existem dados não salvos que serão perdidos. \n Deseja continuar?") == DialogResult.Yes)
                {
                    LimpaCampo();
                    LimpaModel();
                }
        
            }
            
        }
    }
}
