using System.Runtime.Serialization;

namespace MovieBookingApi.Execptions
{
    [Serializable]
    internal class NoSuchUserFoundExecption : Exception
    {
        public string message;
        public NoSuchUserFoundExecption()
        {
            message = "No Such User Found";
        }
        public override string Message => message;

    }
}