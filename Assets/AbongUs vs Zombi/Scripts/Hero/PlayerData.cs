using System;
using UnityEngine;

[Serializable]
public class PlayerData 
{

    public float _health;
    public int _coin;
    public int _speed;
    public string _nameGun;
    public GameObject[] _buttonActive;


}

[Serializable]
public class WeponPistol
{
    public string _name = "Pistol";
    public int _damage = 1;
    public int _cartridges = 60;
    public float _rate = 0.03f;
    public int _magazine = 10;
    public int _bulletForce = 40;
    public int _cost = 0;
    public int _purchased = 0;

}

[Serializable]
public class WeaponDataAK
{
    public string _name = "Small gun";
    public int _damage = 2;
    public int _cartridges = 60;
    public float _rate = 0.1f;
    public int _magazine = 30;
    public int _bulletForce = 40;
    public int _cost = 40;
    public int _purchased = 0;

}

[Serializable]
public class WeaponBigWing
{
    public string _name = "BigWing";
    public int _damage = 2;
    public int _cartridges = 60;
    public float _rate = 0.1f;
    public int _magazine = 30;
    public int _bulletForce = 40;
    public int _cost = 60;
    public int _purchased = 0;

}

[Serializable]
public class WeaponDataCalibri
{
    public string _name = "Calibri";
    public int _damage = 2;
    public int _cartridges = 60;
    public float _rate = 0.1f;
    public int _magazine = 30;
    public int _bulletForce = 40;
    public int _cost = 40;
    public int _purchased = 0;

}

[Serializable]
public class WeaponDataFonk
{
    public string _name = "Fonk";
    public int _damage = 2;
    public int _cartridges = 60;
    public float _rate = 0.1f;
    public int _magazine = 30;
    public int _bulletForce = 40;
    public int _cost = 40;
    public int _purchased = 0;
}

[Serializable]
public class WeaponDataSWH
{
    public string _name = "SVH";
    public int _damage = 2;
    public int _cartridges = 60;
    public float _rate = 0.1f;
    public int _magazine = 30;
    public int _bulletForce = 40;
    public int _cost = 40;
    public int _purchased = 0;
}