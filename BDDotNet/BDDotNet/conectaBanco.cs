using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;



namespace BDDotNet
{
    class conectaBanco
    {
        MySqlConnection conexao = new MySqlConnection("server=localhost;user id=root;password=;database=dotnet");
        public string mensagem;

        public DataTable listaProduto()
        {
            MySqlCommand cmd = new MySqlCommand("lista_produto", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }

        }// fim lista_produto
        public DataTable listaCategoria()
        {
            MySqlCommand cmd = new MySqlCommand("lista_categoria", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                mensagem = "Executou";
                return tabela;
            }// fim try
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }

        }// fim lista_categoria

        public DataTable listaFornecedor()
        {
            MySqlCommand cmd = new MySqlCommand("lista_fornecedor", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }

        }// fim lista_produto

        public bool insereProduto(produto b)
        {
            MySqlCommand cmd = new MySqlCommand("insereProduto", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nomeProduto", b.Nome);
            cmd.Parameters.AddWithValue("descricaoProduto", b.Descricao);
            cmd.Parameters.AddWithValue("precoProduto", b.Preco);
            cmd.Parameters.AddWithValue("idFornecedor", b.IdFornecedor);
            cmd.Parameters.AddWithValue("idCategoria", b.IdCategoria);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim insereProduto

        public bool insereCategoria(categoria b)
        {
            MySqlCommand cmd = new MySqlCommand("insereCategoria", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nomeCategoria", b.Nome);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim insereCategoria

        public bool insereFornecedor(fornecedor b)
        {
            MySqlCommand cmd = new MySqlCommand("insereFornecedor", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nomeFornecedor", b.Nome);
            cmd.Parameters.AddWithValue("cnpj", b.Cnpj);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool deletaProduto(int idProduto)
        {
            MySqlCommand cmd = new MySqlCommand("deletaProduto", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idProduto", idProduto);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim deletaProduto

        public bool deletaCategoria(int idCategoria)
        {
            MySqlCommand cmd = new MySqlCommand("deleta_categoria", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idCategoria", idCategoria);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim deletaCategoria

        public bool deletaFornecedor(int idFornecedor)
        {
            MySqlCommand cmd = new MySqlCommand("deleta_fornecedor", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idFornecedor", idFornecedor);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim deletaProduto

        public bool alteraProduto(produto b, int idProduto)
        {
            MySqlCommand cmd = new MySqlCommand("alteraProduto", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nomeProduto", b.Nome);
            cmd.Parameters.AddWithValue("descricaoProduto", b.Descricao);
            cmd.Parameters.AddWithValue("precoProduto", b.Preco);
            cmd.Parameters.AddWithValue("idFornecedor", b.IdFornecedor);
            cmd.Parameters.AddWithValue("idCategoria", b.IdCategoria);
            cmd.Parameters.AddWithValue("idProduto", idProduto);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim alteraProduto

        public bool alteraCategoria(categoria b, int idCategoria)
        {
            MySqlCommand cmd = new MySqlCommand("alteraCategoria", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nomeCategoria", b.Nome);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool alteraFornecedor(fornecedor b, int idFornecedor)
        {
            MySqlCommand cmd = new MySqlCommand("altera_fornecedor", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nomeFornecedor", b.Nome);
            cmd.Parameters.AddWithValue("cnpj", b.Cnpj);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim alteraFornecedor




    }
}
