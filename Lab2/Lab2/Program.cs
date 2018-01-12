using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
       // static void Op(int a, int b)
        //{
          //  Console.WriteLine("Op1");
        //
        //static void Op(int a, int b, int c )
       // {
         //   Console.WriteLine("Op2");
        //}
        static void Op(int a, int b, int c =1)
        {
            Console.WriteLine(c);
        }
        static void Main (String[] args)
        {
            Op(1, 2 ,5);                                                                          
            Console.ReadLine( );
        }

        
    }
}
