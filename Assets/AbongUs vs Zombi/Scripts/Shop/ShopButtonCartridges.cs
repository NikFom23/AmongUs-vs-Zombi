using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopButtonCartridges : MonoBehaviour
{
    [SerializeField] private GameSession _gameSession;


    public void BuyCartridges()
    {
        if (_gameSession.Data._coin >= 5)
        {
            _gameSession.Data._coin -= 5;
            _gameSession.Data._cartridges += 40;

        }
    }
} 