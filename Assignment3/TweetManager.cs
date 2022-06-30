using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace Assignment3
{
	static class TweetManager
	{
		public static Tweet[] Tweets { get; set; }
		public static string FileName { get; set; }

		static TweetManager()
		{
			FileName = "tweets.txt";

			List<Tweet> tweetList = new List<Tweet>();

			TextReader reader = new StreamReader(FileName);

			string line = reader.ReadLine();

			while (line != null)
			{
				tweetList.Add(Tweet.Process(line));

				line = reader.ReadLine();
			}

			reader.Close();

            Tweets = tweetList.ToArray();
		}
	

	public static void ShowAll()
	{
		foreach (Tweet tweet in Tweets)
		{
			Console.WriteLine(tweet);
			Console.WriteLine();
		}
	}

	public static void ShowAll(string catetag)
	{
		foreach (Tweet tweet in Tweets)
		{
				if (tweet.Category.ToLower() == catetag.ToLower())
			{
				Console.WriteLine(tweet);
				Console.WriteLine();
			}
		}
	}
	public static void ConvertToJson()
	{
		TextWriter Writer = new StreamWriter("tweets.json");

		foreach (Tweet tweet in Tweets)
		{
			string tweetJson = JsonSerializer.Serialize(tweet);
			Writer.WriteLine(tweetJson);
		}
		Writer.Close();
	}
   }
}
