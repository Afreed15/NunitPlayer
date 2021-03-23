using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConTestingPlayers
{
    class Program
    {
        public static List<pla> PList()
        {
            List<pla> plist = new List<pla>
            {
                new pla{PlayerId=1,PlayerName="Rohit",PlayerTeam="MI"},
                new pla{PlayerId=2,PlayerName="",PlayerTeam="MI"},
                
            };

            return plist;
        }
     
        static void Main(string[] args)
        {
            
        }
    }
}
