using Clock_Patience_Game.Interfaces;

namespace Clock_Patience_Game.Models
{
    /// <summary>
    /// Represents a deck of playing cards.
    /// </summary>
    public class Deck : IDeck
    {
        /// <summary>
        /// Cards property representing the collection of ICard in the deck.
        /// </summary>
        public List<ICard> Cards { get; private set; }

        /// <summary>
        /// Constructor that initializes the deck with a list of ICard instances.
        /// </summary>
        public Deck(List<ICard> cards)
        {
            Cards = cards;
        }

        /// <summary>
        /// Reverse cards sequence of the deck.
        /// </summary>
        public void Reverse()
        {
            Cards.Reverse();
        }
    }
}