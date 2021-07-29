using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSEDFinalProjectTripPlanner.DTO
{
    public class MyRestaurants
    {
        // Represent the detail of restsurant for reservation
        public int Id { get; set; }//Primary key
        public string RestaurantName { get; set; }//ReasturantName
        public string Address { get; set; }//Address
        public string Suburb { get; set; }//Suburb
        public string City { get; set; }//City
        public string Region { get; set; }//Region
        public string Postcode { get; set; }//Postcode
        public string Country { get; set; }//Country
        public string Description { get; set; }//Description
        public DateTime Date { get; set; }//Date
        public DateTime Time { get; set; }//Time
        public string Cuisine { get; set; }//Cuisine
        public int NumberInParty { get; set; }//NumberIn Party
        public string ConfirmationNumber { get; set; }//Confirmation Number
        public string HoursOfOperation { get; set; }//Hours of operatiomn 
        public string DressCode { get; set; }//DressCode
        public string PriceRange { get; set; }//Price range
        public int TripId { get; set; }//Trip Id
    }
}
