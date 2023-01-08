using Dapper;
using RouteCards.Models;
using System.Collections.Generic;
using System.Linq;

namespace RouteCards.Data
{
    class UserRepo : RepoBase
    {
        public User Get(int id) => conn.Query<User>(
@"select * from RCUsers where Id = @Id",
new { Id = id }).First();

        public IEnumerable<User> GetAll() => conn.Query<User>(
@"select * from RCUsers
order by Name");


        public int Add(User item) => conn.ExecuteScalar<int>(
@"insert into RCUsers
(Name, Department, Password, RoleId)
values
(@Name, @Department, @Password, @RoleId);
select scope_identity();",
item);

        public void Update(User item) => conn.Execute(
@"update RCUsers
set
Name = @Name,
Department = @Department,
Password = @Password,
RoleId = @RoleId
where Id = @Id",
item);

        public void Remove(User item) => conn.Execute(
@"delete from RCUsers where Id = @Id", item);

        public bool CheckPassword(int id, string password) => conn.ExecuteScalar<bool>(
@"select case when exists (select * from RCUsers where Id = @Id and Password = @Password) then 1 else 0 end",
new { Id = id, Password = password });

        public bool IsThereUser(User item) => conn.ExecuteScalar<bool>(
@"select case when exists (select * from RCUsers where Name = @Name and Department = @Department and Id <> @Id) then 1 else 0 end", item);

    }
}
