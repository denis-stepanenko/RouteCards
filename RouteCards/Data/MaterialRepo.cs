using Dapper;
using RouteCards.Models;
using System.Collections.Generic;

namespace RouteCards.Data
{
    class MaterialRepo : RepoBase
    {
        public IEnumerable<Material> Find(string filter) => conn.Query<Material>(
@"select MaterialId Id, Code, Name, Size + ' ' + Type Parameter from tMaterial
where 
Code like '%' + @Filter + '%'
or Name like '%' + @Filter + '%'
or Size + ' ' + Type like '%' + @Filter + '%'",
new { Filter = filter });

        public IEnumerable<Material> GetAllByProductAndDepartment(string code, int department) => conn.Query<Material>(
@"declare @Id int = (select AssemblyUnitId from tAssemblyUnit where Code = @Code)

select 
aum.AssemblyUnitId Id, 
m.Code, 
m.Name,
ISNULL(m.Size, '') + ISNULL(m.[Type], '') Parameter
from tAssemblyUnitMaterial aum 
left join tMaterial m on m.MaterialId = aum.MaterialId
join tUnit u on u.UnitId = m.UnitId
where 
aum.AssemblyUnitId = @Id
and aum.Department = @Department",
new { Code = code, Department = department });

        public IEnumerable<Material> GetAllByProduct(string code) => conn.Query<Material>(
@"declare @Id int = (select AssemblyUnitId from tAssemblyUnit where Code = @Code)

select 
aum.AssemblyUnitId Id, 
m.Code, 
m.Name,
ISNULL(m.Size, '') + ISNULL(m.[Type], '') Parameter
from tAssemblyUnitMaterial aum 
left join tMaterial m on m.MaterialId = aum.MaterialId
join tUnit u on u.UnitId = m.UnitId
where 
aum.AssemblyUnitId = @Id",
new { Code = code });
    }
}
