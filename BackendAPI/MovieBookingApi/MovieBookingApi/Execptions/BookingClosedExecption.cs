using System.Runtime.Serialization;

namespace MovieBookingApi.Execptions
{
    [Serializable]
    internal class BookingClosedExecption : Exception
    {
        public string message;
        public BookingClosedExecption()
        {
            message = "Booking is Closed!!";
        }

        public override string Message => message;
    }
}