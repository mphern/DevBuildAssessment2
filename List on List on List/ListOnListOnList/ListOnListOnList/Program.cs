using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ListOnListOnList
{
    class Program
    {
        static void Main()
        {
            List<string> MyList = new List<string>() { "Michigan", "Ohio", "New York", "Texas" };
            while (true)
            {
                Console.WriteLine("What would you like to do? (Enter 1-5)");
                Console.WriteLine("1. See list");
                Console.WriteLine("2. Add to list");
                Console.WriteLine("3. Search list");
                Console.WriteLine("4. Sort list");
                Console.WriteLine("5. Quit");

                int choice = GetChoice();
                if (choice == 1)
                    DisplayList(MyList);
                if (choice == 2)
                    AddToString(ref MyList);
                if (choice == 3)
                    SearchList(MyList);
                if (choice == 4)
                    SortList(ref MyList);
                if (choice == 5)
                    break;
            }

            Console.WriteLine("Goodbye!");
        }
        static int GetChoice()
        {
            int choice;
            Console.Write("> ");
            while(!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
                Console.Write("Invalid selection. Enter 1-5 > ");
            return choice;

        }
        static void DisplayList(List<string> list)
        {
            Console.WriteLine("\n");
            foreach(string str in list)
                Console.WriteLine(str);
            Console.WriteLine("\n");
        }

        static void AddToString(ref List<string> list)
        {
            Console.Write("What would you like to add to the list? ");
            string addition = Console.ReadLine();
            list.Add(addition);
            Console.WriteLine(addition+" has been added.\n");

        }
        static void SearchList(List<string> list)
        {
            bool match = false;
            Console.Write("What would you like to search for? ");
            string searchTerm = Console.ReadLine();
            for(int i = 0; i < list.Count; i++)
            {
                if (Regex.IsMatch(list[i], searchTerm, RegexOptions.IgnoreCase))
                {
                    Console.WriteLine("\n" + searchTerm + " is in the list located at index " + i + ".\n");
                    match = true;
                }
            }
            
            if(match == false)
                Console.WriteLine("\nSearch term not found on list\n");
        }
        static List<string> SortList(ref List<string> list)
        {
            list.Sort();
            Console.WriteLine("List has been sorted alphabetically.\n");
            return list;
        }
    }
}
