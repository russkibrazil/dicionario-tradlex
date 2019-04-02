using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicionario.Model
{
    class CategoriaGramatical
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public string sigla { get; set; }
        public string Definicao { get; set; }

        public override string ToString()
        {
            string expressao = "id=" + id + ",descricao='" + descricao + "',sigla='" + sigla;
            return expressao;
        }

        public List<string> ToListValores(bool incluiId = false)
        {
            List<string> val = new List<string>();
            if (incluiId)
                val.Add(id.ToString());
            val.Add(descricao);
            val.Add(sigla);
            val.Add(Definicao);
            return val;
        }

        public static List<string> ToListTabela(bool incluiId = false)
        {
            List<string> val = new List<string>();
            if (incluiId)
                val.Add("id");
            val.Add("descricao");
            val.Add("sigla");
            val.Add("definicao");
            return val;
        }
        public static List<CategoriaGramatical> ConverteObject(List<object[]> entrada)
        {
            List<CategoriaGramatical> s = new List<CategoriaGramatical>();
            int lim = entrada.Count;
            CategoriaGramatical pt = new CategoriaGramatical();
            object[] po = new object[CategoriaGramatical.ToListTabela(true).Count];
            for (int i = 0; i < lim; i++)
            {
                po = entrada.ElementAt(i);
                pt = (CategoriaGramatical)po;
                s.Add(pt);
            }
            return s;
        }
        public static explicit operator CategoriaGramatical(List<string> lista)
        {
            CategoriaGramatical ct = new CategoriaGramatical
            {
                id = int.Parse(lista.ElementAt(0)),
                descricao = lista.ElementAt(1),
                sigla = lista.ElementAt(2),
                Definicao = lista.ElementAt(3)
            };
            return ct;
        }
        public static explicit operator CategoriaGramatical(object[] lista)
        {
            CategoriaGramatical ct = new CategoriaGramatical();
            try
            {
                ct.id = int.Parse(lista[0].ToString());
                ct.descricao = lista[1].ToString();
                ct.sigla = lista[2].ToString();
                ct.Definicao = lista[3].ToString();
            }
            catch (IndexOutOfRangeException)
            {
                ct.descricao = lista[0].ToString();
                ct.sigla = lista[1].ToString();
                ct.Definicao = lista[2].ToString();
            }
            return ct;
        }
    }
}
