using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class Chess
    {
        private Figures[,] board = new Figures[8,8];
        public Chess()
        {
            board[7, 1] = new Horse("Horse", "H", 7, 1);
            board[7, 3] = new Queen("Queen", "Q", 7, 3);
        }
        
        public void Game()
        {
            NewBoard();
            while(true)
            {
                Console.WriteLine("Какой фигурой сделать ход? 1 - Ферзь; 2 - Конь");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 2)
                {
                    Console.WriteLine("куда переместить коня?");
                    NewBoard();
                }
            }
        }
        public void NewBoard()
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] != null)
                    {
                        Console.Write($"{board[i, j].Symbol}\t");
                    }
                    else
                    {
                        Console.Write($"[{i}][{j}]\t");
                    }
                   
                }
                Console.WriteLine("\n\n");
            }
        }
    }
}
