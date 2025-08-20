namespace _117._Populating_Next_Right_Pointers_in_Each_Node_IIv
{
    internal class Program
    {
        public class Node
        {
            public int val;
            public Node left;
            public Node right;
            public Node next;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, Node _left, Node _right, Node _next)
            {
                val = _val;
                left = _left;
                right = _right;
                next = _next;
            }
        }
        public Node Connect(Node root)
        {
            if (root == null) return null;
            int levelCount = 0;
            Node Prev = null;
            var q = new Queue<Node>();
            q.Enqueue(root);
            while (q.Count() != 0)
            {
                int size = q.Count();
                levelCount++;
                for (int i = 0; i < size; i++)
                {
                    Node node = q.Dequeue();
                    if (i == 0)
                    {
                        Prev = node;
                    }
                    else
                    {
                        Prev.next = node;
                        Prev = node;
                    }
                    if (node.left != null)
                    {
                        q.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        q.Enqueue(node.right);
                    }
                }
                Prev.next = null; // Last node in the level should point to null
            }

            return root;


        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
