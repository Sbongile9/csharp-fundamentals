using System;

class Program
{
    static void Main()
    {
        Console.Write("Hello, World!");
    }
}
class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double avg = (a + b + c) / 3.0;

        Console.WriteLine($"Average: {avg:F2}");
    }
}

2_avg.cs
using System;

class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double avg = (a + b + c) / 3.0;

        Console.WriteLine($"Average: {avg:F2}");
    }
}

3_evenodd.cs
using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(n % 2 == 0 ? "Even" : "Odd");
    }
}

4_factorial.cs
using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        long fact = 1;

        for (int i = 2; i <= n; i++)
        {
            fact *= i;
        }

        Console.WriteLine($"{n}! = {fact}");
    }
}

5_f_to_c.cs
using System;

class Program
{
    static void Main()
    {
        double fahrenheit = double.Parse(Console.ReadLine());

        double celsius = (fahrenheit - 32) * 5 / 9;

        Console.WriteLine($"Celsius: {celsius:F1}");
    }
}

6_fibonacci.cs
using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        long a = 0;
        long b = 1;

        for (int i = 0; i < n; i++)
        {
            Console.Write(a);

            if (i < n - 1)
                Console.Write(" ");

            long next = a + b;
            a = b;
            b = next;
        }

        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        string cleaned = new string(
            input.ToLower()
                 .Where(c => c != ' ')
                 .ToArray());

        char[] chars = cleaned.ToCharArray();
        Array.Reverse(chars);

        string reversed = new string(chars);

        Console.WriteLine(cleaned == reversed
            ? "Palindrome"
            : "Not a palindrome");
    }
}

8_prime.cs
using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        bool isPrime = true;

        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        Console.WriteLine(isPrime ? "Prime" : "Not prime");
    }
}

9_max_array.cs
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        Console.WriteLine($"Max: {numbers.Max()}");
    }
}

10_reverse.cs
using System;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();

        char[] chars = text.ToCharArray();
        Array.Reverse(chars);

        Console.WriteLine(new string(chars));
    }
}

11_vowels.cs
using System;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine().ToLower();

        int count = 0;

        foreach (char c in text)
        {
            if ("aeiou".Contains(c))
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}

12_mult_table.cs
using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} x {i} = {n * i}");
        }
    }
}

13_digits.cs
using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        if (input.StartsWith("-"))
            input = input.Substring(1);

        Console.WriteLine(input.Length);
    }
}

14_sum_digits.cs
using System;

class Program
{
    static void Main()
    {
        string number = Console.ReadLine();

        int sum = 0;

        foreach (char c in number)
        {
            if (char.IsDigit(c))
            {
                sum += c - '0';
            }
        }

        Console.WriteLine(sum);
    }
}

15_grade.cs
using System;

class Program
{
    static void Main()
    {
        int score = int.Parse(Console.ReadLine());

        if (score >= 90)
            Console.WriteLine("A");
        else if (score >= 80)
            Console.WriteLine("B");
        else if (score >= 70)
            Console.WriteLine("C");
        else if (score >= 60)
            Console.WriteLine("D");
        else
            Console.WriteLine("F");
    }
}

16_words.cs
using System;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();

        string[] words = text.Split(
            new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine(words.Length);
    }
}

17_leap.cs
using System;

class Program
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());

        bool leap =
            (year % 4 == 0 && year % 100 != 0)
            || (year % 400 == 0);

        Console.WriteLine(
            leap ? "Leap year" : "Not a leap year");
    }
}

18_ascending.cs
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        bool ascending = true;

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < numbers[i - 1])
            {
                ascending = false;
                break;
            }
        }

        Console.WriteLine(
            ascending ? "Ascending" : "Not ascending");
    }
}

19_calculator.cs
using System;

class Program
{
    static void Main()
    {
        double num1 = double.Parse(Console.ReadLine());
        string op = Console.ReadLine();
        double num2 = double.Parse(Console.ReadLine());

        switch (op)
        {
            case "+":
                Console.WriteLine(num1 + num2);
                break;

            case "-":
                Console.WriteLine(num1 - num2);
                break;

            case "*":
                Console.WriteLine(num1 * num2);
                break;

            case "/":
                Console.WriteLine($"{num1 / num2:F2}");
                break;

            default:
                Console.WriteLine("Invalid operator");
                break;
        }
    }
}
