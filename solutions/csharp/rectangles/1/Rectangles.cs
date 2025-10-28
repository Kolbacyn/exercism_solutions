using System;
using System.Collections.Generic;

public static class Rectangles
{
    public static int Count(string[] rows)
    {
        int count = 0;
        int rowCount = rows.Length;
        if (rowCount == 0) return 0;
        int colCount = rows[0].Length;

        // Ищем верхние пары углов (символ '+') в каждой строке
        for (int r1 = 0; r1 < rowCount; r1++)
        {
            for (int c1 = 0; c1 < colCount; c1++)
            {
                if (rows[r1][c1] != '+') continue;

                for (int c2 = c1 + 1; c2 < colCount; c2++)
                {
                    if (rows[r1][c2] != '+') continue;

                    // Искать соответствующие нижние углы прямоугольника
                    for (int r2 = r1 + 1; r2 < rowCount; r2++)
                    {
                        if (rows[r2][c1] == '+' && rows[r2][c2] == '+')
                        {
                            // Проверяем горизонтальные стороны
                            if (CheckRow(rows[r1], c1, c2) && CheckRow(rows[r2], c1, c2)
                                // и вертикальные стороны
                                && CheckColumn(rows, c1, r1, r2)
                                && CheckColumn(rows, c2, r1, r2))
                            {
                                count++;
                            }
                        }
                    }
                }
            }
        }

        return count;
    }

    private static bool CheckRow(string row, int start, int end)
    {
        for (int i = start + 1; i < end; i++)
        {
            char c = row[i];
            if (c != '-' && c != '+') return false;
        }
        return true;
    }

    private static bool CheckColumn(string[] rows, int col, int startRow, int endRow)
    {
        for (int i = startRow + 1; i < endRow; i++)
        {
            char c = rows[i][col];
            if (c != '|' && c != '+') return false;
        }
        return true;
    }
}
