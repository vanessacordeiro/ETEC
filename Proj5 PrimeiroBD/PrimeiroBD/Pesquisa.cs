using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimeiroBD
{
    public partial class Pesquisa : Form
    {
        Crud conexao = new Crud();
        int codContato = -1;

        public Pesquisa()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (conexao.buscar("select * from contato where nome like '" + txtNome.Text + "'"))
            {
                txtTelefone.Enabled = true;
                txtCelular.Enabled = true;
                txtEmail.Enabled = true;

                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
                btnBuscar.Enabled = false;

                codContato = int.Parse(conexao.retornaCampo(0));
                txtNome.Text = conexao.retornaCampo(1);
                txtTelefone.Text = conexao.retornaCampo(2);
                txtCelular.Text = conexao.retornaCampo(3);
                txtEmail.Text = conexao.retornaCampo(4);
            }
            else
            {
                MessageBox.Show("Nome não encontrado!");
            }
            
            conexao.fecharLeitura();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        public void limpar()
        {
            txtTelefone.Enabled = false;
            txtCelular.Enabled = false;
            txtEmail.Enabled = false;

            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
            btnBuscar.Enabled = true;

            codContato = -1;
            txtNome.Text = "";
            txtTelefone.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (conexao.executar("delete * from contato where codContato = " + codContato))
            {
                MessageBox.Show("Contato deletado com sucesso!");
                limpar();
            }
            else
            {
                MessageBox.Show("Erro ao deletar contato!");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (conexao.executar("update contato set nome = '" + txtNome.Text + "', telefone = '" + txtTelefone.Text + "', celular = '" + txtCelular.Text + "', email = '" + txtEmail.Text + "' where codContato = " + codContato))
            {
                MessageBox.Show("Contato atualizado com sucesso!");
                limpar();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar o contato!");
            }
        }
    }
}
