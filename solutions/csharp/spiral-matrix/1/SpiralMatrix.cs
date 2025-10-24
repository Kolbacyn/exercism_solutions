public class SpiralMatrix
{
    public static int[,] GetMatrix(int size)
    {
        int[,] matrix = new int[size, size];

        int value = 1;
        int up = 0;
        int down = size - 1;
        int left = 0;
        int right = size - 1;
        while (value <= size*size)
        {
            for (int i = left; i <= right && value <= size * size; i++)
            {
                matrix[up, i] = value++;
            }
            up++;
            for (int i = up; i <= down && value <= size * size; i++)
            {
                matrix[i, right] = value++;
            }
            right--;
            for (int i = right; i >= left && value <= size * size; i--)
            {
                matrix[down, i] = value++;
            }
            down--;
            for (int i = down; i >= up && value <= size * size; i--)
            {
                matrix[i, left] = value++;
            }
            left++;
        }
        return matrix;
    }
}
