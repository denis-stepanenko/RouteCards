using Dapper;
using RouteCards.Models;
using System.Collections.Generic;
using System.Linq;

namespace RouteCards.Data
{
    class CardRepairRepo : RepoBase
    {
        public CardRepair Get(int id) => conn.Query<CardRepair, Executor, CardRepair>(
@"select r.*, e.* from RCCardRepairs r
join RCExecutors e on e.Id = r.ExecutorId
where r.Id = @Id",
(r, e) => { r.Executor = e; return r; },
new { Id = id }).First();

        public IEnumerable<CardRepair> GetAll(int cardId) => conn.Query<CardRepair, Executor, CardRepair>(
@"select r.*, e.* from RCCardRepairs r
join RCExecutors e on e.Id = r.ExecutorId
where r.CardId = @Id",
(r, e) => { r.Executor = e; return r; },
new { Id = cardId });

        public int Add(CardRepair item) => conn.ExecuteScalar<int>(
@"insert into RCCardRepairs
(CardId, Code, Name, Reason, ExecutorId, StartDate, EndDate, Date)
values
(@CardId, @Code, @Name, @Reason, @ExecutorId, @StartDate, @EndDate, @Date);
select scope_identity();", 
item);

        public void Update(CardRepair item) => conn.Execute(
@"update RCCardRepairs
set
CardId = @CardId,
Code = @Code,
Name = @Name,
Reason = @Reason,
StartDate = @StartDate,
EndDate = @EndDate,
Date = @Date,
ExecutorId = @ExecutorId
where Id = @Id",
item);

        public void Remove(CardRepair item) => conn.Execute(
@"delete from RCCardRepairs
where Id = @Id", item);
    }
}
