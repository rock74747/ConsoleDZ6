using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDZ6
{
    public class House
    {
        public Basement basement;
        public List<Walls> walls;
        public List<Windows> window;
        public Door door;
        public Roof roof;

        public void Paint(TeamLeader leader)
        {
            if (leader.report.Count == 11)
            {
                string Dom = @"
                                /\
                               /  \
                              /    \
                             /______\
                             |  __  |
                             | |__| |
                           __|______|__
                          |____________|
";
                Console.WriteLine(Dom);
            }
        }
    }
}
