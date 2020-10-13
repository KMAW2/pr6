// 3 ВАРИАНТ

using System;

namespace pr6
{
    class Program
    {
        static void Main()
        {
            ResearchTeam team=new ResearchTeam();
            Console.WriteLine(team.ToShortString());

            Console.WriteLine(team[TimeFrame.Long]);
            Console.WriteLine(team[TimeFrame.TwoYears]);
            Console.WriteLine(team[TimeFrame.Year]);

            team.List=new Paper[3];

            team.List[0]= new Paper("publicat-1", new Person(), new DateTime(1887, 6, 1)); 
            Console.WriteLine(team.ToString());

            Paper[] papers = new Paper[2];
            papers[0] = new Paper("publicat-2", new Person(), new DateTime(1888, 7, 10));
            papers[1] = new Paper("publicat-3", new Person(), new DateTime(1889, 8, 21));
            team.AddPapers(papers);

            Console.WriteLine(team.ToString());

            Console.WriteLine(team.lastdate);
        }
    }
}
