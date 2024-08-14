namespace board
{
    internal class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; set; }
        public int qtdMovements { get; protected set; }
        private Board board { get; set; }

        public Piece (Color color, Board board)
        {
            Position = null;
            Color = color;
            qtdMovements = 0;
            this.board = board;
        }
    }
}
