using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSEDFinalProjectTripPlanner.DTO
{
    public class MyFlights
    {
        // Tells the all details of flight 
        public int Id { get; set; }//Primary key
        public string ConfirmationNumber { get; set; }//Confirmation number
        public string Airline { get; set; }//Airline
        public string FlightNumber { get; set; }//Flight Number
        public DateTime DepartureDate { get; set; }//Departure Date
        public DateTime DepartureTime { get; set; }//Deprature time
        public string DepartureFrom { get; set; }//Departure From
        public string DepartureTerminal { get; set; }//Departure Terminal
        public string DepartureGate { get; set; }//Departure gate
        public DateTime ArrivalDate { get; set; }//Arrival date
        public DateTime ArrivalTime { get; set; }//Arrival time
        public string ArrivalTo { get; set; }//Arrival to
        public string ArrivalTerminal { get; set; }//Arrival Terminal
        public string ArrivalGate { get; set; }//Arrival gate
        public string Seats { get; set; }//Seats
        public int TripId { get; set; }//TripId
    }
}
