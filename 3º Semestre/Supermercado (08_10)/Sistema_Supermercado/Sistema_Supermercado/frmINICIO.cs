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
    public partial class Tela1 : Form
    {
        public Tela1()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if ((txtLogin.Text == "adm") && (txtSenha.Text == "123"))
            {
                txtLogin.Text = "";
                txtSenha.Text = "";
                this.Visible = false;

                bool[] funcoes = { true, true, true, true };
                Opcoes setores = new Opcoes(funcoes);
                setores.Show();
            }
            else if ((txtLogin.Text == "caixa") && (txtSenha.Text == "123"))
            {
                txtLogin.Text = "";
                txtSenha.Text = "";
                this.Visible = false;

                bool[] funcoes = { true, false, false, false };
                Opcoes setores = new Opcoes(funcoes);
                setores.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos", "Ocorreu um erro ao autentificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Tela1_Load(object sender, EventArgs e)
        {

        }
    }
}