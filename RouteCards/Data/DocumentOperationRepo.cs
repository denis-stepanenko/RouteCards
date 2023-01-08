using Dapper;
using RouteCards.Models;
using System.Collections.Generic;
using System.Linq;

namespace RouteCards.Data
{
    class DocumentOperationRepo : RepoBase
    {
        public IEnumerable<DocumentOperation> GetAll(int documentId) => conn.Query<DocumentOperation, Executor, DocumentOperation>(
@"select o.*, e.* from RCDocumentOperations o 
left join RCExecutors e on e.Id = o.ExecutorId
where o.DocumentId = @Id
order by o.Position",
(o, e) => { o.Executor = e; return o; },
new { Id = documentId });

        public IEnumerable<DocumentOperation> GetAllByCard(int cardId) => conn.Query<DocumentOperation, Executor, DocumentOperation>(
@"select do.*, e.* from RCDocuments d
join RCDocumentOperations do on do.DocumentId = d.Id
left join RCExecutors e on e.Id = do.ExecutorId
where d.CardId = @Id
order by d.Position, do.Position",
(o, e) => { o.Executor = e; return o; },
new { Id = cardId });

        public bool AreThereOperationsInDocument(int documentId) => conn.ExecuteScalar<bool>(
@"select case when exists (select * from RCDocumentOperations where DocumentId = @DocumentId) then 1 else 0 end",
new { DocumentId = documentId });

        public bool AreThereOperationsInCard(int cardId) => conn.ExecuteScalar<bool>(
@"select case when exists 
(
    select * from RCDocuments d
    join RCDocumentOperations do on do.DocumentId = d.Id
    where d.CardId = @Id
)
then 1 else 0 end",
new { Id = cardId });

        public int Add(DocumentOperation item) => conn.ExecuteScalar<int>(
@"
declare @p int = (select max(Position) from RCDocumentOperations where DocumentId = @DocumentId) + 1;
insert into RCDocumentOperations
(DocumentId, Code, Name, Department, Description, ExecutorId, Labor, Count, StartDate, EndDate, Position, Number)
values
(@DocumentId, @Code, @Name, @Department, @Description, @ExecutorId, @Labor, @Count, @StartDate, @EndDate, @p, @Number);
select scope_identity();", item);

        public int Insert(DocumentOperation item) => conn.ExecuteScalar<int>(
@"update RCDocumentOperations
set Position = Position + 1
where DocumentId = @DocumentId and Position >= @Position;

insert into RCDocumentOperations
(DocumentId, Code, Name, Department, Description, ExecutorId, Labor, Count, StartDate, EndDate, Position, Number)
values
(@DocumentId, @Code, @Name, @Department, @Description, @ExecutorId, @Labor, @Count, @StartDate, @EndDate, @Position, @Number);
select scope_identity();", item);

        public void Update(DocumentOperation item) => conn.Execute(
@"update RCDocumentOperations
set
DocumentId = @DocumentId,
Code = @Code,
Name = @Name,
Department = @Department,
Description = @Description,
ExecutorId = @ExecutorId,
Labor = @Labor,
Count = @Count,
StartDate = @StartDate,
EndDate = @EndDate,
Position = @Position,
Number = @Number
where Id = @Id", item);

        public void Remove(DocumentOperation item) => conn.Execute(
@"delete from RCDocumentOperations where Id = @Id", item);

        public void RecalculatePositions(int documentId) => conn.Execute(
@"declare operationCursor cursor for
select Id from RCDocumentOperations
where DocumentId = @DocumentId
order by Position

declare @Id int

open operationCursor

fetch next from operationCursor into @Id

declare @counter int = 1

while @@FETCH_STATUS = 0
begin
	update RCDocumentOperations set Position = @counter where Id = @Id
	set @counter = @counter + 1
	fetch next from operationCursor into @Id
end

close operationCursor
deallocate operationCursor",
new { DocumentId = documentId });

        public DocumentOperation GetClosestControlOperation(DocumentOperation item) => conn.Query<DocumentOperation>(
@"select top 1 * from RCDocumentOperations
where Position > @Position and DocumentId = @DocumentId and Name like '%ОТК'
order by Position", item).FirstOrDefault();

        public int GetMaxOperationNumber(int id) => conn.ExecuteScalar<int>(
@"select max(convert(int, o.Number)) from RCDocuments d
join RCDocumentOperations o on o.DocumentId = d.Id
where d.CardId = @Id",
new { Id = id});

    }

}
