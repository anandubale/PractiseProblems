using System;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            //striting point s = 0;
            //s1 = 1
            //n = s + s1
            //s = s1;
            //s1 = n1
            /*
           //Fibbonachi Series
           int s = 0;
            int s1 = 1;
            Console.WriteLine(s);

            for (int i = 0; i<= 10; i++)
            {
                int n = s + s1;
                s = s1;
                s1 = n;
                Console.WriteLine(n);
            }

           
            //---------------------------------------------------------------------------------------
            //Reverse Number

            //%10
            //saving Old 
            ///10

            Console.WriteLine("Enter Number");
            int userinput = int.Parse(Console.ReadLine());
            int RN = 0;
            while(userinput>0)
            {   

                int LN = userinput % 10;
                 RN = (RN * 10) + LN;
                userinput = userinput / 10;
            }
            Console.WriteLine(RN);

            //---------------------------------------------------------------------------------------

            //Number Palidrome
            //Same as Above just have to compare the result

            Console.WriteLine("Enter Number");
            int userinput = int.Parse(Console.ReadLine());
            int RN = 0;
            int userinput1 = userinput;
            while (userinput > 0)
            {

                int LN = userinput % 10;
                RN = (RN * 10) + LN; 
                userinput = userinput / 10;
            }
            Console.WriteLine(RN);
            Console.WriteLine(userinput1);
            if(userinput1 == RN)
            {
                Console.WriteLine("This is Palindrome");
            }
            else
            {
                Console.WriteLine("This is Not Palindrome");

            }
            
            
           //---------------------------------------------------------------------------------------

           //higest Number from Array

           Console.WriteLine("Enter length of digits you want to arrange");
            int Length = int.Parse(Console.ReadLine());

            int[] Array = new int[Length];
            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine($"Enter Number { i + 1} Positions: ");
                Array[i] = int.Parse(Console.ReadLine());

            }

            for (int j = 0; j < Length; j++)
            {
                Console.WriteLine("\t" + Array[j]);
            }

            int highest = 0 ;
            for (int i = 0; i < Length-1; i++)
            {

                if (Array[i] > Array[i + 1])
                {
                    highest = Array[i];
                }
                else
                {
                    highest = Array[i + 1];
                }

            }
            Console.WriteLine($"higest Number {highest}");
          
            //---------------------------------------------------------------------------------------
            //String palindrome.

           
            Console.WriteLine("Number of Albhabet string you want to check for Palidrome");
            int Length = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Word you want to check ");
            string input = Console.ReadLine();

            for(int i = 0; i < ( Length / 2); i++)
            {
                if (input[i] == input[(Length - 1)-i])
                {
                    Console.WriteLine($"Check For:{input[i]} & {input[(Length - 1) - i]}");
                }
                else
                {
                    Console.WriteLine("This is not Palindrome");
                    break;
                }
                Console.WriteLine("This is Palindrome");
            }

              
            Console.WriteLine("Number of Alphabet string you want to Reverse");
            int Length = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Word you want to Reverse");
            string input = Console.ReadLine();


            for (int S = (Length - 1); S >= 0; S--)
            {
                Console.Write($"{input[S]}");
       
            } 
            */


        }
    }
}
