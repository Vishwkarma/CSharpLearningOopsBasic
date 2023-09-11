using System;//system namespace ke classes use here 
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
//blur because we are not using 

//Here is we use hello namespace for 
//namespace are store classs and other namespace 
namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)//excution start here because we are using main
        {
            //Console.WriteLine("Hello World");//write on console nad next line shows
            //Console.WriteLine("line forward ");
            //Console.Write("same line follow");// write a 

            //  Console.ReadLine();
            //Console.WriteLine(inp);



            //Single line comments 
            /* 
             * Multiline comments 
             * 
             * 
             */


            //Variable are container 

            //int harry = 34;//Integer 
            //Console.WriteLine("hello print this number " + harry);
            //Console.ReadLine();



            /* Data Types in C#
             * Integer :int  --> 4 byte 
             * Long - 8 byte
             * Floating point number - float --4byte
             * Double -- 8 byte 
             * Character - char a ='A'  -- 2 byte 
             * Boolean - bool isGreat = true;  1 bit 
             * string inp  ="Harry"; 2 bit per character 
             * 
             */


            //string inp = Console.ReadLine();


            // Data types are example 

            //int a = 34;
            //float b = 34.5f;// decimal wala bydefault double it will not show error 

            //double c = 34.5d;

            //bool isGreat = true;
            //char d = 'r';

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);
            //Console.WriteLine(isGreat);





            //Type Casting : it is two types implicit and explicit casting 
            /*
             * 1.Implicit Cating :- char to int long to float to double
             * 
             * 2.Explicit casting :-
             * int a = (int)3.5;
             */


            //int c = 3;
            //double d = c;
            // //  int c = d
            //int z = 'a'; // shows its ASCII value 
            //float var = 'y';
            //float varr = Convert.ToInt32(3.44);
            ////Convert.ToInt164
            ////Convert.ToDouble
            ////Convert.ToString

            //String sx = "Random string ";



            //Console.WriteLine(c);
            //Console.WriteLine(d);
            //Console.WriteLine(z);
            //Console.WriteLine(var);
            //Console.WriteLine(varr);
            //Console.WriteLine(sx);
            //Console.ReadLine();


            //Console.WriteLine("Enter your name ");
            // String name = Console.ReadLine();
            // Console.WriteLine("hey Hello " + name);



            // Console.WriteLine("How many candies do you want ? ");
            // String can = Console.ReadLine();
            // // Console.WriteLine("You will get 4 more candies  " + (Convert.ToInt32(can) + 4) );
            // Console.WriteLine("You will get 4 more candies  " + can + 4);



            //Operators  in C#
            /*1Arthimatic Opeartor 
             * Assignment Operator 
             * logical Oparatot 
             * Comparsion operator 
             */
            //  int a =10; int b = 110;

            //Console.WriteLine("the value of a + b is :" + (a + b));
            //Console.WriteLine("the value of a - b is :" + (a - b));
            //Console.WriteLine("the value of a * b is :" + (a * b));
            //Console.WriteLine("the value of a / b is :" + (a / b));
            //


            //Assignment Opeartors

            //int a = 4;
            //int b = a;
            //b += 4;
            //b -= 4;
            //b *= 4;
            //b /= 4;


            //Console.WriteLine(b);
            //Console.ReadLine();

            //Logical Operator
            //and operator
            //Console.WriteLine(true && false );
            //Console.WriteLine(true && true );
            //Console.WriteLine(false && false );


            //// or operator 
            //Console.WriteLine(true || false );
            //Console.WriteLine(true || true );
            //Console.WriteLine(false|| false);

            ////not operator 
            //Console.WriteLine(!false);
            //Console.WriteLine(!true);

            //Comparsion Opearator 
            //Console.WriteLine(324 > 5);
            //Console.WriteLine(324 >= 5);
            //Console.WriteLine(324 != 5);
            //Console.WriteLine(324 < 5);
            //Console.WriteLine(324 <= 5);
            //Console.WriteLine(324 == 5);


            //int a =  Math.Max(34, 234);
            //  int a = Math.Min(34, 234);
            // int a = Math.Sqrt(34, 234);// it shows error because it becoz of double 
            // double a = Math.Sqrt(34);
            //double a = Math.Abs(a);
            //Console.WriteLine(a);
            //Console.WriteLine();


            // string hello = " 'Hello World this is Harry'";
            //Console.WriteLine(hello.Length);
            //Console.WriteLine(hello.ToUpper());
            //Console.WriteLine(hello.ToLower());
            //Console.WriteLine(hello + "You are a nice guy");
            //Console.WriteLine(string.Concat(hello + "You are a nice guy"));


            // String interpolation

            //string name = Console.ReadLine();
            //string candies = Console.ReadLine();

            //Console.WriteLine($"Your name is {name}. you will get {candies} candies");


            //character of string by using index 
            //string hello = "Hello\t World this \n is Harry";
            //Console.WriteLine(hello[0]);
            //Console.WriteLine(hello.IndexOf("is"));
            //Console.WriteLine(hello.IndexOf("this"));
            //Console.WriteLine(hello.Substring(5));




            //int age = 56;

            //if(age >18)
            //{
            //    Console.WriteLine("You can drive ");
            //}
            //else
            //{
            //    Console.WriteLine("You cannot drive");
            //}

            // Console.WriteLine("Enter Your age");
            // string agrStr = Console.ReadLine();
            //int age = Convert.ToInt32(agrStr);
            // bool isBanned = true;


            //// int age = 16;
            // //if else ladder
            // if (age < 2 && isBanned)
            // {
            //     Console.WriteLine("You are justr born  drive ");
            // }
            // else if (age < 10 || isBanned) {
            //     Console.WriteLine("Please finish your schooling ");

            //  }
            // else if(age < 18  && isBanned ) 
            // {
            //     Console.WriteLine("You are are below 18 ");
            // } else
            // {
            //     Console.WriteLine("You can drive ");
            // }

            //switch Case Statement
            //int age = 78;

            //switch(age)
            //{
            //    case 18:
            //        Console.WriteLine("please wait for an year");
            //        break;
            //    case 20:
            //        Console.WriteLine("You are 20");
            //        break;
            //    default:
            //         Console.WriteLine("Enjoy!");
            //        break;
            //}

            //Loops in c#
            //while loops

            int i = 0;
            while (i < 5)
            {
                Console.Write(i + 1);
                i++;

            }
            Console.ReadLine();

            //for (int i = 0; i < args.Length; i++)
            //{

            //    Console.WriteLine(args[i]);
            //}




        }
    }
}
