
namespace Tetris
{
    public class OBlock:Block
    {
        private readonly Postion[][] tiles = new Postion[][]
              {
            new Postion[] { new (0,0), new (0,1), new (1,0), new (1,1) },
              };

        public override int Id => 4;
        // Start position in the middle of the screen (0,4).
        protected override Postion StartOffset => new Postion(0, 4);
        protected override Postion[][] Tiles => tiles;
    }
}
