namespace CardGameInteractive;

public class CardGame
{
    //Represents the deck of card the game will use.
    private CardDeck _cardDeck;
    
    //The Scoring System of the game.
    private Score _score;
    
    //Last card played by the user.
    private Card _playerCard;
    
    //Last card played by the house.
    private Card _houseCard;
    
    //Constructor of the "CardGame" class.
    public CardGame()
    {
        _cardDeck = new CardDeck();
        _score = new Score();
        _playerCard = null;
        _houseCard = null;
    }

}