//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Pattern
//{
//    internal class Pattern2
//    {
//        static void Main(string[] args)
//        {
//            //2)Print patter
//            //1
//            //12
//            //123
//            //1234
//            //12345
//            //1234
//            //123
//            //12
//            //1

//            int n = 5;
//            //1st half
//            for (int i = 1; i <= n; i++)
//            {
//                for (int j = 1; j <= i; j++)
//                {
//                    Console.Write(j);
//                }
//                Console.WriteLine();
//            }
//            //2nd half
//            for (int i = n - 1; i > 0; i--)
//            {
//                for (int j = 1; j <= i; j++)
//                {
//                    Console.Write(j);
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}
