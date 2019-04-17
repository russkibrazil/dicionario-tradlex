using System;   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicionario
{
    class ConjugacaoEn
    {
        public int id { get; set; }
        public string ConstrPresente { get; set; }
        public string ExPresente { get; set; }
        public string ConstrPassado { get; set; }
        public string ExPassado { get; set; }
        public string ConstrWill { get; set; }
        public string ExWill { get; set; }
        public string ConstrGoingTo { get; set; }
        public string ExGoingTo { get; set; }
        public string ConstrPresPer { get; set; }
        public string ExPresPer { get; set; }
        public string ConstrPasPer { get; set; }
        public string ExPasPer { get; set; }
        public string ConstrPresCon { get; set; }
        public string ExPresCon { get; set; }
        public string ConstrPasCon { get; set; }
        public string ExPasCon { get; set; }

        public static List<string> ToListTabela(bool incluiId = false)
        {
            List<string> val = new List<string>();
            if (incluiId)
                val.Add("idconjugacao");
            val.Add("ConstrPresente");
            val.Add("ExPresente");
            val.Add("ConstrPassado");
            val.Add("ExPassado");
            val.Add("ConstrWill");
            val.Add("ExWill");
            val.Add("ConstrGoingTo");
            val.Add("ExGoingTo");
            val.Add("ConstrPresPer");
            val.Add("ExPresPer");
            val.Add("ConstrPasPer");
            val.Add("ExPasPer");
            val.Add("ConstrPresCon");
            val.Add("ExPresCon");
            val.Add("ConstrPasCon");
            val.Add("ExPasCon");

            return val;
        }
        public List<string> ToListValores(bool incluiId = false)
        {
            List<string> val = new List<string>();
            if (incluiId)
                val.Add(id.ToString());
            val.Add(ConstrPresente );
            val.Add(ExPresente );
            val.Add(ConstrPassado );
            val.Add(ExPassado );
            val.Add(ConstrWill );
            val.Add(ExWill );
            val.Add(ConstrGoingTo );
            val.Add(ExGoingTo );
            val.Add(ConstrPresPer );
            val.Add(ExPresPer );
            val.Add(ConstrPasPer );
            val.Add(ExPasPer );
            val.Add(ConstrPresCon );
            val.Add(ExPresCon );
            val.Add(ConstrPasCon );
            val.Add(ExPasCon);

            return val;
        }
        public static List<ConjugacaoEn> ConverteObject(List<object[]> entrada)
        {
            List<ConjugacaoEn> s = new List<ConjugacaoEn>();
            int lim = entrada.Count;
            ConjugacaoEn pt = new ConjugacaoEn();
            object[] po = new object[ConjugacaoEn.ToListTabela(true).Count];
            for (int i = 0; i < lim; i++)
            {
                po = entrada.ElementAt(i);
                pt = (ConjugacaoEn)po;
                s.Add(pt);
            }
            return s;
        }
        public static explicit operator ConjugacaoEn(List<string> lista)
        {
            ConjugacaoEn cnj = new ConjugacaoEn
            {
                id = int.Parse(lista.ElementAt(0)),
                ConstrPresente = lista.ElementAt(1),
                ExPresente = lista.ElementAt(2),
                ConstrPassado = lista.ElementAt(3),
                ExPassado = lista.ElementAt(4),
                ConstrWill = lista.ElementAt(5),
                ExWill = lista.ElementAt(6),
                ConstrGoingTo = lista.ElementAt(7),
                ExGoingTo = lista.ElementAt(8),
                ConstrPresPer = lista.ElementAt(9),
                ExPresPer = lista.ElementAt(10),
                ConstrPasPer = lista.ElementAt(11),
                ExPasPer = lista.ElementAt(12),
                ConstrPresCon = lista.ElementAt(13),
                ExPresCon = lista.ElementAt(14),
                ConstrPasCon = lista.ElementAt(15),
                ExPasCon = lista.ElementAt(16)
            };
            return cnj;
        }
        public static explicit operator ConjugacaoEn(object[] lista)
        {
            ConjugacaoEn c = new ConjugacaoEn();
            try
            {
                c.id = int.Parse(lista[0].ToString());
                c.ConstrPresente = lista[1].ToString();
                c.ExPresente = lista[2].ToString();
                c.ConstrPassado = lista[3].ToString();
                c.ExPassado = lista[4].ToString();
                c.ConstrWill = lista[5].ToString();
                c.ExWill = lista[6].ToString();
                c.ConstrGoingTo = lista[7].ToString();
                c.ExGoingTo = lista[8].ToString();
                c.ConstrPresPer = lista[9].ToString();
                c.ExPresPer = lista[10].ToString();
                c.ConstrPasPer = lista[11].ToString();
                c.ExPasPer = lista[12].ToString();
                c.ConstrPresCon = lista[13].ToString();
                c.ExPresCon = lista[14].ToString();
                c.ConstrPasCon = lista[15].ToString();
                c.ExPasCon = lista[16].ToString();
            }
            catch (IndexOutOfRangeException)
            {
                c.ConstrPresente = lista[0].ToString();
                c.ExPresente = lista[1].ToString();
                c.ConstrPassado = lista[2].ToString();
                c.ExPassado = lista[3].ToString();
                c.ConstrWill = lista[4].ToString();
                c.ExWill = lista[5].ToString();
                c.ConstrGoingTo = lista[6].ToString();
                c.ExGoingTo = lista[7].ToString();
                c.ConstrPresPer = lista[8].ToString();
                c.ExPresPer = lista[9].ToString();
                c.ConstrPasPer = lista[10].ToString();
                c.ExPasPer = lista[11].ToString();
                c.ConstrPresCon = lista[12].ToString();
                c.ExPresCon = lista[13].ToString();
                c.ConstrPasCon = lista[14].ToString();
                c.ExPasCon = lista[15].ToString();
            }
            return c;
        }
    }
}
