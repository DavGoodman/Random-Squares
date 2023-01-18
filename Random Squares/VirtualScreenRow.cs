using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Squares
{
    internal class VirtualScreenRow
    {
        private VirtualScreenCell[] _cells;

        public VirtualScreenRow(int screenWidth)
        {
            _cells = new VirtualScreenCell[screenWidth];
            for (int i = 0; i < screenWidth; i++)
            {
                _cells[i] = new VirtualScreenCell();
            }
        }

        public void AddBoxTopRow(int boxX, int boxWidth)
        {
            //var firstCell = _cells[boxX];
            //firstCell = new VirtualScreenCell();
            //firstCell.AddUpperLeftCorner();

            _cells[boxX].AddUpperLeftCorner();

            _cells[boxX + boxWidth - 1].AddUpperRightCorner();

            for (int i = 0; i < boxWidth - 2; i++)
            {
                _cells[boxX + i + 1].AddHorizontal();
            }
        }

        public void AddBoxBottomRow(int boxX, int boxWidth)
        {
            _cells[boxX].AddLowerLeftCorner();

            _cells[boxX + boxWidth - 1].AddLowerRightCorner();

            for (int i = 0; i < boxWidth - 2; i++)
            {
                _cells[boxX + i + 1].AddHorizontal();
            }
        }

        public void AddBoxMiddleRow(int boxX, int boxWidth)
        {
            _cells[boxX].AddVertical();

            _cells[boxX + boxWidth - 1].AddVertical();
        }

        public void Show()
        {
            foreach (var cell in _cells)
            {
                
                Console.Write(cell.GetCharacter());
                
            }

            Console.WriteLine();
        }
    }
}
