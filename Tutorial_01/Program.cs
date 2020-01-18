using System;
using System.Collections.Generic;

namespace Tutorial_01
{
    class Program
    {
        //  열거형 (Enum)
        enum Weapon
        {
            None = 0,
            LongSword,
            Staff,
            Bow,
            Etc
        }

        static void Main(string[] args)
        {
            #region 조건문 및 반복문
            //  초록색 글씨는 '주석'
            //  Ctrl + Shift + B 전체 빌드 단축키
            //  Ctrl + F5        빌드 후 실행

            //  자료형 ?
            //  int     -21억 부터 21억 까지 들어감
            //  float   부동 소수점. 소수점 7자리(6자리)
            //  double  부동 소수점. 소수점 16자리(12자리)
            //  bool    ture 또는 false 값만 들어가는 자료형
            //  string  문자열을 넣을 수 있는 자료형
            //  char    -126 ~ 126
            //  unsinged char 0 ~ 256

            //int value = 0;
            //value = value + 1;
            //value += 1;

            //value = value - 1;
            //value -= 1;

            //value = value * 1;
            //value *= 1;

            //value = value / 1;
            //value /= 1;

            //  조건문 ?
            //  value == 1 이면 Ok 를 출력하고
            //  아니면 Flase 를 출력해보세요!
            //  출력하는 방법?
            //if (value == 1) Console.WriteLine("Ok");
            //else Console.WriteLine("False");

            ////  반복문 ?
            ////  for, while
            //for (int i = 0; i <= 10; ++i)
            //{
            //    Console.WriteLine(i.ToString());
            //    //  printf("%d\n", i);
            //}

            //  전체 주석하기
            //  Ctrl + K + C
            //  주석 풀기
            //  Ctlr + K + U

            //  i 는 0 부터 5 까지 순회하되
            //  i 가 2면 OK 를 출력하고
            //  아니면 False 를 출력해보세요

            //for (int x = 0; x < 5; x++)
            //{
            //    if (x == 2) Console.WriteLine("Ok");
            //    else Console.WriteLine("False");
            //}

            //  Gugudan!
            //  1단부터 9단까지 출력해보세요
            //  1 x 1 = 1
            //  1 x 2 = 2
            //  ...
            //  9 x 9 = 81

            //for (int i = 1; i < 10; ++i)
            //{
            //    for (int j = 1; j < 10; ++j)
            //    {
            //        Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
            //    }
            //}
            #endregion

            #region 열거형 및 스위치문
            //  switch ?
            //  조건문 + 열거형 (Enum)

            //  내가 지금 장착하고있는 무기
            //Weapon weapon = Weapon.None;
            ////weapon = default(Weapon);

            //string str = string.Empty;
            //str = Console.ReadLine();

            //Console.WriteLine("내가 장착한 무기 : " + weapon.ToString());

            //Weapon findWeapon = Weapon.None;
            //Enum.TryParse(str, out findWeapon);

            ////  case, break, default
            //switch (findWeapon)
            //{
            //    case Weapon.LongSword:
            //        weapon = Weapon.LongSword;
            //        break;

            //    case Weapon.Staff:
            //        weapon = Weapon.Staff;
            //        break;

            //    case Weapon.Bow:
            //        weapon = Weapon.Bow;
            //        break;

            //    default:
            //        weapon = Weapon.Etc;
            //        break;
            //}

            //Console.WriteLine("새로 장착한 무기 : " + weapon.ToString());

            //  while ?
            //  반복문

            //int value = 0;
            //while (value != 100)
            //{
            //    value++;
            //    Console.WriteLine(value.ToString());
            //}
            #endregion

            //  솔루션 탐색기 단축키
            //  Ctrl + Alt + L

            //  함수
            //  Function()

            //  함수를 사용할 때는
            PrintName();
            int result = Add(3, 5);

            //  Minus 함수 만들어보세요!


        }
        
        //     자료형, 이름, 파라메터
        //  1.  자료형 ? 리턴할 변수형
        //  2.  이름은 함수의 이름
        //  3.  파라메터 (선택) 이 함수를 사용할 때 필요할 수도 있는 객체
        static void PrintName()
        {
            Console.WriteLine("Name");
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Minus(int a, int b)
            => a - b;

        //  { return a - b; }

    }

}
