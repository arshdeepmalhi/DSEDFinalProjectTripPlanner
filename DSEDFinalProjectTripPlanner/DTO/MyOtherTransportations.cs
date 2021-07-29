using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSEDFinalProjectTripPlanner.DTO
{
    public class MyOtherTransportations
    {
        // Description of Transporation used during the trip
        public int Id { get; set; }//Primary key
        public string TypeOfTransport { get; set; }//Type of transport
        public string CarrierName { get; set; }//CarrierName
        public string ConfirmationNumber { get; set; }//Confirmationm Number
        public string DepartureAddress { get; set; }//Departure address
        public string DepartureSuburb { get; set; }//Departure suburb
        public string DepartureCity { get; set; }//Departure city
        public string DepartureRegion { get; set; }//Deprature region
        public string DeparturePostcode { get; set; }//Deprature postcode
        public string DepartureCountry { get; set; }//Deprature country
        public DateTime DepartureDate { get; set; }//departure date
        public DateTime DepartureTime { get; set; }//departure time
        public DateTime ArrivalDate { get; set; }//Arrival date
        public DateTime ArrivalTime { get; set; }//Arrival time
        public string ArrivalAddress { get; set; }//Arrival Address
        public string ArrivalSuburb { get; set; }//Arrival Suburb
        public string ArrivalCity { get; set; }//Arrival city
        public string ArrivalRegion { get; set; }//Arrival Region
        public string ArrivalPostcode { get; set; }//Arrival postcode
        public string ArrivalCountry { get; set; }//ArrivalCountry
        public int TripId { get; set; }//TripID
    }
}
