using UnityEngine;

public class HeroEnterCollisionComponent : MonoBehaviour
{
    private int _damage;
    private Enemy[] _enemy;
    private int _cartridges;

    public WeponCharacteristics[] _weaponCharacteristics;

    public GameSession _gameSession;


    private void Start()
    {
        _enemy = new Enemy[]
       {
            new Enemy { Name = "Zombi", Damage = -1 },
            new Enemy { Name = "Mutant", Damage = -2 },
            new Enemy { Name = "Predator", Damage = -3 },
            new Enemy { Name = "Boss", Damage = -10 }
       };

        _weaponCharacteristics = new WeponCharacteristics[]
        {
            new WeponPistol(),
            new WeaponDataAK(),
            new WeaponBigWing(),
            new WeaponDataCalibri(),
            new WeaponDataFonk(),
            new WeaponDataSWH()
        };

        
    }

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (collision.gameObject.tag == "Enemy")
        {
            
            foreach (var obj in _enemy) 
            {
                
                
                if (obj.Name == collision.gameObject.name)
                {
                    
                    gameObject.GetComponent<Heals>()._healthDelta = obj.Damage;
                    gameObject.GetComponent<Heals>().ModifyHeal();
                    break;
                }
            }
        }

        if (collision.gameObject.tag == "Cartridges")
        {
            foreach (var wepon in _weaponCharacteristics)
            {
                if (_gameSession.Data._nameGun == wepon._name)
                {
                    wepon._cartridges = wepon._cartridges + 20;
                    break;
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Heals")
        {
           
            gameObject.GetComponent<Heals>()._healthDelta = 2;
            gameObject.GetComponent<Heals>().ModifyHeal();
        }
    }
}

public class Enemy
{
    public string Name { get; set; }
    public int Damage { get; set; }
    
}
