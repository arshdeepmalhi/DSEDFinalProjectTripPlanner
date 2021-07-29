using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSEDFinalProjectTripPlanner.DTO
{
    public class MyCarRentals
    { 
        // Represent the Car information for the purpose of rent
        public int Id { get; set; }//Primary key
        public string SuppplierName { get; set; }//Supplier Name
        public string ConfirmationNumber { get; set; }//Confirmation Number
        public string PickupName { get; set; }//Pickup Name
        public string PickupAddress { get; set; }//Pickup Address
        public string PickupSuburb { get; set; }//Pickup Suburb
        public string PickupCity { get; set; }// Pickup City
        public string PickupRegion { get; set; }// Pickup Region
        public string PickupPostcode { get; set;}//Pickup Postcode
        public string PickupCountry { get; set; }//Pickup Country
        public string DropoffAddress { get; set; }//DropOff Address
        public string DropoffSuburb { get; set; }// Dropoff Suburb
        public string DropoffCity { get; set; }//Dropoff City
        public string DropoffRegion { get; set; }//Dropoff Region
        public string DropoffPostcode { get; set; }//Dropoff Postcode
        public string DropoffCountry { get; set; }//Dropoff Country
        public DateTime PickupDate { get; set; }//Pickup date
        public DateTime PickupTime { get; set; }//Pickup time
        public DateTime DropoffDate { get; set; }//Dropoff date
        public DateTime DropoffTime { get; set; }//Dropoff time
        public string SupplierPhoneNumber { get; set; }//Supplier Phone number
        public int TripId { get; set; }//Trip Id
        public bool DropoffCheckbox { get; set; }//Drop off Checkbox
        public int Door { get; set; }//Door
        public int Seats { get; set; }//Seats
        public string Transmission { get; set; }//Transmission
        public int LargeBag { get; set; }//LargeBag
        public int SmallBag { get; set; }//SmallBag
        public int Litres { get; set; }//Litres
    }
}
