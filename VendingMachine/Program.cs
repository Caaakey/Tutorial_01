using System;
using System.Collections.Generic;
using System.Threading;

namespace VendingMachine
{
    enum Drink
    {
        Cola = 0,
        Sida, Fanta, Water, Coffee, Tea
    }

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
                Console.WriteLine(
                    "Cola[100], Sida[200], Fanta[150], Water[80], Coffee[2000], Tea[50]");

                //  2. 입력 받기!
                input = Console.ReadLine();

                Drink select = 0;
                if (!Enum.TryParse(input, out select))
                {
                    Console.WriteLine("알 수 없는 문장입니다!");
                    Thread.Sleep(1000);
                    continue;
                }

                switch (select)
                {
                    case Drink.Cola:
                        if (money >= 100)
                        {
                            Console.WriteLine("{0} 를 구매해주셔서 감사합니다!", Drink.Cola.ToString());
                            money = money - 100;
                        }
                        else Console.WriteLine("공짜는 없다!");
                        break;

                    case Drink.Sida:
                        if (money >= 200)
                        {
                            Console.WriteLine("{0} 를 구매해주셔서 감사합니다!", Drink.Sida.ToString());
                            money = money - 200;
                        }
                        else Console.WriteLine("공짜는 없다!");
                        break;

                    case Drink.Fanta:
                        if (money >= 150)
                        {
                            Console.WriteLine("{0} 를 구매해주셔서 감사합니다!", Drink.Fanta.ToString());
                            money = money - 150;
                        }
                        else Console.WriteLine("공짜는 없다!");
                        break;

                    case Drink.Water:
                        if (money >= 80)
                        {
                            Console.WriteLine("{0} 를 구매해주셔서 감사합니다!", Drink.Water.ToString());
                            money = money - 80;
                        }
                        else Console.WriteLine("공짜는 없다!");
                        break;

                    case Drink.Coffee:
                        if (money >= 2000)
                        {
                            Console.WriteLine("{0} 를 구매해주셔서 감사합니다!", Drink.Coffee.ToString());
                            money = money - 2000;
                        }
                        else Console.WriteLine("공짜는 없다!");
                        break;

                    case Drink.Tea:
                        if (money >= 50)
                        {
                            Console.WriteLine("{0} 를 구매해주셔서 감사합니다!", Drink.Tea.ToString());
                            money = money - 50;
                        }
                        else Console.WriteLine("공짜는 없다!");
                        break;
                }
                Thread.Sleep(2500);

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
