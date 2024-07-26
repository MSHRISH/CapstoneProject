using System.Runtime.Serialization;

namespace MovieBookingApi.Execptions
{
    [Serializable]
    internal class CertificationNotFoundExecption : Exception
    {
        public string message;
        public CertificationNotFoundExecption()
        {
            message = "No such Certification found!";
        }
        public override string Message => message;
    }
}