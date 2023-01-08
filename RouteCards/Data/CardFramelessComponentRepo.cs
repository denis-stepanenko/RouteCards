using Dapper;
using RouteCards.Models;
using System.Collections.Generic;
using System.Linq;

namespace RouteCards.Data
{
    class CardFramelessComponentRepo : RepoBase
    {
        public CardFramelessComponent Get(int id) => conn.Query<CardFramelessComponent>(
@"select * from RCCardFramelessComponents where Id = @Id",
new { Id = id }).FirstOrDefault();

        public IEnumerable<CardFramelessComponent> GetAll(int cardId) => conn.Query<CardFramelessComponent>(
@"select * from RCCardFramelessComponents where CardId = @Id",
new { Id = cardId });

        public int Add(CardFramelessComponent item) => conn.ExecuteScalar<int>(
@"insert into RCCardFramelessComponents
(CardId, Code, Name, DateOfIssueForProduction, DateOfSealing, DaysBeforeSealing)
values
(@CardId, @Code, @Name, @DateOfIssueForProduction, @DateOfSealing, @DaysBeforeSealing);
select scope_identity();", item);

        public void Update(CardFramelessComponent item) => conn.Execute(
@"update RCCardFramelessComponents
set
CardId = @CardId,
Code = @Code,
Name = @Name,
DateOfIssueForProduction = @DateOfIssueForProduction,
DateOfSealing = @DateOfSealing,
DaysBeforeSealing = @DaysBeforeSealing
where Id = @Id", item);

        public void Remove(CardFramelessComponent item) => conn.Execute(
@"delete from RCCardFramelessComponents where Id = @Id", item);
    }
}
