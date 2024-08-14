﻿namespace board
{
    internal class Piece
    {
        public Position Position { get; protected set; }
        public Color Color { get; set; }
        public int qtdMovements { get; protected set; }
        private Board board { get; set; }

        public Piece (Color color, Board board)
        {
            Position = null;
            Color = color;
            this.qtdMovements = 0;
            this.board = board;
        }
    }
}
