using System.Runtime.Serialization;

namespace MovieBookingApi.Execptions
{
    [Serializable]
    internal class ShowNotFoundExecption : Exception
    {
        public string message;
        public ShowNotFoundExecption()
        {
            message = "No Such Show Found!";
        }

        public override string Message => message;
    }
}