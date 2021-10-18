using System;
// Thomas Zundel
// IT113 
// NOTES: 
// BEHAVIORS NOT IMPLEMENTED AND WHY: I think i got it all
namespace Zundel_linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            int choice;
            string input;
            LinkedList List = new LinkedList();
            Node Head = null;
            Node foundNode;
            while (keepGoing)
            {
                PrintMenu();
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    //just making choice so it is outside switch params so default throws
                    choice = 7;
                }
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the string you would like to add:");
                        input = Console.ReadLine();
                        if (Head == null)
                        {
                            Head = List.Add(null, new Node(input));
                            Console.WriteLine("Item added");
                            break;
                        }
                        List.Add(Head, new Node(input));
                        Console.WriteLine("Item added");
                        break;
                    case 2:
                        Console.WriteLine("Enter the string you would like to remove:");
                        input = Console.ReadLine();
                        if (Head == null)
                        {
                            Console.WriteLine("sorry we had no matches");
                            break;
                        }
                        
                        foundNode = List.Remove(Head, input);
                        if(Head.Next == null && Head.Data.ToLower() == input)
                        {
                            Head = null;
                            Console.WriteLine("Item removed");
                            break;
                        }
                        if (foundNode == null)
                        {
                            Console.WriteLine("sorry we had no matches");
                            break;
                        }
                        Head = foundNode;
                        Console.WriteLine("Item removed");
                        break;
                    case 3:
                        Console.WriteLine("Enter the string you would like to search for:");
                        input = Console.ReadLine();
                        if (Head == null)
                        {

                            Console.WriteLine("sorry we had no matches");
                            break;
                        }
                        foundNode = List.Contains(Head, input);
                        if (foundNode == null)
                        {
                            Console.WriteLine("sorry we had no matches");
                            break;
                        }
                        Console.WriteLine("search item found on node:" +foundNode.Data);
                        break;
                    case 4:
                        List.PrintAllNodes(Head);
                        break;
                    case 0:
                        keepGoing = false;
                        break;
                    default:
                        Console.WriteLine("Option not supported");
                        break;
                }
                void PrintMenu()
                {
                    Console.WriteLine("Press any key");
                    Console.ReadKey();
                    Console.WriteLine("Welcome to my linked list");
                    Console.WriteLine("1: Add item");
                    Console.WriteLine("2: Remove Item");
                    Console.WriteLine("3: Search for Item");
                    Console.WriteLine("4: Print");
                    Console.WriteLine("0: Exit");
                }


            }
        }
    }
}
