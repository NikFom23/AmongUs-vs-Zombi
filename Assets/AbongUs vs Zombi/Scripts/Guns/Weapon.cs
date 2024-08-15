using UnityEngine;


public abstract class Weapon : MonoBehaviour
{
    [HideInInspector] public string Name { get; set; }
    [HideInInspector] public int Damage { get; set; }
    [HideInInspector] public int Cartridges { get; set; }
    [HideInInspector] public int Magazine { get; set; }
    [HideInInspector] public float Rate { get; set; }
    [HideInInspector] public int BulletForce { get; set; }

    public abstract void Use();
}

