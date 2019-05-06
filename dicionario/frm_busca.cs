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
    public partial class frm_busca : Form
    {
        List<Palavra> resultadosPalavra, similares;
        private readonly string NOVALINHA = char.ConvertFromUtf32(13) + char.ConvertFromUtf32(10);
        CRUD cRUD = new CRUD();
        public frm_busca()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            List<Palavra> lista = new List<Palavra>();
            string chavePesquisa = searchBox.Text, pesquisa;
            if (chavePesquisa == "")
            {
                InformaDiag.Erro("A caixa de busca não pode estar vazia!");
                return;
            }
            if (chavePesquisa.Contains(" ")) { }
            else
            {
                if (chavePesquisa.EndsWith("ing") || chavePesquisa.EndsWith("ed") || chavePesquisa.EndsWith("ies") || chavePesquisa.EndsWith("es"))
                {
                    InformaDiag.Erro("Entradas em inglês não acessíveis no momento.");
                    return;
                }
                if (chavePesquisa.EndsWith("ar") || chavePesquisa.EndsWith("ir"))
                {
                    //caso suspeitarmos que seja um infinitivo em portugues...
                    pesquisa = "Lema = '" + chavePesquisa + "' AND Idioma = 'PT'";
                    lista = Palavra.ConverteObject(cRUD.SelecionarTabela(tabelasBd.PALAVRA, Palavra.ToListTabela(true), pesquisa));

                    if (lista.Count >= 1) //Existe somente aquele resultado?
                    {
                        if (lista.Count == 1)
                            txtResultado.Text = MontaApresentaçãoInfinitivoPt(lista.First());
                        else
                        {

                        }
                    }
                    else
                        InformaDiag.Erro("Busca não encontrada!");
                }
                else
                {
                    //caso suspeitarmos que é um verbo flexionado em português
                }
            }
        }

        private string MontaApresentaçãoInfinitivoPt(Palavra pReg){
            string pesquisa, textoApresentado = "Equivalências" + NOVALINHA;
            List<Equivalente> listaEquiv = new List<Equivalente>();
            List<Palavra> listaPEquiv = new List<Palavra>();
            List<ConjugacaoEn> listaConjugaEn = new List<ConjugacaoEn>();

            pesquisa = "Origem=" + pReg.id.ToString();
            listaEquiv = Equivalente.ConverteObject(cRUD.SelecionarTabela(tabelasBd.EQUIVALENTE, Equivalente.ToListTabela(), pesquisa, "ORDER BY nApresentacao ASC"));
            pesquisa = "";
            foreach (Equivalente itemEquiv in listaEquiv)
            {
                pesquisa += ("id=" + itemEquiv.equivalente.ToString() + " OR ");
            }
            pesquisa = pesquisa.Remove(pesquisa.Count() - 4);
            listaPEquiv = Palavra.ConverteObject(cRUD.SelecionarTabela(tabelasBd.PALAVRA, Palavra.ToListTabela(true), pesquisa));
            pesquisa = "";
            foreach (Palavra p in listaPEquiv)
            {
                pesquisa += ("idconjugacao=" + p.id_conjuga.ToString() + " OR ");
            }
            pesquisa = pesquisa.Remove(pesquisa.Count() - 4);
            listaConjugaEn = ConjugacaoEn.ConverteObject(cRUD.SelecionarTabela(tabelasBd.CONJUGACAOEN, ConjugacaoEn.ToListTabela(true), pesquisa));

            int elementos = listaEquiv.Count;

            //monta Indice
            for (int i = 0; i < elementos; i++)
            {
                textoApresentado += ((i + 1).ToString() + ". " + (listaPEquiv.ElementAt(i).lema) + " (" + listaEquiv.ElementAt(i).PalavraGuia + ")" + NOVALINHA);
            }
            ConjugacaoEn conjugacao = new ConjugacaoEn();
            for (int i = 0; i < elementos; i++)
            {
                pReg = listaPEquiv.ElementAt(i);
                conjugacao = listaConjugaEn.ElementAt(i);

                textoApresentado += ((i + 1).ToString() + ". " + (pReg.lema) + NOVALINHA);

                textoApresentado += (listaEquiv.ElementAt(i).PalavraGuia + NOVALINHA);

                textoApresentado += (pReg.Definicao + NOVALINHA);

                textoApresentado += (conjugacao.ConstrPresente + NOVALINHA);
                textoApresentado += (conjugacao.ConstrPassado + NOVALINHA);
                textoApresentado += (conjugacao.ConstrWill + NOVALINHA);
                textoApresentado += (conjugacao.ConstrGoingTo + NOVALINHA);
                textoApresentado += (conjugacao.ConstrPresPer + NOVALINHA);
                textoApresentado += (conjugacao.ConstrPasPer + NOVALINHA);
                textoApresentado += (conjugacao.ConstrPresCon + NOVALINHA);
                textoApresentado += (conjugacao.ConstrPasCon + NOVALINHA);

                textoApresentado += (conjugacao.ExPresente + NOVALINHA);
                textoApresentado += (conjugacao.ExPassado + NOVALINHA);
                textoApresentado += (conjugacao.ExWill + NOVALINHA);
                textoApresentado += (conjugacao.ExGoingTo + NOVALINHA);
                textoApresentado += (conjugacao.ExPresPer + NOVALINHA);
                textoApresentado += (conjugacao.ExPasPer + NOVALINHA);
                textoApresentado += (conjugacao.ExPresCon + NOVALINHA);
                textoApresentado += (conjugacao.ExPasCon + NOVALINHA);

                textoApresentado += (pReg.notas_gramatica + NOVALINHA);

                textoApresentado += (pReg.nota_cultura + NOVALINHA);
            }

            textoApresentado += ("Fraseologia" + NOVALINHA + NOVALINHA);

            return textoApresentado;
        }
        private void searchResultsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void editModeButton_Click(object sender, EventArgs e)
        {
            Login l = new Login(new frm_Edit());
            l.ShowDialog();
            l.Dispose();
        }

        private void ConfigButton_Click(object sender, EventArgs e)
        {
            Login l = new Login(new frm_controledeusuario(),0);
            l.ShowDialog();
            l.Dispose();

        }

        private void frm_busca_Resize(object sender, EventArgs e)
        {
            txtResultado.Size = new Size(this.Size.Width - 60, this.Size.Height - 150);
            //tamanho padrão 388*208
        }
    }
}
