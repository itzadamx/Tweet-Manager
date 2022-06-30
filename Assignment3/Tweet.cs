using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace Assignment3
{
    public class Tweet
    {
        private static int recentId = 1;

        public int Id { get; set; } 

        public string From { get; set; }

        public string To { get; set; }

        public string Message { get; set; }

        public string Category { get; set; }

        public Tweet(string from, string to, string message, string category)
        {
            From = from;
            To = to;
            Message = message;
            Category = category;
            Id = Tweet.recentId;
            Tweet.recentId++;
        }

        public static Tweet Process(string line)
        {
            try
            {
                string[] member = line.Split(new char[] { '\t' });
                return new Tweet(member[0], member[1], member[2], member[3]);
            }
            catch (IndexOutOfRangeException)
            {
                return new Tweet("Invalid", "Invalid", "Invalid", "Invalid");
            }
        }
        public override string ToString()
        {
            string tweetToString = $" Id: {Id}  From: {From}  To: {To}  Message: {(Message.Length > 10 ? Message.Substring(0, 10) : Message)}  Category: {Category}";
            return tweetToString;
        }
    }
}
