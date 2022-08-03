class Samurai: Human
{
    public Samurai(string name): base(name)
    {
        Health = 200;
    }

    public override int Attack(Human target)
    {
        if (target.Health < 50)
        {
            target.Health = 0;
            Console.WriteLine("Automatic Knock Out!");
        } else
        {
            target.Health -= Strength * 5;
        }
        return target.Health;
    }

    public int Meditate()
    {
        return Health = 200;
    }

}