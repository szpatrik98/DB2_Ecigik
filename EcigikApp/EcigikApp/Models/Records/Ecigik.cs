using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcigikApp.MyExceptions;

namespace EcigikApp.Models.Records
{
    class Ecigik
    {
        private string sorszam;
 
        public string Sorszam
        {
            set
            {
                if (value == null)
                {
                    throw new NullREcordExc();
                }
                else if(value.Length > 6)
                {
                    throw new TooMuchExc();
                }
                sorszam = value;
            }
            get
            {
                return sorszam;
            }
        }

        private string nev;

        public string Nev
        {
            set
            {
                if (value == null)
                {
                    throw new NullREcordExc("Null");
                }
                else if (value.Length > 15)
                {
                    throw new TooMuchExc("Much");
                }
                nev = value;
            }
            get
            {
                return nev;
            }
        }

        private string szin;
        public string Szin
        {
            set
            {
                if (value == null)
                {
                    throw  new NullREcordExc("Null");
                }
                else if (value.Length > 17)
                {
                    throw new TooMuchExc("Much");
                }
                szin = value;
            }
            get
            {
                return szin;
            }
        }
        private string gyarto;

        public string Gyarto
        {
            set
            {
                if (value == null)
                {
                    throw new NullREcordExc("Null");
                }
                else if (value.Length > 17)
                {
                    throw new TooMuchExc("Much");
                }
                gyarto = value;
            }
            get
            {
                return gyarto;
            }
        }
    }
}
