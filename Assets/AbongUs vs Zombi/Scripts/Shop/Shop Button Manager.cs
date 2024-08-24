using UnityEngine;
using UnityEngine.Events;

public class ShopButtonManager : MonoBehaviour
{
    [SerializeField] private UnityEvent _actionButtonBuy;
    [SerializeField] private UnityEvent _actionButtonPurchased;
    //[SerializeField] private GameObject _shopButton;
    //[SerializeField] private GameObject _purchasedButton;

    public GameSession _gameSession;

    private int _purchased;


    private void Start()
    {
        
        ButtonBuy();
    }

    private void Update()
    {
        
    }


    private void ButtonBuy()
    {
        _purchased = _gameSession.WeaponData._purchased;

        if (_purchased == 0)
        {
            _actionButtonBuy?.Invoke(); 
        }
        else
        {
            _actionButtonPurchased?.Invoke();
        }
    } 
}
