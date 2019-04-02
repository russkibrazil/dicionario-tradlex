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
        public string preterito { get; set; }
        public string presente { get; set; }
        public string futuro { get; set; }

        public static List<string> ToListTabela(bool incluiId = false)
        {
            List<string> val = new List<string>();
            if (incluiId)
                val.Add("id");
            val.Add("preterito");
            val.Add("presente");
            val.Add("futuro");
            
            return val;
        }
        public List<string> ToListValores(bool incluiId = false)
        {
            List<string> val = new List<string>();
            if (incluiId)
                val.Add(id.ToString());
            val.Add(preterito);
            val.Add(presente);
            val.Add(futuro);
        
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
                preterito = lista.ElementAt(1),
                presente = lista.ElementAt(2),
                futuro = lista.ElementAt(3)
                
            };
            return cnj;
        }
        public static explicit operator Conjugacao(object[] lista)
        {
            Conjugacao c = new Conjugacao();
            try
            {
                c.id = int.Parse(lista[0].ToString());
                c.preterito = lista[1].ToString();
                c.presente = lista[2].ToString();
                c.futuro = lista[3].ToString();
            }
            catch (IndexOutOfRangeException)
            {
                c.preterito = lista[0].ToString();
                c.presente = lista[1].ToString();
                c.futuro = lista[2].ToString();
            }
            return c;
        }
    }
}
