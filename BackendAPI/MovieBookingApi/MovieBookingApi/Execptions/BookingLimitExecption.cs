﻿using System.Runtime.Serialization;

namespace MovieBookingApi.Execptions
{
    [Serializable]
    internal class BookingLimitExecption : Exception
    {
        public string message;
        public BookingLimitExecption()
        {
            message = "Minimum 1 ticket and maximum 5 tickets are allowed";
        }

        public override string Message => message;
    }
}