using UnityEngine;
using TMPro;

public class CoinsUI : MonoBehaviour
{
    public int _coin;
    public TMP_Text _textCoin;

    private void Start() 
    {
        _textCoin = GetComponent<TMP_Text>();
        _coin = 0;
    }

    public void UpCoin()
    {
        _coin += 1;
        _textCoin.text = _coin.ToString();
    }
}
