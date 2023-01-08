using Dapper;
using RouteCards.Models;
using System.Collections.Generic;
using System.Data;

namespace RouteCards.Data
{
    class OrderRepo : RepoBase
    {
        public IEnumerable<Order> GetOrders(string productCode) => conn.Query<Order>(
@"GetDirections",
new { ProductCode = productCode },
commandType: CommandType.StoredProcedure);
    }
}
