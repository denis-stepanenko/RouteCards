using Dapper;
using RouteCards.Models;
using System.Collections.Generic;
using System.Linq;

namespace RouteCards.Data
{
    class TechProcessRepo : RepoBase
    {
        public TechProcess Get(int id) => conn.Query<TechProcess>(
@"select * from RCTechProcesses where Id = @Id",
new { Id = id }).First();

        public IEnumerable<TechProcess> GetAll() => conn.Query<TechProcess>(
@"select * from RCTechProcesses");

        public int Add(TechProcess item) => conn.ExecuteScalar<int>(
@"insert into RCTechProcesses
(ProductCode, ProductName, Description, CreatorName, ConfirmUserName, Picker, Recipient)
values
(@ProductCode, @ProductName, @Description, @CreatorName, @ConfirmUserName, @Picker, @Recipient);
select scope_identity();", item);

        public void Update(TechProcess item) => conn.Execute(
@"update RCTechProcesses
set
ProductCode = @ProductCode,
ProductName = @ProductName,
Description = @Description,
CreatorName = @CreatorName,
ConfirmUserName = @ConfirmUserName,
Picker = @Picker,
Recipient = @Recipient
where Id = @Id", item);

        public void Remove(TechProcess item) => conn.Execute(
@"delete from RCTechProcesses where Id = @Id", item);

        public void Confirm(TechProcess item, string userName) => conn.Execute(
@"update RCTechProcesses set ConfirmUserName = @UserName where Id = @Id",
new { Id = item.Id, UserName = userName });
    }
}
