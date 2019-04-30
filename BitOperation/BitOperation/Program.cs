using System;

namespace BitOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            //二进制
            var a = 15;
            var b = 20;

            // 15的二进制  0 0 0 0 1 1 1 1
            // 20的二进制  0 0 0 1 0 1 0 0

            //&的算法
            //1 & 1 = 1
            //0 & 1 = 0
            //0 & 0 = 0
            Console.WriteLine(a & b);

            //|的算法
            //1 | 1 = 1
            //0 | 1 = 1
            //0 | 0 = 0
            Console.WriteLine(a | b);

            //^的算法
            //1 ^ 1 = 0
            //0 ^ 1 = 1
            //0 ^ 0 = 0
            Console.WriteLine(a ^ b);

            //左运算符
            //a << 1 = a乘以2的1次方
            //a << 2 = a乘以2的2次方
            //a << 3 = a乘以2的3次方
            Console.WriteLine(64 << 3);

            //右运算符
            //a >> 1 = a整除2的1次方
            //a >> 2 = a整除2的2次方
            //a >> 3 = a整除2的3次方
            Console.WriteLine(3 >> 64);
            Console.WriteLine("Hello World!");
            Console.ReadKey();

        }
    }
}
