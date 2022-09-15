//Martin Grosso
//6/17/2022


using System;
using System.Collections.Generic;
using System.Linq;

namespace ScoreCards
{
    class Program
    {
        //main method
        static void Main(string[] args)
        {

            //array for par 
            int[] parArray = { 4, 3, 4, 4, 5, 4, 5, 3, 4, 4, 3, 5, 4, 4, 5, 4, 3, 4};
            
            //multi-rectangular array 18 holes, 4 golfers
            int[,] arr = new int[18, 4];
            int[] frontScores = { 0, 0, 0, 0 };
            int[] backScores = { 0, 0, 0, 0 };

            //generate random scores for holes/golfers
            Random randomScores = new Random();

            //Print Hole, Par, Golfer 1-4
            Console.WriteLine("Hole   Par  Golfer 1 Golfer 2 Golfer 3 Golfer 4");

            //for loop first nine scores
            for (int i = 0; i < 9; i++)
            {
                //First nine holes column
                Console.Write((i + 1) + "\t");
                //First nine par column
                Console.Write(parArray[i] + "\t");

                //for loop four golfers 
                for (int j = 0; j < 4; j++)
                {
                    //array random scores for frontScores, with parameters
                    arr [i, j] = randomScores.Next(parArray [i] - 2, parArray [i] + 3);
                    Console.Write(arr[i, j] + "\t");
                    frontScores[j] += arr[i, j];
                }
                
                Console.WriteLine();

            }
            //print front scores/first nine scores 
            Console.WriteLine("Front" + "           " + frontScores[0] + "      " + frontScores[1] + "      " + frontScores[2] + "      " + frontScores[3]);

            //for loop last nine scores 
            for (int i = 9; i < 18; i++)
            {
                //First nine holes column
                Console.Write((i + 1) + "\t");
                //First nine par column
                Console.Write(parArray[i] + "\t");

                //for loop four golfers 
                for (int j = 0; j < 4; j++)
                {
                    //array random scores for backscores,with parameters
                    arr[i, j] = randomScores.Next(parArray[i] - 2, parArray[i] + 3);
                    Console.Write(arr[i, j] + "\t");
                    backScores[j] += arr[i, j];
                }


                Console.WriteLine();
            }

            //print front scores/first nine scores 
            Console.Write("Back" + "           " + backScores[0] + "      " + backScores[1] + "      " + backScores[2] + "      " + backScores[3]);
            Console.WriteLine();
            //print total front scores and back scores for each golfer
            Console.Write("Total" + "          " + (frontScores[0] + backScores[0]) + "      " +  (frontScores[1] + backScores[1]) + "      " + (frontScores[2] + backScores[2]) + "      " + (frontScores[3] + backScores[3]));
            Console.ReadKey();
        }
        
    }

}