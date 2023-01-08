using Dapper;
using RouteCards.Models;
using System.Collections.Generic;

namespace RouteCards.Data
{
    class TechProcessDocumentRepo : RepoBase
    {
        public IEnumerable<TechProcessDocument> Get(int id) => conn.Query<TechProcessDocument>(
@"select * from RCTechProcessDocuments where Id = @Id",
new { Id = id });

        public IEnumerable<TechProcessDocument> GetAll(int techProcessId) => conn.Query<TechProcessDocument>(
@"select * from RCTechProcessDocuments where TechProcessId = @TechProcessId",
new { TechProcessId = techProcessId });

        public int Add(TechProcessDocument item) => conn.ExecuteScalar<int>(
@"insert into RCTechProcessDocuments
(TechProcessId, Name)
values
(@TechProcessId, @Name);
select scope_identity();", item);

        public void Update(TechProcessDocument item) => conn.Execute(
@"update RCTechProcessDocuments
set
TechProcessId = @TechProcessId,
Name = @Name
where Id = @Id", item);

        public void Remove(TechProcessDocument item) => conn.Execute(
@"delete from RCTechProcessDocuments where Id = @Id", item);
    }
}
