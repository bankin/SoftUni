using System;

namespace TheatresManagement.Exceptions
{
    public class DuplicateTheatreException : Exception
    {
        public DuplicateTheatreException(string msg)
            : base(msg)
        {
        }
    }
}
