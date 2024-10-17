//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Pattern
//{
//    internal class Pattern6
//    {
//        public static void FindPattern6()
//        {
//            //    *
//            //   * *
//            //  * * *
//            // * * * *
//            //* * * * *
//            // * * * *
//            //  * * *
//            //   * *
//            //    *
//            int n = 5;
//            for(int i=1; i<=n; i++)
//            {
//                for(int j=n-i; j>=1; j--)
//                {
//                    Console.Write(" ");
//                }
//                for (int j = 1; j <=(2*i-1); j++)
//                {
//                    Console.Write("*");
//                }
//                Console.WriteLine();
//            }
//            for (int i = n-1; i >= 1; i--)
//            {
//                for (int j = n - i; j >=1; j--)
//                {
//                    Console.Write(" ");
//                }
//                for (int j = 1; j <= (2 * i - 1); j++)
//                {
//                    Console.Write("*");
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}
