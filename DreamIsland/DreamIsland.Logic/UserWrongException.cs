using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DreamIsland.Logic
{
    public class UserWrongException : Exception
    {
        public UserWrongException()
        {
        }

        public UserWrongException(string? message) : base(message)
        {
        }

        public UserWrongException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected UserWrongException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
