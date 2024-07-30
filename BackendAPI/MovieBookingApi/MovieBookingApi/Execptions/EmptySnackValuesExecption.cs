using System.Runtime.Serialization;

namespace MovieBookingApi.Execptions
{
    [Serializable]
    internal class EmptySnackValuesExecption : Exception
    {
        public string message;
        public EmptySnackValuesExecption()
        {
            message = "Empty Quantity for snacks is not allowed";
        }
        public override string Message => message;

    }
}