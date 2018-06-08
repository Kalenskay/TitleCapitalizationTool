using System;
using System.Text;

namespace TitleCapitalizationTool
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Enter title to capitalize:");
                Console.ForegroundColor = ConsoleColor.Red;
                string message = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Capitalized title: ");
                Console.ForegroundColor = ConsoleColor.Green;

                string message2 = (message.Replace(".", " . "));
                message2 = (message2.Replace(",", " , "));
                message2 = (message2.Replace(";", " ; "));
                message2 = (message2.Replace(":", " : "));
                message2 = (message2.Replace("!", " ! "));
                message2 = (message2.Replace("?", " ? "));
                message2 = (message2.Replace("-", " - "));

                string[] arrayMessage = message2.Split(' ');
                StringBuilder finalMessage = new StringBuilder();
                foreach (string word in arrayMessage)
                {
                    if (",.;:!?-".Contains(word))
                    {
                        if (word == "-")
                        {
                            finalMessage.Append(" ");
                        }
                        finalMessage.Append(word);
                    }
                    else
                    {
                        string word2 = word.ToLower();
                        if (!"a an the and but for nor so yet at by in of on or out to up".Contains(word2) || finalMessage.Length == 0)
                        {
                            word2 = Char.ToUpper(word2[0]) + word2.Substring(1);
                        }
                        finalMessage.Append(" ");
                        finalMessage.Append(word2);
                    }
                }

                message2 = (finalMessage.ToString().Trim());
                Console.WriteLine(message2);
            }
        }
    }
}