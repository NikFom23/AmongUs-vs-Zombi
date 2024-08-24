
using UnityEngine.Events;
using UnityEngine;

public class Shop : Weapon
{
    [SerializeField] private UnityEvent _actionCost;

    public GameSession _gameSession;

    private int _costGun;
    private int _coin;
    private GameObject[] _name;

    public override void Use()
    {
    }

    private void Start()
    {
        _name = _gameSession.Data._buttonActive;

        foreach (GameObject obj in _name)
        {
            if (obj.name == gameObject.name)
            {
                _actionCost?.Invoke();
                break;
            }
        }
    }


    public void Update()
    {

        _coin = _gameSession.Data._coin;

    }

    public void BuySmallGun()
    {
        _costGun = _gameSession.WeaponData._cost;

        if (_coin >= _costGun)
        {
            
            _coin = _coin - _costGun;
            _gameSession.Data._coin = _coin;
          
            ObjectMassive();
            _actionCost?.Invoke();

        }
    }
    
    public void BuyBigWing()
    {
        _costGun = _gameSession.WeaponBigWing._cost;

        if (_coin >= _costGun)
        {
            _coin = _coin - _costGun;
            _gameSession.Data._coin = _coin;
           
            ObjectMassive();
            _actionCost?.Invoke();

        }
    }
    
    public void BuyCalibri()
    {
        _costGun = _gameSession.DataCalibri._cost;

        if (_coin >= _costGun)
        {
            _coin = _coin - _costGun;
            _gameSession.Data._coin = _coin;
            
            ObjectMassive();
            _actionCost?.Invoke();

        }
    }
    
    public void BuyFonk()
    {
        _costGun = _gameSession.DataFonk._cost;

        if (_coin >= _costGun)
        {
            _coin = _coin - _costGun;
            _gameSession.Data._coin = _coin;
            
            ObjectMassive();
            _actionCost?.Invoke();

        }
    }
    
    public void BuySVH() 
    {

        _costGun = _gameSession.DataSWH._cost;

        if (_coin >= _costGun)
        {
            _coin = _coin - _costGun;
            _gameSession.Data._coin = _coin;
            
            ObjectMassive();
            _actionCost?.Invoke();

        }
    }

    private void ObjectMassive()
    {


        _name = _gameSession.Data._buttonActive;

        GameObject[] newArray = new GameObject[_name.Length + 1];

        for (int i = 0; i < _name.Length; i++)
        {
            newArray[i] = _name[i];
        }

        newArray[newArray.Length - 1] = this.gameObject;
        _name = newArray;
        _gameSession.Data._buttonActive = _name;

       
    }
}
