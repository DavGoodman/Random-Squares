using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Squares
{
    internal class VirtualScreenCell
    {
        public bool Up { get; private set; }
        public bool Down { get; private set; }
        public bool Left { get; private set; }
        public bool Right { get; private set; }

        public char GetCharacter()
        {
            if (Up && Down && Right && Left) return '┼';
            else if (Up && Down && Right) return '├';
            else if (Up && Down && Left) return '┤';
            else if (Down && Left && Right) return '┬';
            else if (Up && Left && Right) return '┴';
            else if (Down && Right) return '┌';
            else if (Left && Right) return '─';
            else if (Down && Left) return '┐';
            else if (Up && Left) return '┘';
            else if (Up && Right) return '└';
            else if (Down && Up) return '│';
            return ' ';
        }

        public void AddHorizontal()
        {
            Left = true;
            Right = true;
        }

        public void AddVertical()
        {
            Up = true;
            Down = true;
        }

        public void AddLowerLeftCorner()
        {
            Up = true;
            Right = true;
        }

        public void AddUpperLeftCorner()
        {
            Down = true;
            Right = true;
        }

        public void AddUpperRightCorner()
        {
            Down = true;
            Left = true;
        }

        public void AddLowerRightCorner()
        {
            Up = true;
            Left = true;
        }
    }
}
