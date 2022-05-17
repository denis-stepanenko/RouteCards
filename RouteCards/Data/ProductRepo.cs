using Dapper;
using RouteCards.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace RouteCards.Data
{
    class ProductRepo : RepoBase
    {
        public IEnumerable<Product> GetAll() => conn.Query<Product>(
@"select Id, 2 TableId, Decnum Code, Name from ref_dse
union all
select Id, 1 TableId, Decnum Code, Name from ref_purchase");

        public IEnumerable<Product> GetAll(string filter) => conn.Query<Product>(
@"select * from
(
    select Id, 2 TableId, Decnum Code, Name from ref_dse
    union all
    select Id, 1 TableId, Decnum Code, Name from ref_purchase
) r
where 
r.Code like '%' + @Filter + '%'
or r.Name like '%' + @Filter + '%'",
new { Filter = filter });

        public IEnumerable<Product> GetAll(string code, string name) => conn.Query<Product>(
@"select * from
(
    select Id, 2 TableId, Decnum Code, Name from ref_dse
    union all
    select Id, 1 TableId, Decnum Code, Name from ref_purchase
) r
where 
r.Code like '%' + @Code + '%'
and r.Name like '%' + @Name + '%'",
new { Code = code, Name = name });

        public IEnumerable<Product> GetOwnProducts() => conn.Query<Product>(
@"select Id, 2 TableId, Decnum Code, Name from ref_dse");

        public IEnumerable<Product> GetOwnProducts(string filter) => conn.Query<Product>(
@"select top 100 Id, 2 TableId, Decnum Code, Name from ref_dse
where 
DecNum like '%' + @Filter + '%'
or Name like '%' + @Filter + '%'",
new { Filter = filter });

        public IEnumerable<Product> GetPurchasedProducts() => conn.Query<Product>(
 @"select Id, 1 TableId, Decnum Code, Name from ref_purchase");

        public string GetRouteByProduct(int productId, int tableId)
        {
            string tm = DateTime.Now.ToString("HHmmssffff");

            using (var transaction = conn.BeginTransaction())
            {
                try
                {
                    conn.Execute("c_SelTask", new { Tm = tm }, commandType: CommandType.StoredProcedure, transaction: transaction);

                    conn.Execute("i_TaskComp", new
                    {
                        IdDse = productId,
                        CountDse = 1,
                        IdOrder = 0,
                        Reference = 1,
                        TableWhat = tableId,
                        Tm = tm
                    }, commandType: CommandType.StoredProcedure, transaction: transaction);

                    conn.Execute("i_CompoundTaskDevelopment", new
                    {
                        IdentOpen = 1,
                        Tm = tm
                    }, commandType: CommandType.StoredProcedure, transaction: transaction);

                    var result = conn.Query("EVPR_sCompoundForDepts",
                        new
                        {
                            Tm = tm,
                            IdentPurchase = 0
                        }, commandType: CommandType.StoredProcedure, transaction: transaction);

                    string route = result.Where(x => string.IsNullOrWhiteSpace(x.DecNumIn)).Select(x => x.Dept).FirstOrDefault();


                    transaction.Commit();
                    return route.Replace("  ", " ");
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}
