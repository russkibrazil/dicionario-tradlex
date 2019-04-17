using System;   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicionario
{
    class ConjugacaoPt
    {
        public int id { get; set; }
        public string ConstrPresente { get; set; }
        public string ExPresente { get; set; }
        public string ConstrPretImp { get; set; }
        public string ExPretImp { get; set; }
        public string ConstrPretPer { get; set; }
        public string ExPretPer { get; set; }
        public string ConstrFutPres { get; set; }
        public string ExFutPres { get; set; }
        public string ConstrFutPret { get; set; }
        public string ExFutPret { get; set; }
        public string ConstrInfPessoal { get; set; }
        public string ExInfPessoal { get; set; }
        public string ConstrParticipio { get; set; }
        public string ExParticipio { get; set; }
        public string ConstrGerundio { get; set; }
        public string ExGerundio { get; set; }

        public static List<string> ToListTabela(bool incluiId = false)
        {
            List<string> val = new List<string>();
            if (incluiId)
                val.Add("idconjugacao");
            val.Add("ConstrPresente");
            val.Add("ExPresente");
            val.Add("ConstrPretImp");
            val.Add("ExPretImp");
            val.Add("ConstrPretPer");
            val.Add("ExPretPer");
            val.Add("ConstrFutPres");
            val.Add("ExFutPres");
            val.Add("ConstrFutPret");
            val.Add("ExFutPret");
            val.Add("ConstrInfPessoal");
            val.Add("ExInfPessoal");
            val.Add("ConstrParticipio");
            val.Add("ExParticipio");
            val.Add("ConstrGerundio");
            val.Add("ExGerundio");

            return val;
        }
        public List<string> ToListValores(bool incluiId = false)
        {
            List<string> val = new List<string>();
            if (incluiId)
                val.Add(id.ToString());
            val.Add(ConstrPresente );
            val.Add(ExPresente );
            val.Add(ConstrPretImp );
            val.Add(ExPretImp );
            val.Add(ConstrPretPer );
            val.Add(ExPretPer );
            val.Add(ConstrFutPres );
            val.Add(ExFutPres );
            val.Add(ConstrFutPret );
            val.Add(ExFutPret );
            val.Add(ConstrInfPessoal );
            val.Add(ExInfPessoal );
            val.Add(ConstrParticipio );
            val.Add(ExParticipio );
            val.Add(ConstrGerundio );
            val.Add(ExGerundio);

            return val;
        }
        public static List<ConjugacaoPt> ConverteObject(List<object[]> entrada)
        {
            List<ConjugacaoPt> s = new List<ConjugacaoPt>();
            int lim = entrada.Count;
            ConjugacaoPt pt = new ConjugacaoPt();
            object[] po = new object[ConjugacaoPt.ToListTabela(true).Count];
            for (int i = 0; i < lim; i++)
            {
                po = entrada.ElementAt(i);
                pt = (ConjugacaoPt)po;
                s.Add(pt);
            }
            return s;
        }
        public static explicit operator ConjugacaoPt(List<string> lista)
        {
            ConjugacaoPt cnj = new ConjugacaoPt
            {
                id = int.Parse(lista.ElementAt(0)),
                ConstrPresente = lista.ElementAt(1),
                ExPresente = lista.ElementAt(2),
                ConstrPretImp = lista.ElementAt(3),
                ExPretImp = lista.ElementAt(4),
                ConstrPretPer = lista.ElementAt(5),
                ExPretPer = lista.ElementAt(6),
                ConstrFutPres = lista.ElementAt(7),
                ExFutPres = lista.ElementAt(8),
                ConstrFutPret = lista.ElementAt(9),
                ExFutPret = lista.ElementAt(10),
                ConstrInfPessoal = lista.ElementAt(11),
                ExInfPessoal = lista.ElementAt(12),
                ConstrParticipio = lista.ElementAt(13),
                ExParticipio = lista.ElementAt(14),
                ConstrGerundio = lista.ElementAt(15),
                ExGerundio = lista.ElementAt(16)
            };
            return cnj;
        }
        public static explicit operator ConjugacaoPt(object[] lista)
        {
            ConjugacaoPt c = new ConjugacaoPt();
            try
            {
                c.id = int.Parse(lista[0].ToString());
                c.ConstrPresente = lista[1].ToString();
                c.ExPresente = lista[2].ToString();
                c.ConstrPretImp = lista[3].ToString();
                c.ExPretImp = lista[4].ToString();
                c.ConstrPretPer = lista[5].ToString();
                c.ExPretPer = lista[6].ToString();
                c.ConstrFutPres = lista[7].ToString();
                c.ExFutPres = lista[8].ToString();
                c.ConstrFutPret = lista[9].ToString();
                c.ExFutPret = lista[10].ToString();
                c.ConstrInfPessoal = lista[11].ToString();
                c.ExInfPessoal = lista[12].ToString();
                c.ConstrParticipio = lista[13].ToString();
                c.ExParticipio = lista[14].ToString();
                c.ConstrGerundio = lista[15].ToString();
                c.ExGerundio = lista[16].ToString();
            }
            catch (IndexOutOfRangeException)
            {
                c.ConstrPresente = lista[0].ToString();
                c.ExPresente = lista[1].ToString();
                c.ConstrPretImp = lista[2].ToString();
                c.ExPretImp = lista[3].ToString();
                c.ConstrPretPer = lista[4].ToString();
                c.ExPretPer = lista[5].ToString();
                c.ConstrFutPres = lista[6].ToString();
                c.ExFutPres = lista[7].ToString();
                c.ConstrFutPret = lista[8].ToString();
                c.ExFutPret = lista[9].ToString();
                c.ConstrInfPessoal = lista[10].ToString();
                c.ExInfPessoal = lista[11].ToString();
                c.ConstrParticipio = lista[12].ToString();
                c.ExParticipio = lista[13].ToString();
                c.ConstrGerundio = lista[14].ToString();
                c.ExGerundio = lista[15].ToString();
            }
            return c;
        }
    }
}
