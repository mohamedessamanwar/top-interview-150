namespace _114._Flatten_Binary_Tree_to_Linked_List
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
        public void Flatten(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            TreeNode left = root.left;
            TreeNode right = root.right;
            // Flatten the left subtree
            Flatten(left);

            if (left != null)
            {

                while (left.right != null)
                {
                    left = left.right;
                }
                // Connect the right subtree to the end of the left subtree
                left.right = root.right;
                root.right = root.left; // Set the right child of the root to the left subtree
                root.left = null; // Set the left child of the left subtree to null
            }
            Flatten(right); // Flatten the right subtree
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
