using System;
using System.Numerics; 
class Program
{
    static void Main()
    {
        Fibonacci(10);
        PrimeCheck(29);
        Armstrong(153);
        ReverseAndPalindrome(121);
        GcdLcm(12, 18);
        PascalsTriangle(5);
        BinaryToDecimal("10101");
        DiamondPattern(5);
        FactorialLarge(30);
        GuessingGame();
        DigitalRoot(9875);
        ContinueExample();
        MenuSystem();
        StrongNumber(145);
        SearchWithGoto();
    }

    static void Fibonacci(int n)
    {
        int a = 0, b = 1;
        Console.Write("Fibonacci: ");
        for (int i = 1; i <= n; i++)
        {
            Console.Write(a + " ");
            int c = a + b;
            a = b;
            b = c;
        }
        Console.WriteLine();
    }

    static void PrimeCheck(int n)
    {
        bool prime = true;
        for (int i = 2; i <= n / 2; i++)
        {
            if (n % i == 0)
            {
                prime = false;
                break;
            }
        }
        Console.WriteLine(prime ? "Prime" : "Not Prime");
    }

    static void Armstrong(int n)
    {
        int temp = n, sum = 0, digits = n.ToString().Length;
        while (temp > 0)
        {
            int d = temp % 10;
            sum += (int)Math.Pow(d, digits);
            temp /= 10;
        }
        Console.WriteLine(sum == n ? "Armstrong" : "Not Armstrong");
    }

    static void ReverseAndPalindrome(int n)
    {
        int rev = 0, temp = n;
        while (temp > 0)
        {
            rev = rev * 10 + temp % 10;
            temp /= 10;
        }
        Console.WriteLine("Reverse: " + rev);
        Console.WriteLine(rev == n ? "Palindrome" : "Not Palindrome");
    }

    static void GcdLcm(int a, int b)
    {
        int x = a, y = b;
        while (y != 0)
        {
            int r = x % y;
            x = y;
            y = r;
        }
        int gcd = x;
        int lcm = (a * b) / gcd;
        Console.WriteLine($"GCD={gcd}, LCM={lcm}");
    }

    static void PascalsTriangle(int n)
    {
        for (int i = 0; i < n; i++)
        {
            int val = 1;
            for (int j = 0; j <= i; j++)
            {
                Console.Write(val + " ");
                val = val * (i - j) / (j + 1);
            }
            Console.WriteLine();
        }
    }

    static void BinaryToDecimal(string bin)
    {
        int dec = 0, baseVal = 1;
        for (int i = bin.Length - 1; i >= 0; i--)
        {
            if (bin[i] == '1')
                dec += baseVal;
            baseVal *= 2;
        }
        Console.WriteLine("Decimal: " + dec);
    }

    static void DiamondPattern(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.Write(new string(' ', n - i));
            Console.WriteLine(new string('*', 2 * i - 1));
        }
        for (int i = n - 1; i >= 1; i--)
        {
            Console.Write(new string(' ', n - i));
            Console.WriteLine(new string('*', 2 * i - 1));
        }
    }

    static void FactorialLarge(int n)
    {
        BigInteger fact = 1;
        for (int i = 1; i <= n; i++)
            fact *= i;
        Console.WriteLine($"Factorial({n}) = {fact}");
    }

    static void GuessingGame()
    {
        int secret = 7, guess;
        do
        {
            Console.Write("Guess number: ");
            guess = int.Parse(Console.ReadLine());
        } while (guess != secret);

        Console.WriteLine("Correct Guess!");
    }

   
    static void DigitalRoot(int n)
    {
        while (n >= 10)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            n = sum;
        }
        Console.WriteLine("Digital Root: " + n);
    }

   
    static void ContinueExample()
    {
        for (int i = 1; i <= 50; i++)
        {
            if (i % 3 == 0) continue;
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

   
    static void MenuSystem()
    {
        int choice;
        do
        {
            Console.WriteLine("\n1.Add  2.Sub  0.Exit");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: Console.WriteLine(5 + 3); break;
                case 2: Console.WriteLine(5 - 3); break;
            }
        } while (choice != 0);
    }

    
    static void StrongNumber(int n)
    {
        int temp = n, sum = 0;
        while (temp > 0)
        {
            int d = temp % 10;
            int fact = 1;
            for (int i = 1; i <= d; i++)
                fact *= i;
            sum += fact;
            temp /= 10;
        }
        Console.WriteLine(sum == n ? "Strong Number" : "Not Strong");
    }

    
    static void SearchWithGoto()
    {
        int[,] arr = { { 1, 2 }, { 3, 4 } };
        int target = 3;

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                if (arr[i, j] == target)
                    goto FOUND;
            }
        }
        Console.WriteLine("Not Found");
        return;

    FOUND:
        Console.WriteLine("Found using goto");
    }
}









