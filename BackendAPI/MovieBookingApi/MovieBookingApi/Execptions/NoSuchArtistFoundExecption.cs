using System.Runtime.Serialization;

namespace MovieBookingApi.Execptions
{
    [Serializable]
    internal class NoSuchArtistFoundExecption : Exception
    {
        public string message;
        public NoSuchArtistFoundExecption()
        {
            message = "No such Artist Found";
        }
        public override string Message => message;


    }
}