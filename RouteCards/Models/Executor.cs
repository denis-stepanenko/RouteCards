namespace RouteCards.Models
{
    public class Executor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Patronymic { get; set; }
        public int Department { get; set; }

        public string FullName => FirstName + " " + SecondName + " " + Patronymic;
        public string ShortName => $"{FirstName} {SecondName[0]}.{Patronymic[0]}.";
    }
}
