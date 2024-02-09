using Clock_Patience_Game.Interfaces;

namespace Clock_Patience_Game.Models
{
    /// <summary>
    /// Represents a playing card with a rank and a suit.
    /// </summary>
    public class Card : ICard
    {
        /// <summary>
        /// Rank of the card. A,2,3,4,5,6,7,8,9,T,J,Q,K
        /// </summary>
        public string Rank { get; private set; }

        /// <summary>
        /// Suit of the card. D = Diamonds, S = Spades, C = Clubs, H = Hearts
        /// </summary>
        public char Suit { get; private set; }

        /// <summary>
        /// Sets card rank and suit.
        /// </summary>
        public Card(string rank, char suit)
        {
            Rank = rank;
            Suit = suit;
        }

        /// <summary>
        /// Determines the pile index based on the card's rank.
        /// </summary>
        public int GetPileIndex()
        {
            if (Rank == "A") return 0;
            if (Rank == "K") return 12; // Kings go to the center pile
            return int.TryParse(Rank, out int numericRank) ? numericRank - 1 : 9 + "TJQ".IndexOf(Rank);
        }
    }
}