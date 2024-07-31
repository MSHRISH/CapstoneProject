using System.Runtime.Serialization;

namespace MovieBookingApi.Execptions
{
    [Serializable]
    internal class TheaterAlreadyExistsExecption : Exception
    {
        public string message;
        public TheaterAlreadyExistsExecption()
        {
            message = "Theater Already Exists";
        }

        public override string Message => message;
    }
}