using System.Runtime.Serialization;

namespace MovieBookingApi.Execptions
{
    [Serializable]
    internal class MovieNotAddedExecption : Exception
    {
        public string message;
        public MovieNotAddedExecption()
        {
            message = "Unexpected Error. Movie not added try again.";
        }
        public override string Message => message;

    }
}