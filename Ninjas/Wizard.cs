class Wizard: Human
{
    public Wizard(string name): base(name)
    {
        Health = 50;
        Intelligence = 25;
    }

    public override int Attack(Human target)
    {
        target.Health -= Intelligence * 5;
        Health += Intelligence * 5;
        return target.Health;
    }

    public int Heal(Human target)
    {
        target.Health += 10 * Intelligence;
        return target.Health;
    }

    public int Heal()
    {
        return Health += 10 * Intelligence;
    }
}