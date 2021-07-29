using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSEDFinalProjectTripPlanner.DTO
{
    public class Trips
    {
        // represent the information of trip planing
        public int Id { get; set; }//Primary key
        public string Name { get; set; }//Name
        public string DestinationCity { get; set; }//Destination City
        public string DestinationCountry { get; set; }//Destination country
        public DateTime StartDate { get; set; }//Start date
        public DateTime FinishDate { get; set; }//Finish date
        public string Description { get; set; }//Description
    }
}
