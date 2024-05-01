using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_matrix
{
    internal class MatrixProperties
    {
        int[,] matrix;
        int[] absSumNegativeOddNums; // column characteristic

        #region properties

        public int Rows { get; set; }
        public int Cols { get; set; }

        public int[] AbsSumNegativeOddNums
        {
            get
            {
                if (absSumNegativeOddNums == null)
                {
                    SumNegativeOddAbsNumInCols();
                }
                return absSumNegativeOddNums;
            }
        }

        // indexer
        public int this[int i, int j]
        {
            get
            {
                if (i < Rows && i >= 0 && 
                    j < Cols && j >= 0)
                {
                    return matrix[i, j];
                } 
                else
                {
                    throw new IndexOutOfRangeException("Index is out of matrix range!");
                }
            }
        }

        #endregion

        #region constructors

        public MatrixProperties(int rows, int cols) 
        {
            matrix = new int[rows, cols];
            Rows = matrix.GetLength(0);
            Cols = matrix.GetLength(1);
        }

        #endregion

        #region functions

        public void FillMatrix(int min, int max)
        {
            Random random = new Random();

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    matrix[i, j] = random.Next(min, max + 1);
                }
            }
        }

        public void SumNegativeOddAbsNumInCols()
        {
            absSumNegativeOddNums = new int[Cols];

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    if (matrix[i, j] % 2 != 0 &&
                        matrix[i, j] < 0)
                    {
                        absSumNegativeOddNums[j] += Math.Abs(matrix[i, j]);
                    }
                }
            }
        }

        // swap values without using temp
        private void Swap(ref int firstElemnet, ref int secondElement)
        {
            firstElemnet = firstElemnet + secondElement;
            secondElement = firstElemnet - secondElement;
            firstElemnet = firstElemnet - secondElement;
        }

        public void SortColsByCharacteristics()
        {
            if (absSumNegativeOddNums == null)
            {
                SumNegativeOddAbsNumInCols();
            }

            for (int i = 0; i < Cols; i++)
            {
                for (int j = i + 1; j < Cols; j++)
                {
                    if (absSumNegativeOddNums[i] > absSumNegativeOddNums[j])
                    {
                        for (int k = 0; k < Rows; k++)
                        {
                            Swap(ref matrix[k, i], ref matrix[k, j]);
                        }
                        Swap(ref absSumNegativeOddNums[i], ref absSumNegativeOddNums[j]);
                    }
                }
            }
        }

        public int SumElementsInColsWithNegativeNums()
        {
            int totalSum = 0;

            for (int col = 0; col < Cols; col++)
            {
                bool hasNegative = false;

                for (int row = 0; row < Rows; row++)
                {
                    if (matrix[row, col] < 0)
                    {
                        hasNegative = true;
                        break;
                    }
                }

                if (hasNegative)
                {
                    int columnSum = 0;

                    for (int row = 0; row < Rows; row++)
                    {
                        columnSum += matrix[row, col];
                    }

                    totalSum += columnSum;
                }
            }

            return totalSum;
        }

        #endregion
    }
}
