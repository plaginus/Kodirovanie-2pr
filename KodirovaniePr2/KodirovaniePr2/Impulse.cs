using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodirovaniePr2
{
    public abstract class Impulse
    {
        private byte a;
        public byte A
        {
            get
            {
                return a;
            }
            set
            {
                if (value > 255) a = 255;
                else a = value;
            }
        }

        private byte tu = 10;
        public byte Tu
        {
            get
            {
                return tu;
            }
        }

        private byte tu1 = 5;
        public byte Tu1
        {
            get
            {
                return tu1;
            }
            set
            {
                if (value > 127) tu1 = 127;
                else if (value < 5) tu1 = 5;
                else tu1 = value;
                tu = (byte)(tu1 + tu2);
            }
        }

        private byte tu2 = 5;
        public byte Tu2
        {
            get
            {
                return tu2;
            }
            set
            {
                if (value > 127) tu2 = 127;
                else if (value < 5) tu2 = 5;
                else tu2 = value;
                tu = (byte)(tu1 + tu2);
            }
        }

        private byte deltaN;
        public byte DeltaN
        {
            get { return deltaN; }
            set
            {
                if (value > 255) deltaN = 255;
                else deltaN = value;
            }
        }

        protected byte[] impulseCords = new byte[1024];
    }
}
