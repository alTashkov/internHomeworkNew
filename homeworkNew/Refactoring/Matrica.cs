using System;

namespace Matrica
{
    internal class WalkInMatrix
    {
        internal static readonly int[] DirectionsX = { 1, 1, 1, 0, -1, -1, -1, 0 };
        internal static readonly int[] DirectionsY = { 1, 0, -1, -1, -1, 0, 1, 1 };

        internal static void ChangeDirection(ref int dX, ref int dY)
        {
            int idx = 0;

            for (int count = 0; count < DirectionsX.Length; count++)
            {
                if (DirectionsX[count] == dX && DirectionsY[count] == dY)
                {
                    idx = count;
                    break;
                }
            }

            if (idx == 7)
            {
                dX = DirectionsX[0];
                dY = DirectionsY[0];

                return;
            }

            dX = DirectionsX[idx + 1];
            dY = DirectionsY[idx + 1];
        }

        internal static bool HasAvailableMove(int[,] arr, int xCoordinate, int yCoordinate)
        {
            for (int i = 0; i < DirectionsX.Length; i++)
            {
                int newX = xCoordinate + DirectionsX[i];
                int newY = yCoordinate + DirectionsY[i];

                if (newX >= 0 && newX < arr.GetLength(0) &&
                    newY >= 0 && newY < arr.GetLength(1) &&
                        arr[newX, newY] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        internal static void FindNextAvailableCell(int[,] array, out int xCoordinate, out int yCoordinate)
        {
            xCoordinate = 0;
            yCoordinate = 0;

            for (int matrixX = 0; matrixX < array.GetLength(0); matrixX++)
            {
                for (int matrixY = 0; matrixY < array.GetLength(1); matrixY++)
                {
                    if (array[matrixX, matrixY] == 0)
                    {
                        xCoordinate = matrixX;
                        yCoordinate = matrixY;

                        return;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            //Console.WriteLine( "Enter a positive number " );
            //string input = Console.ReadLine(  );
            //int n = 0;
            //while ( !int.TryParse( input, out n ) || n < 0 || n > 100 )
            //{
            //    input = Console.ReadLine(  );
            //}
            int numberRowsCols = 6;
            int[,] matrix = new int[numberRowsCols, numberRowsCols];

            int currentNumber = 1;
            int currentCellX = 0;
            int currentCellY = 0;
            int directionX = 1;
            int directionY = 1;

            while (true)
            {
                matrix[currentCellX, currentCellY] = currentNumber;

                if (!HasAvailableMove(matrix, currentCellX, currentCellY))
                {
                    FindNextAvailableCell(matrix, out currentCellX, out currentCellY);
                    if (matrix[currentCellX, currentCellY] != 0)
                        break;

                    directionX = 1;
                    directionY = 1;
                    currentNumber++;
                    continue;
                }

                int nextX = currentCellX + directionX;
                int nextY = currentCellY + directionY;

                while (nextX < 0 || nextX >= numberRowsCols ||
                       nextY < 0 || nextY >= numberRowsCols ||
                       matrix[nextX, nextY] != 0)
                {
                    ChangeDirection(ref directionX, ref directionY);
                    nextX = currentCellX + directionX;
                    nextY = currentCellY + directionY;
                }

                currentCellX = nextX;
                currentCellY = nextY;
                currentNumber++;
            }

            for (int p = 0; p < numberRowsCols; p++)
            {
                for (int q = 0; q < numberRowsCols; q++)
                {
                    Console.Write("{0,4}", matrix[p, q]);
                }

                Console.WriteLine();
            }
        }
    }
}
