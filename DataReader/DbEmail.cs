using System;
using System.Collections.Generic;
using System.Data;
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

                var sql = "Insert EmailUsuario (Registro,Nome,Remetente,Destinatario,DataEnvio,DataGerada,Conteudo)values(@Registro,@Nome,@Remetente,@Destinatario,@DataEnvio,@DataGerada,@Conteudo)";

                SqlCommand cmd = new SqlCommand(sql, Conectar());

                cmd.Parameters.Add(new SqlParameter("@Registro", Registro));
                cmd.Parameters.Add(new SqlParameter("@Nome", arquivoTxt.Nome));
                cmd.Parameters.Add(new SqlParameter("@Remetente", arquivoTxt.Remetente));
                cmd.Parameters.Add(new SqlParameter("@Destinatario", arquivoTxt.Destinatario));
                cmd.Parameters.Add(new SqlParameter("@DataEnvio", arquivoTxt.DataEnvio));
                cmd.Parameters.Add(new SqlParameter("@DataGerada", DateTime.Now));
                cmd.Parameters.Add(new SqlParameter("@Conteudo", arquivoTxt.Conteudo));

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
            else
            {
                MessageBox.Show("REMETENTE E DESTINATARIO PRECISA SER VALIDO!");
            }

            
        }
        public DataTable GetAllEmails()
        {
            var sql = "SELECT *FROM EmailUsuario";
            SqlCommand cmd = new SqlCommand(sql, Conectar());

            SqlDataReader dtReader;
            dtReader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dtReader);
            return dt;
        }
        public DataTable GetEmailsId(string buscar, bool remetente)
        {
            // adicionar tratamento de espaço, tamanho, tipo etc
            // se for por remetente tem que ter @
            var sql = "";
            if (buscar != "")
            {
                if (remetente == true)
                {
                    sql = "SELECT *FROM EmailUsuario WHERE Remetente like " + "'%" + buscar + "%'";
                }
                else
                {
                    sql = "SELECT *FROM EmailUsuario WHERE Registro like " + "'%" + buscar + "%'";
                }
            }

            SqlCommand cmd = new SqlCommand(sql, Conectar());

            SqlDataReader dtReader;
            dtReader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dtReader);
            return dt;
        }
        public void UpdateEmail()
        {

        }
        public void DeleteEmail(string Registro)
        {
            var sql = "DELETE FROM EmailUsuario WHERE Registro = "+ Registro +"";

            SqlCommand cmd = new SqlCommand(sql, Conectar());
            cmd.ExecuteNonQuery();

        }
        public SqlConnection Conectar()
        {
            conn = new SqlConnection(StrConn);
            conn.Open();
            return conn;
        }

        public void Desconectar()
        {
            conn = new SqlConnection(StrConn);
            conn.Close();
        }
        private bool ValidarEmail(ArquivoTxt arquivoTxt)
        {
            if (arquivoTxt.Conteudo != "" && arquivoTxt.Remetente.Contains("@") && arquivoTxt.Remetente.Contains(".com") && arquivoTxt.Destinatario.Contains("@") && arquivoTxt.Destinatario.Contains(".com")) return true; return false;
        }

        private bool VerificarDuplicidade(ArquivoTxt arquivoTxt)
        {
            //implementar validação de dados existentes na tabela
            return true;
        }
    }

}
