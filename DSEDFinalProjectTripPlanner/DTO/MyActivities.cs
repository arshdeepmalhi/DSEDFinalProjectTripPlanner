using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSEDFinalProjectTripPlanner.DTO
{
    public class MyActivities
    {
        //Represent where the activity is performed 
        public int Id { get; set; }//Primary Key
        public string TypeOfActivity { get; set; }//Type of Activity
        public string ConfirmationNumber { get; set; }//Confirmation Number
        public string SupplierName { get; set; }//SupplierName
        public string Description { get; set; }//Description
        public DateTime StartDate { get; set; }//Start date
        public DateTime StartTime { get; set; }//Startatime
        public DateTime EndDate { get; set; }//EndDate
        public DateTime EndTime { get; set; }//EndTime
        public string Address { get; set; }//ASddress
        public string Suburb { get; set; }//Suburb
        public string City { get; set; }//City
        public string Region { get; set; }//Region
        public string Postcode { get; set; }//Postcode
        public string Country { get; set; }//Country
        public int NumOfPeopleAttending { get; set; }//Number of people
        public int TripId { get; set; }//Trip ID
    }
}
