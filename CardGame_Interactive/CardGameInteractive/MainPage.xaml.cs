namespace CardGameInteractive;

public partial class MainPage : ContentPage
{
    //Define the HAS-A relationship with CardGame.cs
    private CardGame _cardGame;
    
    public MainPage()
    {
        InitializeComponent();
        
        //Initialize CardGame.cs
        _cardGame = new CardGame();
    }

    private void OnDealCards(object sender, EventArgs e)
    {
        //Ask game object to deal cards to the player and the dealer
        _cardGame.DealCards();
    }
    
    private void OnSwitchCards(object sender, EventArgs e)
    {
        //Ask game object to swap the cards between the player and the dealer
        _cardGame.SwitchCards();
    }
    
    private void OnPlayCards(object sender, EventArgs e)
    {
        
        _cardGame.PlayRound();
    }
    
    
 }