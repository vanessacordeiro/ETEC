using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Banco_MME
{
    public partial class Operacoes : Form
    {
        OdbcConnection Conexao;
        OdbcDataReader DRBanco = null;
        int codOperacao;

        public Operacoes()
        {
            InitializeComponent();

            Conexao = new OdbcConnection("Driver={Microsoft Access Driver (*.mdb, *.accdb)};Dbq=C:/Users/Etec/Desktop/Proj6 Banco MME/bdBancoMME.mdb;Uid=;Pwd=;");
            Conexao.Open();

            OdbcCommand comando01 = new OdbcCommand("select * from cliente", Conexao);
            DRBanco = comando01.ExecuteReader();
            if (!DRBanco.Read())
            {
                string data = DateTime.Now.ToShortDateString();
                string hora = DateTime.Now.ToLongTimeString();
                OdbcCommand comando02 = new OdbcCommand("insert into cliente(operacao,valor,saldo,data,hora) values('ABERT CONTA',0,0,'" + data + "','" + hora + "')", Conexao);
                comando02.ExecuteNonQuery();
            }
            else
            {
                do
                {
                    codOperacao = int.Parse(DRBanco[0].ToString());
                } while (DRBanco.Read());
            }
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            if (!txtValor.Text.Equals("") && !txtValor.Text.Contains(',') && !txtValor.Text.Contains('.'))
            {
                OdbcCommand comando1 = new OdbcCommand("select * from cliente where codOperacao = "+codOperacao, Conexao);
                DRBanco = comando1.ExecuteReader();
                DRBanco.Read();
            
                int valor = int.Parse(txtValor.Text);
                int saldo = int.Parse(DRBanco[3].ToString()) - valor;
                string data = DateTime.Now.ToShortDateString();
                string hora = DateTime.Now.ToLongTimeString();

                if (saldo >= valor)
                {
                    OdbcCommand comando2 = new OdbcCommand("insert into cliente(operacao,valor,saldo,data,hora) values('SAQUE',"+valor+","+saldo+",'" + data + "','" + hora + "')", Conexao);
                    if (comando2.ExecuteNonQuery() > 0)
                    {
                        codOperacao++;
                        txtValor.Text = "";
                        MessageBox.Show("Saque realizado!");
                    }
                }
                else
                {
                    MessageBox.Show("Saldo insuficiente!");
                }
            }
            else
            {
                MessageBox.Show("Valor digitado não é válido ou campo está em branco!\nAVISO - Este caixa não dispõe de moedas.");
            }
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            if (!txtValor.Text.Equals("") && !txtValor.Text.Contains(',') && !txtValor.Text.Contains('.'))
            {
                OdbcCommand comando1 = new OdbcCommand("select * from cliente where codOperacao = " + codOperacao, Conexao);
                DRBanco = comando1.ExecuteReader();
                DRBanco.Read();

                int valor = int.Parse(txtValor.Text);
                int saldo = int.Parse(DRBanco[3].ToString()) + valor;
                string data = DateTime.Now.ToShortDateString();
                string hora = DateTime.Now.ToLongTimeString();

                OdbcCommand comando2 = new OdbcCommand("insert into cliente(operacao,valor,saldo,data,hora) values('DEPOSITO'," + valor + "," + saldo + ",'" + data + "','" + hora + "')", Conexao);
                if (comando2.ExecuteNonQuery() > 0)
                {
                    codOperacao++;
                    txtValor.Text = "";
                    MessageBox.Show("Depósito realizado!");
                }
                else
                {
                    MessageBox.Show("Erro ao realizar depósito!");
                }
            }
            else
            {
                MessageBox.Show("Valor digitado não é válido ou campo está em branco!\nAVISO - Este caixa não aceita moedas.");
            }
        }

        private void btnExtrato_Click(object sender, EventArgs e)
        {
            Extrato janela = new Extrato();
            janela.Show();
        }
    }
}
