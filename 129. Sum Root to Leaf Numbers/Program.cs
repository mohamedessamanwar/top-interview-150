namespace _129._Sum_Root_to_Leaf_Numbers
{
    internal class Program
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
        public int SumNumbers(TreeNode root)
        {
            return SumNumbersHelper(root, string.Empty);
        }
        public int SumNumbersHelper(TreeNode root, string values)
        {
            if (root == null)
            {
                return 0;
            }
            // Save the current path as a string
            string v = $"{values}{root.val}"; // Append the current node's value to the path string

            int l = SumNumbersHelper(root.left, v);
            int r = SumNumbersHelper(root.right, v);
            if (root.left == null && root.right == null)
            {
                return int.Parse(v);
            }
            return l + r;
        }
        static void Main(string[] args)
        {
            // Create a test tree
            var root = new TreeNode(4)
            {
                left = new TreeNode(9)
                {
                    left = new TreeNode(5),
                    right = new TreeNode(1)
                },
                right = new TreeNode(0)
            };

            // Call the SumNumbers function
            var program = new Program();
            int result = program.SumNumbers(root);

            // Print the result
            Console.WriteLine($"The sum of root-to-leaf numbers is: {result}");
        }
    }
}
