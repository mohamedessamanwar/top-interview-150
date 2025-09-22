namespace Number_of_Connected_Components_in_an_Undirected_Graph
{
    internal class Program
    {
        public int CountComponents(int n, int[][] edges)
        {
            // List to track visited cells
            if (n == 0) return 0;
            if (n == 1) return 1;
            var visitedCells = new HashSet<int>();
            var graph = new Dictionary<int, List<int>>();
            foreach (var edge in edges)
            {
                int u = edge[0];
                int v = edge[1];

                // Initialize adjacency lists if they don't exist
                if (!graph.ContainsKey(u))
                {
                    graph[u] = new List<int>();
                }
                if (!graph.ContainsKey(v))
                {
                    graph[v] = new List<int>();
                }

                // Add edges in both directions (undirected graph)
                graph[u].Add(v);
                graph[v].Add(u);
            }
            int count = 0;
            void DFS(int node)
            {
                visitedCells.Add(node);
                foreach (var edge in graph[node])
                {
                    if (!visitedCells.Contains(edge))
                    {
                        DFS(edge);
                    }
                }
            }
            foreach (var edge in graph)
            {
                if (!visitedCells.Contains(edge.Key))
                {
                    DFS(edge.Key);
                    count++;
                }
            }
            var reaming = n - visitedCells.Count;
            return count + reaming;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
