static void count() {
    int i = 1;
    while (i <= 255) {
        Console.WriteLine(i);
        i++;
    }
}

static void fizzBuzz() {
    int i = 1;
    while (i <= 100) {
        if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("FizzBuzz");
        else if (i % 3 == 0) Console.WriteLine("Fizz");
        else if (i % 5 == 0) Console.WriteLine("Buzz");
        i++;
    }
}

count();
fizzBuzz();