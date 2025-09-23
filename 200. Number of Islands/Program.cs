namespace _200._Number_of_Islands
{
    internal class Program
    {
        public int NumIslands(char[][] grid)
        {
            int count = 0;
            // HashSet for O(1) lookup instead of List's O(n)
            var visitedCells = new HashSet<(int, int)>();
            int rows = grid.Length;
            int cols = grid[0].Length;

            void DFS(int r, int c)
            {
                if (r < 0 || r >= rows || c < 0 || c >= cols || grid[r][c] == '0') return;
                if (visitedCells.Contains((r, c))) return;
                // Mark the cell as visited
                visitedCells.Add((r, c));
                DFS(r + 1, c);
                DFS(r - 1, c);
                DFS(r, c + 1);
                DFS(r, c - 1);
            }

            // Iterate through each cell in the grid
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    // If we find land ('1') that hasn't been visited
                    if (grid[i][j] == '1' && !visitedCells.Contains((i, j)))
                    {
                        // Start DFS to mark all connected land as visited
                        DFS(i, j);
                        // Increment island count
                        count++;
                    }
                }
            }

            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
