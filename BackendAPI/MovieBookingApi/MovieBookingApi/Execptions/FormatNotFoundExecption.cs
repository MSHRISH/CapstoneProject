using System.Runtime.Serialization;

namespace MovieBookingApi.Execptions
{
    [Serializable]
    internal class FormatNotFoundExecption : Exception
    {
        public string message;
        public FormatNotFoundExecption()
        {
            message = "No such Format Found!";
        }
        public override string Message => message;

    }
}