/*Abigail Sikora
 * This program stimulates a card game (War) using methods.
 */


using System;

namespace ConsoleApp1
{
    class Assignment6
    {
        static void Main(string[] args)
        {
            string player1 = "Bob"; 
            string player2 = "Sam";
            War(player1, player2); //calling the war method


            Console.WriteLine("Press enter to exit");
            Console.ReadLine();

        }

        static int Draw() //the draw function returns an integer and takes in no parameters
        {
            Random r = new Random();
            int draw = r.Next(1, 11); //getting a random number between 1 and 10
            return draw;
        }
        static void War(string name1, string name2)
        {
            int cards1 = 26; //the number of starting cards for player 1
            int cards2 = 26;
            int draw1, draw2;
            int rounds = 0;
            while (cards1 != 0 && cards2 != 0) //a while loop to go until a player runs out of cards
            {
                draw1 = Draw(); //player 1 is drawing a card
                draw2 = Draw();
                if(draw1>draw2) //seeing which player had the higher draw
                {
                    cards1++;
                    cards2--;
                    Console.WriteLine("{0} won with {1} over {2}", name1, draw1, draw2);
                }
                else if(draw1<draw2)
                {
                    cards1--;
                    cards2++;
                    Console.WriteLine("{0} won with {1} over {2}", name2, draw2, draw1);
                }
                else
                {
                    Console.WriteLine("Tie!{0} and {1} are equal.", draw1, draw2);
                }
                Console.WriteLine("{0} has {1} cards and {2} and {3} cards", name1, cards1, name2, cards2);
                rounds++; //increasing to keep track of total amount of rounds
               
            }
            if(cards1==0)
            {
                Console.WriteLine("After {0} rounds, {1} won with a score of {2}!", rounds, name2, cards2);
            }
            else
            {
                Console.WriteLine("After {0} rounds, {1} won with a score of {2}!", rounds, name1, cards1);
            }
           
            
        }
        

    }
}
