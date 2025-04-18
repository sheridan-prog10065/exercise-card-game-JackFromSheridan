namespace CardGameLib;

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
    
    /// <summary>
    /// Extracts two random cards from the deck
    /// </summary>
    /// <param name="cardOne"> first card output</param>
    /// <param name="cardTwo"> second card output</param>
    /// <returns>true if the extraction is possible, false if there's no cards left</returns>

    public bool GetPairOfCards(out Card cardOne, out Card cardTwo)
    {
        //check that there's enough cards in the deck
        if (_cardList.Count >= 2)
        {
            //extract the first card
            //generate a random position to extract the card from
            int randPos = CardDeck.Randomizer.Next(_cardList.Count);
            
            //access the card at the random index
            cardOne = _cardList[randPos];
            
            //remove the card from the deck
            _cardList.RemoveAt(randPos);
            
            //extract the second card
            randPos = CardDeck.Randomizer.Next(_cardList.Count);
            cardTwo = _cardList[randPos];
            _cardList.RemoveAt(randPos);
            
            //Indicate success of the extraction
            return true;
        }
        else
        {
            cardOne = null;
            cardTwo = null;
            return false;
        }
        
    }

    public void ExchangeCards(ref Card cardOne, ref Card cardTwo)
    {
        //swap the two cards using tuple deconstruction
        (cardOne, cardTwo) = (cardTwo, cardOne);
    }
    
}