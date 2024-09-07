using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BuyHeal : MonoBehaviour
{
    [SerializeField] private GameSession _gameSession;
    [SerializeField] private Sprite[] _spriteHeals;
    [SerializeField] private UnityEvent _actionCost;

    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.sprite = _spriteHeals[_gameSession.Data._maxHeals - 4];
    }

    public void BuyExtraLife()
    {
        if (_gameSession.Data._coin >= 20 && _gameSession.Data._maxHeals < 6)
        {
            _gameSession.Data._coin -= 20;

            _gameSession.Data._maxHeals += 1;
            _spriteRenderer.sprite = _spriteHeals[_gameSession.Data._maxHeals - 4];

            if (_gameSession.Data._maxHeals == 6)
            {
                _actionCost?.Invoke();
            }

        }
    }


}
