namespace Collections {
    class Program{
        static void Main(string[] args) {

            // Arrays

            int[] intArr2 = new int[10];
            for (int i = 0; i < intArr2.Length; i++) {
                intArr2[i] = i;
                Console.WriteLine(i);
            }

            string[] strArr = {"Tim", "Martin", "Nikki", "Sara"};

            bool[] intBool = new bool[10];
            for (int i = 0; i < intBool.Length; i++) {
                // Would it be better to replace an index or create an index?
                if (i % 2 == 0) {
                    intBool[i] = true;
                } else {
                    intBool[i] = false;
                }
                Console.WriteLine(intBool[i]);
            }

            // Lists

            List<string> flavors = new List<string>();
            flavors.Add("Vanilla");
            flavors.Add("Chocolate");
            flavors.Add("Strawberry");
            flavors.Add("Mint Chocolate Chip");
            flavors.Add("Cookies 'n Creme");
            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2); // Third item/second index
            Console.WriteLine(flavors.Count);

            // Dictionaries
            
            Random random = new Random();

            Dictionary<string, string> profiles = new Dictionary<string, string>();
            foreach (string person in strArr) {
                int randomInt = random.Next(flavors.Count);
                profiles.Add(person, flavors[randomInt]);
            }

            foreach (var person in profiles) {
                Console.WriteLine(person.Key + " - " + person.Value);
            }
        }
    }
}