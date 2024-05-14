using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chat = new List<string>();
            string command = Console.ReadLine();
            while (command!="end")
            {
                string[] commands = command.Split();
                switch (commands[0])
                {
                    case "Chat":
                        string message = commands[1];
                        chat.Add(message);
                        break;
                    case "Delete":
                        string input = commands[1];
                        if (chat.Contains(input))
                        {
                            chat.Remove(input);
                        }
                        break;
                    case "Edit":
                        string message2 = commands[1];
                        string edited = commands[2];
                        if (chat.Contains(message2))
                        {
                                int index = chat.IndexOf(message2);
                                chat[index] = edited;
                        }
                        break;
                    case "Pin":
                        string currentMessage = commands[1];
                        if (chat.Contains(currentMessage))
                        {
                            chat.Remove(currentMessage);
                            chat.Add(currentMessage);
                        }
                        break;
                    case "Spam":
                        chat.AddRange(commands.Skip(1));
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(Environment.NewLine, chat));
        }
    }
}
