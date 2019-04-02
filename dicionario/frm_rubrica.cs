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

namespace dicionario.Model
{
    public partial class frm_rubrica : Form
    {
        Rubrica rubrica = new Rubrica();
        CRUD c = new CRUD();
        public frm_rubrica()
        {
            InitializeComponent();
        }
        private void LimpaCampos() { txtDesc.Text = ""; txtSigla.Text = ""; }
        private void LimpaModel()
        {
            rubrica.descricao = "";
            rubrica.id = -1;
            rubrica.sigla = "";
        }
        private bool verificaCampos() {
            if (txtDesc.Text == "" || txtSigla.Text == "")
                return true;
            return false;
        }
        private void MostraModel(Rubrica r)
        {
            txtDesc.Text = r.descricao;
            txtSigla.Text = r.sigla;
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text != rubrica.descricao || txtSigla.Text != rubrica.sigla)
            {
                if(InformaDiag.ConfirmaSN("Existem dados não salvos que serão perdidos. \n Deseja continuar?") == DialogResult.No)
                    return;
            }
            LimpaCampos();
            LimpaModel();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if(txtDesc.Text == "" || txtSigla.Text == "")
            {
                InformaDiag.Erro("Existem campos obrigatórios vazios!");
                return;
            }
            rubrica.descricao = txtDesc.Text;
            rubrica.sigla = txtSigla.Text;
            if (rubrica.id > 0)
                c.UpdateLine(tabelasBd.RUBRICA, Rubrica.ToListTabela(false), rubrica.ToListValores(), "id=" + rubrica.id.ToString());
            else
                c.InsereLinha(tabelasBd.RUBRICA, Rubrica.ToListTabela(false), rubrica.ToListValores());
            InformaDiag.InformaSalvo();
            LimpaCampos();
            LimpaModel();
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            if (rubrica.id>0)
            {
                if (InformaDiag.ConfirmaSN("Remover um registro pode afetar vários outros. Recomenda-se observar as dependências antes de continuar" + '\n' + "Prosseguir?") == DialogResult.Yes)
                {
                    if (InformaDiag.ConfirmaOkCancel("Esta ação é irreversível! Confirme a exculsão.") == DialogResult.OK)
                    {
                        c.ApagaLinha(tabelasBd.RUBRICA, "Id=" + rubrica.id.ToString());
                        LimpaModel();
                        LimpaCampos();
                    }
                }
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            if (txtSigla.Text != "")
            {
                List<Rubrica> resultado = Rubrica.ConverteObject(c.SelecionarTabela("rubrica", Rubrica.ToListTabela(true), "sigla='" + txtSigla.Text + "'"));
                if (resultado.Count > 0)
                {
                    MostraModel(resultado.First());
                    //TODO: muultiplos resultados vão para onde mesmo?
                }
                else
                {
                    MessageBox.Show("Nenhum resultado encontrado.", "Busca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
