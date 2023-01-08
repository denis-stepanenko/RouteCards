using System;

namespace RouteCards.Models
{
    public class CardReplacedComponent
    {
        public int Id { get; set; }
        public int CardId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string FactoryNumber { get; set; }
        public string ReplacementReason { get; set; }
        public DateTime Date { get; set; }

        public int ExecutorId { get; set; }
        public Executor Executor { get; set; }

        public string ExecutorName => Executor?.FullName;
        public string ExecutorShortName => Executor?.ShortName;

    }
}
