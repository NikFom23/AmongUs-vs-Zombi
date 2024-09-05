
using UnityEngine;


public class EnemyEnterCollisionComponent : MonoBehaviour
{
    [SerializeField] private GameSession _gameSession;

    public WeponCharacteristics[] _weaponCharacteristics;

    private string _nameGun;
    private int _damageGun;


    public void Start()
    {
        _nameGun = _gameSession.Data._nameGun;
        WeaponSerch();         
    }

    private void WeaponSerch()
    {

        _weaponCharacteristics = new WeponCharacteristics[]
        {
            new WeponPistol(),
            new WeaponDataAK(),
            new WeaponBigWing(),
            new WeaponDataCalibri(),
            new WeaponDataFonk(),
            new WeaponDataSWH()
        };

        foreach (var wepon in _weaponCharacteristics)
        {
            if (_nameGun == wepon._name)
            {
                _damageGun = wepon._damage;
                
            }
        }

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            gameObject.GetComponent<Heals>()._healthDelta = _damageGun;
            gameObject.GetComponent<Heals>().ModifyHeal();
            
        }
    }

}
