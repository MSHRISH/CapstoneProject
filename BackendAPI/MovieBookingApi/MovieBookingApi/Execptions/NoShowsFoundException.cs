using System.Runtime.Serialization;

namespace MovieBookingApi.Execptions
{
    [Serializable]
    internal class NoShowsFoundException : Exception
    {
        public string message;
        public NoShowsFoundException()
        {
            message = "No such Shows Found";
        }
        public override string Message => message;

    }
}