using System;

namespace RouteCards.Models
{
    class CardChangeNotice
    {
        public int Id { get; set; }
        public int CardId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
    }
}
