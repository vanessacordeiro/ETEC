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
    public partial class Extrato : Form
    {
        OdbcConnection Conexao;
        OdbcDataReader DRBanco = null;

        public Extrato()
        {
            InitializeComponent();

            Conexao = new OdbcConnection("Driver={Microsoft Access Driver (*.mdb, *.accdb)};Dbq=C:/Users/Etec/Desktop/Proj6 Banco MME/bdBancoMME.mdb;Uid=;Pwd=;");
            Conexao.Open();

            OdbcCommand comando = new OdbcCommand("select * from cliente", Conexao);
            DRBanco = comando.ExecuteReader();

            dgvExtrato.Columns.Clear();
            dgvExtrato.Rows.Clear();
            
            //bool temRegistro = ;
            if (DRBanco.Read())
            {
                dgvExtrato.Columns.Add("operacao", "Operação");
                dgvExtrato.Columns.Add("valor", "Valor da Op");
                dgvExtrato.Columns.Add("saldo", "Saldo atual");
                dgvExtrato.Columns.Add("data", "Data");
                dgvExtrato.Columns.Add("hora", "Hora");

                string[] registro = new string[5];

                do
                {
                    for (int i = 1; i <= 5; i++)
                    {
                        registro[i - 1] = DRBanco.GetString(i);
                    }
                    dgvExtrato.Rows.Add(registro);
                } while (DRBanco.Read());

                
            }
            else
            {
                string texto = "Erro ao emitir comprovante!";
                dgvExtrato.Columns.Add(texto, texto);
            }
        }
    }
}
