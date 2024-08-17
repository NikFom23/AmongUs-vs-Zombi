
using UnityEngine.Events;
using UnityEngine;

public class Shop : Weapon
{
    [SerializeField] private UnityEvent _actionCost;
    public GameSession _gameSession;

    private int _costGun;
    private int _coin;

    public override void Use()
    {
    }

    public void Start()
    {

        _costGun = _gameSession.WeaponData._cost;
        _coin = _gameSession.Data._coin;
        
    }

    public void BuyGun()
    {
        if (_coin >= _costGun)
        {
            _coin =- _costGun;
            _gameSession.Data._coin = _coin;
        }
    }
}
