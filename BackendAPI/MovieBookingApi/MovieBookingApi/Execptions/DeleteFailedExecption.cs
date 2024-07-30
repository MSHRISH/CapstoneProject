using System.Runtime.Serialization;

namespace MovieBookingApi.Execptions
{
    [Serializable]
    internal class DeleteFailedExecption : Exception
    {
        public string message;
        public DeleteFailedExecption()
        {
            message = "Delete Operation Failed";
        }
        public override string Message => message;


    }
}