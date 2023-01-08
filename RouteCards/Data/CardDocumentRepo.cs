using Dapper;
using RouteCards.Models;
using System.Collections.Generic;

namespace RouteCards.Data
{
    class CardDocumentRepo : RepoBase
    {
        public int Add(CardDocument item) => conn.ExecuteScalar<int>(
@"insert into RCCardDocuments
(CardId, Name) values (@CardId, @Name);
select scope_identity();", item);

        public void Update(CardDocument item) => conn.Execute(
@"update RCCardDocuments
set 
CardId = @CardId,
Name = @Name
where Id = @Id", item);

        public IEnumerable<CardDocument> GetAll(int cardId) => conn.Query<CardDocument>(
@"select * from RCCardDocuments where CardId = @Id",
new { Id = cardId });

        public void Remove(CardDocument item) => conn.Execute(
@"delete from RCCardDocuments where Id = @Id", 
item);
    }
}
