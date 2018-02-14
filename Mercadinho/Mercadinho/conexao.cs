using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace Mercadinho
{
    class conexao
    {

        public string sql = "";
        public string sql2 = "";

        MySqlConnection conecta = new MySqlConnection();

        public int Runsql()
        {
            int nrlinhas;

            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = sql;
            comando.Connection = conecta;

            nrlinhas = comando.ExecuteNonQuery();

            return nrlinhas;

           





        }



        public int ExecuteScalar()
        {
            Int32 conta = 0;

            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = sql;
                comando.Connection = conecta;

                conta = (Int32)comando.ExecuteScalar();
            }
            catch
            {
                conta = 1;
            }

            return conta;

        }



       





        public MySqlDataReader Execsql()
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = sql;
            comando.Connection = conecta;

            MySqlDataReader dados = comando.ExecuteReader();



            return dados;
        }

        public void open()
        {
            if (conecta.State == ConnectionState.Closed)
            {
        //        conecta.ConnectionString = ("Server=localhost;Database=bd_caixa;User=root;Pwd=vertrigo");
                conecta.ConnectionString = ("server=10.67.48.3;Database=bd_caixa;User=aluno;Pwd=etec@147");
                conecta.Open();
            }
        }

        public void close()
        {
            if (conecta.State == ConnectionState.Open)
            {
                conecta.Close();
            }
        }
    
}


















    }

