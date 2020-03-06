using System;

namespace UrbanPlanner {
  // Define class here
  public class Building {

    // Private Fields
    private string _address;
    private DateTime _dateConstructed;

    private string _owner;

    private string _designer = "The Graevs";

    // Public Fields
    public int Stories { get; set; }

    public double Width { get; set; }

    public double Depth { get; set; }

    // Method
    public double Volume {
      get {
        return Width * Depth * 3 * Stories;
      }
    }

    public void Construct ()

    {
      _dateConstructed = DateTime.Now;
    }
    public void Purchase (string owner) {
      _owner = owner;

    }

    public void Description () {

      Console.WriteLine (this._address);
      Console.WriteLine ($"---------------------");
      Console.WriteLine ($"Designed by {this._designer}");
      Console.WriteLine ($"Constructed on {this._dateConstructed}");
      Console.WriteLine ($"Owned by {this._owner}");
      Console.WriteLine ($"{this.Volume} cubic meters of space");
      Console.WriteLine ("");

    }

    // Constructor
    public Building (string address, double width, double depth, int stories) {

      _address = address;
      Width = width;
      Depth = depth;
      Stories = stories;
    }
  }
}