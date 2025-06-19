using System;
using System.Net.NetworkInformation;

namespace section2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1.

            int x = 5;
            int y = 10;
            int sum = x + y;
            Console.WriteLine(sum);

            #endregion

            #region Q2
            string input = "12abc";  

            int number = int.Parse(input);   

            Console.WriteLine( number);



            #endregion

            #region Q3

            float num1 = 5.5f; 
            float num2 = 2.2f;  

            float result = num1 + num2; 

            Console.WriteLine( result);
            #endregion

            #region q4
            ring text = "Hello, World!";  

            
            string part = text.Substring(7, 5);

            Console.WriteLine(part);
            #endregion

            #region q5
            int a = 10;       
            int b = a;        

            b = 20;          

            Console.WriteLine(a);
            Console.WriteLine( b);
            #endregion

            #region q6
            Person p1 = new Person();    
            p1.Name = "Ali";

            Person p2 = p1;             
            p2.Name = "Omar";          

            Console.WriteLine("p1.Name: " + p1.Name);
            Console.WriteLine("p2.Name: " + p2.Name);

            #endregion

            #region q choise

            //  8:b
            //   9: d
            //   10 : d

            #endregion

        }
    }
}
