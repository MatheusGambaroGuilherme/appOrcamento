using System;
using System.Collections.Generic;
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
    }
}
