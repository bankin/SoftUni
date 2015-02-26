using System;

namespace TheatresManagement.Exceptions
{
    public class TimeDurationOverlapException : Exception
    {
        public TimeDurationOverlapException(string msg)
            : base(msg)
        {
        }
    }
}
