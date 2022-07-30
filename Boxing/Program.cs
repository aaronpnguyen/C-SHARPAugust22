namespace Boxing {
    class Program {
        static void Main(string[] args) {
            List<object> list = new List<object>();
            list.Add(7);
            list.Add(28);
            list.Add(true);
            list.Add(-1);
            list.Add("chair");

        int sum = 0;
        foreach (var item in list) {
            Console.WriteLine(item);
            if (item is int) {
                int value = (int)item;
                sum += value;
            }
        }
        Console.WriteLine($"Total sum from object: {sum}");
        }
    }
}