
namespace board
{
    internal class Board
    {
        public int Lines { get; set; }
        public  int Columns { get; set; }
        public Piece[,] pieces { get; set; }

        public Board(int line, int columns)
        {
            Lines = line;
            Columns = columns;
            pieces = new Piece[Lines, Columns];
        }
    }
}
