using Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPFPresentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {

            Empresa emp = new Empresa(lblEstado.Text, lblNomeFantasia.Text, lblCNPJ.Text);
            Fornecedor forn = new Fornecedor(lblEmpresa.Text, lblNomeProprietario.Text, lblCNPJ2.Text, lblDataCadastro.Text, lblTelefone.Text, lblRG.Text, lblDataNascimento.Text);
            ClienteBLL bll = new ClienteBll();

                                              
                        
        }

        private int Tostring(string text)
        {
            throw new NotImplementedException();
        }

        private int ToString(string text)
        {
            throw new NotImplementedException();
        }
    }
}
