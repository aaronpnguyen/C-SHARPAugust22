namespace Puzzles {
    class Program {

        
        static void Main(string[] args) {
            
            static int[] RandomArray() {
                int[] arr = new int[10];
                int sum = 0, min = 26, max = 5;
                Random random = new Random();
                for (int i = 0; i < arr.Length; i++) {
                    arr[i] = random.Next(5, 26);
                    sum += arr[i];
                    if (arr[i] < min) min = arr[i];
                    if (arr[i] > max) max = arr[i];
                }
                Console.WriteLine($"Sum: {sum}\nMinium Value: {min}\nMaximum Value: {max}");
                return arr;
            }

            static string TossCoin() {
                Random random = new Random();
                string output = "Heads";
                Console.WriteLine("Tossing a Coin!");
                int coin = random.Next(2);
                if (coin == 1) output = "Tails";
                return output;
            }

            static string TossMultipleCoins(int num) {
                Random random = new Random();
                int count = 0;
                for (int i = 0; i < num; i++) {
                    int coin = random.Next(2);
                    if (coin == 1) count++;
                }
                double ratio = (double) count/num * 100;
                string ratioString = ratio.ToString();
                return $"The ratio of heads to tails is: {ratio}%";
            }

            static List<string> Names() {
                List<string> names = new List<string>();
                Random random = new Random();

                names.Add("Todd");
                names.Add("Tiffany");
                names.Add("Charlie");
                names.Add("Geneva");
                names.Add("Sydney");

                for (int i = 0; i < names.Count; i++) {
                    if (names[i].Length < 5) names.RemoveAt(i);
                }

                for (int i = 0; i < names.Count; i++) {
                    int randomIndex = random.Next(names.Count);
                    string temp = names[i];
                    names[i] = names[randomIndex];
                    names[randomIndex] = temp;
                }

                return names;
            }

            RandomArray();
            Console.WriteLine();
            Console.WriteLine(TossCoin());
            Console.WriteLine();
            Console.WriteLine(TossMultipleCoins(50));
            Console.WriteLine();
            List<string> names = Names();
            foreach (string name in names) {
                Console.WriteLine(name);
            }
        }
    }
}