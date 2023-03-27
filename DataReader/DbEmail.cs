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
            //ADICIONAR DIALOGO SE REALMENTE DESEJA SALVAR

            if (ValidarEmail(arquivoTxt))
            {
                Registro = Guid.NewGuid();

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
                MessageBox.Show("REMETENTE E DESTINATARIO PRECISA SER VÁLIDO!");
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
        public DataTable GetEmailsId(string buscar)
        {
            DataTable dt = new DataTable();
            
            try
            {
                var sql = "";
                if (buscar != "")
                {
                    if (buscar.Contains("@") && buscar.Contains(".com"))
                    {
                        sql = "SELECT *FROM EmailUsuario WHERE Remetente like " + "'%" + buscar + "%'";
                    }
                    else if (!buscar.Contains("@") && !buscar.Contains(".com"))
                    {
                        sql = "SELECT *FROM EmailUsuario WHERE Registro = " + "'" + buscar + "'";
                    }                  
                }

                SqlCommand cmd = new SqlCommand(sql, Conectar());

                SqlDataReader dtReader = null;              
           
                dtReader = cmd.ExecuteReader();                
                dt.Load(dtReader);

                if (dt.Rows.Count>0)
                {
                    return dt;
                }
                else
                {
                    MessageBox.Show("EMAIL NÃO ENCONTRADO!");
                }               

            }            

            catch
            {
                MessageBox.Show("ERRO AO PESQUISAR!");
            }
    
            return dt = null;
           
        }
        public void UpdateEmail()
        {

        }
        public void DeleteEmail(string buscar)
        {
            var sql = "";
            var email = GetEmailsId(buscar);

            if ( email.Rows.Count > 0)
            {

                try
                {
                    if (buscar.Contains("@") && buscar.Contains(".com"))
                    {
                        MessageBox.Show("DIGITE O NÚMERO DO REGISTRO QUE DESEJA REMOVER!");
                    }
                    else if (!buscar.Contains("@") && !buscar.Contains(".com"))
                    {
                        sql = "DELETE EmailUsuario where Registro ='"+ buscar +"'";
                    }

                    SqlCommand cmd = new SqlCommand(sql, Conectar());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("DADOS REMOVIDOS COM SUCESSO!");

                }
                catch
                {
                    MessageBox.Show("ERROR!");
                }
        
            }

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
        public bool ValidarEmail(ArquivoTxt arquivoTxt)
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
