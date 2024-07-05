using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDZ6
{
    public class Worker : IWorker
    {
        string Name { get; set; }
        public Worker (string name)
        { Name = name; }
        string IWorker.Name => Name;
        bool isWorking;

        public void Build (House house, TeamLeader leader, List<Worker> woker)
        {
            if (house.basement == null)
            {
                Basement basement = new Basement();
                basement.Builder(house);
                Console.WriteLine($"Worker {woker[0].Name} строит фундамент");
                leader.report.Add($"Worker {woker[0].Name}  построил фундамент");
                if (leader.report.Count == 1) woker[0].isWorking = false; else woker[0].isWorking = true;
            }

            else
            if (house.walls == null || house.walls.Count < 4) 
            {
                if (house.walls == null && woker[0].isWorking == false)
                { house.walls = new List<Walls>(); }
                Walls wall = new Walls();
                wall.Builder(house);
                Console.WriteLine($"Worker {woker[1].Name} строит {house.walls.Count}-ю стену");
                leader.report.Add($"Worker {woker[1].Name}  построил {house.walls.Count} стену ");
                if (leader.report.Count == 5) woker[1].isWorking = false; 
                else woker[1].isWorking = true;

            }
            else
                if (house.door == null && woker[1].isWorking == false)
            {
                Door door = new Door();
                door.Builder(house);
                Console.WriteLine($"Worker {woker[2].Name} строит дверь");
                leader.report.Add($"Worker {woker[2].Name} построил дверь");
                if (leader.report.Count == 6) woker[2].isWorking = false; 
                else woker[2].isWorking = true;

            }

            else
                if (house.window == null || house.window.Count < 4)
            {
                if (house.window == null && woker[2].isWorking == false)
                { house.window = new List<Windows>(); }
                Windows window = new Windows();
                window.Builder(house);
                Console.WriteLine($"Worker {woker[3].Name} строит {house.window.Count}-е окно");
                leader.report.Add($"Worker {woker[3].Name} построил  {house.window.Count} окно");
                if (leader.report.Count == 10) woker[3].isWorking = false;
                else woker[3].isWorking = true;
                    
            }

            else
                if (house.roof == null && woker[3].isWorking == false)
            {
                Roof roof = new Roof();
                roof.Builder(house);
                Console.WriteLine($"Worker {woker[4].Name} строит крышу");
                leader.report.Add($"Worker {woker[4].Name} построил крышу");
            }
        }
    }
}
