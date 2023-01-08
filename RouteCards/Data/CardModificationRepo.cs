using Dapper;
using RouteCards.Models;
using System.Collections.Generic;
using System.Linq;

namespace RouteCards.Data
{
    class CardModificationRepo : RepoBase
    {
        public CardModification Get(int id) => conn.Query<CardModification, Executor, CardModification>(
@"select m.*, e.* from RCCardModifications m
left join RCExecutors e on e.Id = m.ExecutorId
where m.Id = @Id",
(m, e) => { m.Executor = e; return m; },
new { Id = id }).First();


        public IEnumerable<CardModification> GetAll(int cardId) => conn.Query<CardModification, Executor, CardModification>(
@"select m.*, e.* from RCCardModifications m
left join RCExecutors e on e.Id = m.ExecutorId
where m.CardId = @Id",
(m, e) => { m.Executor = e; return m; },
new { Id = cardId });

        public int Add(CardModification item) => conn.ExecuteScalar<int>(
@"insert into RCCardModifications
(CardId, Code, Name, ExecutorId, DocumentNumber)
values
(@CardId, @Code, @Name, @ExecutorId, @DocumentNumber);
select scope_identity();",
item);

        public void Update(CardModification item) => conn.Execute(
@"update RCCardModifications
set
CardId = @CardId,
Code = @Code,
Name = @Name,
ExecutorId = @ExecutorId,
DocumentNumber = @DocumentNumber
where Id = @Id",
item);

        public void Remove(CardModification item) => conn.Execute(
@"delete from RCCardModifications where Id = @Id", item);
    }
}
