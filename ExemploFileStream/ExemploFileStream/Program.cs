using System;
using System.IO;

namespace ExemploFileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\leona\Documents\temp\file1.txt";

            StreamReader streamReader = null;

            try
            {
                streamReader = File.OpenText(path);

                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (streamReader != null) streamReader.Close();
            }
        }
    }
}
