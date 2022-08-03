class Program
{
    static void Main(string[] args)
    {
        Samurai froilan = new Samurai("Froilan");
        Wizard sherline = new Wizard("Sherline");
        Ninja kenia = new Ninja("Kenia");
        Human aaron = new Human("Aaron");
        Console.WriteLine(froilan.Attack(aaron));
        Console.WriteLine(froilan.Attack(aaron));
        Console.WriteLine(froilan.Attack(aaron));
        Console.WriteLine(froilan.Attack(aaron));
        Console.WriteLine(froilan.Attack(aaron));
        Console.WriteLine(sherline.Heal(aaron));
        Console.WriteLine(sherline.Heal(aaron));
        Console.WriteLine(kenia.Attack(aaron));
        Console.WriteLine(kenia.Steal(froilan));
        Console.WriteLine(froilan.Meditate());
    }
}