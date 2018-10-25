using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace QuestiPGM.Desk
{
    class DAL
    {
        #region Atributos
        private MySqlConnection _conexao;
        private MySqlCommand _comandoDB;
        private MySqlDataAdapter _adaptador;
        private DataSet _dados;
        #endregion

        #region Getters e setters
        public string Host { get; set; } = "localhost";
        public string DBName { get; set; } = "";
        public string Usuario { get; set; } = "root";
        public string Senha { get; set; } = "";
        #endregion

        #region Construtor
        public DAL() { }
        #endregion

        #region Métodos
        public void Conectar()
        {

            string strConexao = "Server=" + Host;
            strConexao += ";Database=" + DBName;
            strConexao += ";Uid=" + Usuario;
            strConexao += ";Pwd=" + Senha;
            strConexao += ";SSL Mode=None";

            try
            {
                _conexao = new MySqlConnection(strConexao);
                if (_conexao.State.Equals(ConnectionState.Closed))
                {
                    _conexao.Open();
                }

            }
            catch (MySqlException erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                _conexao.Dispose();
            }

        }

        public void Inserir(string strSQL)
        {
            try
            {
                Conectar();

                if (_conexao.State.Equals(ConnectionState.Closed))
                {
                    _conexao.Open();
                }

                _comandoDB = _conexao.CreateCommand();
                _comandoDB.CommandText = strSQL;

                if (_comandoDB.ExecuteNonQuery() != 1)
                {
                    throw new Exception("Falha ao inserir");
                }
            }
            catch (MySqlException erro)
            {
                throw new Exception("Erro ao inserir: " + erro.Message);
            }
        }

        public void Atualizar(string strSQL, List<MySqlParameter> valores)
        {
            Conectar();

            if (_conexao.State.Equals(ConnectionState.Closed))
            {
                _conexao.Open();
            }

            try
            {
                _comandoDB = _conexao.CreateCommand();
                _comandoDB.CommandText = strSQL;

                foreach (MySqlParameter param in valores)
                    _comandoDB.Parameters.Add(param);

                if (_comandoDB.ExecuteNonQuery() != 1)
                {
                    throw new Exception("A Atualização dos Dados FALHOU !!!");
                }

            }
            catch (MySqlException erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                if (_conexao.State == ConnectionState.Open)
                    _conexao.Close();
            }

        }


        #endregion
    }
}
