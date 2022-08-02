class Ninja
{
    private int calorieIntake;
    public List<Food> FoodHistory;
    
    public Ninja()
    {
        calorieIntake = 0;
        FoodHistory = new List<Food>();
    }

    public bool IsFull
    {
        get
        {   
            return this.calorieIntake > 1200;
        }
    }

    public void Eat(Food item)
    {
        if (!IsFull)
        {
            calorieIntake += item.Calories;
            FoodHistory.Add(item);
            Console.WriteLine($"You have eaten {item.Name}, it " + (item.IsSpicy? "was ": "was not ") + "spicy and " + (item.IsSweet? "was ": "was not ") + "sweet");
        }
        else
        {
            Console.WriteLine("Stop eating you boutta get thicc like squidward");
        }
    }
}