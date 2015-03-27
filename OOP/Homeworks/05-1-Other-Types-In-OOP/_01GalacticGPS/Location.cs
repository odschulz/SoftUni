using System;


public struct Location
{
    private double latitude;
    private double longitude;
    private Planet planet;
    public Location(double latitude, double longitude, Planet planet) 
        : this()
    {
        this.Latitude = latitude;
        this.Longitude = longitude;
        this.Planet = planet;
    }
    public double Latitude 
    { 
        get { return this.latitude; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("Latitude cannot be 0 or negative number!");
            }
            this.latitude = value;
        } 
    }
    public double Longitude 
    {
        get { return this.longitude; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("Longitude cannot be 0 or negative number!");
            }
            this.longitude = value;
        } 
    }
    public Planet Planet 
    {
        get { return this.planet; }
        set
        {
            this.planet = value;
        }
    }

    public override string ToString()
    {
        return String.Format("{0}, {1} - {2}", this.Latitude, this.Longitude, this.Planet);
    }
}

