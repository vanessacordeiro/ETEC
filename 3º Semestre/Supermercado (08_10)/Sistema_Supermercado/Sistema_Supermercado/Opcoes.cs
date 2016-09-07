using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Supermercado
{
    public partial class Opcoes : Form
    {
        public Opcoes(bool[] funcoes)
        {
            InitializeComponent();

            btnCaixa.Enabled = funcoes[0];
            btnEstoque.Enabled = funcoes[1];
            btnRelatorio.Enabled = funcoes[2];
            btnCadastro.Enabled = funcoes[3];
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Caixa telaCaixa = new Caixa();
            telaCaixa.Show();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Estoque telaEstoque = new Estoque();
            telaEstoque.Show();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Relatorio telaRelatorio = new Relatorio();
            telaRelatorio.Show();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Cadastro telaCadastro = new Cadastro();
            telaCadastro.Show();
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Visible = true;
            this.Close();
        }
    }
}
