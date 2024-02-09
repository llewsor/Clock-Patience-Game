namespace Clock_Patience_Game.Interfaces
{
    /// <summary>
    /// Interface for game logic.
    /// </summary>
    public interface IGame
    {
        /// <summary>
        /// Plays a single game of Clock Patience with the given deck.
        /// </summary>
        void PlayGame(IDeck deck);
    }
}