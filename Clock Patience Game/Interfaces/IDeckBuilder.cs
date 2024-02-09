namespace Clock_Patience_Game.Interfaces
{
    public interface IDeckBuilder
    {
        /// <summary>
        /// Specifies that a card should be added to the deck. Returns the builder for chaining.
        /// </summary>
        IDeckBuilder AddCard(string cardRepresentation);

        /// <summary>
        /// Constructs and returns the final Deck object.
        /// </summary>
        IDeck Build();
    }
}