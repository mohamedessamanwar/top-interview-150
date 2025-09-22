namespace _733._Flood_Fill
{
    internal class Program
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            int originalColor = image[sr][sc];
            if (originalColor == color) return image;
            int rows = image.Length;
            int cols = image[0].Length;

            // List to track visited cells
            var visitedCells = new List<(int, int)>();

            void DFS(int r, int c)
            {
                if (r < 0 || r >= rows || c < 0 || c >= cols) return;
                if (image[r][c] != originalColor) return;
                if (visitedCells.Contains((r, c))) return;
                // Mark the cell as visited
                visitedCells.Add((r, c));
                image[r][c] = color;

                DFS(r + 1, c);
                DFS(r - 1, c);
                DFS(r, c + 1);
                DFS(r, c - 1);
            }

            DFS(sr, sc);
            return image;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
