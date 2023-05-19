using Reversed_Link_List.LinkedList;

MyLinkedList myList;
string inp;

while (true)
{
    myList = new MyLinkedList();
    Console.Clear();
    Console.CursorVisible = true;
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write("  Please enter your inputs:\n");
    Console.ForegroundColor = ConsoleColor.Blue;
    while (true)
    {
        Console.Write("  ");
        inp = Console.ReadLine() + "";
        if (inp == "") break;
        myList.InsertFront(inp);
    } // Get inputs
    Console.CursorVisible = false;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("  Your inputs are: \n  ");
    Console.ForegroundColor = ConsoleColor.Yellow;
    var node = myList.Head;
    while (true)
    {
        if (node == null) break;
        Console.Write((node.Next != null) ? node.Data + "|" + node.Next.Data + " -> " : node.Data);
        node = node.Next;
    } // Write outputs

    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("\n\n  R: restart   |   ESC: exit\n\n");
What_To_Do:
    switch (Console.ReadKey(true).Key)
    {
        case ConsoleKey.R:
            break;
        case ConsoleKey.Escape:
            Console.ResetColor();
            return;
        default:
            goto What_To_Do;
    } // Check if restart or exit the app
}