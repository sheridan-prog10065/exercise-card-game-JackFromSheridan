namespace CardGameInteractive;

public class CardDeck
{
    //List of cards in the deck.
    private List<Card> _cardList;

    public CardDeck()
    {
        _cardList = new List<Card>();
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
    
    
    
    
}