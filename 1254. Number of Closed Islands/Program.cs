namespace _1254._Number_of_Closed_Islands
{
    internal class Program
    {
        public int ClosedIsland(int[][] grid)
        {
            int count = 0;
            // HashSet for O(1) lookup instead of List's O(n)
            var visitedCells = new HashSet<(int, int)>();
            int n = grid.Length;
            int m = grid[0].Length;

            void DfsFill(int r, int c)
            {
                if (r < 0 || r >= n || c < 0 || c >= m) return;
                if (grid[r][c] != 0) return;   // اشتغل بس على اليابس (0)

                //  grid[r][c] = 2;
                if (visitedCells.Contains((r, c))) return;
                // Mark the cell as visited
                visitedCells.Add((r, c));
                grid[r][c] = 2;
                DfsFill(r + 1, c);
                DfsFill(r - 1, c);
                DfsFill(r, c + 1);
                DfsFill(r, c - 1);
            }

            for (int j = 0; j < m; j++)
            {
                if (grid[0][j] == 0) DfsFill(0, j);
                if (grid[n - 1][j] == 0) DfsFill(n - 1, j);
            }
            for (int i = 0; i < n; i++)
            {
                if (grid[i][0] == 0) DfsFill(i, 0);
                if (grid[i][m - 1] == 0) DfsFill(i, m - 1);
            }
            visitedCells.Clear();
            void DFS1(int r, int c)
            {
                if (r < 0 || r >= n || c < 0 || c >= m || grid[r][c] != 0) return;
                if (visitedCells.Contains((r, c))) return;
                // Mark the cell as visited
                visitedCells.Add((r, c));
                //  grid[r][c] = 2;
                DFS1(r + 1, c);
                DFS1(r - 1, c);
                DFS1(r, c + 1);
                DFS1(r, c - 1);
            }
            // Iterate through each cell in the grid
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    // If we find land ('1') that hasn't been visited
                    if (grid[i][j] == 0 && !visitedCells.Contains((i, j)))
                    {
                        // Start DFS to mark all connected land as visited
                        DFS1(i, j);
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
