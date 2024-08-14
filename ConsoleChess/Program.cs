using Chess;
using board;

namespace ConsoleChess
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(8, 8);
            board.PutPiece(new Rook(Color.White, board), new Position(0, 0));
            board.PutPiece(new Rook(Color.White, board), new Position(0, 7));
            board.PutPiece(new Rook(Color.White, board), new Position(7, 0));
            board.PutPiece(new Rook(Color.White, board), new Position(7, 7));

            Screen.PrintBoard(board);
        }
    }
}
