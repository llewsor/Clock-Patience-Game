namespace Clock_Patience_Game.Interfaces
{
	/// <summary>
    /// Interface for a playing card.
    /// </summary>
    public interface ICard
    {
        /// <summary>
        /// Rank of the card. A,2,3,4,5,6,7,8,9,T,J,Q,K
        /// </summary>
        string Rank { get; }

        /// <summary>
        /// Suit of the card. D = Diamonds, S = Spades, C = Clubs, H = Hearts
        /// </summary>
        char Suit { get; }

        /// <summary>
        /// Determines the pile index based on the card's rank.
        /// </summary>
        int GetPileIndex();
    }
}