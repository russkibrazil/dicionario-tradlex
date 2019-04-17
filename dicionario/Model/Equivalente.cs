using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dicionario.Helpers;

namespace dicionario.Model
{
    class Equivalente : Itabelas
    {
        public int origem { get; private set; }
        public int equivalente { get; private set; }
        public bool heterotonico { get; set; }
        public bool heterossemantico { get; set; }
        public bool heterogenerico { get; set; }
        public string exemplo { get; set; }
        public string exemplo_traduzido { get; set; }
        public int Referencia { get; set; }
        public string PalavraGuia { get; set; }
        public int nOrdem { get; private set; }

        public static List<string> ToListTabela()
        {
            return new List<string> { "origem", "equivalente" , "heterogenerico", "heterotonico", "heterossemantico", "Exemplo", "Exemplo_Traduzido", "Referencia", "PGuia", "nApresentacao"};
        }

        public List<string> ToListValores()
        {
            List<string> r = null;
            if (equivalente > 0 && origem > 0 && origem != equivalente){
                r = new List<string>{
                    origem.ToString(),
                    equivalente.ToString(),
                    heterogenerico.ToString(),
                    heterotonico.ToString(),
                    heterossemantico.ToString(),
                    exemplo,
                    exemplo_traduzido,
                    Referencia.ToString(),
                    PalavraGuia.ToString(),
                    nOrdem.ToString()
                };
            }
            return r;
        }

        public void Setequivalente(int d)
        {
            if (origem != d)
                equivalente = d;
            else
                Invalidarequivalente();
        }

        public void SetOrigem(int o)
        {
            if (equivalente != o)
                origem = o;
            else
                InvalidarOrigem();
        }

        public void Invalidarequivalente()
        {
            equivalente = -1;
        }

        public void InvalidarOrigem()
        {
            origem = -1;
        }

        public void DefinirOrdemApresentação(int pos){
            nOrdem = pos;
        }

        public static List<Equivalente> ConverteObject(List<object[]> listaObjs){
            List<Equivalente> s = new List<Equivalente>();
            foreach (object[] data in listaObjs)
            {
                s.Add((Equivalente)data);
            }
            return s;
        }

        public static explicit operator Equivalente(object[] entrada)
        {
            Equivalente eqv = new Equivalente();
            int i = 0;
            eqv.origem = int.Parse(entrada[i++].ToString());
            eqv.equivalente = int.Parse(entrada[i++].ToString());
            eqv.heterogenerico = Helper.ParseBoolean(entrada[i++].ToString());
            eqv.heterotonico = Helper.ParseBoolean(entrada[i++].ToString());
            eqv.heterossemantico = Helper.ParseBoolean(entrada[i++].ToString());
            eqv.exemplo = entrada[i++].ToString();
            eqv.exemplo_traduzido = entrada[i++].ToString();
            eqv.Referencia = int.Parse(entrada[i++].ToString());
            eqv.PalavraGuia = entrada[i++].ToString();
            eqv.nOrdem = int.Parse(entrada[i++].ToString());
            return eqv;
        }
    }
}
