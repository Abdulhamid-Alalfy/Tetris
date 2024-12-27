

using System.Diagnostics.Eventing.Reader;

namespace Tetris
{
    public abstract class Block
    {
        protected abstract Postion[][] Tiles { get; }
        protected abstract Postion StartOffset { get; }
        public abstract int Id { get; }

        private int rotationState;
        private Postion offset;

        public Block()
        {
            offset = new Postion(StartOffset.Row, StartOffset.Column);
        }

        public IEnumerable<Postion> TilePositions()
        {
            foreach (Postion p in Tiles[rotationState])
            {
                yield return new Postion(p.Row + offset.Row, p.Column + offset.Column);
            }
        }

        public void RotateCW()
        {
            rotationState = (rotationState + 1) % Tiles.Length;
        }

        public void RotateCCW()
        {
            if (rotationState == 0)
            {
                rotationState = Tiles.Length - 1;
            }
            else
            {
                rotationState--;
            }
        }

        public void Move(int rows, int columns)
        {
            offset.Row += rows;
            offset.Column += columns;
        }

        public void Reset()
        {
            rotationState = 0;
            offset.Row = StartOffset.Row;
            offset.Column = StartOffset.Column;
        }
    }
}
