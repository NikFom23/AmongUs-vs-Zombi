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

// ������� ����� ������������� ������
public class WeponCharacteristics 
{
    public string _name;
    public int _damage;
    public int _cartridges;
    public float _rate;
    public int _magazine;
    public int _bulletForce;
}

// ����� ��� ���������
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
        _rate = 0.03f;
        _magazine = 10;
        _bulletForce = 40;
    }
}

// ����� ��� AK
[Serializable]
public class WeaponDataAK : WeponCharacteristics
{
    public int _cost = 40;
    public int _purchased = 0;

    public WeaponDataAK()
    {
        _name = "Small gun";
        _damage = 2;
        _cartridges = 60;
        _rate = 0.1f;
        _magazine = 30;
        _bulletForce = 40;
    }
}

// ����� ��� BigWing
[Serializable]
public class WeaponBigWing : WeponCharacteristics
{
    public int _cost = 60;
    public int _purchased = 0;

    public WeaponBigWing()
    {
        _name = "BigWing";
        _damage = 2;
        _cartridges = 60;
        _rate = 0.1f;
        _magazine = 30;
        _bulletForce = 40;
    }
}

// ����� ��� Calibri
[Serializable]
public class WeaponDataCalibri : WeponCharacteristics
{
    public int _cost = 40;
    public int _purchased = 0;

    public WeaponDataCalibri()
    {
        _name = "Calibri";
        _damage = 2;
        _cartridges = 60;
        _rate = 0.1f;
        _magazine = 30;
        _bulletForce = 40;
    }
}

// ����� ��� Fonk
[Serializable]
public class WeaponDataFonk : WeponCharacteristics
{
    public int _cost = 40;
    public int _purchased = 0;

    public WeaponDataFonk()
    {
        _name = "Fonk";
        _damage = 2;
        _cartridges = 60;
        _rate = 0.1f;
        _magazine = 30;
        _bulletForce = 40;
    }
}

// ����� ��� SWH
[Serializable]
public class WeaponDataSWH : WeponCharacteristics
{
    public int _cost = 40;
    public int _purchased = 0;

    public WeaponDataSWH()
    {
        _name = "SVH";
        _damage = 2;
        _cartridges = 60;
        _rate = 0.1f;
        _magazine = 30;
        _bulletForce = 40;
    }
}
