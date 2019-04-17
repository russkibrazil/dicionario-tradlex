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
    public partial class frm_Edit : Form
    {
        public frm_Edit()
        {
            InitializeComponent();
        }
        private CRUD crud = new CRUD();
        private Palavra p = new Palavra();
        private Referencia refere = new Referencia();
        private List<object[]> resultados;
        private List<Palavra> resPalavra = new List<Palavra>();
        private int ipal = 0;
        private List<Referencia> resRef = new List<Referencia>();

        private void EditForm_Load(object sender, EventArgs e)
        {
            //ComboGenero.
        }
        private void LimpaCampos()
        {
            txtDefinicao.Text = "";
            txtGramatica.Text = "";
            txtpalavra.Text = "";
            ComboClasseGram.SelectedIndex = -1;
            ComboClasseGram.Text = "";
            ComboGenero.SelectedIndex = -1;
            ComboGenero.Text = "";
            ComboIdioma.SelectedIndex = -1;
            ComboIdioma.Text = "";
            textCultura.Text = "";
            btnEquiv.Enabled = false;
            btnConjuga.Enabled = false;
        }
        private void LimpaModel()
        {
            p.id = -1;
            p.lema = "";
            p.ClasseGram = "";
            p.Genero = "S";
        }
        private void MostraDados()
        {
            txtpalavra.Text = p.lema;
            if (p.idioma == "PT")
                ComboIdioma.SelectedIndex = 0;
            else
            {
                if (p.idioma == "ES")
                    ComboIdioma.SelectedIndex = 1;
                else
                {
                    ComboIdioma.SelectedIndex = 2;
                }
            }
            textCultura.Text = p.nota_cultura;
            txtGramatica.Text = p.notas_gramatica;            
            switch (p.Genero) {
                case "M":
                    ComboGenero.SelectedIndex = 0;
                    break;
                case "N":
                    ComboGenero.SelectedIndex = 2;
                    break;
                case "F":
                    ComboGenero.SelectedIndex = 1;
                    break;
                default:
                    ComboGenero.SelectedIndex = 3;
                    break;
            }
            ComboClasseGram.Text = p.ClasseGram;
            btnEquiv.Enabled = true;
            btnConjuga.Enabled = true;
        }
        private void AtivaNavegadores() {
            btnPrimeiro.Enabled = true;
            btnAnterior.Enabled = true;
            btnProx.Enabled = true;
            btnUltimo.Enabled = true;
        }
        private void DesativaNavegadores()
        {
            btnPrimeiro.Enabled = false;
            btnAnterior.Enabled = false;
            btnProx.Enabled = false;
            btnUltimo.Enabled = false;
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchBox.Text != "")
            {
                string filtroquery;
                int temp;
                switch (filterComboBox.SelectedIndex)
                {
                    case 1:
                        filtroquery = "Cod";
                        break;
                    default:
                        filtroquery = "lema";
                        break;
                }
                switch (ComboFiltroPrecisao.SelectedIndex)
                {
                    case 1:
                        filtroquery += " LIKE '" + searchBox.Text + "%'";
                        break;
                    default:
                        filtroquery += "=";
                        if (int.TryParse(searchBox.Text, out temp))
                            filtroquery += searchBox.Text;
                        else
                            filtroquery += "'" + searchBox.Text + "'";
                        break;
                }
                switch (comboFiltroIdiomas.SelectedIndex)
                {
                    case 1:
                        filtroquery += "AND Idioma='PT'";
                        break;
                    case 2:
                        filtroquery += "AND Idioma='EN'";
                        break;
                    case 3:
                        filtroquery += "AND Idioma='ES'";
                        break;
                    default:
                        break;
                }
                if (ComboFiltroPrecisao.Text == "Precisamente")
                    resultados  = crud.SelecionarTabela(tabelasBd.PALAVRA, Palavra.ToListTabela(true), "lema='" + searchBox.Text + "'");
                else
                    resultados = crud.SelecionarTabela(tabelasBd.PALAVRA, Palavra.ToListTabela(true), "lema LIKE '%" + searchBox.Text + "%'");
                if (resultados.Count > 0)
                {
                    resPalavra = Palavra.ConverteObject(resultados);
                    p = resPalavra.First();
                    MostraDados();
                    if (resPalavra.Count == 1)
                    {
                        DesativaNavegadores();
                    }
                    else
                    {
                        AtivaNavegadores();
                        ipal = 0;
                    }
                }
                else
                {
                    InformaDiag.Erro("Nenhum resultado adequado encontrado.");
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (txtpalavra.Text != "")
            {
                if (InformaDiag.ConfirmaSN("Existem dados não salvos. Caso prossiga com a operação, todos os dados" + '\n' + "digitados serão perdidos. Continuar mesmo assim?") == DialogResult.No)
                    return;
            }
            LimpaCampos();
            LimpaModel();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if(txtpalavra.Text == String.Empty)
            {
                InformaDiag.Erro("Palavra não pode ser vazio!");
                return;
            }
            if (ComboClasseGram.SelectedItem == null)
            {
                InformaDiag.Erro("Selecione um valor válido de Classe gramatical!");
                return;
            }
            if (ComboGenero.SelectedItem == null)
            {
                InformaDiag.Erro("Selecione um gênero válido!");
                return;
            }
            if (ComboIdioma.SelectedItem == null)
            {
                InformaDiag.Erro("É obrigatório selecionar um idioma!");
                return;
            }
            string lng;
            p.lema = txtpalavra.Text;

            switch (ComboIdioma.SelectedIndex)
            {
                case 0:
                    lng = "PT";
                    break;
                case 2:
                    lng = "EN";
                    break;
                case 1:
                    lng = "ES";
                    break;
                default:
                    lng = "";
                    break;
            }
            p.idioma = lng;
            p.notas_gramatica = txtGramatica.Text;
            p.nota_cultura = textCultura.Text;
            p.Definicao = txtDefinicao.Text;
            switch (ComboGenero.SelectedIndex)
            {
                case 0:
                    p.Genero = "M";
                    break;
                case 1:
                    p.Genero = "F";
                    break;
                case 2:
                    p.Genero = "N";
                    break;
                default:
                    p.Genero = "S";
                    break;
            }
            p.ClasseGram = ComboClasseGram.Text;
            if (p.id <= 0)
            {
                if (p.idioma == "PT")
                {
                    crud.InsereLinha(tabelasBd.CONJUGACAOPT, ConjugacaoPt.ToListTabela(), new ConjugacaoPt().ToListValores());
                    p.id_conjuga = ConjugacaoPt.ConverteObject(crud.SelecionarTabela(tabelasBd.CONJUGACAOPT, ConjugacaoPt.ToListTabela(), "", "ORDER BY idconjugacao DESC LIMIT 2")).First().id;
                }
                else
                {
                    crud.InsereLinha(tabelasBd.CONJUGACAOEN, ConjugacaoEn.ToListTabela(), new ConjugacaoEn().ToListValores());
                    p.id_conjuga = ConjugacaoEn.ConverteObject(crud.SelecionarTabela(tabelasBd.CONJUGACAOEN, ConjugacaoEn.ToListTabela(), "", "ORDER BY idconjugacao DESC LIMIT 2")).First().id;
                }
                crud.InsereLinha(tabelasBd.PALAVRA, Palavra.ToListTabela(), p.ToListValores());
            }
            else
                crud.UpdateLine(tabelasBd.PALAVRA, Palavra.ToListTabela(), p.ToListValores(), "id=" + p.id.ToString());
            //Uma excessão pode ser lançda aqui quando os valores das chaves estrangerias forem <1, pois estão refernciando um valor que não existe. Como o int no c# não cabe um NULL, seria melhor não enviar o tal valor que evitamos o problema
            InformaDiag.Informa("Salvo!");
            LimpaCampos();
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            if (InformaDiag.ConfirmaSN("Remover um registro pode afetar vários outros. Recomenda-se observar as dependências antes de continuar"+ '\n' + "Prosseguir?") == DialogResult.Yes)
            {
                if (InformaDiag.ConfirmaOkCancel("Esta ação é irreversível! Confirme a exculsão.") == DialogResult.OK)
                {
                    crud.ApagaLinha(tabelasBd.PALAVRA, "Id=" + p.id.ToString());
                    if (resPalavra.Count > 1)
                    {
                        resPalavra.Remove(p);
                        if (ipal > 0)
                            btnAnterior_Click(sender, e);
                        else
                            btnProx_Click(sender, e);
                    }
                    else {
                        LimpaModel();
                        LimpaCampos();
                    }                   
                }
            }
            
        }

        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImportaCsv ICsv = new frmImportaCsv();
            ICsv.Show();
        }

        private void contatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_contato cont = new frm_contato();
            cont.ShowDialog();
        }

        private void referênciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_referencia rf = new frm_referencia();
            rf.ShowDialog();
        }

        private void btnEquiv_Click(object sender, EventArgs e)
        {
            frm_Equivalente feq = new frm_Equivalente(p);
            feq.ShowDialog();
        }

        private void btnConjuga_Click(object sender, EventArgs e)
        {
            if (p.id_conjuga > 0)
            {
                frm_conjuga fc = new frm_conjuga(p.id_conjuga, p.idioma);
                fc.ShowDialog();
            }
            else
            {
                InformaDiag.Informa("Salve as alterações antes de acessar as conjugações");
            }
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            if (ipal > 0)
            {
                p = resPalavra.First();
                MostraDados();
                ipal = 0;
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (ipal > 0)
            {
                p = resPalavra.ElementAt(--ipal);
                MostraDados();
            }
        }

        private void btnProx_Click(object sender, EventArgs e)
        {
            if (ipal < (resPalavra.Count - 1))
            {
                p = resPalavra.ElementAt(++ipal);
                MostraDados();
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            int mx = (resPalavra.Count - 1);
            if (ipal < mx)
            {
                p = resPalavra.Last();
                ipal = mx;
                MostraDados();
            }
        }
    }
}
