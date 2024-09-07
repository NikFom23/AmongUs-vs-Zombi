using System;
using UnityEngine;

[Serializable]
public class PlayerData 
{
    public int _maxHeals;
    public int _health;
    public int _coin;
    public int _speed;
    public string _nameGun;
    public GameObject[] _buttonActive;
    public GameObject _gunObj;
    public int _cartridges;

}

[Serializable]
public class EnemyData
{
    public GameObject[] _enemy;
}

// Базовый класс характеристик оружия
public class WeponCharacteristics 
{
    public string _name;
    public int _damage;
    public int _cartridges;
    public float _rate;
    public int _magazine;
    public int _bulletForce;
}

// Класс для пистолета
[Serializable]
public class WeponPistol : WeponCharacteristics
{
    public int _cost = 0;
    public int _purchased = 0;

    public WeponPistol()
    {
        _name = "Pistol";
        _damage = 1;
        _cartridges = 60;
        _rate = 0.5f;
        _magazine = 10;
        _bulletForce = 40;
    }
}

// Класс для AK
[Serializable]
public class WeaponDataAK : WeponCharacteristics
{
    public int _cost = 20;
    public int _purchased = 0;

    public WeaponDataAK()
    {
        _name = "Small gun";
        _damage = -2;
        _cartridges = 60;
        _rate = 0.3f;
        _magazine = 30;
        _bulletForce = 40;
    }
}

// Класс для BigWing
[Serializable]
public class WeaponBigWing : WeponCharacteristics
{
    public int _cost = 200;
    public int _purchased = 0;

    public WeaponBigWing()
    {
        _name = "BigWing";
        _damage = -5;
        _cartridges = 60;
        _rate = 0.5f;
        _magazine = 30;
        _bulletForce = 80;
    }
}

// Класс для Calibri
[Serializable]
public class WeaponDataCalibri : WeponCharacteristics
{
    public int _cost = 300;
    public int _purchased = 0;

    public WeaponDataCalibri()
    {
        _name = "Calibri";
        _damage = -1;
        _cartridges = 60;
        _rate = 0.2f;
        _magazine = 30;
        _bulletForce = 60;
    }
}

// Класс для Fonk
[Serializable]
public class WeaponDataFonk : WeponCharacteristics
{
    public int _cost = 400;
    public int _purchased = 0;

    public WeaponDataFonk()
    {
        _name = "Fonk";
        _damage = -2;
        _cartridges = 80;
        _rate = 0.1f;
        _magazine = 30;
        _bulletForce = 80;
    }
}

// Класс для SWH
[Serializable]
public class WeaponDataSWH : WeponCharacteristics
{
    public int _cost = 500;
    public int _purchased = 0;

    public WeaponDataSWH()
    {
        _name = "SVH";
        _damage = -2;
        _cartridges = 60;
        _rate = 0.05f;
        _magazine = 30;
        _bulletForce = 90;
    }
}
