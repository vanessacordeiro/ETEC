using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;

namespace PrimeiroBD
{
    public partial class Cadastro : Form
    {
        Crud conexao = new Crud();
        

        public Cadastro()
        {
            InitializeComponent();
            mostrar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (conexao.executar("insert into contato (nome,telefone,celular,email) values ('"+txtNome.Text+"','"+txtTelefone.Text+"','"+txtCelular.Text+"','"+txtEmail.Text+"')"))
            {
                mostrar();
                MessageBox.Show("Cadastrado com sucesso.");
                
                txtNome.Text = "";
                txtTelefone.Text = "";
                txtCelular.Text = "";
                txtEmail.Text = "";
            }
            else
            {
                MessageBox.Show("Não cadastrado!");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            conexao.fecharConexao();
            MessageBox.Show("Obrigado por utilizar nossa agenda!\n\nVolte sempre!");
            Application.Exit();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            Pesquisa busca = new Pesquisa();
            busca.Show();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            mostrar();
        }

        public void mostrar()
        {
            OdbcConnection Conexao = new OdbcConnection("Driver={Microsoft Access Driver (*.mdb, *.accdb)};Dbq=C:/Users/Etec/Desktop/bdTeste.mdb;Uid=;Pwd=;");
            int nColunas = 4;
            OdbcDataReader DRDados;

            Conexao.Open();
            OdbcCommand cmd = new OdbcCommand("select * from contato", Conexao);
            DRDados = cmd.ExecuteReader();

            dgTabela.Columns.Clear();
            dgTabela.Rows.Clear();

            for (int i = 1; i <= nColunas; i++)
            {
                dgTabela.Columns.Add(DRDados.GetName(i).ToString(), DRDados.GetName(i).ToString());
            }

            string[] registro = new string[nColunas];

            while (DRDados.Read())
            {
                for (int i = 0; i <= 3; i++)
                {
                    registro[i] = DRDados.GetString(i+1).ToString();
                }

                dgTabela.Rows.Add(registro);
            }

        }
    }
}
