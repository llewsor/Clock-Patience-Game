using Clock_Patience_Game.Interfaces;
using Clock_Patience_Game.Models;

namespace Clock_Patience_Game.Factories
{
    /// <summary>
    /// Factory for creating Card objects from string representations.
    /// </summary>
    public class CardFactory : ICardFactory
    {
        /// <summary>
        // Ensures a single instance of the factory, adhering to the Singleton pattern.
        /// </summary>
        public static ICardFactory Instance { get; } = new CardFactory();

        /// <summary>
        // Private constructor to prevent instantiation outside of the Instance property.
        /// </summary>
        private CardFactory() { }

        /// <summary>
        /// Create and returns a new card.
        /// </summary>
        public ICard CreateCard(string cardRepresentation)
        {
            //Get the rank of the card by getting the first character from the two character card representation
            var rank = cardRepresentation.Substring(0, cardRepresentation.Length - 1);
            //Get the suit of the card by getting the second character from the two character card representation
            var suit = cardRepresentation[^1];

            //Create and return a new card with the rank and suit.
            return new Card(rank, suit);
        }
    }
}