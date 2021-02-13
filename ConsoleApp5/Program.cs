using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arayy
{   

        class Program

        {

            static void Main(string[] args)
            {


            //// this is how can we input the array length by user
            ////this is string Array 
            //Console.WriteLine("write ur array length");
            //int Num1 = int.Parse(Console.ReadLine());
            //string[] Name = new string[Num1];
            //for (int i = 0; i < Name.Length; i++)
            //{
            //    Console.WriteLine("Write your Array Name" + (i + 1));
            //    Name[i] = Console.ReadLine();
            //}
            //foreach (var n in Name)
            //{
            //    Console.Write(n + " ");
            //}


            // this is int Array 
            Console.WriteLine("enter ur Array lengthe");
            int num1 = int.Parse(Console.ReadLine());
            int[] Arr = new int[num1];
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine("Write your array nummber: " +  "" +(i + 1));
                Arr[i] = int.Parse(Console.ReadLine());
            }
            int total = 0;
            for (int i = 0; i <Arr.Length;i++)      
            {
              
                total = total + Arr[i];
               
            }
            Console.WriteLine("The total nummber of your array is : "+""+total) ;
        }
        }
    }

    

