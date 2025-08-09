namespace _236._Lowest_Common_Ancestor_of_a_Binary_Tree
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
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
            {
                return null;
            }
            if (root == q || root == p)
            {
                return root;
            }
            var l = LowestCommonAncestor(root.left, p, q);
            var r = LowestCommonAncestor(root.right, p, q);
            if (l != null && r != null)
            {
                return root;
            }
            return l == null ? r : l;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
