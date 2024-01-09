using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orcamento_RRG.model.DAO
{
    internal class OrcamentoDAO
    {
        private static SQLiteConnection con;

        private static SQLiteConnection ConexaoBanco()
        {
            con = new SQLiteConnection("Data Source = C:\\Users\\mathe\\Documents\\Orcamento_RRG\\Orcamento_RRG\\data_base\\db_rrg");
            con.Open();
            return con;
        }

        public static DataTable consultarTodosOrcamentos()
        {
            DataTable dt = new DataTable(); // objeto que retorna oq pedi ao banco
            SQLiteDataAdapter da = null; // objeto que cria a query no banco

            try
            {
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "Select * from orcamento"; // criação da query
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

        public static void adicionarOrcamento(Orcamento orcamento)
        {
            try
            {
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "Insert into orcamento (cliente, data, valor, numero) values (@cliente, @data, @valor, @numero)";
                cmd.Parameters.AddWithValue("@cliente", orcamento.Cliente);
                cmd.Parameters.AddWithValue("@data", orcamento.Data);
                cmd.Parameters.AddWithValue("@valor", orcamento.Valor);
                cmd.Parameters.AddWithValue("@numero", orcamento.Numero);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Orçamento Salvo com Sucesso!");
                con.Close();
            }catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void adicionarItens(int idProduto, string numeroOrcamento, int quantidade)
        {
            try
            {
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "insert into orcamento_produto (IDProduto, NumeroOrcamento, Quantidade) values (@idProduto, @idOrcamento, @quantidade)";
                cmd.Parameters.AddWithValue("@idProduto", idProduto);
                cmd.Parameters.AddWithValue("@idOrcamento", numeroOrcamento);
                cmd.Parameters.AddWithValue("@quantidade", quantidade);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable consultarItensAnteriores(string numero)
        {
            DataTable dt = new DataTable(); // objeto que retorna oq pedi ao banco
            SQLiteDataAdapter da = null; // objeto que cria a query no banco

            try
            {
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "Select * from orcamento_produto where NumeroOrcamento = '@id'"; // criação da query
                //cmd.Parameters.AddWithValue("@id", numero);
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
