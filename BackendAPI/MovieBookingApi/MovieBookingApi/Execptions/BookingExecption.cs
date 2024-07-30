using System.Runtime.Serialization;

namespace MovieBookingApi.Execptions
{
    [Serializable]
    internal class BookingExecption : Exception
    {
        public string message;
        public BookingExecption()
        {
            message = "Something went wrong try again!";
        }

        public override string Message => message;
    }
}