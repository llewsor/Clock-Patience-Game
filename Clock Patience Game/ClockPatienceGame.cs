using Clock_Patience_Game.Interfaces;

namespace Clock_Patience_Game
{
    /// <summary>
    /// Manages the Clock Patience game logic.
    /// </summary>
    public class ClockPatienceGame : IGame
    {
        private static ClockPatienceGame? instance;

        /// <summary>
        /// Piles of cards.
        /// </summary>
        private List<Stack<ICard>> piles = new List<Stack<ICard>>();

        /// <summary>
        /// Add new 13 piles of stack cards.
        /// </summary>
        private ClockPatienceGame()
        {
            for (int i = 0; i < 13; i++) piles.Add(new Stack<ICard>());
        }

        /// <summary>
        /// Gets the single instance of ClockPatienceGame.
        /// </summary>
        public static ClockPatienceGame Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ClockPatienceGame();
                }
                return instance;
            }
        }

        /// <summary>
        /// Plays a single game of Clock Patience with the given deck.
        /// </summary>
        public void PlayGame(IDeck deck)
        {
            //Current pile index
            int cp = 0;

            foreach (var card in deck.Cards)
            {
                //Add card to the pile
                piles[cp].Push(card);

                //Increment current pile index, if 12 (12 = K) set to 0 
                cp = cp == 12 ? 0 : cp + 1;
            }

            //Cards exposed counter
            int cardsExposed = 0;

            //Get card from pile, start with the King pile
            ICard currentCard = piles[12].Pop();

            //Increment card exposed counter.
            cardsExposed++;

            //While there are cards in the current card pile, do
            while (piles[currentCard.GetPileIndex()].Count > 0)
            {
                //Get card from current card pile
                currentCard = piles[currentCard.GetPileIndex()].Pop();
                //Increment card exposed counter.
                cardsExposed++;
            }

            //END of game, output number of cards exposed and the last card exposed
            Console.WriteLine($"{cardsExposed:D2},{currentCard.Rank}{currentCard.Suit}");
        }
    }
}