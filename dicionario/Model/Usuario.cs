using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicionario.Model
{
    class Usuario
    {
        public Usuario() { }
        public string usr { get; set; }
        public string pass { get; set; }
        public string permissao { get; set; }
        public string email { get; set; }
        public string nome { get; set; }
        public string contato { get; set; }
        public string rsocial { get; set; }
        public string cpf { get; set; }
        public string tel { get; set; }

        public override string ToString()
        {
            string expressao = "usr=" + usr + ",pass='" + pass + "',nivel_permissao='" + permissao + "',email='" + email + "',nome='" + nome + "',contato='" + contato + "',rede_social='" + rsocial + "',cpf='" + cpf + "',telefone='" + tel;
            return expressao;
        }

        public static List<string> ToListTabela()
        {
            List<string> val = new List<string>();
            val.Add("usr");
            val.Add("pass");
            val.Add("nivel_permissao");
            val.Add("email");
            val.Add("nome");
            val.Add("contato");
            val.Add("rede_social");
            val.Add("cpf");
            val.Add("telefone");
            return val;
        }
        public List<string> ToListValores()
        {
            List<string> val = new List<string>();
            val.Add(usr.ToString());
            val.Add(pass);
            val.Add(permissao);
            val.Add(email);
            val.Add(nome);
            val.Add(contato);
            val.Add(rsocial);
            val.Add(cpf);
            val.Add(tel);
            return val;
        }
        public static List<Usuario> ConverteObject(List<object[]> entrada)
        {
            List<Usuario> s = new List<Usuario>();
            int lim = entrada.Count;
            Usuario pt = new Usuario();
            object[] po = new object[Usuario.ToListTabela().Count];
            for (int i = 0; i < lim; i++)
            {
                po = entrada.ElementAt(i);
                pt = (Usuario)po;
                s.Add(pt);
            }
            return s;
        }
        public static explicit operator Usuario (List<string> lista)
        {
            Usuario usu = new Usuario
            {
                usr = lista.ElementAt(0),
                pass = lista.ElementAt(1),
                permissao = lista.ElementAt(2),
                email = lista.ElementAt(3),
                nome = lista.ElementAt(4),
                contato = lista.ElementAt(5),
                rsocial = lista.ElementAt(6),
                cpf = lista.ElementAt(7),
                tel = lista.ElementAt(8)
            };
            return usu;
        }
        public static explicit operator Usuario (object[] entrada)
        {
            Usuario usu = new Usuario
            {
                usr = entrada[0].ToString(),
                pass = entrada[1].ToString(),
                permissao = entrada[2].ToString(),
                email = entrada[3].ToString(),
                nome = entrada[4].ToString(),
                contato = entrada[5].ToString(),
                rsocial = entrada[6].ToString(),
                cpf = entrada[7].ToString(),
                tel = entrada[8].ToString()
            };
            return usu;
        }
    }
    //class adsadfa : Tabelas, IServiceProvider { }
}
