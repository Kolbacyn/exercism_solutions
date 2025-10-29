using System;
using System.Collections.Generic;

public static class SaddlePoints
{
    public static IEnumerable<(int row, int col)> Calculate(int[,] matrix)
    {
        int rowCount = matrix.GetLength(0);
        int colCount = matrix.GetLength(1);
        var results = new List<(int, int)>();

        for (int row = 0; row < rowCount; row++)
        {
            int maxInRow = int.MinValue;
            for (int col = 0; col < colCount; col++)
            {
                if (matrix[row, col] > maxInRow)
                    maxInRow = matrix[row, col];
            }

            for (int col = 0; col < colCount; col++)
            {
                if (matrix[row, col] == maxInRow)
                {
                    bool isMinInCol = true;
                    for (int r = 0; r < rowCount; r++)
                    {
                        if (matrix[r, col] < maxInRow)
                        {
                            isMinInCol = false;
                            break;
                        }
                    }

                    if (isMinInCol)
                    {
                        results.Add((row + 1, col + 1));
                    }
                }
            }
        }
        return results;
    }
}
