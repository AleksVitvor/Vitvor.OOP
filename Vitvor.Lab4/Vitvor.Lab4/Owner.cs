using System;

namespace Vitvor.Lab4
{
    class Owner
    {
        public string _Name { get; set; }
        public string _Organization { get; set; }
        public readonly int _ID;

        public Owner(string Name, string Organization)
        {
            Random random = new Random();
            _Name = Name;
            _Organization = Organization;
            _ID = (int)(Math.PI * Math.E * random.Next(0, 111));
        }
    }
}
