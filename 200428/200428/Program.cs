using System;

namespace _200428
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int height;
            int weight;

            Console.WriteLine("송이의 나이와 키와 몸무게를 더한 값은?");

            age = Convert.ToInt32( Console.ReadLine() );
            height = Convert.ToInt32( Console.ReadLine() );
            weight = Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine( "송이의 나이와 키와 몸무게를 더한 값은" + ( age + height + weight ) + "입니다");




        }
    }
}
