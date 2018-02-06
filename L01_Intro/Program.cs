using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace L01_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("안녕하세요 다시 제대로 배우자");
            for(int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("변수{0} {1}", i, args[i]); //디버그 옵션에서 미리 넣어둔 값 출력
            }
            string[] myArgs = Environment.GetCommandLineArgs();
            Console.WriteLine(string.Join("[]", myArgs));
            SayHello();

            //Boolean myBoolean = true;
            

            Console.Write("가장 큰 정수는 {0}", int.MaxValue);
            Console.WriteLine("<-------><-------> 가장 작은 정수는 {0}", int.MinValue);
            Console.Write("가장 큰 실수는 {0}", long.MaxValue);
            Console.WriteLine("<-------><-------> 가장 작은 실수는 {0}", long.MinValue);
            Console.Write("가장 큰 부동실수는 {0}", float.MaxValue);
            Console.WriteLine("<-------><-------> 가장 작은 부동실수는 {0}", float.MinValue);
            Console.Write("가장 큰 실수는 {0}", double.MaxValue);
            Console.WriteLine("<-------><-------> 가장 작은 실수는 {0}", double.MinValue);

            TimeSpan timeSpan = new TimeSpan(12,30,0);
            timeSpan = timeSpan.Subtract(new TimeSpan(0, 15, 0));
            timeSpan = timeSpan.Add(new TimeSpan(1, 0, 0));
            Console.WriteLine("시간: {0}", timeSpan.ToString());

            BigInteger bigInteger = BigInteger.Parse("111111111111111111111111111111111111111111111111111111112222222222222222222222222222222222");
            Console.WriteLine("정말 큰수는 {0}",bigInteger*3);// 프로젝트에서 add reference 한후 system.numerics 체크

            

            Console.ReadLine(); //화면이 자동으로 꺼지는것을 방지하기 위해
        }

        private static void SayHello()
        {
            string name = "";
            Console.Write("당신의 이름은? ");
            name = Console.ReadLine();
            Console.WriteLine("반갑습니다. {0}", name); //{0} 이렇게 붙여써야 함 { 0 } 이렇게 하면 에러남
        }
    }
}
