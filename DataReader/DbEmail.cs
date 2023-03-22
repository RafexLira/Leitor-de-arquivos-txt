using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataReader
{
    internal class DbEmail
    {
        private const string StrConn = "Data Source=COREI7\\SQLEXPRESS;Initial Catalog=DbEmail; Integrated Security=true";
        private SqlConnection conn;
        private Guid Registro;

        public DbEmail()
        {

        }

        public void InsertEmail(ArquivoTxt arquivoTxt)
        {

            if (ValidarEmail(arquivoTxt))
            {
                Registro = new Guid();
                //var param = string.Concat("'", Registro, "','", arquivoTxt.Nome, "','", arquivoTxt.Remetente, "','", arquivoTxt.Destinatario, "','", arquivoTxt.DataEnvio, "',", "GETDATE()", ",'", arquivoTxt.Conteudo, "'");

                var sql = "Insert EmailUsuario (Registro,Nome,Remetente,Destinatario,DataEnvio,DataGerada,Conteudo)values(@Registro,@Nome,@Remetente,@Destinatario,@DataEnvio,@DataGerada,@Conteudo)";

                SqlCommand cmd = new SqlCommand(sql,Conectar());

                cmd.Parameters.Add(new SqlParameter("@Registro", Registro));
                cmd.Parameters.Add(new SqlParameter("@Nome", arquivoTxt.Nome));
                cmd.Parameters.Add(new SqlParameter("@Remetente", arquivoTxt.Remetente));
                cmd.Parameters.Add(new SqlParameter("@Destinatario", arquivoTxt.Destinatario));
                cmd.Parameters.Add(new SqlParameter("@DataEnvio", arquivoTxt.DataEnvio));
                cmd.Parameters.Add(new SqlParameter("@DataGerada", DateTime.Now));
                cmd.Parameters.Add(new SqlParameter("@Conteudo", arquivoTxt.Conteudo));

                //SqlCommand cmd = new SqlCommand("Insert EmailUsuario (Registro,Nome,Remetente,Destinatario,DataEnvio,DataGerada,Conteudo)values(" + param + ")", Conectar());

                try
                {
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("DADOS INSERIDOS COM SUCESSO!");
                }
                catch
                {
                    MessageBox.Show("ERRO AO TENTAR INSERIR DADOS!");
                }

            }

           
        }
        public SqlDataReader GetAllEmails()
        {                      
            SqlCommand cmd = new SqlCommand("Select *from EmailUsuario", Conectar());
            SqlDataReader dtReader;
            dtReader = cmd.ExecuteReader();
            return dtReader;
        }
        public void UpdateEmail()
        {

        }
        public void DeleteEmail()
        {

        }

        public SqlConnection Conectar()
        {
            conn = new SqlConnection(StrConn);
            conn.Open();
            return conn;
        }

        private bool ValidarEmail(ArquivoTxt arquivoTxt)
        {
            if (arquivoTxt.Conteudo != "" && arquivoTxt.Remetente.Contains("@") && arquivoTxt.Remetente.Contains(".com") && arquivoTxt.Destinatario.Contains("@") && arquivoTxt.Destinatario.Contains(".com")) return true; return false;
        }

    }
}
