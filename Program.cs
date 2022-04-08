using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);
          
            int mod1;
            int mod2;
            int ctr = 1;
            Console.WriteLine("Random Numbers");
            Console.WriteLine("Dice #1: " + dice1);
            Console.WriteLine("Dice #2: " + dice2);

            //all "l" variable used to create spaces between dice 1 and dice 2
            for (int i = 0; i < ctr; i++)
            {
                //getting the half value of dice 1
                if (dice1 == 6)
                {

                    for (int j = 1; j <= 3; j++)
                    {
                        Console.Write("*");

                    }
                    for (int l = 0; l < 1; l++)
                    {
                        Console.Write(" ");
                    }
                }
                if (dice1 == 5)
                {

                    for (int j = 1; j <= 3; j++)
                    {
                        Console.Write("*");

                    }
                    for (int l = 0; l < 1; l++)
                    {
                        Console.Write(" ");
                    }
                }   

                if (dice1 == 4)
                {

                    for (int j = 1; j <= 3; j++)
                    {
                        Console.Write("*");

                    }
                    for (int l = 0; l < 1; l++)
                    {
                        Console.Write(" ");
                    }
                }

                //getting the half value of dice 1
                if (dice2 == 6)
                {

                    for (int j = 1; j <= 3; j++)
                    {
                        Console.Write("*");

                    }
                }
                if (dice2 == 5)
                {

                    for (int j = 1; j <= 3; j++)
                    {
                        Console.Write("*");

                    }
                }

                if (dice2 == 4)
                {

                    for (int j = 1; j <= 3; j++)
                    {
                        Console.Write("*");

                    }

                }
            }
                
                //getting the value of dice 1 that is less than 4
                while (dice1 == 3 || dice1 == 2 || dice1 == 1)
                {

                    for (int o = 1; o <= dice1; o++)
                    {
                        Console.Write("*");

                    
                }
                for (int l= 0; l < 1; l++)
                {
                    Console.Write(" ");
                }
                break;
                }
            //getting the value of dice 2 that is less than 4
            while (dice2 == 3 || dice2 == 2 || dice2 == 1)
                {

                    for (int o = 1; o <= dice2; o++)
                    {
                        Console.Write("*");
                    
                }
                for (int l = 0; l < 1; l++)
                {
                    Console.Write(" ");
                }
                break;
                }
            Console.WriteLine();

            //second line 
            while (dice1 == 6 || dice2 == 6)
            {
                mod1 = dice1 /2;
                mod2 = dice2 /2;

                for (int o = 1; o <= mod1; o++)
                {
                    Console.Write("*");
                    for (int l = 0; l < 1; l++)
                    {
                        Console.Write(" ");
                    }
                }
                for (int l = 0; l < 1; l++)
                {
                    Console.Write(" ");
                }
                for (int o = 1; o <= mod2; o++)
                {
                    Console.Write("*");

                }
               
                break;
            }
             
            while (dice1 == 5 || dice2 == 5)
                {
                    mod1 = dice1 - 3;
                    mod2 = dice2 - 3;

                    for (int o = 1; o <= mod1; o++)
                    {
                        Console.Write("*");
                    
                }
                for (int l = 0; l < 1; l++)
                {
                    Console.Write(" ");
                }
                for (int o = 1; o <= mod2; o++)
                    {
                        Console.Write("*");

                    }
                    break;
                }
                while (dice1 == 4 || dice2 == 4)
                {
                    mod1 = dice1 - 3;
                    mod2 = dice2 - 3;

                    for (int o = 1; o <= mod1; o++)
                    {
                        Console.Write("*");

                    }
                    for (int l = 0; l < 1; l++)
                    {
                        Console.Write(" ");
                    }
                    for (int o = 1; o <= mod2; o++)
                    {
                        Console.Write("*");

                    }

                    break;
                }

            Console.WriteLine();


        }
        }
    }


