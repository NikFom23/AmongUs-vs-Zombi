using UnityEngine;

public class WeaponManadger : MonoBehaviour
{
    [SerializeField] private GameObject[] _guns;

    private Gun _gunInstance;
    private string _gunName;

    public GameSession _gameSession;


    private void Start()
    {
           
    }


    private void Update()
    {
        _gunName = _gameSession.Data._nameGun;
        GetGunByName(_gunName);
        Shooting();
    }

    private void Shooting()
    {
        if (Input.GetButton("Fire1") || Input.GetButtonDown("Fire1"))
        {
            _gunInstance.Use();
        }
    }

    private void GetGunByName(string name)
    {
        
        foreach (GameObject gun in _guns)
        {
            
            if (gun.name == name)
            {
                gun.SetActive(true);
                _gunInstance = gun.GetComponent<Gun>();
                _gameSession.Data._gunObj = gun;
            }
            else
            {
                
                gun.SetActive(false);
            }
        }
    }
}



