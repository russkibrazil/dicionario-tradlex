using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicionario
{
    class Referencia
    {
        public int id { get; set; }
        public string Cod { get; set; }
        public string descricao { get; set; }
        public int ano { get; set; }
        public string autor { get; set; }

        public List<string> ToListValores(bool incluiId = false)
        {
            List<string> val = new List<string>();
            if (incluiId)
                val.Add(id.ToString());
            val.Add(Cod);
            val.Add(descricao);
            val.Add(ano.ToString());
            val.Add(autor);
            return val;
        }

        public static List<string> ToListTabela(bool incluiId = false)
        {

            List<string> val = new List<string>();
            if (incluiId)
                val.Add("id");
            val.Add("Cod");
            val.Add("descricao");
            val.Add("ano");
            val.Add("autor");
            return val;
        }
        public static List<Referencia> ConverteObject (List<object[]> entrada)
        {
            List<Referencia> s = new List<Referencia>();
            int lim = entrada.Count;
            Referencia pt = new Referencia();
            object[] po = new object[Referencia.ToListTabela(true).Count];
            for (int i = 0; i < lim; i++)
            {
                po = entrada.ElementAt(i);
                pt = (Referencia)po;
                s.Add(pt);
            }
            return s;
        }
        public static explicit operator Referencia(List<string> lista)
        {
            Referencia novo = new Referencia
            {
                id = int.Parse(lista.ElementAt(0)),
                Cod = lista.ElementAt(1),
                descricao = lista.ElementAt(1),
                ano = int.Parse(lista.ElementAt(2)),
                autor = lista.ElementAt(3)
            };
            return novo;
        }
        public static explicit operator Referencia(object[] lista)
        {
            int itera = 0;
            Referencia novo = new Referencia();
            try {
                novo.id = int.Parse(lista[itera++].ToString());
                novo.Cod = lista[itera++].ToString();
                novo.descricao = lista[itera++].ToString();
                novo.ano = int.Parse(lista[itera++].ToString());
                novo.autor = lista[itera++].ToString();
            }
            catch (IndexOutOfRangeException) {
                novo.Cod = lista[itera++].ToString();

                novo.descricao = lista[itera++].ToString();
                novo.ano = int.Parse(lista[itera++].ToString());
                novo.autor = lista[itera++].ToString();
            }
            return novo;
        }
    }
}
