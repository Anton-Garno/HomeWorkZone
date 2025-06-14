using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets divide numbers, just input two nubbers bellow and i'll calculate it! ");

            Console.WriteLine("\nPlease input your first integer number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nFirst number is:  {firstNumber};");
            //first block

            Console.WriteLine("Please input your second number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nSecond number is:  {secondNumber};");
            //second block

            double result;

            try
            {
                result = firstNumber / secondNumber;
                Console.WriteLine($"Your result is: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Opsss, you just tried division by zero... This is not good!");
            }
            finally { Console.Write("\nYour choise has led you to a mystery Cave...." +
                "\nIf you want to get out  alive, you will have to defeat the Dragon..." +
                "\nAnd than you might learn the secreat of division by Zero.." +
                "\nOr you will just Die.  \n"); }
            //finaly go to new stage of game

            Console.WriteLine("Pleas enter your name Hero.\n");
            Player player = new Player();
            player.AskName();
            Console.WriteLine($"Our new HERO is:{player}.\nWelcome to Cave Journey!!!");
            //Player name stage



        }//static void
    }//class Main
    public class Player
    {
        public string Name;
        public short Heals;
        public void AskName()
        {
            Console.WriteLine("Enter Your Name new Hero:");
            Name = Console.ReadLine();
        } 
        public void PlayerHeals()
        {
            Heals = 2;
            if(Heals==0) {
                Console.WriteLine("Im sorry but you a loser..");
        }
    }//class Player
    
    public class Dragon
    {
        public short HealsPoints;

    }
}//namespace
