using System.Runtime.Serialization;

namespace MovieBookingApi.Execptions
{
    [Serializable]
    internal class AlreadyPaymentDoneExecption : Exception
    {
        public string message;
        public AlreadyPaymentDoneExecption()
        {
            message = "Already Payment done for this Booking!";
        }

        public override string Message => message;
    }
}