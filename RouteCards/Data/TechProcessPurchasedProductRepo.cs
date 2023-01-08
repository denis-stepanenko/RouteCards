using Dapper;
using RouteCards.Models;
using System.Collections.Generic;

namespace RouteCards.Data
{
    class TechProcessPurchasedProductRepo : RepoBase
    {
        public IEnumerable<TechProcessPurchasedProduct> GetAll(int techProducessId) => conn.Query<TechProcessPurchasedProduct>(
@"select * from RCTechProcessPurchasedProducts where TechProducessId = @TechProducessId",
new { TechProducessId = techProducessId });

        public int Add(TechProcessPurchasedProduct item) => conn.ExecuteScalar<int>(
@"insert into RCTechProcessPurchasedProducts
(TechProducessId, Code, Name, Count)
values
(@TechProducessId, @Code, @Name, @Count)
select scope_identity()", item);

        public void Update(TechProcessPurchasedProduct item) => conn.Execute(
@"update RCTechProcessPurchasedProducts
set
TechProducessId = @TechProducessId,
Code = @Code,
Name = @Name,
Count = @Count
where Id = @Id", item);

        public void Remove(TechProcessPurchasedProduct item) => conn.Execute(
@"delete from RCTechProcessPurchasedProducts where Id = @Id", item);

    }
}
