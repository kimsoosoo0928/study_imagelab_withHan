using System;

namespace triangle_class
{

    class Triangle
    {
        int side_a;
        int side_b;
        int side_c;

        int round;

        public int Round
        {
            get
            {
                return round;
            }
            set
            {
                round = value;
            }
        }


        public Triangle(int _side_a, int _side_b, int _side_c) // 클래스 안에 클래스 
        {
            side_a = _side_a;
            side_b = _side_b;
            side_c = _side_c;

            Round = side_a + side_b + side_c;
        }

        public override string ToString()
        {
            return $"Draw({side_a}, {side_b}, {side_c})";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자를 ,로 나눠서 입력하세요");

            
            string[] input = Console.ReadLine().Split(",");

            int side_a = int.Parse(input[0]);
            int side_b = int.Parse(input[1]);
            int side_c = int.Parse(input[2]);

            Triangle trg = new(side_a, side_b, side_c);

            Console.WriteLine(trg.Round);
            Console.WriteLine(trg);
            
        }
    }
}
