using System.Runtime.Serialization;

namespace MovieBookingApi.Execptions
{
    [Serializable]
    internal class LanguageNotFoundExecption : Exception
    {
        public string message;
        public LanguageNotFoundExecption()
        {
            message = "No Such Language Found";
        }
        public override string Message => message;

    }
}