using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class TBlock : IBlock
    {
        private readonly Postion[][] tiles = new Postion[][]
{
            new Postion[] { new (0,1), new (1,0), new (1,1), new (1,2) },
            new Postion[] { new (0,1),new (1,1), new (1,2), new(2,1) },
            new Postion[] { new (1,0),new (1,1), new (1,2), new(2,1) },
            new Postion[] { new (0,1),new (1,0), new (1,1), new(2,1) }
};

        public override int Id => 6;
        // Start position in the middle of the screen (0,3).
        protected override Postion StartOffset => new Postion(0, 3);
        protected override Postion[][] Tiles => tiles;
    }
}

