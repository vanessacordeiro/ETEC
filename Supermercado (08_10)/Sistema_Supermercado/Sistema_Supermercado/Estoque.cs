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
    public partial class Estoque : Form
    {
        OdbcConnection Conexao;
        OdbcDataReader DRBanco = null;

        public Estoque()
        {
            InitializeComponent();

            Conexao = new OdbcConnection("Driver={Microsoft Access Driver (*.mdb, *.accdb)};Dbq=C:/Users/Etec/Desktop/Supermercado (08_10)/Sistema_Supermercado/bdMercado.mdb;Uid=;Pwd=;");
            Conexao.Open();

            carregaTabela();
        }

        public void carregaTabela()
        {
            OdbcCommand comando01 = new OdbcCommand("select * from produto", Conexao);
            DRBanco = comando01.ExecuteReader();
            ctableEstoque.Rows.Clear();
            if (!DRBanco.Read())
            {
                ctableEstoque.Rows.Add(new object[] { "-", "Nenhum produto cadastrado!", "-", "-", "-" });
            }
            else
            {
                do
                {
                    ctableEstoque.Rows.Add(new object[] { DRBanco[0].ToString(), DRBanco[1].ToString(), DRBanco[2].ToString(), DRBanco[3].ToString(), DRBanco[4].ToString() });
                } while (DRBanco.Read());
            }
        }

        public void filtraTabela()
        {
            OdbcCommand comando01 = new OdbcCommand("select * from produto", Conexao);
            DRBanco = comando01.ExecuteReader();
            ctableEstoque.Rows.Clear();
            if (!DRBanco.Read())
            {
                ctableEstoque.Rows.Add(new object[] { "-", "Nenhum produto encontrado!", "-", "-", "-" });

                string data = DateTime.Now.ToShortDateString();
                string hora = DateTime.Now.ToLongTimeString();
            }
            else
            {
                do
                {
                    if(DRBanco[1].ToString().Contains(txtProdEstoque.Text))
                        ctableEstoque.Rows.Add(new object[] { DRBanco[0].ToString(), DRBanco[1].ToString(), DRBanco[2].ToString(), DRBanco[3].ToString(), DRBanco[4].ToString() });
                } while (DRBanco.Read());
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!txtProdEstoque.Text.Equals(""))
            {
                filtraTabela();
                btnCancelar.Visible = true;
            }
            else
            {
                carregaTabela();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Visible = true;

            OdbcCommand comando01 = new OdbcCommand("update produto set nome='"+txtNome.Text+"', valor='"+txtValor.Text+"', quantidade='"+txtQuantidade.Text+"', categoria='"+cbxCategoria.SelectedItem+"' where codProduto = " + txtCod.Text, Conexao);

            if (comando01.ExecuteNonQuery() == 1)
            {
                carregaTabela();
                MessageBox.Show("Produto alterado com sucesso!");
                txtCod.Text = "";
                txtNome.Text = "";
                txtValor.Text = "";
                txtQuantidade.Text = "";
                cbxCategoria.SelectedIndex = 0;
            }
            else
                MessageBox.Show("Erro ao alterar!");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Visible = true;

            OdbcCommand comando01 = new OdbcCommand("delete * from produto where codProduto = "+txtCod.Text, Conexao);
            
            if (comando01.ExecuteNonQuery() == 1)
            {
                carregaTabela();
                MessageBox.Show("Produto excluído com sucesso!");
                txtCod.Text = "";
                txtNome.Text = "";
                txtValor.Text = "";
                txtQuantidade.Text = "";
                cbxCategoria.SelectedIndex = 0;
            }
            else
                MessageBox.Show("Erro ao excluir!");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Visible = false;
            btnCadastrar.Visible = true;

            txtProdEstoque.Text = "";
            txtCod.Text = "";
            txtNome.Text = "";
            txtValor.Text = "";
            txtQuantidade.Text = "";
            cbxCategoria.SelectedIndex = 0;
            carregaTabela();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Visible = false;

            if (!txtNome.Text.Equals("") && !txtValor.Text.Equals("") && !txtQuantidade.Text.Equals("") && !cbxCategoria.SelectedItem.Equals(""))
            {
                OdbcCommand comando02 = new OdbcCommand("insert into produto(nome,valor,quantidade,categoria) values('" + txtNome.Text + "','" + txtValor.Text + "','" + txtQuantidade.Text + "','" + cbxCategoria.SelectedItem + "')", Conexao);
                if (comando02.ExecuteNonQuery() == 1)
                {
                    carregaTabela();
                    MessageBox.Show("Cadastro de '" + txtNome.Text + "' realizado!");
                    txtCod.Text = "";
                    txtNome.Text = "";
                    txtValor.Text = "";
                    txtQuantidade.Text = "";
                    cbxCategoria.SelectedIndex = 0;
                }
                else
                    MessageBox.Show("Erro ao cadastrar!");
            }
            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Application.OpenForms[1].Visible = true;
            this.Close();
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Visible = true;
            this.Close();
        }

        private void ctableEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnCancelar.Visible = true;

            txtCod.Text = ctableEstoque.SelectedCells[0].Value.ToString();
            txtNome.Text = ctableEstoque.SelectedCells[1].Value.ToString();
            txtValor.Text = ctableEstoque.SelectedCells[2].Value.ToString();
            txtQuantidade.Text = ctableEstoque.SelectedCells[3].Value.ToString();
            cbxCategoria.SelectedItem = ctableEstoque.SelectedCells[4].Value.ToString();
        }
    }
}
