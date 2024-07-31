using System.Runtime.Serialization;

namespace MovieBookingApi.Execptions
{
    [Serializable]
    internal class NoSuchMemberTypeExecption : Exception
    {
        public string message;
        public NoSuchMemberTypeExecption()
        {
            message = "No such Membertype Found!";
        }

        public override string Message => message;
    }
}