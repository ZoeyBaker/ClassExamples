using System;

namespace ClassesEx
{
    class Program
    {
        static void Main(string[] args)
        {

            static void Main(string[] args)

            {

                var orlandoTeam = new Team();
                orlandoTeam.City = "Orlando";

                var chicagoTeam = new Team();
                chicagoTeam.City = "Chi town";

            }

            
        }
    }

    internal class Team
    {
        public Team()
        {
        }

        public string City { get; internal set; }
    }
}
