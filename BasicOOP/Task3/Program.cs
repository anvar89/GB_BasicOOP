using System;
using System.IO;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void GetMailList(string source, string target)
        {
            string sourceText = File.ReadAllText(source);
            string targetText = string.Empty;
            string[] mailList = sourceText.Split("&");

            for (int i = 0; i < mailList.Length; i++)
            {
                SearchMail(ref mailList[i]);
                targetText += mailList[i] + "\n";
            }

            File.WriteAllText(target + @"\mailList.txt", targetText);
        }

        public static void SearchMail(ref string s)
        {
            string[] arr = s.Split(" ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Contains("@"))
                {
                    s = arr[i];
                    break;
                }
            }
            s = string.Empty;
        }
    }
}
