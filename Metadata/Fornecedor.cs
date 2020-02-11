using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Fornecedor
    {
        private string text1;
        private string text2;
        private string text3;
        private string text4;
        private string text5;
        private string text6;
        private string text7;

        public Fornecedor(string nomeEmpresa, string nomeProprietario, int cnpj, DateTime dataCadastro, int telefone, int rg, DateTime dataNascimento)
        {
            this.NomeEmpresa = nomeEmpresa;
            this.NomeProprietario = nomeProprietario;
            this.CPNJ =cnpj;
            this.DataCadastro = dataCadastro;
            this.Telefone = telefone;
            this.RG = rg;
            this.DataNascimento = dataNascimento;


        }

        public Fornecedor(string text1, string text2, string text3, string text4, string text5, string text6, string text7)
        {
            this.text1 = text1;
            this.text2 = text2;
            this.text3 = text3;
            this.text4 = text4;
            this.text5 = text5;
            this.text6 = text6;
            this.text7 = text7;
        }

        public string NomeEmpresa { get; set; }
        public string NomeProprietario { get; set; }
        public int CPNJ { get; set; }
        public DateTime DataCadastro { get; set; }
        public int Telefone { get; set; }
        public int RG { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
