namespace Clock_Patience_Game.Interfaces
{
    public interface ICardFactory
    {
        /// <summary>
        /// Defines a method to create a card from its string representation.
        /// </summary>
        ICard CreateCard(string cardRepresentation);
    }
}