using System;
using System.IO;
using System.Text;

namespace stringbuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = @"This is a test paragraph
for test purposes please don't use it
for real reasons in proper applications";

            string line;

            StringReader sr = new StringReader(text);
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }

            // append Test string to text
            StringBuilder sb = new StringBuilder(text);
            sb.AppendLine("Test string");
            Console.WriteLine(sb.ToString());

            // append Testtttt to sb.ToString()
            StringWriter sw = new StringWriter(sb);
            sw.Write("Testtttt");
            Console.WriteLine(sw.ToString());
        }
    }
}
