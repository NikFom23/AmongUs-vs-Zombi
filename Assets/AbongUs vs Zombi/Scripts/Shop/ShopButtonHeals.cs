using UnityEngine;

public class ShopButtonHeals : MonoBehaviour
{
    public GameSession _gameSession;

    public void BuyHeals() 
    {
        if (_gameSession.Data._coin >= 5)
        {
            if (_gameSession.Data._health > _gameSession.Data._maxHeals)
            {
                _gameSession.Data._health += 1;
                _gameSession.Data._coin -= 5;
            }
        }
        
    }
}
