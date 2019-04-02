using System;   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicionario
{
    class Conjugacao
    {
        public int id { get; set; }
        public string ExPreterito { get; set; }
        public string ExPresente { get; set; }
        public string ExFuturo { get; set; }
        public string ConstrPreterito { get; set; }
        public string ConstrPresente { get; set; }
        public string ConstrFuturo { get; set; }
        /*
         Columns:
idconjugacao int(11) AI PK 
ExPreterito text 
ExPresente text 
ExFuturo text 
ConstrPreterito text 
ConstrPresente text 
ConstrFuturo text
             */

        public static List<string> ToListTabela(bool incluiId = false)
        {
            List<string> val = new List<string>();
            if (incluiId)
                val.Add("idconjugacao");
            val.Add("ExPreterito");
            val.Add("ExPresente");
            val.Add("ExFuturo");
            val.Add("ConstrPreterito");
            val.Add("ConstrPresente");
            val.Add("ConstrFuturo");

            return val;
        }
        public List<string> ToListValores(bool incluiId = false)
        {
            List<string> val = new List<string>();
            if (incluiId)
                val.Add(id.ToString());
            val.Add(ExPreterito);
            val.Add(ExPresente);
            val.Add(ExFuturo);
            val.Add(ConstrPreterito);
            val.Add(ConstrPresente);
            val.Add(ConstrFuturo);

            return val;
        }
        public static List<Conjugacao> ConverteObject(List<object[]> entrada)
        {
            List<Conjugacao> s = new List<Conjugacao>();
            int lim = entrada.Count;
            Conjugacao pt = new Conjugacao();
            object[] po = new object[Conjugacao.ToListTabela(true).Count];
            for (int i = 0; i < lim; i++)
            {
                po = entrada.ElementAt(i);
                pt = (Conjugacao)po;
                s.Add(pt);
            }
            return s;
        }
        public static explicit operator Conjugacao(List<string> lista)
        {
            Conjugacao cnj = new Conjugacao
            {
                id = int.Parse(lista.ElementAt(0)),
                ExPreterito = lista.ElementAt(1),
                ExPresente = lista.ElementAt(2),
                ExFuturo = lista.ElementAt(3),
                ConstrPreterito = lista.ElementAt(4),
                ConstrPresente = lista.ElementAt(5),
                ConstrFuturo = lista.ElementAt(6)

            };
            return cnj;
        }
        public static explicit operator Conjugacao(object[] lista)
        {
            Conjugacao c = new Conjugacao();
            try
            {
                c.id = int.Parse(lista[0].ToString());
                c.ExPreterito = lista[1].ToString();
                c.ExPresente = lista[2].ToString();
                c.ExFuturo = lista[3].ToString();
                c.ConstrPreterito = lista[4].ToString();
                c.ConstrPresente = lista[5].ToString();
                c.ConstrFuturo = lista[6].ToString();
            }
            catch (IndexOutOfRangeException)
            {
                c.ExPreterito = lista[0].ToString();
                c.ExPresente = lista[1].ToString();
                c.ExFuturo = lista[2].ToString();
                c.ConstrPreterito = lista[3].ToString();
                c.ConstrPresente = lista[4].ToString();
                c.ConstrFuturo = lista[5].ToString();
            }
            return c;
        }
    }
}
