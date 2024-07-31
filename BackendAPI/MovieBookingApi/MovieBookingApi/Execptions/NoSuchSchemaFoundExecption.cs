using System.Runtime.Serialization;

namespace MovieBookingApi.Execptions
{
    [Serializable]
    internal class NoSuchSchemaFoundExecption : Exception
    {
        public string message;
        public NoSuchSchemaFoundExecption()
        {
            message = "No such Schema Found";
        }
        public override string Message => message;
    }
}