using Dapper;
using RouteCards.Models;
using System.Collections.Generic;
using System.Linq;

namespace RouteCards.Data
{
    class OperationRepo : RepoBase
    {
        public Operation Get(int id) => conn.Query<Operation>(
@"select * from RCOperations where Id = @Id",
new { Id = id }).FirstOrDefault();

        public IEnumerable<Operation> GetAll() => conn.Query<Operation>(
@"select * from RCOperations");

        public IEnumerable<Operation> GetAllByDepartment(int department) => conn.Query<Operation>(
@"select * from RCOperations
where Department = @Department
order by Name",
new { Department = department });

        public int Add(Operation item) => conn.ExecuteScalar<int>(
@"insert into RCOperations
(Code, Name, Department, GroupName) values (@Code, @Name, @Department, @GroupName);
select scope_identity();",
item);

        public void Update(Operation item) => conn.Execute(
@"update RCOperations
set
Code = @Code,
Name = @Name,
Department = @Department,
GroupName = @GroupName
where Id = @Id",
item);

        public void Remove(Operation item) => conn.Execute(
@"delete from RCOperations
where Id = @Id",
item);

        public bool IsThereOperationWithDepartmentAndName(Operation item) => conn.ExecuteScalar<bool>(
@"select case when exists (select * from RCOperations where Department = @Department and Name = @Name) then 1 else 0 end", item);
    }
}
