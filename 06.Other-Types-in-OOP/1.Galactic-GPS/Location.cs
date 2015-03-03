using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Galactic_GPS
{
    public struct Location
    {
        private double latitude;
        private double longitude;
        private Planet planet;
        public Location(double latitude, double longitude, Planet planet) : this()
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
                if(value.Equals(null))
                {
                    throw new ArgumentNullException("Value can not be empty!");
                }
                this.latitude = value;
            }
        }
        public double Longitude
        {
            get { return this.latitude; }
            set
            {
                if (value.Equals(null))
                {
                    throw new ArgumentNullException("Value can not be empty!");
                }
                this.latitude = value;
            }
        }
        public Planet Planet { get; set; }
        public override string ToString()
        {
            return String.Format("{0}, {1} - {2}", this.Latitude, this.Longitude, this.Planet);
        }
    }
}
