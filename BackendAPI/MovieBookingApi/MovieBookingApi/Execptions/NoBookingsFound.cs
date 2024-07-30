using System.Runtime.Serialization;

namespace MovieBookingApi.Execptions
{
    [Serializable]
    internal class NoBookingsFound : Exception
    {
        public string message;
        public NoBookingsFound()
        {
            message = "No Such Booking Found";
        }
        public override string Message => message;
       
    }
}