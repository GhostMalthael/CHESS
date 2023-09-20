using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class Chess
    {
        public string[,] board = new string[8, 8];
        public Chess()
        {
            
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
                    NewBoard();
                }
            }
        }
        public void NewBoard()
        {
             string[,] board = new string[8, 8];
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = $"[{i}][{j}]";
                    board[figures[1].xPos, figures[1].yPos] = figures[1].symbol;
                    board[figures[0].xPos, figures[0].yPos] = figures[0].symbol;
                    board[figures[2].xPos, figures[2].yPos] = figures[2].symbol;
                    Console.Write($"{board[i, j]}\t");
                }
                Console.WriteLine("\n\n");
            }
        }
    }
}
