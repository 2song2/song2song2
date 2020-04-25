using System;

namespace _204024v2
{
    class Program
    {
        static void Main(string[] args)
        {

            int 형석나이 = 35;
            int 송이나이;

            Console.WriteLine("형석이의 나이를 입력하세요.");

            형석나이 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("형석이의 나이는 " + (형석나이 + 송이나이) + " 입니다.");
            
            













            /*// 1. 자료형을 명시 -> 변수를 선언
            int 송이나이 = 31;
            
            //string 송이문자열나이 = "31";

            
            // 2. 안내문구(없어도 됨)
            Console.WriteLine("송이의 나이를 입력하세요!");

            // 3. 송이나이를 입력받는다.
            송이나이 = Convert.ToInt32( Console.ReadLine() );


            Console.WriteLine("송이나이 : " + 송이나이);


            //////*/
            Console.WriteLine("아무키나 입력하면 송이숙제 프로그램이 종료되요!");
            //확인창이 바로 꺼지지 않게 작성해놓은 코드.
            Console.ReadKey();
            
        }
    }
}
