namespace api.Models
{
    public class FarmerMarketEvent
    {
        public int FMEventID {get; set;}
        public string FMDate {get; set;}
        public string FMLocation {get; set;}
        public string FMAttendees {get; set;}
        public double FMTotalRevenue {get; set;}

        public FarmerMarketEvent()
        {
            
        }
    }
}