using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Xml;
using VoteCount.Entities;

namespace VoteCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> voters = new Dictionary<string, int>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int voteQuantity = int.Parse(line[1]);

                        Voters voter = new Voters(name, voteQuantity);

                        if (voters.ContainsKey(voter.Name))
                        {
                            voters[voter.Name] += voter.VoteQuantity;
                        }
                        else
                        {
                            voters.Add(voter.Name, voter.VoteQuantity);
                        }
                    }

                    foreach (var item in voters)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
