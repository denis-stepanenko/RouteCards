namespace RouteCards.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Department { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
    }
}
