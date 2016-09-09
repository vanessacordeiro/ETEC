using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Sistema_Supermercado
{
    public partial class Caixa : Form
    {
        OdbcConnection Conexao;
        OdbcDataReader DRBanco = null;
        int[,] carrinho = new int[2,100]; //posição 0-cod | 1-quantidade
        byte indice = 0; //indice

        public Caixa()
        {
            InitializeComponent();

            Conexao = new OdbcConnection("Driver={Microsoft Access Driver (*.mdb, *.accdb)};Dbq=C:/Users/Etec/Desktop/Supermercado (08_10)/Sistema_Supermercado/bdMercado.mdb;Uid=;Pwd=;");
            Conexao.Open();

            for (int x = 0; x < 2; x++)
            {
                for (int y = 0; y < 100; y++)
                {
                    carrinho[x, y] = 0;
                }
            }
        }

        private void btnCancelaCompra_Click(object sender, EventArgs e)
        {
            Application.OpenForms[1].Visible = true;
            this.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            OdbcCommand comando01 = new OdbcCommand("select * from produto where codProduto = "+txtCod.Text, Conexao);
            DRBanco = comando01.ExecuteReader();
            if (!DRBanco.Read())
            {
                MessageBox.Show("Nenhum produto cadastrado!");
            }
            else
            {
                txtNome.Text = DRBanco[1].ToString();
                txtPreco.Text = DRBanco[2].ToString();
                txtQuant.Text = "1";
                btnConfirmar.Enabled = true;
                btnInserir.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCod.Text = "";
            txtNome.Text = "";
            txtPreco.Text = "";
            txtQuant.Text = "";
            btnConfirmar.Enabled = false;
            btnInserir.Enabled = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            OdbcCommand comando01 = new OdbcCommand("select quantidade from produto where codProduto = " + txtCod.Text, Conexao);
            DRBanco = comando01.ExecuteReader();
            if (DRBanco.Read())
            {
                int oldQuant = int.Parse(DRBanco[0].ToString());
                int quant = int.Parse(txtQuant.Text);
                int preco = int.Parse(txtPreco.Text);
                int total = int.Parse(txtVTotal.Text);

                if (oldQuant >= quant)
                {
                    ltbCarrinho.Items.Add(txtNome.Text + " - " + txtQuant.Text + " x R$ " + txtPreco.Text);

                    txtVTotal.Text = (total + (quant * preco)).ToString();

                    carrinho[0, indice] = int.Parse(txtCod.Text);
                    carrinho[1, indice] = int.Parse(txtQuant.Text);
                    indice++;

                    txtCod.Text = "";
                    txtNome.Text = "";
                    txtPreco.Text = "";
                    txtQuant.Text = "";
                    btnConfirmar.Enabled = false;
                    btnInserir.Enabled = true;
                }
                else
                    MessageBox.Show("Quantidade indisponível no estoque!");
            }
        }

        private void txtVRecebido_TextChanged(object sender, EventArgs e)
        {
            if (!txtVRecebido.Text.Equals(""))
            {
                int total = int.Parse(txtVTotal.Text);
                int recebido = int.Parse(txtVRecebido.Text);
                txtTroco.Text = (recebido - total).ToString();
            }
            else
                txtTroco.Text = "";
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            int baixaEstoque = 0;
            for (int x = 0; x < 100; x++)
            {
                OdbcCommand comando01 = new OdbcCommand("select quantidade from produto where codProduto = " + carrinho[0, x], Conexao);
                DRBanco = comando01.ExecuteReader();
                if (DRBanco.Read() && !DRBanco[0].ToString().Equals(""))
                {
                    int quant = int.Parse(DRBanco[0].ToString()) - carrinho[1, x];
                    OdbcCommand comando02 = new OdbcCommand("update produto set quantidade='" + quant + "' where codProduto = " + carrinho[0, x], Conexao);

                    if (comando02.ExecuteNonQuery() == 1)
                    {
                        baixaEstoque++;
                    }
                }
            }
            
            if (baixaEstoque != 0)
            {
                MessageBox.Show("<<<< carregar lista aqui >>>> "+baixaEstoque);
            }
            else
                MessageBox.Show("Erro ao comprar!");

            for (int x = 0; x < 2; x++)
            {
                for (int y = 0; y < 100; y++)
                {
                    carrinho[x, y] = 0;
                }
            }
            indice = 0;

            ltbCarrinho.Items.Clear();
            txtPreco.Text = "0";
            txtVTotal.Text = "0";
            txtVRecebido.Text = "";
            txtTroco.Text = "";
            
        }
    }
}
