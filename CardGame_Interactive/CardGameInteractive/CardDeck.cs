namespace CardGameInteractive;

public class CardDeck
{
    //List of cards in the deck.
    private List<Card> _cardList;
    
    //Define card deck constants
    private const int MAX_SUIT_COUNT = 4;
    private const int MAX_CARD_VALUE = 13;
    
    //Define singleton randomizer object
    private static Random s_randomizer;

    static CardDeck()
    {
        s_randomizer = new Random();
    }

    public CardDeck()
    {
        _cardList = new List<Card>();
        
        //Create the cards in the deck
        CreateCards();
    }

    /// <summary>
    /// Read-only property that returns the number of cards in the deck.
    /// </summary>
    public int CardCount
    {
        get
        {
            return _cardList.Count;
        }
    }

    public static Random Randomizer
    {
        get { return s_randomizer; }
    }

    private void CreateCards()
    {
        //For each suit in the card deck
        for (int iSuit = 1; iSuit <= MAX_SUIT_COUNT; iSuit++)
        {
            CardSuit suit = (CardSuit)iSuit;
            //For each card value
            for (byte value = 1; value <= MAX_CARD_VALUE; value++)
            {
                //Create the card object with the given suit and value
                Card card = new Card(value, suit);

                //add the card to the deck
                _cardList.Add(card);
            }
            
        }
    }

    public void ShuffleCards()
    {
        //For each card in the deck 
        for (int iCard = 0 ; iCard < _cardList.Count ; iCard++)
        {
            //Choose a random position in the deck
            int randPos = s_randomizer.Next(iCard, _cardList.Count);
            
            //Replace the current card with the card at the random position
            Card crtCard = _cardList[iCard];
            Card randCard = _cardList[randPos];
            _cardList[randPos] = crtCard;
            _cardList[iCard] = randCard;
            
        }
        
    }

    public bool GetPairOfCards(out Card cardOne, out Card cardTwo)
    {
        
    }
    
}