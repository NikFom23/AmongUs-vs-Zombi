using UnityEngine;

public class WeaponGun : Weapon
{
    public GameObject _bullet;
    public GameObject _spaunBull;
    public GameSession _gameSession;

    [HideInInspector] public float _nextShoot;

    public override void Use()
    {
    }
}


public class Gun : WeaponGun
{
    private void Start()
    {
        _nextShoot = 0f;

        Name = _gameSession.WeaponData._name;    
        Damage = _gameSession.WeaponData._damage;
        Cartridges = _gameSession.WeaponData._cartridges;
        Rate = _gameSession.WeaponData._rate;
        Magazine = _gameSession.WeaponData._magazine;
        BulletForce = _gameSession.WeaponData._bulletForce;
        Cost = _gameSession.WeaponData._cost;

    }


    public override void Use()
    {

        if (_nextShoot <= 0f)
        {
 
            Debug.Log(Cartridges);

            if (Cartridges > 0)
            {
                Cartridges -= 1;
                Shoot();

                _nextShoot = Rate;
            }
        }
        else
        {
            _nextShoot -= Time.deltaTime;

        }
    }

    private void Shoot()
    {
        GameObject bullet = Instantiate(_bullet, _spaunBull.transform.position, _spaunBull.transform.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(_spaunBull.transform.right * BulletForce, ForceMode2D.Impulse);
    }
}

