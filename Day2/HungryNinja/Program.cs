class Program
{
    static void Main(string[] args)
    {
        Buffet foodBar = new Buffet();
        Ninja datBoi = new Ninja();
        datBoi.Eat(foodBar.Serve());
        datBoi.Eat(foodBar.Serve());
        datBoi.Eat(foodBar.Serve());
    }
}
