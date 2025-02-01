namespace CardGameInteractive;

//Defines the card in a card game with its value and suit
public class Card
{
    //The Value of the card
    private byte _value;
    
    //The Suit of the card
    private CardSuit _suit;

    public Card(byte value, CardSuit suit)
    {
        _value = value;
        _suit = suit;
    }
}