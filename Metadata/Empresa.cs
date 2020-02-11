using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Empresa
    {
        private string text1;
        private string text2;
        private string text3;

        public Empresa(string nomeFantasia, int cnpj, string estado)
        {
            this.NomeFantasia = nomeFantasia;
            this.CNPJ = cnpj;
            this.Estado = estado;

        }

        public Empresa(string text1, string text2, string text3)
        {
            this.text1 = text1;
            this.text2 = text2;
            this.text3 = text3;
        }

        public string Estado { get; set; }
        public string NomeFantasia { get; set; }
        public int CNPJ { get; set; }
    }
}
