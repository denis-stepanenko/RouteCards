using Dapper;
using RouteCards.Models;
using System.Collections.Generic;
using System.Linq;

namespace RouteCards.Data
{
    class CardComponentRepo : RepoBase
    {
        public CardComponent Get(int id) => conn.Query<CardComponent>(
@"select * from RCCardComponents where Id = @Id",
new { Id = id }).First();

        public IEnumerable<CardComponent> GetAll(int cardId) => conn.Query<CardComponent>(
@"select * from RCCardComponents where CardId = @Id",
new { Id = cardId });

        public int Add(CardComponent item) => conn.ExecuteScalar<int>(
@"insert into RCCardComponents
(CardId, Code, Name, FactoryNumber, AccompanyingDocument, Count)
values
(@CardId, @Code, @Name, @FactoryNumber, @AccompanyingDocument, @Count);
select scope_identity();", item);

        public void Update(CardComponent item) => conn.Execute(
@"update RCCardComponents
set
CardId = @CardId,
Code = @Code,
Name = @Name,
FactoryNumber = @FactoryNumber,
AccompanyingDocument = @AccompanyingDocument,
Count = @Count
where Id = @Id", item);

        public void Remove(CardComponent item) => conn.Execute(
@"delete from RCCardComponents where Id = @Id", item);
    }
}
