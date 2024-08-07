using PixelCrew.Model;
using UnityEngine;
using UnityEngine.Events;

public class Heals : MonoBehaviour
{
    [SerializeField] public float _heals;
    [SerializeField] private UnityEvent _onDamage;
    [SerializeField] private UnityEvent _onHeal;
    [SerializeField] private UnityEvent _onDie;
    [SerializeField] private GameSession _gameSession;

    [HideInInspector] public int _healthDelta;

    private PlayerData _playerData;
    private Enemy _ebemyData;


    private void Start()
    {

        if (_gameSession == null)
        {
            _gameSession = FindObjectOfType<GameSession>();
        }

        if (gameObject.CompareTag("Player") && _gameSession != null)
        {
            _heals = _gameSession.Data._health; 
        }
        
    }

    public void ModifyHeal()
    {
        
        _heals += _healthDelta;

        if (_healthDelta < 0)
        {
            _onDamage?.Invoke();
        }

        if (_healthDelta > 0)
        {
            _onHeal?.Invoke();
        }

        if (_heals <= 0)
        {
            _onDie?.Invoke();
        }
    }

}
