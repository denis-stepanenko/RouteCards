namespace RouteCards.Models
{
    public class CardModification
    {
        public int Id { get; set; }
        public int CardId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string DocumentNumber { get; set; }

        public int ExecutorId { get; set; }
        public Executor Executor { get; set; }

        public string ExecutorName => Executor?.FullName;
        public string ExecutorShortName => Executor?.ShortName;
    }
}
