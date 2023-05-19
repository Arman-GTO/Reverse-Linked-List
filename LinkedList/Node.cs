namespace Reversed_Link_List.LinkedList
{
    internal class Node
    {
        public Node(string data)
        {
            Data = data;
        }

        public string Data { get; }

        public Node? Next { get; set; }
    }
}