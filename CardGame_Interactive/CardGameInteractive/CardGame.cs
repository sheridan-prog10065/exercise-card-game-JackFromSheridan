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

    //Plays the game.
    public void Play()
    {
        
    }
    
    //Play a round of the game.
    /// <returns>
    /// +1: User wins
    /// 0: Tie
    /// -1: House wins
    /// </returns>
    private sbyte PlayRound()
    {
        return 0;
    }

    
    //Give cards to the House and the User.
    private void DealCards()
    {
        
    }

    private void SwitchCards()
    {
        
    }

    private byte DetermineCardRank()
    {
        return 0;
    }

    private void ShowRoundResult()
    {
        
    }
    
    

}