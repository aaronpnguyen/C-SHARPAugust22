namespace HungryNinja
{
    class Food
    {
        public string Name;
        public int Calories;
        public bool IsSpicy;
        public bool IsSweet;

        public Food(string name, int calories, bool isSpicy, bool isSweet)
        {
            Name = name;
            Calories = calories;
            IsSpicy = isSpicy;
            IsSweet = isSweet;
        }
    }

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
}