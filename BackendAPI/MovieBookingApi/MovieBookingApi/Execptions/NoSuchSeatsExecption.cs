using System.Runtime.Serialization;

namespace MovieBookingApi.Execptions
{
    [Serializable]
    internal class NoSuchSeatsExecption : Exception
    {
        public string message;
        public NoSuchSeatsExecption()
        {
            message = "No such Seats are found!";
        }
        public override string Message => message;

    }
}