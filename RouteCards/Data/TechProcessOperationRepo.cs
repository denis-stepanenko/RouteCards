using Dapper;
using RouteCards.Models;
using System.Collections.Generic;
using System.Linq;

namespace RouteCards.Data
{
    class TechProcessOperationRepo : RepoBase
    {
        public TechProcessOperation Get(int id) => conn.Query<TechProcessOperation>(
@"select * from RCTechProcessOperations where Id =  @Id",
new { Id = id }).First();

        public IEnumerable<TechProcessOperation> GetAll(int techProcessId) => conn.Query<TechProcessOperation>(
@"select * from RCTechProcessOperations 
where TechProcessId = @TechProcessId
order by Position",
new { TechProcessId = techProcessId });

        public int Add(TechProcessOperation item) => conn.ExecuteScalar<int>(
@"
declare @p int = isnull((select max(Position) from RCTechProcessOperations where TechProcessId = @TechProcessId), 0) + 1;
insert into RCTechProcessOperations
(TechProcessId, Code, Name, Department, Count, Description, Position)
values 
(@TechProcessId, @Code, @Name, @Department, @Count, @Description, @p);
select scope_identity();", item);

        public void Update(TechProcessOperation item) => conn.Execute(
@"update RCTechProcessOperations
set
TechProcessId = @TechProcessId,
Code = @Code,
Name = @Name,
Department = @Department,
Description = @Description,
Count = @Count,
Position = @Position
where Id = @Id", item);

        public void Remove(TechProcessOperation item) => conn.Execute(
@"delete from RCTechProcessOperations where Id = @Id", item);

        public void Reorder(int techProcessId) => conn.Execute(
@"declare itemsCursor cursor for
select Id from RCTechProcessOperations
where TechProcessId = @TechProcessId
order by Position

declare @Id int

open itemsCursor

fetch next from itemsCursor into @Id

declare @counter int = 1

while @@FETCH_STATUS = 0
begin
	update RCTechProcessOperations set Position = @counter where Id = @Id
	set @counter = @counter + 1
	fetch next from itemsCursor into @Id
end

close itemsCursor
deallocate itemsCursor",
new { TechProcessId = techProcessId });

        public void Swap(TechProcessOperation item1, TechProcessOperation item2) => conn.Execute(
@"if exists (select * from RCTechProcessOperations where Id = @Id1 and Position = @Position1)
and exists (select * from RCTechProcessOperations where Id = @Id2 and Position = @Position2)
update RCTechProcessOperations set Position = @Position2 where Id = @Id1
update RCTechProcessOperations set Position = @Position1 where Id = @Id2",
new
{
    Id1 = item1.Id,
    Id2 = item2.Id,
    Position1 = item1.Position,
    Position2 = item2.Position
});

    }
}
