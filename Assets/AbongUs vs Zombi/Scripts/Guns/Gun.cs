using UnityEngine;

public class WeaponGun : Weapon
{
    public GameObject _bullet;
    public GameObject _spaunBull;
    public GameSession _gameSession;

    public GunPistol _gunPistol;

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

        Name = _gunPistol.Name;    
        Damage = _gunPistol.Damage;
        Cartridges = _gameSession.Data._cartridges;
        Rate = _gunPistol.Rate;
        Magazine = _gunPistol.Magazine;
        BulletForce = _gunPistol.BulletForce;

        _gameSession.Data._cartridges = Cartridges;

    }


    public override void Use()
    {

        if (_nextShoot <= 0f)
        {
 
            

            if (Cartridges > 0)
            {
                Cartridges -= 1;
                _gameSession.Data._cartridges = Cartridges;
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

