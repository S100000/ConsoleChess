using Chess;
using board;

namespace ConsoleChess
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Board board = new Board(8, 8);
                board.PutPiece(new Rook(Color.White, board), new Position(0, 0));
                board.PutPiece(new Rook(Color.White, board), new Position(0, 7));
                board.PutPiece(new Rook(Color.White, board), new Position(7, 0));
                board.PutPiece(new Rook(Color.White, board), new Position(7, 9));

                Screen.PrintBoard(board);
            }
            catch (BoardExceptions e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
