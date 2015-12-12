using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PongGame
{
    class CollisionDetector
    {
        public static bool Overlaps(Sprite s1, Sprite s2)
        {
            if (s1.Position.X < s2.Position.X || s1.Position.X >= s2.Position.X + s2.Size.Width)
                return false;

            if(s2.Position.Y==0)
            {
                if (s1.Position.Y <= s2.Size.Height)
                    return true;
                return false;
            }
            else
            {
                if (s1.Position.Y + s1.Size.Height >= s2.Position.Y)
                    return true;
                return false;
            }
        }
    }
}
