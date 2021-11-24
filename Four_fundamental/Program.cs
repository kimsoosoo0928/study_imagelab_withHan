using System;

namespace Four_fundamental
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 0;
            int second = 0;

            Console.WriteLine("숫자를 , 로 구분해서 두개 입력하세요");
            string[] input = Console.ReadLine().Split(',');

            first = int.Parse(input[0]);
            second = int.Parse(input[1]);

            int sum = first + second;
            int sub = first - second;
            int mul = first * second;
            float div = (float)first / (float)second;

            Console.WriteLine(sum);
            Console.WriteLine(sub);
            Console.WriteLine(mul);
            Console.WriteLine(div);
        }

        
    }
}
