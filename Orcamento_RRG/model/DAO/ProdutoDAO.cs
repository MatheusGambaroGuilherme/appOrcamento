using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Orcamento_RRG.model.DAO
{
    internal class ProdutoDAO
    {
        private static SQLiteConnection con;

        private static SQLiteConnection ConexaoBanco()
        {
            string caminhoBanco = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
            string dbPath = caminhoBanco + @"data_base\db_rrg";
            con = new SQLiteConnection($"Data Source={dbPath};Mode=ReadWrite;");
            con.Open();
            return con;
        }

        public static DataTable obterProdutos(int op)
        {
            DataTable dt = new DataTable(); // objeto que retorna oq pedi ao banco
            SQLiteDataAdapter da = null; // objeto que cria a query no banco

            try
            {
                var cmd = ConexaoBanco().CreateCommand();
                if(op == 0) cmd.CommandText = "Select * from Produto where ativo = 1"; // criação da query
                if(op == 1) cmd.CommandText = "Select * from Produto where ativo = 1 order by valorVenda ASC "; // criação da query
                if(op == 2) cmd.CommandText = "Select * from Produto where ativo = 1 order by valorCompra ASC "; // criação da query
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco()); // execução da query
                da.Fill(dt);// preenchimento do dt com os elementos recebidos
                con.Close();
                return dt;
                
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable obterNomeProdutos()
        {
            DataTable dt = new DataTable(); // objeto que retorna oq pedi ao banco
            SQLiteDataAdapter da = null; // objeto que cria a query no banco

            try
            {
                var cmd = ConexaoBanco().CreateCommand();

                cmd.CommandText = "Select nome as 'Nome' from Produto where ativo = 1"; // criação da query
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco()); // execução da query
                da.Fill(dt);// preenchimento do dt com os elementos recebidos
                con.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable obterValorVendaProdutos()
        {
            DataTable dt = new DataTable(); // objeto que retorna oq pedi ao banco
            SQLiteDataAdapter da = null; // objeto que cria a query no banco

            try
            {
                var cmd = ConexaoBanco().CreateCommand();

                cmd.CommandText = "Select nome as 'Nome', valorVenda as 'Valor de Venda' from Produto where ativo = 1 order by valorVenda ASC"; // criação da query
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco()); // execução da query
                da.Fill(dt);// preenchimento do dt com os elementos recebidos
                con.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable obterValoCompraProdutos()
        {
            DataTable dt = new DataTable(); // objeto que retorna oq pedi ao banco
            SQLiteDataAdapter da = null; // objeto que cria a query no banco

            try
            {
                var cmd = ConexaoBanco().CreateCommand();

                cmd.CommandText = "Select nome as 'Nome', valorCompra as 'Valor Compra' from Produto where ativo = 1 order by valorCompra ASC"; // criação da query
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco()); // execução da query
                da.Fill(dt);// preenchimento do dt com os elementos recebidos
                con.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void cadastrarProduto(Produto produto)
        {
            try
            {
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "INSERT into produto (nome, valorVenda, valorCompra, codigo, ativo) values(@nome, @valorVenda, @valorCompra, @codigo, 1)";
                cmd.Parameters.AddWithValue("@nome", produto.Nome);
                cmd.Parameters.AddWithValue("@valorVenda", produto.ValorVenda);
                cmd.Parameters.AddWithValue("@valorCompra", produto.ValorCompra);
                cmd.Parameters.AddWithValue("@codigo", produto.Codigo);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto Cadastrado com Sucesso!");
                con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }

        public static void alterarProduto(Produto produto)
        {
            try
            {
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "Update produto set nome =  @nome, valorVenda = @valorVenda, valorCompra =  @valorCompra, codigo = @codigo where numero = @numero";
                cmd.Parameters.AddWithValue("@nome", produto.Nome);
                cmd.Parameters.AddWithValue("@valorVenda", produto.ValorVenda);
                cmd.Parameters.AddWithValue("@valorCompra", produto.ValorCompra);
                cmd.Parameters.AddWithValue("@codigo", produto.Codigo);
                cmd.Parameters.AddWithValue("@numero", produto.Numero);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto Alterado com Sucesso!");
                con.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static void excluirProduto(int id)
        {
            try
            {
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "Update produto set ativo = 0 where numero = " + id;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto Excluído com Sucesso!");
                con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        public static DataTable consultarPorNumero(int numero)
        {
            DataTable dt = new DataTable(); // objeto que retorna oq pedi ao banco
            SQLiteDataAdapter da = null; // objeto que cria a query no banco

            try
            {
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "Select * from produto where numero = " + numero; // criação da query
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco()); // execução da query
                da.Fill(dt);// preenchimento do dt com os elementos recebidos
                con.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
