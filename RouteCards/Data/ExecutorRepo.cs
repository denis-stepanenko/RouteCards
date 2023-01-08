using Dapper;
using RouteCards.Models;
using System.Collections.Generic;

namespace RouteCards.Data
{
    class ExecutorRepo : RepoBase
    {
        public IEnumerable<Executor> GetAll() => conn.Query<Executor>(
@"select * from RCExecutors");

        public IEnumerable<Executor> GetAllByDepartment(int department) => conn.Query<Executor>(
@"select * from RCExecutors
where Department = @Department",
new { Department = department });

        public int Add(Executor item) => conn.ExecuteScalar<int>(
@"insert into RCExecutors
(FirstName, SecondName, Patronymic, Department)
values
(@FirstName, @SecondName, @Patronymic, @Department);
select scope_identity();", item);

        public void Update(Executor item) => conn.Execute(
@"update RCExecutors
set
FirstName = @FirstName,
SecondName = @SecondName,
Patronymic = @Patronymic
where Id = @Id", item);

        public void Remove(Executor item) => conn.ExecuteScalar(
"delete from RCExecutors where Id = @Id", item);
    }
}
