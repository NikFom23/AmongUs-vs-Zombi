
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
        _coin = _gameSession.Data._coin;
        if (_gameSession == null)
        {
            Debug.LogError("GameSession is not assigned!");
            return;
        }

        if (_cponPlayer == null)
        {
            Debug.LogError("TMP_Text component is missing!");
            return;
        }
        _cponPlayer.text = _coin.ToString();

        
    }
}

