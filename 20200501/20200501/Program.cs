using System;

namespace _20200501
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            bool IsTodaySpring =false ;

            int TodayMonth = 5;

            IsTodaySpring = TodayMonth == 6;

            if(IsTodaySpring) // true
            {
                Console.WriteLine("입력한 달이 5월이 맞아요!");
            }
            else //false 
            {
                Console.WriteLine("입력한 달이 5월이 아니에요!");
            }
      */

            /*
            bool IsTodaySpring = false;

            int TodayMonth = 5;
            int InputMonth = 0;

            Console.WriteLine("이번달을 입력하세요!");
            InputMonth = Convert.ToInt32(Console.ReadLine());

            IsTodaySpring = TodayMonth == InputMonth;

            if (IsTodaySpring) // true
            {
                Console.WriteLine("입력한 달이 5월이 맞아요!");
            }
            else //false 
            {
                Console.WriteLine("입력한 달이 5월이 아니에요!");
            }
            */

            /*송이  곤듀님이 스스로 한부분
            //3을 입력받고 참, 거짓 판단

            bool IsNum3 = false;
            int num3 = 3;
            int inputNum = 0;

            //IsNum3 = num3 == inputNum;

            Console.WriteLine("3을 입력하세요.");
            inputNum = Convert.ToInt32( Console.ReadLine() );
            
            IsNum3 = (num3 == inputNum);

            if ( IsNum3 ) {
                Console.WriteLine("정확히 입력하셨네요");
            }
            else {
                Console.WriteLine("다시 입력해주세요.");
            }

            */

            int num = 0;
            //세개다 똑같아요!
            num = num + 1;
            num++;
            num += 1;
            ////
            ///

            //조건문 1 -> for문

            /*for (int i = 0; //i = 0 으로 시작합니다.
                i <= 100; //i < 100 조건이 true인 상태라면 괄호{} 안의 코드를 실행하고
                i++ //이 코드(i++)를 실행합니다.

                )
            {
                Console.WriteLine(i);

                if (i == 50)
                {
                    break;
                }
            }*/

            //조건문 2 -> while 문 while(bool){} bool이 true면 계속 실행
            /*
            int InputPassword;

            while (true)
            {
                Console.WriteLine("프로그램을 끝내려면 패스워드를 입력하세요!");

                InputPassword = Convert.ToInt32(Console.ReadLine());

                if (InputPassword == 1234)
                {
                    Console.WriteLine("패스워드가 맞아서 종료할게요!");
                    break;
                }
                else
                {
                    Console.WriteLine("패스워드를 다시 입력해주세요!");
                }
            }*/




            /*Console.WriteLine("프로그램을 끝내려면 패스워드를 입력하세요!");

            int InputPassword = Convert.ToInt32(Console.ReadLine());

            if (InputPassword == 1234)
            {
                Console.WriteLine("패스워드가 맞아서 종료할게요!");

            }
            else
            {
                while (InputPassword != 1234)
                {
                    Console.WriteLine("패스워드를 다시 입력해주세요!");
                    InputPassword = Convert.ToInt32(Console.ReadLine());
            
                }

                Console.WriteLine("패스워드가 맞아서 종료할게요!");
            }*/


            /*for ( int i = 0; i <= 200; i++ ) {
                Console.WriteLine(i);
            }*/


            //패스워드 입력 받기 

            /*Console.WriteLine("패스워드를 입력해주세요.");


            while ( true ) {
                
                string pw = "송이송이";
                string inputPw;

                inputPw = Console.ReadLine();

                if (pw == inputPw)
                {                                 
                    Console.WriteLine("패스워드가 맞습니다.");
                    break;
                }
                else {
                    Console.WriteLine("패스워드를 재입력해주세요.");
                }
            }*/


            //송이송이 입력받기 재시도

            bool IsName = false;
            string name = "송이송이";
            string inputName = "";

            Console.WriteLine("텍스트를 입력해주세요");
            inputName = Console.ReadLine();

            //문자열 비교
            IsName = name.Equals(inputName);
            //IsName = name == inputName;

            if (IsName )
            {
                Console.WriteLine("맞아요");

            }
            else {
                Console.WriteLine("틀렸어요!");
            }

            //

            bool IsConditionAND = (1 == 1 && 1 == 2);
            bool IsConditionOR = (1 == 1 || 1 == 2);

            //&& AND 양쪽의 bool값이 둘다 true인경우 true 그게 아니면 false
            //|| OR 양쪽의 bool값중 하나만 true인경우 true 그게 아니면 false

            Console.WriteLine("IsConditionAND : " + IsConditionAND);
            Console.WriteLine("IsConditionOR : " + IsConditionOR);

             IsConditionAND = (1 == 1 && 2 == 2);
             IsConditionOR = (1 == 2 || 1 == 2);

            Console.WriteLine("IsConditionAND : " + IsConditionAND);
            Console.WriteLine("IsConditionOR : " + IsConditionOR);



        }
    }
}
