using System.Runtime.Serialization;

namespace MovieBookingApi.Execptions
{
    [Serializable]
    internal class ScreenNameAlreadyExistsExecption : Exception
    {
        public string message;
        public ScreenNameAlreadyExistsExecption()
        {
            message = "Screen Name Already exists";
        }

        public override string Message => message;
    }
}