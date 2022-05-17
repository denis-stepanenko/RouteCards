using Dapper;
using RouteCards.Models;
using System.Collections.Generic;
using System.Linq;

namespace RouteCards.Data
{
    class CardChangeNoticeRepo : RepoBase
    {
        public CardChangeNotice Get(int id) => conn.Query<CardChangeNotice>(
@"select * from RCCardChangeNotices where Id = @Id",
new { Id = id }).First();

        public IEnumerable<CardChangeNotice> GetAll(int cardId) => conn.Query<CardChangeNotice>(
@"select * from RCCardChangeNotices where CardId = @Id",
new { Id = cardId });

        public int Add(CardChangeNotice item) => conn.ExecuteScalar<int>(
@"insert into RCCardChangeNotices
(CardId, Name, Date)
values
(@CardId, @Name, @Date);
select scope_identity();", item);

        public void Update(CardChangeNotice item) => conn.Execute(
@"update RCCardChangeNotices
set
CardId = @CardId,
Name = @Name,
Date = @Date
where Id = @Id", item);

        public void Remove(CardChangeNotice item) => conn.Execute(
@"delete from RCCardChangeNotices where Id = @Id", item);
    }
}
