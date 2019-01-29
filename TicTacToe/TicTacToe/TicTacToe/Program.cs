using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
	class Program
	{
		private static int[,] board = new int[3, 3] { 
			{ 1, 2, 3 }, 
			{ 4, 5, 6 }, 
			{ 7, 8, 9 }
		};
		private bool gameOver = false;

		static void Main(string[] args)
		{
			Board game = new Board();
		}

		static void Draw() {
			Console.WriteLine($"_{board[0,0]}_|_{board[0,1]}_|_{board[0,2]}_\n" +
							  $"_{board[1,0]}_|_{board[1,1]}_|_{board[1,2]}_\n" +
							  $" {board[2,0]} | {board[2,1]} | {board[2,2]} ");
		}
	}
}
