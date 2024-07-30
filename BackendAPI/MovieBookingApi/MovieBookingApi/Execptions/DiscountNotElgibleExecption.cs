using System.Runtime.Serialization;

namespace MovieBookingApi.Execptions
{
    [Serializable]
    internal class DiscountNotElgibleExecption : Exception
    {
        public string message;
        public DiscountNotElgibleExecption()
        {
            message = "You are eligible for the discount!";
        }

        public override string Message => message;
    }
}