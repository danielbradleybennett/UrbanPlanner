using System;

namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            City Nashville = new City("Nashville", "John Cooper", 1806);
            City Nachtmar = new City("Nashville", "John Cooper", 1806);

            Building FiveOneTwoEigth = new Building("512 8th Avenue", 1000, 3000, 4);
            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Purchase("Steve Brownlee");

            Building OneTwoThree = new Building("90 8th Avenue", 10000, 2000, 10);
            OneTwoThree.Construct();
            OneTwoThree.Purchase("Steve Grey");

            Building FourFiveSix = new Building("218 8th Avenue", 4000, 2100, 14);
            FourFiveSix.Construct();
            FourFiveSix.Purchase("Mikael Brownlee");

            // FiveOneTwoEigth.Description ();
            // OneTwoThree.Description ();
            // FourFiveSix.Description ();

            Nashville.addBuilding(FourFiveSix);
            Nashville.addBuilding(OneTwoThree);
            Nachtmar.addBuilding(FiveOneTwoEigth);

            foreach (Building building in Nashville.Buildings)
            {
                building.Description();
            }

        }

    }
}