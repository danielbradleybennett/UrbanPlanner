using System;
using System.Collections.Generic;

namespace UrbanPlanner
{
  public class City
  {
    private string _mayor;
    private int _year;

    private string _cityName;

    public void ElectedMayor(string mayor)
    {
      _mayor = mayor;
    }

    // public void Description () {
    //   Console.WriteLine (this._cityName);
    //   Console.WriteLine ($"--------------");
    //   Console.WriteLine (this._mayor);
    //   Console.WriteLine (this._year);
    // }

    public List<Building> Buildings = new List<Building>();
    public void addBuilding(Building building)
    {
      Buildings.Add(building);
    }
    public City(string city, string mayor, int year)
    {

      _cityName = city;
      _mayor = mayor;
      _year = year;

    }
  }

}