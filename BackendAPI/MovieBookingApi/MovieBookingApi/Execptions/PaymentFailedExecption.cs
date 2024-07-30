using System.Runtime.Serialization;

namespace MovieBookingApi.Execptions
{
    [Serializable]
    internal class PaymentFailedExecption : Exception
    {
        public string message;
        public PaymentFailedExecption()
        {
            message = "Error Payment Failed!";
        }
        public override string Message => message;

    }
}