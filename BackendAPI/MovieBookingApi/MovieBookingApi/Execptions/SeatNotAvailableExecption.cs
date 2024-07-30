using System.Runtime.Serialization;

namespace MovieBookingApi.Execptions
{
    [Serializable]
    internal class SeatNotAvailableExecption : Exception
    {
        public string message;
        public SeatNotAvailableExecption()
        {
            message = "Some Seats are Not Available!!";
        }
        public override string Message => message;

    }
}