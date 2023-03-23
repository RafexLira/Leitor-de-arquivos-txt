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
            CbRegistro.Checked = true;
            dataGridView1.DataSource = dbEmail.GetAllEmails();
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
              dbEmail.Desconectar();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbEmail.GetEmailsId(TxtBuscar.Text,CbRemetente.Checked);
            dbEmail.Desconectar();
        }

        private void CbRemetente_CheckedChanged(object sender, EventArgs e)
        {
            if (CbRemetente.Checked == true) CbRegistro.Checked = false; 
        }

        private void CbRegistro_CheckedChanged(object sender, EventArgs e)
        {
            if (CbRegistro.Checked == true) CbRemetente.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtCaminho.Text = "";
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
           // List<DataTable> dt = new List<DataTable>();
            
           //var x = dbEmail.GetEmailsId(TxtBuscar.Text, CbRemetente.Checked = false);
           
           // foreach (var y in x)
           // {

           // }

           // dbEmail.DeleteEmail();
        }
    }
}

