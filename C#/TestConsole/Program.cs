//                                  ### Бином Ньютона ###

using System;

internal class Program {
    static void Main() {
        Console.Clear();
        Console.Write("Введите степень многочлена: ");
        int n = Convert.ToInt32(Console.ReadLine());
        string res = "";
        Random ClrRand = new Random();
        Console.Write($"(A + B)^{n} = ");
        for(int k = 0; k <= n; k++) {
            int result = C(n, k);
            int randColor = ClrRand.Next(0,10);
            switch(randColor){
                case 0:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case 7:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case 8:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case 9:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
            }
            

            if(k == n)
                Console.WriteLine($"{result}*A^{n-k}*B^{k}");
            else
                Console.Write($"{result}*A^{n-k}*B^{k} + ");
        }
    }

    static int C(int n, int k) {
        return Fact(n) / (Fact(k) * Fact(n - k));
    }

    static int Fact(int i) {
        if (i == 0 || i == 1) {
            return 1;
        }

        return i *= Fact(i - 1);
    }
}