using System;

class Program
{
    static void Main()
    {
        HeightCategory(170);
        LargestOfThree(10, 25, 15);
        LeapYearChecker(2024);
        QuadraticEquation(1, -5, 6);
        AdmissionEligibility(70, 60, 55);
        ElectricityBill(450);
        VowelOrConsonant('a');
        TriangleType(5, 5, 8);
        QuadrantFinder(-3, 4);
        GradeDescription('E');
        ValidDateCheck(29, 2, 2024);
        ATMWithdrawal(true, true, 5000, 3000);
        ProfitLoss(1000, 1200);
        RockPaperScissors("rock", "scissors");
        SimpleCalculator(10, 5, '+');
    }

    static void HeightCategory(int height)
    {
        if (height < 150) Console.WriteLine("Dwarf");
        else if (height <= 165) Console.WriteLine("Average");
        else if (height <= 190) Console.WriteLine("Tall");
        else Console.WriteLine("Abnormal");
    }

    static void LargestOfThree(int a, int b, int c)
    {
        int max;
        if (a > b)
        {
            if (a > c) max = a;
            else max = c;
        }
        else
        {
            if (b > c) max = b;
            else max = c;
        }
        Console.WriteLine("Largest: " + max);
    }

    static void LeapYearChecker(int year)
    {
        if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            Console.WriteLine("Leap Year");
        else
            Console.WriteLine("Not a Leap Year");
    }

    static void QuadraticEquation(double a, double b, double c)
    {
        double d = b * b - 4 * a * c;
        if (d > 0)
        {
            Console.WriteLine("Roots: " +
                ((-b + Math.Sqrt(d)) / (2 * a)) + ", " +
                ((-b - Math.Sqrt(d)) / (2 * a)));
        }
        else if (d == 0)
        {
            Console.WriteLine("One Root: " + (-b / (2 * a)));
        }
        else
        {
            Console.WriteLine("No Real Roots");
        }
    }


    static void AdmissionEligibility(int math, int phys, int chem)
    {
        int total = math + phys + chem;
        if (math >= 65 && phys >= 55 && chem >= 50 &&
            (total >= 180 || math + phys >= 140))
            Console.WriteLine("Eligible");
        else
            Console.WriteLine("Not Eligible");
    }


    static void ElectricityBill(int units)
    {
        double bill;
        if (units <= 199) bill = units * 1.20;
        else if (units <= 400) bill = 199 * 1.20 + (units - 199) * 1.50;
        else if (units <= 600) bill = 199 * 1.20 + 201 * 1.50 + (units - 400) * 1.80;
        else bill = 199 * 1.20 + 201 * 1.50 + 200 * 1.80 + (units - 600) * 2.00;

        if (bill > 400) bill += bill * 0.15;
        Console.WriteLine("Bill: " + bill);
    }

    static void VowelOrConsonant(char ch)
    {
        switch (char.ToLower(ch))
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine("Vowel");
                break;
            default:
                Console.WriteLine("Consonant");
                break;
        }
    }

    static void TriangleType(int a, int b, int c)
    {
        if (a == b && b == c) Console.WriteLine("Equilateral");
        else if (a == b || b == c || a == c) Console.WriteLine("Isosceles");
        else Console.WriteLine("Scalene");
    }

    static void QuadrantFinder(int x, int y)
    {
        if (x > 0 && y > 0) Console.WriteLine("Quadrant I");
        else if (x < 0 && y > 0) Console.WriteLine("Quadrant II");
        else if (x < 0 && y < 0) Console.WriteLine("Quadrant III");
        else if (x > 0 && y < 0) Console.WriteLine("Quadrant IV");
        else Console.WriteLine("On Axis");
    }

    static void GradeDescription(char grade)
    {
        switch (grade)
        {
            case 'E': Console.WriteLine("Excellent"); break;
            case 'V': Console.WriteLine("Very Good"); break;
            case 'G': Console.WriteLine("Good"); break;
            case 'A': Console.WriteLine("Average"); break;
            case 'F': Console.WriteLine("Fail"); break;
            default: Console.WriteLine("Invalid Grade"); break;
        }
    }

    static void ValidDateCheck(int d, int m, int y)
    {
        try
        {
            DateTime dt = new DateTime(y, m, d);
            Console.WriteLine("Valid Date");
        }
        catch
        {
            Console.WriteLine("Invalid Date");
        }
    }

    static void ATMWithdrawal(bool card, bool pin, double balance, double amount)
    {
        if (card)
        {
            if (pin)
            {
                if (balance >= amount)
                    Console.WriteLine("Withdraw Successful");
                else
                    Console.WriteLine("Insufficient Balance");
            }
            else Console.WriteLine("Invalid PIN");
        }
        else Console.WriteLine("Insert Card");
    }

    static void ProfitLoss(double cp, double sp)
    {
        if (sp > cp)
            Console.WriteLine("Profit % = " + ((sp - cp) / cp * 100));
        else if (cp > sp)
            Console.WriteLine("Loss % = " + ((cp - sp) / cp * 100));
        else
            Console.WriteLine("No Profit No Loss");
    }

    static void RockPaperScissors(string p1, string p2)
    {
        if (p1 == p2) Console.WriteLine("Draw");
        else if ((p1 == "rock" && p2 == "scissors") ||
                 (p1 == "scissors" && p2 == "paper") ||
                 (p1 == "paper" && p2 == "rock"))
            Console.WriteLine("Player 1 Wins");
        else
            Console.WriteLine("Player 2 Wins");
    }

    static void SimpleCalculator(double a, double b, char op)
    {
        switch (op)
        {
            case '+': Console.WriteLine(a + b); break;
            case '-': Console.WriteLine(a - b); break;
            case '*': Console.WriteLine(a * b); break;
            case '/': Console.WriteLine(b != 0 ? a / b : "Division by zero"); break;
            default: Console.WriteLine("Invalid Operator"); break;
        }
    }
}
