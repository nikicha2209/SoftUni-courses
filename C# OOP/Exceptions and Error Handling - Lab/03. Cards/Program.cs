namespace _03._Cards
{
    class Card
    {
        public string Face { get; set; }
        public string Suit { get; set; }

        public Card(string face, string suit)
        {
            Face = face;
            Suit = suit;
        }

        public override string ToString()
        {
            return $"[{Face}{Suit}]";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] drawnCards = Console.ReadLine().Split(", ");
            List<Card> cardDeck = new List<Card>();

            for (int i = 0; i < drawnCards.Length; i++)
            {
                string face = drawnCards[i].Split().First();
                string suit = drawnCards[i].Split().Last();

                try
                {
                    cardDeck.Add(CreateCard(face, suit));
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine(string.Join(" ", cardDeck));
        }

        static Card CreateCard(string face, string suit)
        {
            string[] validFaces = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string[] validSuits =  { "S", "H", "D", "C" };


            if (!validFaces.Contains(face) || !validSuits.Contains(suit))
            {
                throw new ArgumentException("Invalid card!");
            }

            string utfSuit = string.Empty;
            switch (suit)
            {
                case "S": utfSuit = "\u2660"; break;
                case "H": utfSuit = "\u2665"; break;
                case "D": utfSuit = "\u2666"; break;
                case "C": utfSuit = "\u2663"; break;
            }

            return new Card(face, utfSuit);
        }
    }
}