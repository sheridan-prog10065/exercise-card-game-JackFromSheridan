using System.Diagnostics;

namespace CardGameInteractive;

public class CardGame
{
    #region Fields
    //Represents the deck of card the game will use.
    private CardDeck _cardDeck;
    
    //The Scoring System of the game.
    private Score _score;
    
    //Last card played by the user.
    private Card _playerCard;
    
    //Last card played by the house.
    private Card _houseCard;
    #endregion Fields
    
    #region Constructors
    //Constructor of the "CardGame" class.
    public CardGame()
    {
        _cardDeck = new CardDeck();
        _cardDeck.ShuffleCards();
        _score = new Score();
        _playerCard = null;
        _houseCard = null;
    }
    
    #endregion Constructors


    #region Properties
    public Score Score
    {
        get
        {
            return _score;
        }
        
        set
        {
            _score = value;
        }
    }

    public Card PlayerCard
    {
        get
        {
            return _playerCard;
        }
    }

    public Card HouseCard
    {
        get
        {
            return _houseCard;
        }
    }

    public bool IsOver
    {
        get
        {
            return _cardDeck.CardCount < 2;
        }
    }

    public bool PlayerWins
    {
        get
        {
            return this.IsOver && (_score.PlayerScore > _score.HouseScore);
        }
    }

    public bool HouseWins
    {
        get
        {
            return this.IsOver && (_score.HouseScore > _score.PlayerScore);
        }
    }
    
    #endregion
    
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
    public sbyte PlayRound()
    {
        byte cardRank;
        byte houseRank;
        return 0;
    }

    
    //Give cards to the House and the User.
    public void DealCards()
    {
        //extract two cards from the deck and assign them to the player and the house
        bool cardsDealt = _cardDeck.GetPairOfCards(out _playerCard, out _houseCard);
        Debug.Assert(cardsDealt, "Cards could not be dealt. Check the game is not over");
        
    }

    public void SwitchCards()
    {
        //Ask the Card Deck to swap the player and house cards
        _cardDeck.ExchangeCards(ref _playerCard, ref _houseCard);
    }

    private byte DetermineCardRank()
    {
        return 0;
    }

    private void ShowRoundResult()
    {
        
    }
    
    

}