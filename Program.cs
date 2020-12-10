using System;
using System.Collections.Generic;

namespace ZeroMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 0, 6 } , { 7, 8, 9 } };

            for ( int i = 0; i < matrix.GetLength(0); i++ )
            {
              for( int j = 0; j < matrix.GetLength(1); j++ )
              {
                Console.Write( matrix[i,j] );
              }
              Console.WriteLine("");
            }
            matrix = SetToZeroMatrix(matrix);

            for ( int i = 0; i < matrix.GetLength(0); i++ )
            {
              for ( int j = 0; j < matrix.GetLength(1); j++ )
              {
                Console.Write(matrix[i, j]);
              }
              Console.WriteLine("");
            }
            Console.ReadLine();
        }

        public static int[,] SetToZeroMatrix(int[,] matrix){
            List<string> zeroPositions = new List<string>();
            int lengthRows = matrix.GetLength(0);
            int lengthCols = matrix.GetLength(1);

            for( int i=0; i<lengthRows; i++ )
              for( int j=0; j<lengthCols; j++ )
                if( matrix[i, j] == 0 )
                  zeroPositions.Add(i + "," + j);
            
            foreach ( var position in zeroPositions )
            {
              int row = int.Parse(position.Split(',')[0].ToString());
              int column = int.Parse(position.Split(',')[1].ToString());

              for( int i=0; i<lengthRows; i++ )
                matrix[row, i] = 0;

              for( int i=0; i<lengthCols; i++ )
                matrix[i, column] = 0;

            }

            return matrix;
        }
    }
}
