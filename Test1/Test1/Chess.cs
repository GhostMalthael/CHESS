using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class Chess
    {
        Horse horse;
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
                    Console.Write($"{board[i, j]}\t");
                }
                Console.WriteLine("\n\n");
            }
        }
    }
}
