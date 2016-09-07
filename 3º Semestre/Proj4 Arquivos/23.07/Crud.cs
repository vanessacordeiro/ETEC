using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _23._07
{
    public partial class Crud : Form
    {
        String[,] contatos = null;
        int posic;

        public Crud(String[,] contatos)
        {
            InitializeComponent();
            this.contatos = contatos;
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                if (txtNome.Text.ToUpper().Equals(contatos[0, i]))
                {
                    txtEndereco.Text = contatos[1, i];
                    txtTelefone.Text = contatos[2, i];
                    posic = i;

                    txtEndereco.Enabled = true;
                    txtTelefone.Enabled = true;
                    btnAlterar.Visible = true;
                    btnExcluir.Visible = true;
                    break;
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            contatos[0, posic] = txtNome.Text.ToUpper();
            contatos[1, posic] = txtEndereco.Text.ToUpper();
            contatos[2, posic] = txtTelefone.Text.ToUpper();

            txtNome.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
            txtEndereco.Enabled = false;
            txtTelefone.Enabled = false;
            btnAlterar.Visible = false;
            btnExcluir.Visible = false;

            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            for (int i = posic; i < 100; i++)
            {
                if (i != 99)
                {
                    contatos[0, i] = contatos[0, i + 1];
                    contatos[1, i] = contatos[1, i + 1];
                    contatos[2, i] = contatos[2, i + 1];
                }
                else
                {
                    contatos[0, i] = null;
                    contatos[1, i] = null;
                    contatos[2, i] = null;
                }
            }

            this.Close();
        }
    }
}
