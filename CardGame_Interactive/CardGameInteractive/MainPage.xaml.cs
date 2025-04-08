using System.Diagnostics;
using CardGameLib;

namespace CardGameInteractive;

public partial class MainPage : ContentPage
{
    private readonly static ImageSource s_imageSourceCardBack;
    
    //Define the HAS-A relationship with CardGame.cs
    private CardGame _cardGame;
    
    public MainPage()
    {
        InitializeComponent();
        
        //Initialize CardGame.cs
        _cardGame = new CardGame();
    }

    static MainPage()
    {
        s_imageSourceCardBack = ImageSource.FromFile("cardBack_blue.png");
    }

    private void OnDealCards(object sender, EventArgs e)
    {
        //ensure the cards being dealt are turned face down
        _imgPlayerCard.Source = s_imageSourceCardBack;
        _imgHouseCard.Source = s_imageSourceCardBack;
        
        //Ask game object to deal cards to the player and the dealer
        _cardGame.DealCards();
        
        //Inform the user what they can do next: switch or play the cards
        _txtGameBoard.Text = "You can play the round or swap cards with the house";

        //allow the user to play
        _btnDealCards.IsEnabled = true;
        _btnSwitchCards.IsEnabled = true;

    }
    
    private void OnSwitchCards(object sender, EventArgs e)
    {
        //Ask game object to swap the cards between the player and the dealer
        _cardGame.SwitchCards();
    }
    
    private void OnPlayCards(object sender, EventArgs e)
    {
        //Ask the game to play a round in the game
        sbyte roundResult =  _cardGame.PlayRound();
        
        //Show the results of the round
        ShowRoundResult(roundResult);
        
        //Disable the play commands and allow the user to deal another card
        _btnSwitchCards.IsEnabled = false;
        _btnPlayCards.IsEnabled = false;
        _btnDealCards.IsEnabled = true;

        //Check whether the game is over
        if (_cardGame.IsOver)
        {
            //
        }

    }

    private void ShowRoundResult(sbyte roundResult)
    {
        //Update scoreboard
        _txtPlayerScore.Text = _cardGame.Score.PlayerScore.ToString();
        _txtHouseScore.Text = _cardGame.Score.HouseScore.ToString();
        
        //Show the cards that've been played
        ShowCard(_imgPlayerCard, _cardGame.PlayerCard);
        ShowCard(_imgHouseCard, _cardGame.HouseCard);

        //Display who won the round
        switch (roundResult)
        {
            case 1:
                _txtGameBoard.Text = "Player wins the round.";
                break;
            
            case -1:
                _txtGameBoard.Text = "House wins the round.";
                break;
            
            case 0:
                _txtGameBoard.Text = "The round is a tie";
                break;
            
            default:
                Debug.Assert(false, "Unknown round result");
                break;
            
        }

    }

    private void ShowCard(Image imageControl, Card card)
    {
        //Determine the image source for player and house cards based on the card value and suit
        char suitId = card.Suit.ToString()[0];
        string fileName = $"{suitId}{card.Value.ToString(format: "00")}.png";

        //Set the image source
        imageControl.Source = ImageSource.FromFile(fileName);

    }

    private void ShowGameOver()
    {
        //Display who won the game
        if (_cardGame.PlayerWins)
        {
            _txtGameBoard.Text = "The player won the game.";
        }
        else if (_cardGame.HouseWins)
        {
            _txtGameBoard.Text = "The House Always Wins.";
        }
        else
        {
            _txtGameBoard.Text = "The game was a draw";
        }
        
        //Disallow the dealing of the cards
        _btnSwitchCards.IsEnabled = false;
        _btnPlayCards.IsEnabled = false;
        _btnDealCards.IsEnabled = false;
        
        
    }
    
    
}