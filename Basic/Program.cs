namespace Basic {
    class Program {
        static void Main(string[] args) {
            static void PrintNumbers() {
                for (int i = 1; i <= 255; i++) {
                    Console.WriteLine(i);
                }
            }

            static void PrintOdds() {
                for (int i = 1; i <= 255; i++) {
                    if (i % 2 != 0) Console.WriteLine(i);
                }
            }

            static void PrintSum() {
                int sum = 0;
                for (int i = 1; i <= 255; i++) {
                    sum += i;
                }
                Console.WriteLine(sum);
            }
            
            static void LoopArray(int[] numbers) {
                foreach (int i in numbers) {
                    Console.WriteLine(i);
                }
            }

            static int FindMax(int[] numbers) {
                int max = 0;
                foreach (int i in numbers) {
                    if (i > max) max = i;
                }
                return max;
            }

            static void GetAverage(int[] numbers) {
                int avg = 0;
                foreach (int i in numbers) {
                    avg += i;
                }
                Console.WriteLine((double)avg/numbers.Length);
            }

            static int[] OddArray() {
                int[] arr = new int[(int)Math.Ceiling((double)255 / 2)];
                for (int i = 1; i < arr.Length; i += 2) {
                    arr[i] = i;
                    Console.WriteLine(arr[i]);
                }
                return arr;
            }

            static int GreaterThanY(int[] numbers, int y) {
                int count = 0;
                foreach (int i in numbers) {
                    if (i > y) count++;
                }
                return count;
            }

            static void SquareArrayValues(int[] numbers) {
                for (int i = 0; i < numbers.Length; i++) {
                    numbers[i] *= numbers[i];
                    Console.WriteLine(numbers[i]);
                }
            }

            static void EliminateNegatives(int[] numbers) {
                for (int i = 0; i < numbers.Length; i++) {
                    if (numbers[i] < 0) numbers[i] = 0;
                    Console.WriteLine(numbers[i]);
                }
            }

            static void MinMaxAverage(int[] numbers) {
                int min = numbers[numbers.Length - 1], max = numbers[numbers.Length - 1];
                float average = 0;
                foreach (int i in numbers) {
                    if (i < min) min = i;
                    if (i > max) max = i;
                    average += i;
                }
                average = average / numbers.Length;
                Console.WriteLine($"Min: {min}, Max: {max}, Average: {average.ToString("n2")}");
            }

            static void ShiftValues(int[] numbers) {
                for (int i = 0; i < numbers.Length; i++) {
                    if (i == numbers.Length - 1) numbers[i] = 0;
                    else numbers[i] = numbers[i + 1];
                    Console.WriteLine(numbers[i]);
                }
            }

            static object[] NumToString(object[] numbers) {
                for(int i = 0; i < numbers.Length; i++) {
                    if ((int)numbers[i] < 0) {
                        numbers[i] = "Dojo";
                    }
                Console.WriteLine(numbers[i]);
                }
                return numbers;
            }

            PrintNumbers();
            PrintOdds();
            PrintSum();
            int[] arr = {-1, -3, 2, 5, 2, 3, 1, 9 -10, 5};
            object[] arrObj = {-1, -3, 2};
            LoopArray(arr);
            FindMax(arr);
            Console.WriteLine(FindMax(arr));
            GetAverage(arr);
            Console.WriteLine(OddArray());
            Console.WriteLine(GreaterThanY(arr, 2));
            SquareArrayValues(arr);
            EliminateNegatives(arr);
            MinMaxAverage(arr);
            ShiftValues(arr);
            NumToString(arrObj);
        }
    }
}