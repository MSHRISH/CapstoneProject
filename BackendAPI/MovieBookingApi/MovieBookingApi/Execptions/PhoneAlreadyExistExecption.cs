using System.Runtime.Serialization;

namespace MovieBookingApi.Execptions
{
    [Serializable]
    internal class PhoneAlreadyExistExecption : Exception
    {
        public string message;
        public PhoneAlreadyExistExecption()
        {
            message = "Phone Number Already Exists";
        }
        public override string Message => message;


    }
}