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
        CRUD cRUD = new CRUD();
        public frm_busca()
        {
            InitializeComponent();
            this.extraComboBox1.Hide();
            this.extraComboBox2.Hide();
        }

        private void contactButton_Click(object sender, EventArgs e)
        {
            //Por hora, cria uma nova instância do mesmo form.
            //Trocar o HomeForm para os Forms corretos.
            frm_contato contato = new frm_contato();
            contato.ShowDialog();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            List<object[]> lista = new List<object[]>();
            if (searchBox.Text == "")
            {
                InformaDiag.Erro("A caixa de busca não pode estar vazia!");
                return;
            }
            string filtro = "";
            switch (filterComboBox.SelectedIndex)
            {
                case 1:
                    filtro += "lema LIKE'" + searchBox.Text + "'";
                    break;
                case 2:
                    //anagrama
                    break;
                case 3:
                    //filtro += "definicao LIKE '" + searchBox.Text + "'";
                    break;
                case 4:
                    //exemplo
                    break;
                case 5:
                    //Heterogenérico
                    break;
                case 6:
                    //Heterotônico
                    break;
                default:
                    filtro += "lema='" + searchBox.Text + "'";
                    break;
            }
            lista = cRUD.SelecionarTabela("palavra", Palavra.ToListTabela(true),filtro , "ORDER BY lema ASC");
            searchResultsListBox.Items.Clear();
            if (lista.Count > 0)
            {
                try
                {
                    resultadosPalavra.Clear();
                }
                catch (NullReferenceException) {
                    resultadosPalavra = new List<Palavra>();
                }
                List<string> cabecalhos = new List<string>();
                Palavra temPal = new Palavra();
                resultadosPalavra = AgrupaResultados(Palavra.ConverteObject(lista), out cabecalhos, out int[] divisores);
                int c = 0, i;
                foreach (string conjunto in cabecalhos)
                {
                    searchResultsListBox.Items.Add(conjunto);
                    for (i=0; i<divisores[c]; i++) {
                        temPal = resultadosPalavra.ElementAt(i);
                        filtro = temPal.lema + " Acep."  + " " + " \""; //+ temPal.referencia_exemplo + "\"" + "\"" + temPal.ref_ex_tr + "\"" + temPal.referencia_verbete;
                        searchResultsListBox.Items.Add(filtro);
                    }
                    c++;
                }
                searchResultsListBox.Enabled = true;

                similares = Palavra.ConverteObject(cRUD.SelecionarTabela(tabelasBd.PALAVRA, Palavra.ToListTabela(true), "referencia_exemplo LIKE '" + searchBox.Text + "'"));
                if (similares.Count > 0)
                {
                    foreach (Palavra p in similares)
                    {
                        similarListBox.Items.Add(p.lema);
                    }
                } else
                {
                    similarListBox.Items.Clear();
                    similarListBox.Items.Add("Não há entradas similares além das pesquisadas.");
                    similarListBox.Enabled = false;
                }
                similarListBox.Enabled = true;
            }
            else
            {
                similarListBox.Items.Clear();
                searchResultsListBox.Items.Add("Nenhum resultado encontrado. Verifique seus critérios de pesquisa!");
                searchResultsListBox.Enabled = false;
                similarListBox.Enabled = false;
            }
            this.searchResultsListBox.Show();
        }

        private void searchResultsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private List<Palavra> AgrupaResultados(List<Palavra> res, out List<string> cnj, out int[] intervalos)
        {
            List<Palavra> s = new List<Palavra>();
            List<Palavra> temp = new List<Palavra>();
            List<string> grupos = new List<string>();
            int[] pos = new int[res.Count];
            int i = 0;
            string agrupador;
            Palavra t = new Palavra();
            while(res.Count > 0)
            {
                t = res.First();
                agrupador = t.lema;
                temp = res.FindAll(p => p.lema == agrupador);
                //temp.OrderBy(p => p.acepcao);
                s.AddRange(temp);
                res.RemoveAll(p => p.lema == agrupador);
                grupos.Add(agrupador);
                pos[i++] = temp.Count;
                temp.Clear();
            }
            cnj = grupos;
            intervalos = pos;
            return s;
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

        private void extraFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (extraFilterCheckBox.Checked)
            {
                this.extraComboBox1.Show();
                this.extraComboBox2.Show();
            }
            else if (!extraFilterCheckBox.Checked)
            {
                this.extraComboBox1.Hide();
                this.extraComboBox2.Hide();
            }
        }

        private void ConfigButton_Click(object sender, EventArgs e)
        {
            Login l = new Login(new frm_controledeusuario(),0);
            l.ShowDialog();
            l.Dispose();

        }

        private void helpButton_Click(object sender, EventArgs e)
        {

        }
        private void searchResultsListBox_DoubleClick(object sender, EventArgs e)
        {
            IEnumerable<string> slist = searchResultsListBox.Items.Cast<string>();
            string s = slist.ElementAt(searchResultsListBox.SelectedIndex);
            Palavra resultado = new Palavra();
            List<Palavra> r = new List<Palavra>();
            if (s.Contains("Entrada")){
                string entra = PegaInformacoes(s, out int a);
                //r.Add(resultadosPalavra.Find(p => p.lema == entra && p.acepcao == a));
            } else {
                r.AddRange(resultadosPalavra.FindAll(p => p.lema == s));
            }
            //r.Add(resultado);
            frm_visualizaverbete _Visualizaverbete = new frm_visualizaverbete(r);
            _Visualizaverbete.ShowDialog();
        }

        private void similarListBox_DoubleClick(object sender, EventArgs e)
        {
            List<Palavra> r = new List<Palavra>();
            r.Add(similares.ElementAt(similarListBox.SelectedIndex));
            frm_visualizaverbete _Visualizaverbete = new frm_visualizaverbete(r);
            _Visualizaverbete.ShowDialog();
        }
        private string PegaInformacoes (string s, out int nAcepcaoSel)
        {
            string retorno = "";
            int ac = 2, elementos;
            string[] lemas = s.Split(' ');
            bool encontrado = false;
            elementos = lemas.Count();
            do
            {
                encontrado = int.TryParse(lemas[ac], out int temp);
                if (!encontrado) ac++;
            } while (!encontrado || ac >= elementos);
            ac--;
            for (int i = 0; i < ac; i++)
            {
                retorno += (lemas[i] + " ");
            }
            retorno = retorno.Remove(retorno.Length - 1);
            nAcepcaoSel = int.Parse(lemas[++ac]);
            return retorno;
        }

        private void frm_busca_Resize(object sender, EventArgs e)
        {
            searchResultsListBox.Size = new Size(this.Size.Width - 212, this.Size.Height - 242);
            similarListBox.Size = new Size(146, this.Size.Height - 242);//tamanho padrão 388*208
        }
    }
}
