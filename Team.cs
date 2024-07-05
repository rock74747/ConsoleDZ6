using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDZ6
{
    public class Team : IWorker
    {
        public TeamLeader leader;
        public List<Worker> woker;
       
        public Team()
        {
            leader = new TeamLeader("Prorab");
            woker = [new Worker("Slava"), new Worker("Ivan"), new Worker("Sergey"), new Worker("Petr"),
            new Worker("Bomzh")];
        }

        public string Name  { get => "Бригада строителей № 1"; }
}
    
}
