using UnityEngine;

public class WeaponManadger : MonoBehaviour
{   
    private Gun _gunInstance;


    private void Start()
    {
        _gunInstance = GetComponent<Gun>();
    }


    private void Update()
    {
        Shooting();
    }

    private void Shooting()
    {
        if (Input.GetButton("Fire1") || Input.GetButtonDown("Fire1"))
        {
            _gunInstance.Use();
        }
    }
}

    

