using System;

namespace RouteCards.Models
{
    public class CardFramelessComponent
    {
        public int Id { get; set; }
        public int CardId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime DateOfIssueForProduction { get; set; }
        public DateTime DateOfSealing { get; set; }
        public int DaysBeforeSealing { get; set; }
    }
}
