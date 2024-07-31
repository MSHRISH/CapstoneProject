using System.Runtime.Serialization;

namespace MovieBookingApi.Execptions
{
    [Serializable]
    internal class EmailAlreadyExistExecption : Exception
    {
        public string message;
        public EmailAlreadyExistExecption()
        {
            message = "Email already Exists!";
        }
        public override string Message => message;

    }
}