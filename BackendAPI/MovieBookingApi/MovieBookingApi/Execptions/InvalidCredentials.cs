using System.Runtime.Serialization;

namespace MovieBookingApi.Execptions
{
    [Serializable]
    internal class InvalidCredentials : Exception
    {
        public string message;
        public InvalidCredentials()
        {
            message = "Invalid Password or Email";
        }
        public override string Message => message;
    }
}