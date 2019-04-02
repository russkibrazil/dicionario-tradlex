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
        Conjugacao conjuga = new Conjugacao();
        CRUD crud = new CRUD();
        public frm_conjuga(int reg)
        {
            InitializeComponent();
            List<Conjugacao> p = Conjugacao.ConverteObject(crud.SelecionarTabela("conjugacao", Conjugacao.ToListTabela(true), "idConjugacao=" + reg.ToString()));
            conjuga = p.First();

        }
        ///TODO: Sugerir que as informações nas textboxes sejam quebradas uma por linha. A apresentação das informçãoes de cada uma delas será contolada pelo CHR(13) na exibição do lema
        private void button2_Click(object sender, EventArgs e)
        {
            Conjugacao nconj = new Conjugacao();
            nconj.id = conjuga.id;
            nconj.ExPresente = txtPresente.Text;
            nconj.ExFuturo = txtFuturo.Text;
            nconj.ExPreterito = txtPreterito.Text;
            nconj.ConstrFuturo = txtCFuturo.Text;
            nconj.ConstrPresente = txtCPresente.Text;
            nconj.ConstrPreterito = txtCPassado.Text;
            crud.UpdateLine(tabelasBd.CONJUGACAO, Conjugacao.ToListTabela(), nconj.ToListValores(), "idConjugacao=" + nconj.id.ToString());
            conjuga = nconj;
        }

        private void frm_conjuga_Load(object sender, EventArgs e)
        {
            txtFuturo.Text = conjuga.ExFuturo;
            txtPresente.Text = conjuga.ExPresente;
            txtPreterito.Text = conjuga.ExPreterito;
            txtCFuturo.Text = conjuga.ConstrFuturo;
            txtCPresente.Text = conjuga.ConstrPresente;
            txtCPassado.Text = conjuga.ConstrPreterito;
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
