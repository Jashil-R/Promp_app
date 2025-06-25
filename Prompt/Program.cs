using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prompt
{
    //Completed, try add one or two extras
    public class Program
    {
        static List<String> names = new List<String>();
        static String db = "database.txt";
        static void AddName()
        {
                Console.WriteLine("Enter a name to add to the list: ");
                string name = Console.ReadLine();                
                names.Add(name);            
        }
        static void RemoveName()
        {
                Console.WriteLine("Enter a name to remove from the list: ");
                string name = Console.ReadLine();                
                names.Remove(name);            
        }
        static void ShowName()
        {
            Console.WriteLine("These are the name in the list: ");            
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }            
        }

        static void Read()
        {
            if (File.Exists(db))
            {
                string list = File.ReadAllText(db);
                string[] split = list.Split('\n');
                foreach (string name in split)
                {                    
                    if (name != "\n")
                    {
                        names.Add(name);
                    }
                }
            }
           
        }
        public static void Save()
        {            
            string builder = "";
            foreach (string name in names)
            {
                builder += name + "\n";
            }
            File.WriteAllText(db, builder);
        }

        static void Main(string[] args)
        {
            Read();
            Console.WriteLine("Welcome");
            while (true)
            {
                Console.WriteLine(" ");
                Console.WriteLine("1. Add a new name");
                Console.WriteLine("2. Remove a name");
                Console.WriteLine("3. Show all names");
                Console.WriteLine("Q. Exit");
                Console.WriteLine(" ");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();
                Console.WriteLine();                

                switch (choice)
                {
                    case "1":
                        AddName();
                        Save();
                        break;
                    case "2":
                        RemoveName();
                        Save();
                        break;
                    case "3":
                        ShowName();
                        break;
                    case "Q":
                        return;                        
                }
            }

            
                
            //while (true)
            //{
            //    Console.WriteLine("Enter a name to check if it is the list: ");
            //    String searchName = Console.ReadLine();               
            //    if (searchName.Equals("STOP"))
            //    {
            //        break;
            //    }
            //    if (names.Contains(searchName))
            //    {
            //        Console.WriteLine(searchName + " is in the list");
            //    }
            //    else
            //    {
            //        Console.WriteLine(searchName + " is not in the list");
            //    }
            //}
            
        }
    }
}
