// See https://aka.ms/new-console-template for more information
class Human
{
    // Properties for Human
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    public int Health;
    // Add a constructor that takes a value to set Name, and set the remaining fields to default values
    Human(string name)
    {
    	Name = name;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        Health = 100;
    }
     
    // Add a constructor to assign custom values to all fields
    Human(string name,int strength,int intelligence, int dexterity, int health)
    {
    	Name = name;
        Strength = strength;
        Intelligence = intelligence;
        Dexterity = dexterity;
        Health = health;
    }
     
    // Build Attack method
    public int Attack(Human attacker,Human attacked)
    {
        int damage=3*attacker.Strength;
        attacked.Health=attacked.Strength-damage;
        return attacked.Health;
    }
    private static void Main(string[] args)
    {
        Human attacked = new Human("jack",6,0,0,0);
        Human attacker = new Human("Tim",9,0,0,0);
        Console.WriteLine("The attacked name is : "+attacked.Name);
        Console.WriteLine("The attacked strength is : "+attacked.Strength);
        Console.WriteLine("The attacker name is : "+attacker.Name);
        Console.WriteLine("The attacker strength is : "+attacker.Strength);
        Console.WriteLine("The remaining health of the attacked : "+attacked.Attack(attacker,attacked));
    }
}
