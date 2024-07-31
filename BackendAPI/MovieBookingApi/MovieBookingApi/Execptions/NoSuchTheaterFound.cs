using System.Runtime.Serialization;

namespace MovieBookingApi.Execptions
{
    [Serializable]
    internal class NoSuchTheaterFound : Exception
    {
        public string message;
        public NoSuchTheaterFound()
        {
            message = "No Such Theater Exists";
        }
        public override string Message => message;

    }
}