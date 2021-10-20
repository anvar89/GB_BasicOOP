using System;
using System.IO;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            GetMailList("List.txt", "");
        }

        public static void GetMailList(string source, string target)
        {
            string sourceText = File.ReadAllText(source);
            string targetText = string.Empty;
            string[] mailList = sourceText.Split("&"); // поскольку по заданию нужны только адреса эл. почты

            for (int i = 0; i < mailList.Length; i++)
            {
                SearchMail(ref mailList[i]);

                if (mailList[i].Length == 0) continue;

                targetText += mailList[i] + "\n";
            }

            File.WriteAllText(target + "mailList.txt", targetText);
        }

        public static void SearchMail(ref string s)
        {
            string[] arr = s.Split(" ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Contains("@"))
                {
                    s = arr[i];
                    return;
                }
            }
            s = string.Empty;
        }
    }
}
