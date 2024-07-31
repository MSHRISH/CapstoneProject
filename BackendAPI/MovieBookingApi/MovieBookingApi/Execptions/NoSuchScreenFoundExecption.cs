using System.Runtime.Serialization;

namespace MovieBookingApi.Execptions
{
    [Serializable]
    internal class NoSuchScreenFoundExecption : Exception
    {
        public string message;
        public NoSuchScreenFoundExecption()
        {
            message = "No such screen Found";
        }

        public override string Message => message;
    }
}