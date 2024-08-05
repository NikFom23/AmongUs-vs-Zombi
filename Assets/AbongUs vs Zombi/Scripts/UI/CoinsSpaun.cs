using UnityEngine;

public class CoinsSpaun : MonoBehaviour
{
    [SerializeField] private Transform _spaun;
    [SerializeField] private GameObject _coinCopper;
    [SerializeField] private GameObject _coinsSilver;
    [SerializeField] private GameObject _coinsGold;

    private GameObject _coinObject;
    private Transform _coinTransform;

    public void SpaunCoins()
    {
        _spaun = GetComponent<Transform>();
        _coinTransform = _spaun;
        Instantiate(_coinCopper, _spaun.position, _spaun.rotation);
        
    }
}
