namespace Clock_Patience_Game.Interfaces
{
    public interface IDeck
    {
        /// <summary>
        /// Cards property representing the collection of ICard in the deck.
        /// </summary>
        List<ICard> Cards { get; }

        /// <summary>
        /// Reverse cards sequence of the deck.
        /// </summary>
        void Reverse();
    }
}

