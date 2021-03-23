using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConTestingPlayers
{[TestFixture]
    class Players
    {
        [Test]
        public void PlayerTest()
        {
            foreach (var Player in Program.PList())
            {
                Assert.IsNotNull(Player.PlayerId);
                Assert.IsNotEmpty(Player.PlayerName);
                Assert. IsNotEmpty(Player.PlayerTeam);



            }
        }

    }
}
