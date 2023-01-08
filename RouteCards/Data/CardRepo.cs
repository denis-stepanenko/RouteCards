using Dapper;
using RouteCards.Models;
using System.Collections.Generic;
using System.Linq;

namespace RouteCards.Data
{
    class CardRepo : RepoBase
    {
        public int Add(Card card) => conn.ExecuteScalar<int>(
@"insert into RCCards
(Number, ProductCode, ProductName, ProductCount, OwnerProductName, Stage, Department, Route, GroupName, Direction, ClientOrder, FactoryNumber, 
PickingListNumber, MaterialCode, MaterialName, MaterialParameter, ESDProtectionRequired, [Order], Date, InformationAboutReplacement, Picker, Recipient)
values
(@Number, @ProductCode, @ProductName, @ProductCount, @OwnerProductName, @Stage, @Department, @Route, @GroupName, @Direction, @ClientOrder, 
@FactoryNumber, @PickingListNumber, @MaterialCode, @MaterialName, @MaterialParameter, @ESDProtectionRequired, @Order, @Date, @InformationAboutReplacement,
@Picker, @Recipient);
select scope_identity();", card);

        public void Update(Card card) => conn.Execute(
@"update RCCards
set
Number = @Number,
ProductCode = @ProductCode,
ProductName = @ProductName,
ProductCount = @ProductCount,
OwnerProductName = @OwnerProductName,
Stage = @Stage,
Department = @Department,
GroupName = @GroupName,
Direction = @Direction,
ClientOrder = @ClientOrder,
FactoryNumber = @FactoryNumber,
PickingListNumber = @PickingListNumber,
MaterialCode = @MaterialCode,
MaterialName = @MaterialName,
MaterialParameter = @MaterialParameter,
ESDProtectionRequired = @ESDProtectionRequired,
[Order] = @Order,
Date = @Date,
[Route] = @Route,
InformationAboutReplacement = @InformationAboutReplacement,
Picker = @Picker,
Recipient = @Recipient
where Id = @Id",
card);

        public void UpdateRoute(int cardId, string newRoute) => conn.Execute(
@"update RCCards
set Route = @Route
where Id = @Id",
new { Id = cardId, Route = newRoute });

        public Card Get(int id) => conn.Query<Card>(
@"select * from RCCards
where Id = @Id",
new { Id =  id }).FirstOrDefault();

        public IEnumerable<Card> GetAll() => conn.Query<Card>(
@"select * from RCCards
order by Id desc");

        public IEnumerable<Card> GetAllByDepartment(int department) => conn.Query<Card>(
@"select * from RCCards
where Department = @Department
order by Id desc",
new { Department = department });

        public void Remove(Card card) => conn.Execute(
@"delete from RCCards where Id = @Id", 
card);

        public int GetNewCardNumber() => conn.ExecuteScalar<int>(
@"select isnull(max(convert(int, Number)), 0) + 1 from RCCards");

        public int GetNewCardNumberWithinDepartment(int department) => conn.ExecuteScalar<int>(
@"select isnull(max(convert(int, Number)), 0) + 1 from RCCards
where Department = @Department",
new { Department = department });

        public bool IsThereCardWithNumber(string number) => conn.ExecuteScalar<bool>(
@"select case when exists (select * from RCCards where Number = @Number) then 1 else 0 end",
new { Number = number });

        public bool IsThereCardWithNumberWithinDepartment(string number, int department) => conn.ExecuteScalar<bool>(
@"select case when exists (select * from RCCards where Number = @Number and Department = @Department) then 1 else 0 end",
new { Number = number, Department = department });
    }
}
