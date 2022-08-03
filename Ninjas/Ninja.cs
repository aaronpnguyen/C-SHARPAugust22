class Ninja: Human
{
    public Ninja(string name): base(name)
    {
        Dexterity = 175;
    }

    public override int Attack(Human target)
    {
        Random random = new Random();
        int critChance = random.Next(5);
        int critDamage = 0;
        if (critChance == 0)
        {
            critDamage = 10;
            Console.WriteLine("Critical damage, +10 damage!");
        } 
        target.Health -= Dexterity * 5 + critDamage;
        return target.Health;
    }

    public int Steal(Human target)
    {
        target.Health -= 5;
        Health += 5;
        return target.Health;
    }
}