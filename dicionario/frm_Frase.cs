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
    public partial class frm_Frase : Form
    {
        private Fraseologia frs = new Fraseologia();
        private Fraseologia frs_old = new Fraseologia();
        private CRUD cRUD = new CRUD();
        private List<Fraseologia> lFrase = new List<Fraseologia>();
        private List<object[]> resultados = new List<object[]>();
        private int iFrase = 1;
        private bool novo = false;

        public frm_Frase( int reg)
        {
            InitializeComponent();
            frs.IdPalavra = reg;
            resultados = cRUD.SelecionarTabela(tabelasBd.FRASEOLOGIA, Fraseologia.ToListTabela(), "IdPalavra=" + reg.ToString());

        }

        private void LimpaCampos()
        {
            txtCultura.Text = "";
            txtExemplo.Text = "";
            txtExemploTrad.Text = "";
            txtFequivalente.Text = "";
            txtForiginal.Text = "";
            txtGramatica.Text = "";
        }

        private void LimpaRegistro()
        {
            frs.Categoria = "";
            frs.ExemploEquivalente = "";
            frs.ExemploOriginal = "";
            frs.FraseEquiv = "";
            frs.FraseOrig = "";
            frs.NotasCultura = "";
            frs.NotasGramatica = "";
        }

        private void MostraDados()
        {
            txtCultura.Text = frs.NotasCultura;
            txtExemplo.Text = frs.ExemploOriginal;
            txtExemploTrad.Text = frs.ExemploEquivalente;
            txtFequivalente.Text = frs.FraseEquiv;
            txtForiginal.Text = frs.FraseOrig;
            txtGramatica.Text = frs.NotasGramatica;
            if (frs.Categoria == "I")
                comboCategoria.SelectedIndex = 0;
            else
                comboCategoria.SelectedIndex = 1;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            LimpaRegistro();
            novo = true;
            DesativaNavegadores();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            frs_old = frs;
            if (comboCategoria.SelectedIndex == 0)
            {
                frs.Categoria = "I";
            }
            else
            {
                frs.Categoria = "C";
            }
            frs.ExemploEquivalente = txtExemploTrad.Text;
            frs.ExemploOriginal = txtExemplo.Text;
            frs.FraseEquiv = txtFequivalente.Text;
            frs.FraseOrig = txtForiginal.Text;
            frs.NotasCultura = txtCultura.Text;
            frs.NotasGramatica = txtGramatica.Text;
            if (novo)
            {
                cRUD.InsereLinha(tabelasBd.FRASEOLOGIA, Fraseologia.ToListTabela(), frs.ToListValores());
                lFrase.Add(frs);
                if (lFrase.Count < 2) DesativaNavegadores();
            }
            else{
                cRUD.UpdateLine(tabelasBd.FRASEOLOGIA, Fraseologia.ToListTabela(), frs.ToListValores(), "IdPalavra=" + frs_old.IdPalavra.ToString() + " AND FraseOrig='" + frs_old.FraseOrig + "' AND FraseEquiv='" + frs_old.FraseEquiv + "' AND Categoria='" + frs_old.Categoria + "'");
                int idx = lFrase.FindIndex(frl => frl == frs);
                lFrase.RemoveAt(idx);
                lFrase.Insert(idx, frs);
            }
            InformaDiag.InformaSalvo();
            novo = false;
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            if (InformaDiag.ConfirmaSN("Deseja apagar o registro ativo?") == DialogResult.Yes)
            {
                cRUD.ApagaLinha(tabelasBd.FRASEOLOGIA, "IdPalavra=" + frs_old.IdPalavra.ToString() + " AND FraseOrig='" + frs_old.FraseOrig + "' AND FraseEquiv='" + frs_old.FraseEquiv + "' AND Categoria='" + frs_old.Categoria + "'");
                lFrase.Remove(frs);
                LimpaCampos();
                LimpaRegistro();
                btnProx_Click(sender, e);
                btnAnterior_Click(sender, e);
                if (lFrase.Count < 2) DesativaNavegadores();
            }
        }

        private void AtivaNavegadores()
        {
            btnAnterior.Enabled = true;
            btnProx.Enabled = true;
            btnPrimeiro.Enabled = true;
            btnUltimo.Enabled = true;
        }
        private void DesativaNavegadores()
        {
            btnAnterior.Enabled = false;
            btnProx.Enabled = false;
            btnPrimeiro.Enabled = false;
            btnUltimo.Enabled = false;
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            if (iFrase > 0)
            {
                frs = lFrase.First();
                MostraDados();
                iFrase = 0;
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (iFrase > 0)
            {
                frs = lFrase.ElementAt(--iFrase);
                MostraDados();
            }
        }

        private void btnProx_Click(object sender, EventArgs e)
        {
            if (iFrase < (lFrase.Count -1))
            {
                frs = lFrase.ElementAt(++iFrase);
                MostraDados();
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            int mx = (lFrase.Count - 1);
            if (iFrase < mx)
            {
                frs = lFrase.Last();
                iFrase = mx;
                MostraDados();
            }
        }

        private void frm_Frase_Load(object sender, EventArgs e)
        {
            if (resultados.Count > 0)
            {
                lFrase = Fraseologia.ConverteObject(resultados);
                btnPrimeiro_Click(sender, e);
                if (lFrase.Count > 1)
                    AtivaNavegadores();
            }
        }
    }
}
