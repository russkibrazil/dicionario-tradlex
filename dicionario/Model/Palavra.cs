using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicionario.Model
{
    public class Palavra
    {
        public int id { get; set; }
        public string lema { get; set; }
	    public string ClasseGram { get; set; }
        public string idioma { get; set; }
        public string notas_gramatica { get; set; }
        public string nota_cultura { get; set; }
        public string Genero { get; set; }
        public string Definicao { get; set; }

        public List<string> ToListValores(bool incluiId = false)
        {
            List<string> val = new List<string>();
            if (incluiId)
                val.Add(id.ToString());
            val.Add(lema);
            val.Add(ClasseGram.ToString());
            val.Add(idioma);
            val.Add(notas_gramatica);
            val.Add(nota_cultura);
            val.Add(Genero);
            val.Add(Definicao);
            return val;
        }

        public static List<string> ToListTabela(bool incluiId = false)
        {
            List<string> val = new List<string>();
            if (incluiId)
                val.Add("id");
            val.Add("Lema");
	        val.Add("ClasseGram");
            val.Add("Idioma");
            val.Add("notas_gramatica");
            val.Add("Genero");
            val.Add("Definicao");
            return val;
        }

        public static List<Palavra> ConverteObject(List<object[]> entrada)
        {
            List<Palavra> s = new List<Palavra>();
            int lim = entrada.Count;
            Palavra pt = new Palavra();
            object[] po = new object[ToListTabela(true).Count];
            for (int i = 0; i < lim; i++)
            {
                po = entrada.ElementAt(i);
                pt = (Palavra)po;
                s.Add(pt);
            }
            return s;
        }
        public static explicit operator Palavra(List<string> lista)
        {
            int i = 0;
            Palavra p = new Palavra();
            if (int.TryParse(lista[i].ToString(),out int result))
            {
                p.id = result;
                i++;
            }
            p.lema = lista.ElementAt(i++);
            p.ClasseGram = lista.ElementAt(i++);        
            p.idioma = lista.ElementAt(i++);
            p.notas_gramatica = lista.ElementAt(i++);
            p.nota_cultura = lista.ElementAt(i++);
            p.Genero = lista.ElementAt(i++);
            p.Definicao = lista.ElementAt(i++);
            return p;
        }
        public static explicit operator Palavra(object[] lista)
        {
            Palavra saida = new Palavra();
            int i = 0;
            if (int.TryParse(lista[i].ToString(), out int resul))
            {
                saida.id = resul;
                i++;
            }
            saida.lema = lista[i++].ToString();
            saida.ClasseGram = lista[i++].ToString();
            saida.idioma = lista[i++].ToString();
            saida.notas_gramatica = lista[i++].ToString();
            saida.nota_cultura = lista[i++].ToString();
            saida.Genero = lista[i++].ToString();
            saida.Definicao = lista[i++].ToString();          
            return saida;
        }
        
    }
}