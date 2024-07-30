using System.Runtime.Serialization;

namespace MovieBookingApi.Execptions
{
    [Serializable]
    internal class NoSuchBookingFoundExecption : Exception
    {
        public string message;
        public NoSuchBookingFoundExecption()
        {
            message = "No Such Booking Found";
        }

        public override string Message => message;
    }
}