public class WordSearch
{
    private readonly char[,] grid;
    private readonly int rows;
    private readonly int cols;

    private static readonly (int, int)[] directions = new (int, int)[]
    {
        (-1, -1), (-1, 0), (-1, 1),
        (0, -1),           (0, 1),
        (1, -1),  (1, 0),  (1, 1)
    };
    
    public WordSearch(string gridString)
    {
        var lines = gridString.Split('\n', StringSplitOptions.RemoveEmptyEntries);
        rows = lines.Length;
        cols = lines[0].Length;
        grid = new char[rows, cols];
        for (int r = 0; r < rows; r++)
        {
            var line = lines[r].Trim();
            for (int c = 0; c < cols; c++)
            {
                grid[r, c] = line[c];
            }
        }
    }

    public Dictionary<string, ((int, int), (int, int))?> Search(string[] wordsToSearchFor)
    {
        var result = new Dictionary<string, ((int, int), (int, int))?>();
        foreach (var word in wordsToSearchFor)
        {
            result[word] = null;
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (grid[r, c] == word[0])
                    {
                        foreach (var (dx, dy) in directions)
                        {
                            if (CheckWord(word, r, c, dx, dy, out var end))
                            {
                                result[word] = ((c + 1, r + 1), end);
                                goto NextWord;
                            }
                        }
                    }
                }
            }
        NextWord:;
        }
        return result;
    }

    private bool CheckWord(string word, int startX, int startY, int dx, int dy, out (int, int) endPos)
    {
        int x = startX, y = startY;
        for (int i = 0; i < word.Length; i++)
        {
            if (x < 0 || x >= rows || y < 0 || y >= cols || grid[x, y] != word[i])
            {
                endPos = (-1, -1);
                return false;
            }
            x += dx;
            y += dy;
        }
        endPos = (y - dy + 1, x - dx + 1);
        return true;
    }
}