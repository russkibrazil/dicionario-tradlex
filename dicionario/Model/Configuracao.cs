using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicionario.Model
{
    class Configuracao
    {
        public string connName { get; set; }
        public string hostname { get; set; }
        public string port { get; set; }
        public string username { get; set; }
        public string pswd { get; set; }

        public override string ToString()
        {
            string expressao = "connName='" + connName + "',hostname='" + hostname + "',port=" + port + "',username='" +
                username + "',pasword='" + pswd + "'";
            return expressao;
        }

        public List<string> ToListTabela()
        {
            List<string> val = new List<string>();
            val.Add("connName");
            val.Add("hostname");
            val.Add("port");
            val.Add("username");
            val.Add("pswd");

            return val;
            
        }
        public List<string> ToListValores()
        {
            List<string> val = new List<string>();
            val.Add(connName);
            val.Add(hostname);
            val.Add(port);
            val.Add(username);
            val.Add(pswd);

            return val;
        }
    }
}
