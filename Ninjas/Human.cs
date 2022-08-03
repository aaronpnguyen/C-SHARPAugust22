class Human
{
    public string Name {get;set;}
    public int Strength {get;set;}
    public int Intelligence {get;set;}
    public int Dexterity {get;set;}
    public int Health {get;set;}

    public Human(string name)
    {
        Name = name;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        Health = 100;
    }

    public Human(string name, int strength, int intelligence, int dexterity, int health)
    {
        Name = name;
        Strength = strength;
        Intelligence = intelligence;
        Dexterity = dexterity;
        Health = health;
    }

    public virtual int Attack(Human target)
    {
        target.Health -= Strength * 5;
        Console.WriteLine("This is from the Human!");
        return target.Health;
    }
}