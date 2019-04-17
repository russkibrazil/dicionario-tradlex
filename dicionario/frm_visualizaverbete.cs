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
    public partial class frm_visualizaverbete : Form
    {
        /*public frm_visualizaverbete(Palavra)
        {
            InitializeComponent();
            
        }*/
        public frm_visualizaverbete(List<Palavra> Resultado) {
            InitializeComponent();
            PreencheTreeList(Resultado);
        }
        private void PreencheTreeList(List<Palavra> entrada)
        {
            CRUD operaBd = new CRUD();
            List<Referencia> resRefer = new List<Referencia>();
            List<int> v2 = new List<int>();
            List<int> v3 = new List<int>();
            List<string> s = new List<string>();
            TreeNode[] exemplos, holder;
            List<TreeNode[]> nf = new List<TreeNode[]>();
            //List<TreeNode[]> holder = new List<TreeNode[]>();
            List<TreeNode[]> saida = new List<TreeNode[]>();

            foreach (Palavra p in entrada)
            {
                /*if (v2.FindIndex(val => val == p.rubrica) < 0)
                {
                    v2.Add(p.rubrica);
                }
                if (v3.FindIndex(val => val == p.referencia_verbete) < 0)
                {
                    v3.Add(p.referencia_verbete);
                }*/
            }
            /*filtro = montaFiltro("id", v2); //filtrando rubrica
            resRubrica = Rubrica.ConverteObject(operaBd.SelecionarTabela("rubrica", Rubrica.ToListTabela(true), filtro));
            filtro = montaFiltro("Id", v3);
            resRefer = Referencia.ConverteObject(operaBd.SelecionarTabela("referencias", Referencia.ToListTabela(true), filtro));*/
            foreach (Palavra p in entrada) {
                //vamos criar os nodes de exemplo e juntá-los num único conjunto
                s.Clear();
                //s.Add(p.referencia_exemplo);
                //s.Add(p.ref_ex_tr);
                exemplos = criaNode(s);

                //vamos agora juntar os outros valores pertinentes à acepção ou verbete selecionado
                //s = criaListaValores(p, cgselect, resRefer.Find(iref => iref.id == p.referencia_verbete));
                nf = criaTreeNodes(s);

                //mesclando ambos em nf
                nf.Add(exemplos);

                //vamos criar os pais destas folhas
                //s = criaListaTitulos(p, cgselect, resRubrica.Find(irub => irub.id == p.rubrica));
                holder = criaTreeTether(s, nf);

                saida.Add(new TreeNode[] { new TreeNode("Acepção" , holder) });
            }
            foreach (TreeNode[] i in saida)
            {
                TrvPalavra.Nodes.AddRange(i);
            }
            lblLema.Text = entrada.First().lema;
        }
        private string montaFiltro(string nomeCampo, List<int> valores) {
            String retorno = (nomeCampo + "=" + valores.First().ToString());
            for (int i = 1; i < valores.Count; i++)
            {
                retorno += (" OR " + nomeCampo + "=" + valores.ElementAt(i));
            }
            return retorno;
        }
        private TreeNode[] criaNode(List<string> en)
        {
            TreeNode[] nd = new TreeNode[en.Count];
            int i = 0;
            foreach (string s in en) {
                nd[i++] = new TreeNode(s);
            }
            return nd;
        }
        private List<string> criaListaValores(Palavra p, Referencia r)
        {
            List<string> sai = new List<string>
            {
                "Classe Gramatical",
                //String.Concat(p.referencia_exemplo,"\n", p.ref_ex_tr),
                r.descricao,
                p.notas_gramatica,
                p.nota_cultura
            };
            return sai;
        }
        private List<string> criaListaTitulos(Palavra p)
        {
            List<string> sai = new List<string>
            {
                "Classe Gramatical",
                //r.descricao,
                "Notas Gramaticais",
                "Notas Culturais",
                "Exemplos de uso"
            };
            return sai;
        }
        /*private TreeNode[] criaTreeNodes(List<string> valores) {
            //IEnumerator<string> i = valores.GetEnumerator();
            string[] v = valores.ToArray();
            int i = 0;
            TreeNode[] tnm = new TreeNode[] {new TreeNode(v[i]), new TreeNode(v[++i]), new TreeNode(v[++i]), new TreeNode(v[++i]), new TreeNode(v[++i]), new TreeNode(v[++i]) };
            return tnm;
        }*/
        private List<TreeNode[]> criaTreeNodes(List<string> valores)
        {
            List<TreeNode[]> tnm = new List<TreeNode[]>();
            foreach (string s in valores){
                tnm.Add(new TreeNode[] { new TreeNode(s) });
            }
            return tnm;       
        }
        private TreeNode[] criaTreeTether(List<string> valores, List<TreeNode[]> descFilhos) {
            int i = 0;
            TreeNode[] tn = new TreeNode[valores.Count];
            foreach (string s in valores)
            {
                tn[i] = new TreeNode(s, descFilhos.ElementAt(i));
                i++;
            }
            return tn;
        }
        /*private TreeNode[] ConverteList (List<TreeNode[]> l)
        {
            TreeNode[] s = new TreeNode[l.Count];
            int i = 0;
            foreach(TreeNode[] n in l)
            {
                s[i++] = n;
            }
            return s;
        }*/
        private void frm_visualizaverbete_Load(object sender, EventArgs e)
        {
             
            
        }
    }
}
