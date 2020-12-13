using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcigikApp.MyExceptions
{
    class NullREcordExc : Exception
    {
        public NullREcordExc()
        {
        }

        public NullREcordExc(string message)
            : base(message)
        {
           throw new NotImplementedException();
        }


    }
}
