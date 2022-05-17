using System;

namespace RouteCards.Models
{
    public class DocumentOperation
    {
        public int Id { get; set; }
        public int DocumentId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int Department { get; set; }
        public int Count { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Position { get; set; }
        public string Number { get; set; }
        public decimal Labor { get; set; }
        public string Description { get; set; }

        public int ExecutorId { get; set; }
        public Executor Executor { get; set; }

        public string ExecutorName => Executor?.FullName;
        public string ExecutorShortName => Executor?.ShortName;
    }
}
