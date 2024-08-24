
using UnityEngine.UI;
using UnityEngine;

public class CoinPlayer : MonoBehaviour
{
    private Text _cponPlayer;

    public GameSession _gameSession;

    private int _coin;

    private void Start()
    {
        _cponPlayer = GetComponent<Text>();
 
    }

    private void Update()
    {
        _coin = _gameSession.Data._coin;
        _cponPlayer .text = _coin.ToString();
        
    }
}

