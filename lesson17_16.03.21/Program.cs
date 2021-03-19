using System;
using System.Linq;

namespace lesson17_16._03._21
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "hello";
            Zadacha1(ref a);
            Console.WriteLine(a);
            Zadacha2(ref a);
            Console.WriteLine(a);

            a = "gdfgdf234dg54gf*23oP42";
            Console.WriteLine(Zadacha3(a));

            a = "camelCasing";
            Zadacha4(ref a);
            Console.WriteLine(a);

        }

        static void Zadacha1(ref string input)
        {
            input = new string (input
                .Select(n => 
                    n == 'a' ? '1' :
                    n == 'e' ? '2' :
                    n == 'i' ? '3' :
                    n == 'o' ? '4' :
                    n == 'u' ? '5' :
                    n)
                .ToArray()
                );
        }

        static void Zadacha2(ref string input)
        {
            input = new string(input
                .Select(n =>
                    n == '1' ? 'a' :
                    n == '2' ? 'e' :
                    n == '3' ? 'i' :
                    n == '4' ? 'o' :
                    n == '5' ? 'u' :
                    n)
                .ToArray()
                );
        }

        static double Zadacha3(string input)
        {
            var sign = input
                .First(char.IsPunctuation);

            var clear = new string(input
                .Where(i => Char.IsDigit(i) || char.IsPunctuation(i))
                .ToArray())
                .Split(sign);

            double x = double.Parse(clear[0]);
            double y = double.Parse(clear[1]);

            var ans = sign switch
            {
                '+' => x + y,
                '-' => x - y,
                '*' => x * y,
                '/' => x / y,
                _ => default
            };
            return ans;
        }

        static void Zadacha4(ref string input)
        {
            var temp = input[0];
            input = temp + input
                .Skip(1)
                .Select(n =>
                Char.IsUpper(n) ? " " + n : 
                n.ToString())
                .Aggregate((a, b) => a + b);
        }
    }
}
