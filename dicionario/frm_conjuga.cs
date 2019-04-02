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

namespace dicionario
{
    public partial class frm_conjuga : Form
    {
        Conjugacao conjuga = new Conjugacao();
        ConectaBanco banco = new ConectaBanco("dicionario", "root", "gamesjoker");
        CRUD crud = new CRUD();
        public frm_conjuga(int reg)
        {
            InitializeComponent();
            List<Conjugacao> p = Conjugacao.ConverteObject(crud.SelecionarTabela("conjugacao", Conjugacao.ToListTabela(true), "idconjugacao=" + reg.ToString()));
            conjuga = p.First();

        }
        ///TODO: Sugerir que as informações nas textboxes sejam quebradas uma por linha. A apresentação das informçãoes de cada uma delas será contolada pelo CHR(13) na exibição do lema
        private void button2_Click(object sender, EventArgs e)
        {
            Conjugacao nconj = new Conjugacao();
            nconj.id = conjuga.id;
            nconj.presente = txtPresente.Text;
            nconj.futuro = txtFuturo.Text;
            nconj.preterito = txtPreterito.Text;
            crud.UpdateLine("conjugacao", Conjugacao.ToListTabela(), nconj.ToListValores(), "idconjugacao=" + nconj.id.ToString());
        }

        private void frm_conjuga_Load(object sender, EventArgs e)
        {
            txtFuturo.Text = conjuga.futuro;
            txtPresente.Text = conjuga.presente;
            txtPreterito.Text = conjuga.preterito;
        }
        private void btnLimpaPr_Click(object sender, EventArgs e)
        {
            txtPreterito.Text = String.Empty;
        }

        private void btnLimpaPe_Click(object sender, EventArgs e)
        {
            txtPresente.Text = String.Empty;
        }

        private void btnLimpaFu_Click(object sender, EventArgs e)
        {
            txtFuturo.Text = String.Empty;
        }

        private void btnDescarta_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Serão carregadas as informações previamente salvas e\ntodas as alterações serão perdidas. Continuar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                btnLimpaFu_Click(sender, e);
                btnLimpaPe_Click(sender, e);
                btnLimpaPr_Click(sender, e);
            }
        }
    }
}
