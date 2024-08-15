
using UnityEngine;
using UnityEngine.Events;

public class Heals : MonoBehaviour
{
    
    [SerializeField] private UnityEvent _onDamage;
    [SerializeField] private UnityEvent _onHeal;
    [SerializeField] private UnityEvent _onDie;
    [SerializeField] private GameSession _gameSession;

    [HideInInspector] public int _healthDelta;

    private PlayerData _playerData;
    private Enemy _ebemyData;
    public float _heals;


    private void Start()
    {
        

        if (gameObject.CompareTag("Player") && _gameSession != null)
        {
            _heals = _gameSession.Data._health;
            
        }
        
    }

    public void ModifyHeal()
    {
        _heals += _healthDelta;

        if (_gameSession != null)
        {
            _gameSession.Data._health = _heals;
            
        }

        

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
