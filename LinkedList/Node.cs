namespace Reversed_Link_List.LinkedList
{
    internal class Node
    {
        public string Data { get; }

        public Node? Next { get; set; }

        public Node(string data)
        {
            Data = data;
        }
    }
}