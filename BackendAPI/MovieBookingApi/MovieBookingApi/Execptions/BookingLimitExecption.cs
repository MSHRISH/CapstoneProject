using System.Runtime.Serialization;

namespace MovieBookingApi.Execptions
{
    [Serializable]
    internal class BookingLimitExecption : Exception
    {
        public string message;
        public BookingLimitExecption()
        {
            message = "Only Able to book 5 tickets in one booking";
        }

        public override string Message => message;
    }
}