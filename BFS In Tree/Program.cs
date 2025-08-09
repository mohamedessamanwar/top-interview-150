namespace BFS_In_Tree
{
    internal class Program
    {
        // tree node definition
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x)
            {
                val = x;
                left = null;
                right = null;
            }
        }
        // BFS function to traverse the tree
        public void BFS(TreeNode root)
        {
            if (root == null) return;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int level = 0;

            while (queue.Count > 0)
            {
                int levelNodeCount = queue.Count; // Number of nodes at the current level
                Console.WriteLine($"Level {level}: {levelNodeCount} node(s)");

                for (int i = 0; i < levelNodeCount; i++)
                {
                    TreeNode current = queue.Dequeue();
                    Console.Write(current.val + " ");
                    if (current.left != null)
                    {
                        queue.Enqueue(current.left);
                    }
                    if (current.right != null)
                    {
                        queue.Enqueue(current.right);
                    }
                }
                Console.WriteLine(); // Move to the next line for the next level
                level++;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
