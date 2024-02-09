using Clock_Patience_Game;
using Clock_Patience_Game.Builders;

//Declare a new deck builder.
var deckBuilder = new DeckBuilder();

//Store current line text
string line;

//Read user input untill the user input the character '#' to being the game.
while ((line = Console.ReadLine()) != null && line != "#")
{
    //Split string by whitespace and alterate each string
    foreach (var cardStr in line.Split(' '))
    {
        //Add new card to the card builder using card representation string 
        deckBuilder.AddCard(cardStr);
    }
}

//Build deck and play Clock Patience Game
ClockPatienceGame.Instance.PlayGame(deckBuilder.Build());
Console.ReadLine();