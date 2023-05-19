namespace Reversed_Link_List.LinkedList
{
    internal class MyLinkedList
    {
        internal Node? Head { get; set; }

        internal void InsertFront(string data)
        {
            Node newNode = new(data) { Next = Head };
            Head = newNode;
        }
    }
}