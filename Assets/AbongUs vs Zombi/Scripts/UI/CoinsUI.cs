using UnityEngine;
using TMPro;


public class CoinsUI : MonoBehaviour
{
    [SerializeField] private GameSession _gameSession;

    public int _coin;
    public TMP_Text _textCoin;

    

    private void Start() 
    {
        _textCoin = GetComponent<TMP_Text>();


        if (_gameSession != null)
        {
            _coin = _gameSession.Data._coin;


            UpdateCoinUI();
        }
    }


    private void UpdateCoinUI()
    {
        _textCoin.text = _coin.ToString();
    }

    public void UpCoin()
    {
        _coin += 1;
        _textCoin.text = _coin.ToString();


        if (_gameSession != null)
        {
            _gameSession.Data._coin = _coin;

        }
    }
}
