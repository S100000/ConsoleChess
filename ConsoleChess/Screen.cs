using board;

namespace ConsoleChess
{
    internal class Screen
    {
        public static void PrintBoard(Board  board)
        {
            for(int i = 0; i < board.Lines; i ++)
            {
                for (int j = 0; j < board.Columns; j ++)
                {
                    if (board.pieces[i,j] == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(board.pieces[i,j]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
