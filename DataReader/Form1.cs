using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataReader
{
    public partial class Form1 : Form
    {
        string Pasta;       
        string Validador1 = "<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<";
        string Validador2 = ">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>";

        ArquivoTxt arquivoTxt;
        DbEmail dbEmail = new DbEmail();
        public Form1()
        {
            InitializeComponent();
        }

        // lógica tarefa 1
        /*
           1 - procurar e selecionar pasta com os arquivos
           2 - verificar a extensão dos arquivos - txt ou eml 
           3 - selecionar todos os arquivos com a extensão definida
           4 - ler o arquivo txt separando as propriedades por linha
           5 - verificar se os dados do arquivo ja existe na base
           6 - salvar o conteúdo do arquivo na base           
         */

        // lógica tarefa 2
        /*

         */

        private void BtnSolucionar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Pasta = dialog.SelectedPath;
                TxtCaminho.Text = Pasta;

                DirectoryInfo directory = new DirectoryInfo(dialog.SelectedPath);
                FileInfo[] files = directory.GetFiles("*.txt");

                foreach (FileInfo file in files)
                {
                    var caminhoArquivo = string.Concat(string.Concat(directory, "\\", file.ToString()));

                    var conteudoArquivo = File.ReadAllLines(caminhoArquivo);

                    try
                    {
                        if ((conteudoArquivo != null || conteudoArquivo[0] == Validador1) && (conteudoArquivo[7] != null || conteudoArquivo[7] == Validador2))
                        {
                            arquivoTxt = new ArquivoTxt
                            {
                                DataEnvio = conteudoArquivo[2].Substring(11),
                                Nome = conteudoArquivo[3].Substring(5),
                                Remetente = conteudoArquivo[4].Substring(10),
                                Destinatario = conteudoArquivo[5].Substring(13),
                                Conteudo = conteudoArquivo[6].Substring(9)
                            };             
                        }
                    }
                    catch
                    {
                        MessageBox.Show(string.Concat("O ARQUIVO ", file.Name.ToUpper(), " É INVÁLIDO"));
                    }
                }

            }
           
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
              dbEmail.InsertEmail(arquivoTxt);              
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Add("");
            //var dataEmails = dbEmail.GetAllEmails();
        }
    }
}

