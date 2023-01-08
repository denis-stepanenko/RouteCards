namespace RouteCards.Models
{
    public class ProductRelation
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Count { get; set; }
        public decimal CountAll { get; set; }
        public decimal TechWaste { get; set; }
        public decimal CountAllWithoutWaste { get; set; }
        public string ParentCode { get; set; }
        public string Route { get; set; }
        public int Type { get; set; }
        public int? ParentType { get; set; }
        public string TypeName { get; set; }
        public string AssemblyDepartment { get; set; }
        public bool IsAssembly { get; set; }
    }
}
