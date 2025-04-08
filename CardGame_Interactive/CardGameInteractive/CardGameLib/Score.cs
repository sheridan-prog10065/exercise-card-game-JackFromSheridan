namespace CardGameLib;

public struct Score
{
    //Number of rounds won by the Player
    private int _playerScore;
    
    
    //Number of rounds won by the House
    private int _houseScore;

    public int PlayerScore
    {
        get
        {
            return _playerScore;
        }
    }
    
    public int HouseScore
    {
        get
        {
            return _houseScore;
        }
    }
    
}