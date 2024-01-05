using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teacher_q
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FineWinner();
        }
        static void FineWinner()
        {
            Console.Write("Введите очки Айбара ");
            int[] aibarBall = InputArray();
            Console.Write("Введите очки Назарбека ");
            int[] Na2aBall = InputArray();

            int sumAiabarBall = SumBall(aibarBall);
            int sumNa2aBall = SumBall(Na2aBall);

            CompareBall(sumAiabarBall, sumNa2aBall);
        }

        static int[] InputArray()
        {
            string inputStr = Console.ReadLine();
            string[] arrayStr = inputStr.Split(' ');
            int[] userBall = new int[4];
            for (int i = 0; i < arrayStr.Length; i++)
            {
                userBall[i] = Convert.ToInt32(arrayStr[i]);
            }
            return userBall;
        }

        static int SumBall(int[] ball)
        {
            int sumBall = 0;
            for(int i = 0; i < 3; i++)
            {
                sumBall += ball[i];
            }
            return sumBall;
        }

        static void CompareBall(int aibarBall, int Na2aBall)
        {
            if (aibarBall > Na2aBall)
                Console.WriteLine("aibark");
            else if (Na2aBall > aibarBall)
                Console.WriteLine("Na2a");
            else if (Na2aBall == aibarBall)
                Console.WriteLine("Tekor");
            
        }
    }
}
