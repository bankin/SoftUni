using System;

namespace TheatresManagement.Exceptions
{
    public class TheatreNotFoundException : Exception
    {
        public TheatreNotFoundException(string msg)
            : base(msg)
        {
        }
    }
}
