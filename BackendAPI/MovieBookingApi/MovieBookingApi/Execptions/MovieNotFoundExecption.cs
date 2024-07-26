using System.Runtime.Serialization;

namespace MovieBookingApi.Execptions
{
    [Serializable]
    internal class MovieNotFoundExecption : Exception
    {
        public string message;
        public MovieNotFoundExecption()
        {
            message = "Movie Not Found!";
        }
        public override string Message => message;
    }
}