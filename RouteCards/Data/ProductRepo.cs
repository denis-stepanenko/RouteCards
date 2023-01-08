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

        public Product GetByCode(string code) => conn.Query<Product>(
@"select * from
(
    select Id, 2 TableId, Decnum Code, Name from ref_dse
    union all
    select Id, 1 TableId, Decnum Code, Name from ref_purchase
) r
where 
r.Code = @Code",
new { Code = code }).FirstOrDefault();

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

        //public IEnumerable<ProductRelation> GetPurchasedProductRelations(string code, int count)
        //{
        //    string tm = DateTime.Now.ToString("HHmmssffff");

        //    using (var tran = conn.BeginTransaction())
        //    {
        //        try
        //        {
        //            int id = conn.ExecuteScalar<int>("select Id from ref_dse where Decnum = @Code", new { Code = code }, transaction: tran);

        //            conn.Execute("c_SelTask", new { Tm = tm }, commandType: CommandType.StoredProcedure, transaction: tran);

        //            conn.Execute("i_TaskComp", new
        //            {
        //                IdDse = id,
        //                CountDse = count,
        //                IdOrder = 0,
        //                Reference = 1,
        //                TableWhat = 2,
        //                Tm = tm
        //            }, commandType: CommandType.StoredProcedure, transaction: tran);

        //            conn.Execute("i_CompoundTaskDevelopment", new
        //            {
        //                IdentOpen = 1,
        //                Tm = tm
        //            }, commandType: CommandType.StoredProcedure, transaction: tran);

        //            var result = conn.Query("EVPR_sCompoundForDepts",
        //                new { Tm = tm, IdentPurchase = 1 }, commandType: CommandType.StoredProcedure, transaction: tran)
        //                .Select(x => new ProductRelation
        //                {
        //                    Code = x.DecNumWhat,
        //                    Name = x.Name,
        //                    ParentCode = string.IsNullOrWhiteSpace(x.DecNumIn) ? null : x.DecNumIn,
        //                    Count = Convert.ToDecimal(x.Count),
        //                    TechWaste = Convert.ToDecimal(x.TechWaste),
        //                    CountAll = Convert.ToDecimal(x.CountAll),
        //                    CountAllWithoutWaste = Convert.ToDecimal(x.CountAllWithoutTO),
        //                    Route = x.Dept,
        //                    Type = x.TypeWhat,
        //                    ParentType = string.IsNullOrWhiteSpace(x.DecNumIn) ? null : x.TypeIn,
        //                    TypeName = x.TypeName,
        //                    AssemblyDepartment = x.Dept21?.ToString(),
        //                    IsAssembly = Convert.ToBoolean(x.Sb)
        //                });

        //            tran.Commit();
        //            return result;
        //        }
        //        catch (Exception)
        //        {
        //            tran.Rollback();
        //            throw;
        //        }
        //    }
        //}

        public IEnumerable<ProductRelation> GetPurchasedProductRelationsForPickingList(string code, int count)
        {
            string tm = DateTime.Now.ToString("HHmmssffff");

            using (var tran = conn.BeginTransaction())
            {
                try
                {
                    int id = conn.ExecuteScalar<int>("select Id from ref_dse where Decnum = @Code", new { Code = code }, transaction: tran);

                    conn.Execute("c_SelTask", new { Tm = tm }, commandType: CommandType.StoredProcedure, transaction: tran);

                    conn.Execute("i_TaskComp", new
                    {
                        IdDse = id,
                        CountDse = count,
                        IdOrder = 0,
                        Reference = 1,
                        TableWhat = 2,
                        Tm = tm
                    }, commandType: CommandType.StoredProcedure, transaction: tran);

                    conn.Execute("i_CompoundTaskDevelopment", new
                    {
                        IdentOpen = 0,
                        Tm = tm
                    }, commandType: CommandType.StoredProcedure, transaction: tran);

                    var result1 = conn.Query("EVPR_sDeliveryList", new { Tm = tm, Count = count, Type = 0 }, 
                        commandType: CommandType.StoredProcedure, transaction: tran)
                        .Select(x => new ProductRelation 
                        {
                            Code = x.Decnum,
                            Name = x.Name,
                            Count = x.CountAll
                        });

                    var result2 = conn.Query("EVPR_sDeliveryList", new { Tm = tm, Count = count, Type = 1 }, 
                        commandType: CommandType.StoredProcedure, transaction: tran)
                        .Select(x => new ProductRelation
                        {
                            Code = x.Decnum,
                            Name = x.Name,
                            Count = x.CountAll
                        });

                    var result = new List<ProductRelation>();
                    result.AddRange(result1);
                    result.AddRange(result2);

                    tran.Commit();
                    return result;
                }
                catch (Exception)
                {
                    tran.Rollback();
                    throw;
                }
            }
        }

    }
}
