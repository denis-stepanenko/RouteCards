using System.Data;
using System.Data.SqlClient;

namespace RouteCards.Data
{
    class RepoBase
    {
        protected IDbConnection conn;

        public RepoBase()
        {
            conn = new SqlConnection(@"");
            conn.Open();
        }
    }
}
