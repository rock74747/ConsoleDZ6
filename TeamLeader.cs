using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDZ6
{

    public class TeamLeader : IWorker
    {
        string Name { get; set; }
        public TeamLeader(string name)
        { Name = name; }
        string IWorker.Name => Name;
        public List<string> report = new List<string>();
    }
}
