using System.Runtime.Serialization;

namespace MovieBookingApi.Execptions
{
    [Serializable]
    internal class DiscountNotElgibleExecption : Exception
    {
        public string message;
        public DiscountNotElgibleExecption()
        {
            message = "Discount not availalbe!";
        }

        public override string Message => message;
    }
}