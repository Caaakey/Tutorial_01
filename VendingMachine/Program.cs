using System;
using System.Collections.Generic;
using System.Threading;

namespace VendingMachine
{
    class Program
    {
        //  열거형 자리

        static void Main(string[] args)
        {
            //  자판기 프로젝트!
            int money = 10000;

            string input = "Start";
            while (!string.IsNullOrEmpty(input))
            {
                Console.Clear();
                Console.WriteLine("소지금 : {0}", money);
                Console.WriteLine("어서오세요 자판기입니다");
                //  1. 상품 보여주기!

                //  2. 입력 받기!
                input = Console.ReadLine();

                //  맨 위에 using System.Threading; 추가하기
                Thread.Sleep(1000); //  1초동안 기다린다

                //  열거행을 사용하여 자판기를 만들어보세요!
                //  이름 : Cola, Sida, Fanta, Water, Coffee, Tea
                //  가격 : 100,  200,  150,   80,     2000,   50

                //string[] str = Enum.GetNames(typeof(Drink));

                //  3. 계산하기!
                //  대출 불가! 마이너스 통장 불가!
                //  무조건 정가
            }

            Console.WriteLine("자판기 종료!");
        }
    }
}
