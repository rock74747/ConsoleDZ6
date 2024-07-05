namespace ConsoleDZ6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            Team team = new Team();
            Console.WriteLine(team.Name);

            for (int i = 0; i < 11; i++)
            {
                team.woker[0].Build (house, team.leader, team.woker);
                Console.WriteLine($"{team.leader.report[i]}");

            }
            house.Paint(team.leader);
        }
    }
    
}
