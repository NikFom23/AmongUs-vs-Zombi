using System;

[Serializable]
public class PlayerData 
{

    public float _health;
    public int _coin;
    public int _speed;

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


}public class WeaponDataColt
{
    public int _damage;
    public int _cartridges;
    public float _rate;
    public int _magazine;
    public int _bulletForce;

}public class WeaponDataAWM
{
    public int _damage;
    public int _cartridges;
    public float _rate;
    public int _magazine;
    public int _bulletForce;

}public class WeaponDataSuperGun
{
    public int _damage;
    public int _cartridges;
    public float _rate;
    public int _magazine;
    public int _bulletForce;
}