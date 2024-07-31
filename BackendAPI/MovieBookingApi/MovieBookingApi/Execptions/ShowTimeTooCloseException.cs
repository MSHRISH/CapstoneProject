using System.Runtime.Serialization;

namespace MovieBookingApi.Execptions
{
    [Serializable]
    internal class ShowTimeTooCloseException : Exception
    {
        public string message;
        public ShowTimeTooCloseException()
        {
            message = "Minimum time difference between two shows in a screen is 4 hours";
        }


        public override string Message => message;
    }
}