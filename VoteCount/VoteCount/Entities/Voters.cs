using System;
using System.Collections.Generic;
using System.Text;

namespace VoteCount.Entities
{
    class Voters
    {
        public string Name { get; set; }
        public int VoteQuantity { get; set; }

        public Voters(string name, int voteQuantity)
        {
            Name = name;
            VoteQuantity = voteQuantity;
        }
    }
}
