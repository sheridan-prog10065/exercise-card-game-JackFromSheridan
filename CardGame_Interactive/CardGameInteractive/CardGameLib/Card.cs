using System.Diagnostics;
using Debug = System.Diagnostics.Debug;

namespace CardGameLib;

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

    public byte Value
    {
        get
        {
            return _value;
        }
    }

    public CardSuit Suit
    {
        get
        {
            return _suit;
        }

        set
        {
            _suit = value;
        }
    }

    public string CardName
    {
        get
        {
            switch (_value)
            {
                case 1:
                    return "Ace";
                
                case 13:
                    return "King";
                
                case 12:
                    return "Queen";
                
                case 11:
                    return "Jack";
                
                default:
                    //Convert the numeric value into a string.
                    return _value.ToString();
            }
        }
    }

    public string SuitName
    {
        get
        {
            switch (_suit)
            {
                case CardSuit.Clubs:
                    return "Clubs";
                
                case CardSuit.Diamonds:
                    return "Diamonds";
                
                case CardSuit.Hearts:
                    return "Hearts";
                
                case CardSuit.Spades:
                    return "Spades";
                
                default:
                    Debug.Assert(false, "Unknown suit value. Cannot return suit name");
                    return _suit.ToString();
            }
        }
    }
    
}