
using UnityEngine;

public class GunPistol : Weapon
{
    public GameSession _gameSession;

    public WeponCharacteristics[] _weaponCharacteristics;
    public override void Use()
    {
    }

    public void Start()
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
        
        foreach (var weapon in _weaponCharacteristics)
        {
            
            
            if (weapon._name == gameObject.name)
            {

               

                Name = weapon._name;
                Damage = weapon._damage;
                
                Rate = weapon._rate;
                Magazine = weapon._magazine;
                BulletForce = weapon._bulletForce;

                
                break;
            }
        }
    }

}
