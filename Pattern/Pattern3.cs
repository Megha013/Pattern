//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Pattern
//{
//    internal class Pattern3
//    {
//        public static void FindPattern3()
//        {
//            //1
//            //121
//            //12321
//            //1234321
//            //123454321
//            //1234321
//            //12321
//            //121
//            //1
//            int n = 5;
//            for (int i = 1; i <= n; i++)
//            {
//                for (int j = 1; j <= i; j++)
//                {
//                    Console.Write(j);
//                }

//                for (int j = i - 1; j > 0; j--)
//                {
//                    Console.Write(j);
//                }
//                Console.WriteLine();
//            }

//            for (int i = n - 1; i > 0; i--)
//            {
//                for (int j = 1; j <= i; j++)
//                {
//                    Console.Write(j);
//                }

//                for (int j = i - 1; j > 0; j--)
//                {
//                    Console.Write(j);
//                }
//                Console.WriteLine();
//            }

//        }
//    }
//}
