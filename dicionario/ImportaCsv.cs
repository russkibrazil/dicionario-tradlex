using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using dicionario.Model;
using dicionario.Helpers;
using System.Collections;

namespace dicionario
{
    public partial class frmImportaCsv : Form
    {
        private enum EnumErros
        {
            Erro_dados,
            Erro_coluna_destino,
            Informa_Abortado

        }
        CRUD operacoes = new CRUD();
        public frmImportaCsv()
        {
            InitializeComponent();
        }

        private void BtnProcura_Click(object sender, EventArgs e)
        {
            if (AbreArquivoDialog.ShowDialog() == DialogResult.OK)
            {
                LblArquivo.Text = AbreArquivoDialog.FileName;
                BtnStart.Enabled = true;
                listErros.Items.Clear();
            }
        }

        private int LiberaArquivo (StreamReader f)
        {
            try{
            f.DiscardBufferedData();
            f.Dispose();
            }
            catch (IOException)
            {
                InformaDiag.Erro("Erro ao liberar o arquivo");
                return 1;
            }
            return 0;
        }
        private void BtnStart_Click(object sender, EventArgs e)
        //NOTE: Usar ponto e vírgula como separador no CSV
        {
            string linha;
            string[] divisor;
            int v = 0;
            List<string> ptlt = new List<string>();
            progressBar1.MarqueeAnimationSpeed = 50;
            if (ComboTable.Text != "")
            {
                switch (ComboTable.Text)
                {
                    case "Palavra":
                        v = Palavra.ToListTabela().Count;
                        ptlt = Palavra.ToListTabela();
                        break;
                    case "Referência":
                        v = Referencia.ToListTabela().Count;
                        ptlt = Referencia.ToListTabela();
                        break;
                    default:
                        throw new Exception("Não implementado");                       
                }
                try
                {
                    StreamReader leitor = new StreamReader(LblArquivo.Text, Encoding.Default);
                    try
                    {
                        do
                        {
                            linha = leitor.ReadLine();
                            if (linha != "")
                            {
                                divisor = linha.Split(';');
                                //varificar dimensao antes de prosseguir
                                if (divisor.Count() != v)
                                {
                                    InformaDiag.Erro("A quantidade de colunas da entrada é diferente do destino.\nOperação Abortada.");
                                    progressBar1.MarqueeAnimationSpeed = 0;
                                    BtnStart.Enabled = false;
                                    LiberaArquivo(leitor);
                                    return;
                                }
                                
                                for (int i = 0; i < divisor.GetLength(0); i++)
                                {
                                    if (divisor[i] == ptlt.ElementAt(i))
                                        dataGridView1.Columns.Add(divisor[i], divisor[i]);
                                    else
                                    {
                                        dataGridView1.Columns.Clear();
                                        EnumeraColunasFaltantes(divisor, ptlt);
                                        progressBar1.MarqueeAnimationSpeed = 0;
                                        BtnStart.Enabled = false;
                                        LiberaArquivo(leitor);
                                        return;
                                    }
                                }
                            }
                        } while (linha == "");
                        do //implementar thread
                        {
                            linha = leitor.ReadLine();
                            if (linha != "")
                            {
                                divisor = linha.Split(';');
                                dataGridView1.Rows.Add(divisor);
                            }
                        } while (leitor.Peek() != -1);
                        LiberaArquivo(leitor);
                    }
                    catch (IndexOutOfRangeException) { }
                    catch (EndOfStreamException) { }
                }
                
                catch (FileLoadException) {
                    return;
                }
                catch (FileNotFoundException) {
                    return;
                }
                catch (IOException)
                {
                    InformaDiag.Erro("O arquivo está inacessível no momento.\nTente novamente mais tarde.");
                    return;
                }
                BtnStart.Enabled = false;
                BtnProcura.Enabled = false;
                BtnCancela.Enabled = true;
                BtnGrava.Enabled = true;
                ComboTable.Enabled = false;
                progressBar1.MarqueeAnimationSpeed = 0;
 
            }
            else
            {
                InformaDiag.Informa("Escolha uma tabela destino");
            }
            
        }
        private void EnumeraColunasFaltantes(string[] linhasEncontradas, List<string> camposEsperados)
        {
            int i = camposEsperados.Count;
            IEnumerator<string> lTe = camposEsperados.GetEnumerator();
            IEnumerator lEe = linhasEncontradas.GetEnumerator();
            VerificadorIgualdadeNomes(lEe, lTe, i);
        }

        private void VerificadorIgualdadeNomes(IEnumerator opl, IEnumerator<string> opr, int max)
        {
            for (int i = 0; i < max; i++)
            {
                opl.MoveNext();
                opr.MoveNext();
                if ((string) opl.Current != opr.Current)
                {
                    LoggerErros(EnumErros.Erro_coluna_destino, new List<string> { opr.Current, (string)opl.Current }); 
                }
            }
            LoggerErros(EnumErros.Informa_Abortado);
        }

        private void BtnCancela_Click(object sender, EventArgs e)
        {
            if (InformaDiag.ConfirmaSN("Você tem certeza que deseja apagar todos os dados não salvos?") == DialogResult.Yes)
            {
                progressBar1.MarqueeAnimationSpeed = 50;
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                BtnCancela.Enabled = false;
                BtnGrava.Enabled = false;
                BtnStart.Enabled = false;
                ComboTable.Enabled = true;
                BtnProcura.Enabled = true;
                LblArquivo.Text = "Nenhum arquivo selecionado";
                progressBar1.MarqueeAnimationSpeed = 0;
            }
        }

        private void LblArquivo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private List<string> SanitizaValores(string tabela, List<string> valores)
        { //função para trocar possíveis valores em string por suas respectivas FK
            string saida;
            
            for(int i = 0; i < valores.Count; i++)
            {
                if (SanitizaString(valores.ElementAt(i), out saida)){
                    valores.RemoveAt(i);
                    valores.Insert(i,saida);
                }
            }
            if (tabela == tabelasBd.PALAVRA){
                List<string> FKs = new List<string>();
                int idx, c = 0;
                bool[] fila = { false, false};
                ///TODO: Ah, enumeradores...
                /////faço issoi para evitar que seja lançada uma exceção e os valores perdidos no cast logo abaixo
                //rubrica
                idx = Palavra.ToListTabela().FindIndex(bs => bs == "Rubrica");
                if (!int.TryParse(valores.ElementAt(idx), out int conv) && (valores.ElementAt(idx) != ""))
                {
                    FKs.Add(valores.ElementAt(idx));
                valores.RemoveAt(idx);
                valores.Insert(idx, "0");
                    fila[c] = true;
                }
                c++;
                //referencia
                idx = Palavra.ToListTabela().FindIndex(bs => bs == "referencia_verbete");
                if (!int.TryParse(valores.ElementAt(idx), out conv) && (valores.ElementAt(idx) != ""))
                {
                    FKs.Add(valores.ElementAt(idx));
                valores.RemoveAt(idx);
                valores.Insert(idx, "0");
                    fila[c++] = true;
                }
                c++;

                idx = Palavra.ToListTabela().FindIndex(bs => bs == "Infinitivo");
                if (!int.TryParse(valores.ElementAt(idx), out conv))
                {
                    valores.RemoveAt(idx);
                    valores.Insert(idx, "0");
                }
                idx = Palavra.ToListTabela().FindIndex(bs => bs == "Id_conjuga");
                if (!int.TryParse(valores.ElementAt(idx), out conv))
                {
                    valores.RemoveAt(idx);
                    valores.Insert(idx, "0");
                }

                Palavra teste = new Palavra();
                try
                {
                    teste = (Palavra)valores;
                }
                catch (InvalidCastException)
                {
                    LoggerErros(EnumErros.Erro_dados);
                    return null;
                }
                catch (FormatException)
                {
                    LoggerErros(EnumErros.Erro_dados);
                    return null;
                }

                List<Referencia> lref = new List<Referencia>();
                IEnumerator<string> ff = FKs.GetEnumerator();
                c = 0;
                if (fila[c++]){
                    ff.MoveNext();
                }
                if (fila[c]){
                    saida = ff.Current;
                    lref = Referencia.ConverteObject(operacoes.SelecionarTabela(tabelasBd.REFERENCIAS, Referencia.ToListTabela(true), "Cod='" + saida + "'"));
                    if (lref.Count > 0)
                    {
                       // teste.referencia_verbete = lref.First().id;
                    }
                    else
                    {
                        return null;
                    }
                }
                    valores.Clear();
                    valores.AddRange(teste.ToListValores());             
            }
            return valores;
        }
        private void LoggerErros(EnumErros erro, List<string> outrosParam = null)
        {
            switch (erro)
            {
                case EnumErros.Erro_dados:
                    listErros.Items.Add("Tipo de dado divergente ou inválido");
                    break;
                case EnumErros.Erro_coluna_destino:
                    if (outrosParam.Count < 2) throw new Exception("Argumentos insuficientes");

                    IEnumerator<string> args = outrosParam.GetEnumerator();
                    args.MoveNext();
                    string msg = "O programa espera encontrar a coluna " + args.Current + " mas encontrou ";

                    args.MoveNext();
                    msg += args.Current;

                    listErros.Items.Add(msg);
                    break;
                case EnumErros.Informa_Abortado:
                    listErros.Items.Add("Operação abortada");
                    break;
                default:
                    throw new Exception("Não implementado");
                    break;
            }
        }
        private void BtnGrava_Click(object sender, EventArgs e)
        {

                if (InformaDiag.ConfirmaSN("Você tem certeza que deseja continuar?\n" + "Todos os dados válidos da tabela serão salvos no Banco de Dados!") == DialogResult.Yes)
                {
                    if (importador(ComboTable.Text) == 1)
                       InformaDiag.Informa("Houveram erros na importação e alguns registros foram ignorados.");
                    BtnProcura.Enabled = true;
                    LblArquivo.Text = "Nenhum arquivo selecionado";
                    progressBar1.MarqueeAnimationSpeed = 0;
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();
                }
        }
        private int importador(string NomeTabela)
        {
            DataGridViewRow[] linhas = new DataGridViewRow[dataGridView1.Rows.Count];
            DataGridViewCell[] cell = new DataGridViewCell[dataGridView1.ColumnCount];
            List<string> ValoresLinha = new List<string>();
            string query = "";

            switch (NomeTabela)
            {
                case "Palavra":
                    NomeTabela = tabelasBd.PALAVRA;
                    break;
                case "Rubrica":
                    NomeTabela = tabelasBd.RUBRICA;
                    break;
                case "Referência":
                    NomeTabela = tabelasBd.REFERENCIAS;
                    break;
            }

            progressBar1.MarqueeAnimationSpeed = 50;
            BtnCancela.Enabled = false;
            BtnGrava.Enabled = false;
            BtnStart.Enabled = false;
            BtnProcura.Enabled = false;

            try
            {
                dataGridView1.Rows.CopyTo(linhas, 0);
            }
            catch(OutOfMemoryException)
            {
                InformaDiag.Erro("Memória esgotada!\nTente novamente importando menos registros.");
            }

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                //pegar uma linha da grade e coloca no ValoresLinha
                linhas[i].Cells.CopyTo(cell, 0);
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    ValoresLinha.Add(Convert.ToString(cell[j].Value));  
                }

                query += "(";
                ValoresLinha = SanitizaValores(NomeTabela, ValoresLinha);
                if (ValoresLinha == null) {
                    ValoresLinha = new List<string>();
                    query = query.Remove(query.Count() - 1);
                    continue;
                }
                foreach (string s in ValoresLinha)
                {
                    if (HelperBd.VerificaInt(s)){
                        query += (s + ",");
                    }
                    else
                    {
                        if (HelperBd.VerificaBool(s, out string valor))
                            query += (valor + ",");
                        else
                            query += "'" + s + "',";
                    }
                }
                query = query.Remove(query.Count()-1);
                query += "),";
                ValoresLinha.Clear();
            }
            if (query.Count() > 0){
                query = query.Remove(query.Count() - 1);
                query += ";";
                operacoes.InserirEmMassa(NomeTabela, query);
                return 0;
            }
            return 1;
        }
        private bool SanitizaString (string valor, out string saida)
        {
            if (valor.Contains("'")){
                saida = valor.Replace(char.Parse("'"), char.Parse("*"));
                return true;
            }
            saida = valor;
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }

    }
}
