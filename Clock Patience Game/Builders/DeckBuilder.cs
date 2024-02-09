using Clock_Patience_Game.Factories;
using Clock_Patience_Game.Interfaces;
using Clock_Patience_Game.Models;

namespace Clock_Patience_Game.Builders
{
    /// <summary>
    /// Builder for creating a Deck of cards.
    /// </summary>
    public class DeckBuilder : IDeckBuilder
    {
        // Stores the intermediate state of the deck being built.
        private List<ICard> cards = new List<ICard>();

        /// <summary>
        /// Adds a card to the deck being built. Returns the builder for fluent chaining.
        /// </summary>
        public IDeckBuilder AddCard(string cardRepresentation)
        {
            // Utilizes the CardFactory to create and add a card.
            var card = CardFactory.Instance.CreateCard(cardRepresentation.ToUpper());
            cards.Add(card);
            return this;
        }

        /// <summary>
        /// Builds and returns the final Deck object, encapsulating the built cards
        /// </summary>
        public IDeck Build()
        {
            // Initializes the Deck with the cards collected by the builder.
            var deck = new Deck(new List<ICard>(cards));
            //Reverse deck order.
            deck.Reverse();
            return deck;
        }
    }
}