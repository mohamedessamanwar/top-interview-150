namespace _138._Copy_List_with_Random_Pointer
{
    internal class Program
    {
        public class Node
        {
            public int val;
            public Node next;
            public Node random;

            public Node(int _val)
            {
                val = _val;
                next = null;
                random = null;
            }
        }
        public Node CopyRandomList(Node head)
        {
            if (head == null) return null;

            var Current = new Node(head.val);
            var Prev = Current;
            var Dummy = Current;
            var hash = new Dictionary<Node, Node>();
            hash.Add(head, Current);
            if (head.random != null)
            {
                if (hash.ContainsKey(head.random))
                {
                    Current.random = hash[head.random];
                }
                else
                {
                    var noderandom = new Node(head.random.val);
                    Current.random = noderandom;
                    hash.Add(head.random, noderandom);
                }

            }
            else
            {
                Current.random = null;
            }
            Current = head.next;
            while (Current != null)
            {
                var NewNode = new Node(Current.val);
                if (hash.ContainsKey(Current))
                {
                    Prev.next = hash[Current];
                    Prev = hash[Current];
                    NewNode = hash[Current];
                }
                else
                {
                    NewNode = new Node(Current.val);
                    Prev.next = NewNode;
                    Prev = NewNode;
                    hash.Add(Current, NewNode);
                }


                if (Current.random != null)
                {
                    if (hash.ContainsKey(Current.random))
                    {
                        NewNode.random = hash[Current.random];
                    }
                    else
                    {
                        var n = new Node(Current.random.val);

                        hash.Add(Current.random, n);
                        NewNode.random = n;

                    }
                }
                else
                {
                    NewNode.random = null;
                }
                Current = Current.next;
            }
            Prev.next = null;
            return Dummy;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
