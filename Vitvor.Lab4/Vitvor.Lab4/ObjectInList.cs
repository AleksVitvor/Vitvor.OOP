using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.Lab4
{
    class ObjectInList
    {
        private string NameOfTeam;
        public string nameofteam
        {
            get
            {
                return NameOfTeam;
            }
        }
        private string NameOfCoach;
        public string nameofcoach
        {
            get
            {
                return NameOfCoach;
            }
        }
        private int _numbersOfPleyers;
        public int NumbersOfPlayers
        {
            get
            {
                return _numbersOfPleyers;
            }
            set
            {
                if (value > 0)
                    _numbersOfPleyers = value;
                else
                {
                    Console.WriteLine("Error, you should have one or more players");
                    _numbersOfPleyers = 1;
                }
            }
        }
        public ObjectInList()
        {
            Console.WriteLine("Enter team");
            NameOfTeam = Console.ReadLine();
            Console.WriteLine("Enter coach surname");
            NameOfCoach = Console.ReadLine();
            Console.WriteLine("Enter numbers of players");
            NumbersOfPlayers = Convert.ToInt32(Console.ReadLine());
        }
        public ObjectInList(string nameOfTeam, string nameOfCoach, int numbersOfPlayers)
        {
            NameOfTeam = nameOfTeam;
            NameOfCoach = nameOfCoach;
            NumbersOfPlayers = numbersOfPlayers;
        }
    }
}
