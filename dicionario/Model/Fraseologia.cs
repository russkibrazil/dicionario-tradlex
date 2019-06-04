using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicionario.Model
{
    class Fraseologia : Itabelas
    {
        public int IdPalavra { get; set; }
        public string FraseOrig { get; set; }
        public string FraseEquiv { get; set; }
        public string ExemploOriginal { get; set; }
        public string ExemploEquivalente { get; set; }
        public string NotasCultura { get; set; }
        public string NotasGramatica { get; set; }
        public string Categoria { get; set; } //i,c

        public static List<string> ToListTabela(){
            return new List<string> { "IdPalavra", "FraseOrig", "FraseEquiv", "ExemploOrig", "ExemploEquiv", "NotasCultura", "NotasGramatica", "Categoria" };
        }
        public List<string> ToListValores(){
            return new List<string>{
                IdPalavra.ToString(),
                FraseOrig,
                FraseEquiv,
                ExemploOriginal,
                ExemploEquivalente,
                NotasCultura,
                NotasGramatica,
                Categoria
            };
        }
        public static List<Fraseologia> ConverteObject(List<object[]> listaObjs)
        {
            List<Fraseologia> s = new List<Fraseologia>();
            foreach (object[] data in listaObjs)
            {
                s.Add((Fraseologia)data);
            }
            return s;
        }

        public static explicit operator Fraseologia(object[] entrada)
        {
            Fraseologia ev = new Fraseologia();
            int i = 0;
            ev.IdPalavra = int.Parse(entrada[i++].ToString());
            ev.FraseOrig = entrada[i++].ToString();
            ev.FraseEquiv = entrada[i++].ToString();
            ev.ExemploOriginal = entrada[i++].ToString();
            ev.ExemploEquivalente = entrada[i++].ToString();
            ev.NotasCultura = entrada[i++].ToString();
            ev.NotasGramatica = entrada[i++].ToString();
            ev.Categoria = entrada[i++].ToString();
            return ev;
        }
    }
}
