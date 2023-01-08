namespace RouteCards.Models
{
    public class Document
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int Department { get; set; }
        public int Position { get; set; }

        public int CardId { get; set; }
        public Card Card { get; set; }

        public string CardNumber => Card.Number;
    }
}
