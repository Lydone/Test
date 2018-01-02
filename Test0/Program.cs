using System;


class Program {

    static int ReadNumber(string message, string errorMessage) {
        int n;
        Console.Write(message);
        while(!int.TryParse(Console.ReadLine(), out n) || n < 15 || n > 50) {
            Console.WriteLine(errorMessage);
        }
        return n;
    }

    static bool CheckTriangle(int a, int b, int c, out int perimeter) {
        if (a + b > c && a + c > b && b + c > a) {
            perimeter = a + b + c;
            return true;
        } else {
            perimeter = 0;
            return false;
        }
    }

    static void PrintTriangle(int a, int b, int c, int perimeter) {
        Console.WriteLine("a = {0}, b = {1}, c = {2}, perimeter = {3}", a, b, c, perimeter);
    }

    static void Main(string[] args) {
        int n, perimeter;
        string message = "Input integer number 15...50: ";
        string errorMessage = "Incorrect input, please, try again";
        ConsoleKeyInfo key = new ConsoleKeyInfo();
        do {
            n = ReadNumber(message, errorMessage);
            for (int i = 8; i < n + 1; i++) {
                for (int j = i + 1; j < n + 1; j++) {
                    if (CheckTriangle(5, i, j, out perimeter)) {
                        PrintTriangle(5, i, j, perimeter);
                    }
                }
            }
            Console.WriteLine("Press esc to exit, enter to continue");
            key = Console.ReadKey(true);
        } while (key.Key != ConsoleKey.Escape);
    }
}
