using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackGroundWorker
{
    public class MatrixDimensions
    {
        public int RowsMatrix1 { get; }
        public int ColsMatrix1 { get; }
        public int RowsMatrix2 { get; }
        public int ColsMatrix2 { get; }

        public MatrixDimensions(int rowsMatrix1, int colsMatrix1, int rowsMatrix2, int colsMatrix2)
        {
            RowsMatrix1 = rowsMatrix1;
            ColsMatrix1 = colsMatrix1;
            RowsMatrix2 = rowsMatrix2;
            ColsMatrix2 = colsMatrix2;
        }
    }
}
