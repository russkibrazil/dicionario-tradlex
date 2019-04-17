using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dicionario.Model;
using dicionario.Helpers;

namespace dicionario
{
    public partial class frm_conjuga : Form
    {
        ConjugacaoPt cPt;
        ConjugacaoEn cEn;
        CRUD crud = new CRUD();
        string lingua;
        public frm_conjuga(int reg, string idioma)
        {
            InitializeComponent();
            lingua = idioma;
            if (idioma == "PT")
            {
                cPt = new ConjugacaoPt();
                tabs.TabPages[1].Text = "Pret Imp";
                tabs.TabPages[2].Text = "Pret Per";
                tabs.TabPages[3].Text = "Fut Pres";
                tabs.TabPages[4].Text = "Fut Pret";
                tabs.TabPages[5].Text = "Infin Pessoal";
                tabs.TabPages[6].Text = "Participio";
                tabs.TabPages[7].Text = "Gerúndio";
                List<ConjugacaoPt> p = ConjugacaoPt.ConverteObject(crud.SelecionarTabela(tabelasBd.CONJUGACAOPT, ConjugacaoPt.ToListTabela(true), "idConjugacao=" + reg.ToString()));
                cPt = p.First();
            }
            else
            {
                cEn = new ConjugacaoEn();
                tabs.TabPages[1].Text = "Passado";
                tabs.TabPages[2].Text = "Will";
                tabs.TabPages[3].Text = "Going To";
                tabs.TabPages[4].Text = "Pres Perf";
                tabs.TabPages[5].Text = "Pass. Perf";
                tabs.TabPages[6].Text = "Pres Cont";
                tabs.TabPages[7].Text = "Pass Cont";
                List<ConjugacaoEn> o = ConjugacaoEn.ConverteObject(crud.SelecionarTabela(tabelasBd.CONJUGACAOEN, ConjugacaoEn.ToListTabela(true), "idConjugacao=" + reg.ToString()));
                cEn = o.First();
            }

        }
        ///TODO: Sugerir que as informações nas textboxes sejam quebradas uma por linha. A apresentação das informçãoes de cada uma delas será contolada pelo CHR(13) na exibição do lema
        private void button2_Click(object sender, EventArgs e)
        {
            if (lingua == "PT")
            {
                ConjugacaoPt nPt = new ConjugacaoPt();
                nPt.ConstrPresente = txtC1.Text;
                nPt.ExPresente = txtE1.Text;
                nPt.ConstrPretImp = txtC2.Text;
                nPt.ExPretImp = txtE2.Text;
                nPt.ConstrPretPer = txtC3.Text;
                 nPt.ExPretPer = txtE3.Text;
                 nPt.ConstrFutPres = txtC4.Text;
                 nPt.ExFutPres = txtE4.Text;
                 nPt.ConstrFutPret = txtC5.Text;
                nPt.ExFutPret = txtE5.Text;
                 nPt.ConstrInfPessoal = txtC6.Text;
                nPt.ExInfPessoal = txtE6.Text;
                nPt.ConstrParticipio = txtC7.Text;
                nPt.ExParticipio = txtE7.Text;
                 nPt.ConstrGerundio = txtC8.Text;
                 nPt.ExGerundio = txtE8.Text;
                crud.UpdateLine(tabelasBd.CONJUGACAOPT, ConjugacaoPt.ToListTabela(), nPt.ToListValores(), "idConjugacao=" + cPt.id.ToString());
                cPt = nPt;
            }
            else
            {
                ConjugacaoEn nEn = new ConjugacaoEn();
                nEn.ConstrPresente = txtC1.Text;
                nEn.ExPresente = txtE1.Text;
                nEn.ConstrPassado = txtC2.Text;
                nEn.ExPassado = txtE2.Text;
                nEn.ConstrWill = txtC3.Text;
                nEn.ExWill = txtE3.Text;
                nEn.ConstrGoingTo = txtC4.Text;
                nEn.ExGoingTo = txtE4.Text;
                nEn.ConstrPresPer = txtC5.Text;
                nEn.ExPresPer = txtE5.Text;
                nEn.ConstrPasPer = txtC6.Text;
                nEn.ExPasPer = txtE6.Text;
                nEn.ConstrPresCon = txtC7.Text;
                nEn.ExPresCon = txtE7.Text;
                nEn.ConstrPasCon = txtC8.Text;
                nEn.ExPasCon = txtE8.Text;
                crud.UpdateLine(tabelasBd.CONJUGACAOEN, ConjugacaoEn.ToListTabela(), nEn.ToListValores(), "idConjugacao=" + cEn.id.ToString());
                cEn = nEn;
            }
        }

        private void frm_conjuga_Load(object sender, EventArgs e)
        {
            if(lingua == "PT")
            {
                txtC1.Text = cPt.ConstrPresente;
                txtE1.Text = cPt.ExPresente;
                txtC2.Text = cPt.ConstrPretImp;
                txtE2.Text = cPt.ExPretImp;
                txtC3.Text = cPt.ConstrPretPer;
                txtE3.Text = cPt.ExPretPer;
                txtC4.Text = cPt.ConstrFutPres;
                txtE4.Text = cPt.ExFutPres;
                txtC5.Text = cPt.ConstrFutPret;
                txtE5.Text = cPt.ExFutPret;
                txtC6.Text = cPt.ConstrInfPessoal;
                txtE6.Text = cPt.ExInfPessoal;
                txtC7.Text = cPt.ConstrParticipio;
                txtE7.Text = cPt.ExParticipio;
                txtC8.Text = cPt.ConstrGerundio;
                txtE8.Text = cPt.ExGerundio;
            }
            else
            {
                txtC1.Text = cEn.ConstrPresente;
                txtE1.Text = cEn.ExPresente;
                txtC2.Text = cEn.ConstrPassado;
                txtE2.Text = cEn.ExPassado;
                txtC3.Text = cEn.ConstrWill;
                txtE3.Text = cEn.ExWill;
                txtC4.Text = cEn.ConstrGoingTo;
                txtE4.Text = cEn.ExGoingTo;
                txtC5.Text = cEn.ConstrPresPer;
                txtE5.Text = cEn.ExPresPer;
                txtC6.Text = cEn.ConstrPasPer;
                txtE6.Text = cEn.ExPasPer;
                txtC7.Text = cEn.ConstrPresCon;
                txtE7.Text = cEn.ExPresCon;
                txtC8.Text = cEn.ConstrPasCon;
                txtE8.Text = cEn.ExPasCon;
            }
        }

        private void btnDescarta_Click(object sender, EventArgs e)
        {
            if(InformaDiag.ConfirmaSN("Serão carregadas as informações previamente salvas e\ntodas as alterações serão perdidas. Continuar?") == DialogResult.Yes)
            {
                frm_conjuga_Load(sender, e);
            }
        }
    }
}
