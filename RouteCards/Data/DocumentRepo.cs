using Dapper;
using RouteCards.Models;
using System.Collections.Generic;
using System.Linq;

namespace RouteCards.Data
{
    class DocumentRepo : RepoBase
    {
        public Document Get(int id) => conn.Query<Document, Card, Document>(
@"select d.*, c.* from RCDocuments d
join RCCards c on c.Id = d.CardId
where d.Id = @Id",
(d, c) => { d.Card = c; return d; },
new { Id = id }).First();

        public IEnumerable<Document> GetAll() => conn.Query<Document, Card, Document>(
@"select d.*, c.* from RCDocuments d
join RCCards c on c.Id = d.CardId
order by Position",
(d, c) => { d.Card = c; return d; });

        public IEnumerable<Document> GetAllByCard(int id) => conn.Query<Document, Card, Document>(
@"select d.*, c.* from RCDocuments d
join RCCards c on c.Id = d.CardId
where d.CardId = @Id
order by Position",
(d, c) => { d.Card = c; return d; },
new { Id = id });

        public int Add(Document item) => conn.ExecuteScalar<int>(
@"
declare @p int = isnull((select max(Position) from RCDocuments where CardId = @CardId), 0) + 1;
insert into RCDocuments
(CardId, Number, Department, Position)
values
(@CardId, @Number, @Department, @p);
select scope_identity();", item);

        public void Remove(Document item) => conn.Execute(
@"delete from RCDocuments where Id = @Id", item);

        //        public void Reorder(int cardId) => conn.Execute(
        //@"declare @c int = 0
        //update RCDocuments set @c = Position = @c + 1 where CardId = @CardId",
        //new { CardId = cardId });

        public void Reorder(int cardId) => conn.Execute(
@"declare documentsCursor cursor for
select Id from RCDocuments
where CardId = @CardId
order by Position

declare @Id int

open documentsCursor

fetch next from documentsCursor into @Id

declare @counter int = 1

while @@FETCH_STATUS = 0
begin
	update RCDocuments set Position = @counter where Id = @Id
	set @counter = @counter + 1
	fetch next from documentsCursor into @Id
end

close documentsCursor
deallocate documentsCursor",
new { CardId = cardId });

        public void Swap(Document item1, Document item2) => conn.Execute(
@"if exists (select * from RCDocuments where Id = @Id1 and Position = @Position1)
and exists (select * from RCDocuments where Id = @Id2 and Position = @Position2)
update RCDocuments set Position = @Position2 where Id = @Id1
update RCDocuments set Position = @Position1 where Id = @Id2",
new 
{ 
    Id1 = item1.Id, 
    Id2 = item2.Id,
    Position1 = item1.Position,
    Position2 = item2.Position
});
    }
}
