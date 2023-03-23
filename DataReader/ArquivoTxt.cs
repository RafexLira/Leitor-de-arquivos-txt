using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReader
{
    internal class ArquivoTxt
    {
        int Id { get; set; }
        public Guid Registro { get; }
        public string Nome { get; set; }
        public string Remetente { get; set; }
        public string Destinatario { get; set; }
        public string DataEnvio { get; set; }
        DateTime DataGerada { get; set; }
        public string Conteudo { get; set; }

        public ArquivoTxt()
        {
            DataGerada = DateTime.Now;
            Registro = Guid.NewGuid();
        }

        public ArquivoTxt(Guid registro)
        {
            Registro = registro;
        }
    }
}
