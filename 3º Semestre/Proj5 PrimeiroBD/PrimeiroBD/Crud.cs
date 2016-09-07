using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Data;

namespace PrimeiroBD
{
    class Crud
    {
        OdbcConnection Conexao;
        OdbcDataReader DRDados = null;

        public Crud()
        {
            Conexao = new OdbcConnection("Driver={Microsoft Access Driver (*.mdb, *.accdb)};Dbq=C:/Users/Etec/Desktop/bdTeste.mdb;Uid=;Pwd=;");
            Conexao.Open();
        }

        public bool buscar(string sql)
        {
            OdbcCommand comando = new OdbcCommand(sql, Conexao);
            DRDados = comando.ExecuteReader();
            if (this.proxRegistro())
                return true;
            else
                return false;
        }

        public bool executar(string sql)
        {
            OdbcCommand comando = new OdbcCommand(sql, Conexao);

            if (comando.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool proxRegistro()
        {
            if (DRDados.Read())
                return true;
            else
                return false;
        }

        public string retornaCampo(int i)
        {
            return DRDados[i].ToString();
        }

        public void fecharLeitura()
        {
            DRDados.Close();
        }
        public void fecharConexao()
        {
            Conexao.Close();
        }
    }
}
