using UnityEngine;
using UnityEngine.Events;

public class Heals : MonoBehaviour
{
    [SerializeField] public float _heals;
    [SerializeField] private UnityEvent _onDamage;
    [SerializeField] private UnityEvent _onHeal;
    [SerializeField] private UnityEvent _onDie;

    [HideInInspector] public int _healthDelta;

    private PlayerData _playerData;
    private Enemy _ebemyData;


    private void Start()
    {
        if (gameObject.CompareTag("Player"))
        {
            _heals = _playerData._health;
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
