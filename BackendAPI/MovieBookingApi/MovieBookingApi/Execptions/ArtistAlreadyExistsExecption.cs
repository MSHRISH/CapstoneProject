using System.Runtime.Serialization;

namespace MovieBookingApi.Execptions
{
    [Serializable]
    internal class ArtistAlreadyExistsExecption : Exception
    {
        public string message;
        public ArtistAlreadyExistsExecption()
        {
            message = "Artist already exists";
        }
        public override string Message => message;
    }
}