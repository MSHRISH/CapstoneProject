using System.Runtime.Serialization;

namespace MovieBookingApi.Execptions
{
    [Serializable]
    internal class RegistrationFailedExecption : Exception
    {
        public string message;
        public RegistrationFailedExecption()
        {
            message = "Registration Failed";
        }
        public override string Message => message;
    }
}