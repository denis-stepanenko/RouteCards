using Dapper;
using RouteCards.Models;
using System.Collections.Generic;
using System.Linq;

namespace RouteCards.Data
{
    class CardReplacedComponentRepo : RepoBase
    {
        public CardReplacedComponent Get(int id) => conn.Query<CardReplacedComponent, Executor, CardReplacedComponent>(
@"select c.*, e.* from RCCardReplacedComponents c 
left join RCExecutors e on e.Id = c.ExecutorId
where c.Id = @Id",
(c, e) => { c.Executor = e; return c; },
new { Id = id }).FirstOrDefault();

        public IEnumerable<CardReplacedComponent> GetAll(int cardId) => conn.Query<CardReplacedComponent, Executor, CardReplacedComponent>(
@"select c.*, e.* from RCCardReplacedComponents c 
left join RCExecutors e on e.Id = c.ExecutorId 
where c.CardId = @Id",
(c, e) => { c.Executor = e; return c; },
new { Id = cardId });

        public int Add(CardReplacedComponent item) => conn.ExecuteScalar<int>(
@"insert into RCCardReplacedComponents
(CardId, Code, Name, FactoryNumber, ReplacementReason, ExecutorId, Date)
values
(@CardId, @Code, @Name, @FactoryNumber, @ReplacementReason, @ExecutorId, @Date);
select scope_identity();", 
item);

        public void Update(CardReplacedComponent item) => conn.Execute(
@"update RCCardReplacedComponents
set
CardId = @CardId,
Code = @Code,
Name = @Name,
FactoryNumber = @FactoryNumber,
ReplacementReason = @ReplacementReason,
ExecutorId = @ExecutorId,
Date = @Date
where Id = @Id", 
item);

        public void Remove(CardReplacedComponent item) => conn.Execute(
@"delete from RCCardReplacedComponents where Id = @Id",
item);
    }
}
