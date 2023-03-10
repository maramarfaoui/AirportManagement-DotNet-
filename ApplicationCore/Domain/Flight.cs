using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Domain
{
    public class Flight
    {
        public int Id { get; set; }
        [ForeignKey("Plane")]
        public int PlaneFK { get; set; }
        public string Destination { get; set; }
        public string Departure { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightId { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int EstimatedDuration { get; set; }

        public Plane Plane { get; set; }
        public string AirlineLogo { get; set; }
        public ICollection<Passenger> Passengers { get; set; }
        public int Key { get; internal set; }

        public override string ToString()
        {
            return this.FlightId + " " + this.Destination + " " + this.EstimatedDuration;
        }
    }
}
