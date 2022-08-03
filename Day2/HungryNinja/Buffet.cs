class Buffet
{
    public List<Food> Menu;

    public Buffet()
    {
        Menu = new List<Food>() {
            new Food("A5 Japanese Wagyu Steak", 1000, false, false),
            new Food("Ice Cream", 500, false, true),
            new Food("Pizza", 1500, false, true),
            new Food("Thai Chili Chicken", 800, true, true),
            new Food("Spicy Chicken Alfredo", 1400, true, false),
            new Food("Lemon Garlic Wings", 1380, false, false),
            new Food("Seasoned Lobster with Garlic Knots", 2000, true, true)
        };
    }

    public Food Serve() {
        Random random = new Random();
        Food item = Menu[random.Next(Menu.Count)];
        return item;
    }
}