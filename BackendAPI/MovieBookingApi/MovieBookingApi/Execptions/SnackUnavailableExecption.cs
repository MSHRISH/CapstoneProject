using System.Runtime.Serialization;

namespace MovieBookingApi.Execptions
{
    [Serializable]
    internal class SnackUnavailableExecption : Exception
    {
        public string message;
        public SnackUnavailableExecption()
        {
            message = "Some snacks are not found or not available!";
        }
        public override string Message => message;

    }
}