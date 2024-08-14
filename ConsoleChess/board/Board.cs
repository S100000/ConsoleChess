
namespace board
{
    internal class Board
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        public Piece[,] pieces { get; set; }

        public Board(int line, int columns)
        {
            Lines = line;
            Columns = columns;
            pieces = new Piece[Lines, Columns];
        }

        public Piece piece(int line, int column)
        {
            return pieces[line, column];
        }

        public Piece piece(Position pos)
        {
            return pieces[pos.Line, pos.Column];
        }

        public bool ExistPiece(Position pos)
        {
            PositionValidation(pos);
            return piece(pos) != null;
        }

        public void PutPiece(Piece p, Position pos)
        {
            if (ExistPiece(pos))
            {
                throw new BoardExceptions("There is already a piece in that position!");
            }
            pieces[pos.Line, pos.Column] = p;
            p.Position = pos;
        }

        public bool ValidPosition(Position pos)
        {
            if (pos.Line < 0 || pos.Line >= Lines || pos.Column < 0 || pos.Column >= Columns)
            {
                return false;
            }
            return true;
        }

        public void PositionValidation(Position pos)
        {
            if (!ValidPosition(pos))
            {
                throw new BoardExceptions("Invalid Position!");
            }
        }
    }
}
