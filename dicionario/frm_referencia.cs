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
    public partial class frm_referencia : Form
    {
        Referencia referencia = new Referencia();
        CRUD c = new CRUD();
        List<Referencia> resultado = new List<Referencia>();
        int p = 0;
        public frm_referencia()
        {
            InitializeComponent();
        }
        private void LimpaCampos() {
            txtAno.Text = "";
            txtDesc.Text = "";
            txtAutor.Text = "";
            txtCod.Text = "";
        }
        private void LimpaModel()
        {
            referencia.descricao = "";
            referencia.ano = 0;
            referencia.autor = "";
            referencia.Cod = "";
            referencia.id = -1;
            txtCod.ReadOnly = false;
        }
        private void MostraModel() {
            txtDesc.Text = referencia.descricao;
            txtAno.Text = referencia.ano.ToString();
            txtAutor.Text = referencia.autor;
            txtCod.Text = referencia.Cod.ToString();
        }
        private bool verificaCampos()
        {
            if (txtAutor.Text == "" || txtAno.Text == "")
                return true;
            return false;
        }
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            resultado = Referencia.ConverteObject(c.SelecionarTabela(tabelasBd.REFERENCIAS, Referencia.ToListTabela(true), "Cod='" + txtCodPSQ.Text + "'"));
            if (resultado.Count < 1) {
                InformaDiag.Informa("Nenhum resultado encontrado.");
                return;
            }
            referencia = resultado.First();
            MostraModel();
            if (resultado.Count > 1)
            {
                btnAnt.Visible = true;
                btnProx.Visible = true;
            }
            p = 0;
            txtCod.ReadOnly = true;
        }
        private void btnAnt_Click (object sender, EventArgs e)
        {
            if (p > 0)
            {
                referencia = resultado.ElementAt(--p);
                MostraModel();
            }
        }

        private void btnProx_Click (object sender, EventArgs e)
        {
            if(p < resultado.Count)
            {
                referencia = resultado.ElementAt(++p);
                MostraModel();
            }
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text != referencia.descricao || txtAno.Text != referencia.ano.ToString() || txtAutor.Text != referencia.autor)
            {
                if (InformaDiag.ConfirmaSN("Existem dados não salvos que serão perdidos. \n Deseja continuar?") == DialogResult.No)
                    return;
            }
            LimpaCampos();
            LimpaModel();
            
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text == "" || txtAno.Text == "" || txtAutor.Text == "" || txtCod.Text == "")
            {
                InformaDiag.Erro("Existem campos obrigatórios vazios!");
                return;
            }
            referencia.Cod = txtCod.Text;
            referencia.descricao = txtDesc.Text;
            referencia.ano = int.Parse(txtAno.Text);
            referencia.autor = txtAutor.Text;
            if (referencia.id > 0) { 
                c.UpdateLine(tabelasBd.REFERENCIAS, Referencia.ToListTabela(false), referencia.ToListValores(), "Id=" + referencia.id.ToString());
            }
            else
            {
                c.InsereLinha(tabelasBd.REFERENCIAS, Referencia.ToListTabela(false), referencia.ToListValores());
            }
            InformaDiag.InformaSalvo();
            LimpaCampos();
            LimpaModel();

        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            if (referencia.id > 0)
            {
                if (InformaDiag.ConfirmaSN("Remover um registro pode afetar vários outros. Recomenda-se observar as dependências antes de continuar" + '\n' + "Prosseguir?") == DialogResult.Yes)
                {
                    if (InformaDiag.ConfirmaOkCancel("Esta ação é irreversível! Confirme a exculsão.") == DialogResult.OK)
                    {
                        c.ApagaLinha(tabelasBd.REFERENCIAS, "Cod=" + referencia.Cod.ToString());
                        resultado.RemoveAt(p);
                        if (resultado.Count > 0)
                        {
                            try
                            {
                                referencia = resultado.ElementAt(--p);
                            }
                            catch (IndexOutOfRangeException)
                            {
                                referencia = resultado.ElementAt(++p);
                            }
                            MostraModel();
                        }
                        else {
                            LimpaModel();
                            LimpaCampos();
                        }
                        
                    }
                }
            }
        }
    }
}
