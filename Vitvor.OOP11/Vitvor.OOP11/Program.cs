using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.OOP11
{
    class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }
    }
    class Team
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] summerwinter = { "June", "July", "August", "December", "January", "February" };
            Console.WriteLine("Введите длину названия месяца");
            int length = Convert.ToInt32(Console.ReadLine());
            string[] mounths = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            IEnumerable<string> evens = from i in mounths where i.Length == length select i;
            Console.WriteLine("Месяцы с заданной длиной названия");
            foreach (string i in evens)
                Console.WriteLine(i);
            IEnumerable<string> subset = from g in mounths where g.Contains("u") && g.Length >= 4 orderby g select g;
            Console.WriteLine("Месяцы в алфавитном порядке, содержащие u и названием длиной не менее 4");
            foreach (string g in subset)
                Console.WriteLine(g);
            IEnumerable<string> vs = from h in mounths where (summerwinter.Contains(h)) select h;
            Console.WriteLine("Только летние и зимние месяцы");
            foreach (string h in vs)
                Console.WriteLine(h);
            Date date = new Date(11, 10, 2018);
            Date date1 = new Date(16, 03, 2019);
            Date date2 = new Date(28, 11, 2017);
            Date date3 = new Date(29, 11, 2019);
            Date date4 = new Date(11, 11, 2019); 
            List<Date> dates = new List<Date>();
            dates.Add(date4);
            dates.Add(date1);
            dates.Add(date2);
            dates.Add(date3);
            dates.Add(date);
            Console.WriteLine("Введите год для поиска");
            int year = Convert.ToInt32(Console.ReadLine());
            IEnumerable<Date> dates1 = from d in dates where d.Year == year select d;
            Console.WriteLine("Даты искомого года");
            foreach (Date d in dates1)
                Console.WriteLine(d.ToString());
            Console.WriteLine("Введите месяц для поиска");
            int mounth = Convert.ToInt32(Console.ReadLine());
            IEnumerable<Date> dates2 = from d in dates where d.Mounth == mounth select d;
            Console.WriteLine("Даты искомого месяца");
            foreach (Date d in dates2)
                Console.WriteLine(d.ToString());
            Console.WriteLine("Введите начальную дату");
            Date startdate = new Date();
            Console.WriteLine("Введите конечную дату");
            Date enddate = new Date();
            IEnumerable<Date> dates3 = from q in dates where startdate.CompareTo(q) == 1 && enddate.CompareTo(q) == 0 select q;
            Console.WriteLine("Даты из заданного диапазона");
            foreach (Date q in dates3)
                Console.WriteLine(q.ToString());
            IEnumerable<Date> dates4 = from w in dates orderby w.Year, w.Mounth, w.Day  select w;
            Console.WriteLine("Даты в хронологическом порядке");
            foreach (Date w in dates4)
                Console.WriteLine(w.ToString());
            Console.WriteLine("Максимальная дата");
            Console.WriteLine(dates4.Last().ToString());
            Console.WriteLine("Введите искомый день");
            int day = Convert.ToInt32(Console.ReadLine());
            IEnumerable<Date> dates6 = from r in dates where r.Day == day select r;
            Console.WriteLine(dates6.First().ToString());
            List<Team> teams = new List<Team>()
            {
                new Team{Name="Арсенал", Country ="Англия"},
                new Team{Name="Ливерпуль", Country ="Англия"}

            };
            List<Player> players = new List<Player>()
            {

                new Player{Name="Salah", Team="Ливерпуль" },
                new Player{Name="Saka", Team="Арсенал" },

            };
            var result = from pl in players join t in teams on pl.Team equals t.Name select new { Name = pl.Name, Team = pl.Team, Country = t.Country };
            foreach(var item in result)
            {
                Console.WriteLine($"{item.Name} - {item.Team}, {item.Country}");
            }
            Console.ReadLine();
        }
    }
}
