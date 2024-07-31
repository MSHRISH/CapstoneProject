using System.Runtime.Serialization;

namespace MovieBookingApi.Execptions
{
    [Serializable]
    internal class ImporperShowTimeExecption : Exception
    {
        public string message;
        public ImporperShowTimeExecption()
        {
            message = "Added Show must be atleast 30mins past the current time";
        }
        public override string Message => message;
    }
}