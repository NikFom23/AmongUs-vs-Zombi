

public abstract class Weapon 
{ 
    public string Name { get; set; }
    public int Damage { get; set; }
    public int Cartridges { get; set; }
    public int Magazine { get; set; }
    public int Rate { get; set; }

    public abstract void Use();
}

public class Pistol : Weapon
{
    public override void Use()
    {

    }
}

public class Gun : Weapon
{
    public override void Use()
    {

    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Weapon pistol = new Pistol { Name = "Glock ", Damage = 1, Cartridges = 30, Magazine = 7, Rate = 8};
        Weapon gun = new Gun { Name = "AK-47 ", Damage = 2, Cartridges = 60, Magazine = 30, Rate = 4 };

        pistol.Use();
    }
}