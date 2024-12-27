

namespace Tetris
{
    public class IBlock:Block
    {
        private readonly Postion[][] tiles = new Postion[][]
        {
            new Postion[] { new (1,0), new (1,1), new (1,2), new (1,3) },
            new Postion[] { new (0,2),new (1,2), new (2,2), new(3,2) },
            new Postion[] { new (2,0),new (2,1), new (2,2), new(2,3) },
            new Postion[] { new (0,1),new (1,1), new (2,1), new(3,1) }
        };

        public override int Id => 1;
        // Start position in the middle of the screen (-1,3).
        protected override Postion StartOffset => new Postion(-1, 3);
        protected override Postion[][] Tiles => tiles;
    }
}
