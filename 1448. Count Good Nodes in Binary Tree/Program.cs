namespace _1448._Count_Good_Nodes_in_Binary_Tree
{
    internal class Program
    {
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
        public int GoodNodes(TreeNode root)
        {
            int Count = 0;
            int Max = int.MinValue;
            GoodNodsHelper(Max, ref Count, root);

            void GoodNodsHelper(int max, ref int count, TreeNode treeNode)
            {
                if (treeNode == null) return;
                if (treeNode.val > max)
                {
                    count++;
                    max = treeNode.val;
                }
                GoodNodsHelper(max, ref count, treeNode.left);
                GoodNodsHelper(max, ref count, treeNode.right);
            }
            return Count;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
