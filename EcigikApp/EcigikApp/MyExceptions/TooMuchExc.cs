using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcigikApp.MyExceptions
{
    class TooMuchExc : Exception
    {
        public TooMuchExc()
        {
        }

        public TooMuchExc(string message)
            : base(message)
        {
            throw new NotImplementedException();
        }
    }
}
