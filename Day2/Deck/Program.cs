class Program
{
    static void Main(string[] args)
    {   
        Deck deck = new Deck();
        Player datBoi = new Player("Aaron");
        datBoi.Draw(deck);
        Console.WriteLine(datBoi.Hand[0]);
    }
}