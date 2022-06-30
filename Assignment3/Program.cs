using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

/*
 *Authors:
 *Adam Daabaz
 *Ignacio Agustin Zuluaga 
 *Sohyeon Song
  Group 24
 */

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ---------------------*Tweet search App*-----------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("All the tweets available to see:");
            Console.WriteLine();
            TweetManager.ShowAll();
            Console.WriteLine("=====================================");
            Console.Write(" Dear user, kindly enter the category to search for:");
            string userCategory = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($" All the tweets with {userCategory} tag:");
            Console.WriteLine();
            TweetManager.ShowAll(userCategory);
            TweetManager.ConvertToJson();
            Console.ReadKey(); 
        }
    }
}
