using Dapper;
using RouteCards.Models;
using System.Collections.Generic;
using System.Linq;

namespace RouteCards.Data
{
    class CardOperationRepo : RepoBase
    {
        public IEnumerable<CardOperation> GetByCard(int id) => conn.Query<CardOperation, Executor, CardOperation>(
@"select * from RCCardOperations o
left join RCExecutors e on e.Id = o.ExecutorId
where o.CardId = @Id
order by o.Position", 
(o, e) => { o.Executor = e; return o; },
new { Id = id });

        public void Add(CardOperation item) => conn.Execute(
@"declare @p int = isnull((select max(Position) from RCCardOperations where CardId = @CardId), 0) + 1;
insert into RCCardOperations
(Code, Name, Department, Description, ExecutorId, Labor, Position, Count, StartDate, EndDate, Number, CardId)
values
(@Code, @Name, @Department, @Description, @ExecutorId, @Labor, @p, @Count, @StartDate, @EndDate, @Number, @CardId)", item);

        public void Update(CardOperation item) => conn.Execute(
@"update RCCardOperations
set
Code = @Code,
Name = @Name,
Department = @Department,
Description = @Description,
ExecutorId = @ExecutorId,
Labor = @Labor,
Position = @Position,
Count = @Count,
StartDate = @StartDate,
EndDate = @EndDate,
Number = @Number,
CardId = @CardId
where Id = @Id", item);

        public void Remove(CardOperation item) => conn.Execute(
@"delete from RCCardOperations where Id = @Id", item);

        public bool AreThereOperationsInCard(int cardId) => conn.ExecuteScalar<bool>(
@"select case when exists 
(
    select * from RCCardOperations
    where CardId = @Id
)
then 1 else 0 end",
new { Id = cardId });

        public int GetMaxOperationNumber(int cardId) => conn.ExecuteScalar<int>(
@"select max(convert(int, Number)) from RCCardOperations where CardId = @CardId",
new { CardId = cardId });


        public void RecalculateOperationPositions(int cardId) => conn.Execute(
@"declare operationCursor cursor for
select Id from RCCardOperations
where CardId = @CardId
order by Position

declare @Id int

open operationCursor

fetch next from operationCursor into @Id

declare @counter int = 1

while @@FETCH_STATUS = 0
begin
	update RCCardOperations set Position = @counter where Id = @Id
	set @counter = @counter + 1
	fetch next from operationCursor into @Id
end

close operationCursor
deallocate operationCursor",
new { CardId = cardId });

        public CardOperation GetClosestControlOperation(CardOperation item) => conn.Query<CardOperation>(
@"select top 1 * from RCCardOperations
where Position > @Position and CardId = @CardId and Name like '%ОТК'
order by Position", item).FirstOrDefault();

        public void Swap(CardOperation item1, CardOperation item2) => conn.Execute(
@"if exists (select * from RCCardOperations where Id = @Id1 and Position = @Position1)
and exists (select * from RCCardOperations where Id = @Id2 and Position = @Position2)
update RCCardOperations set Position = @Position2 where Id = @Id1
update RCCardOperations set Position = @Position1 where Id = @Id2",
new
{
    Id1 = item1.Id,
    Id2 = item2.Id,
    Position1 = item1.Position,
    Position2 = item2.Position
});

        public void UpdateCountForOperation005(int cardId, int newCount) => conn.Execute(
"update RCCardOperations set [Count] = @NewCount where CardId = @CardId and Number = '005'",
new { CardId = cardId, NewCount = newCount });

    }

    
}
