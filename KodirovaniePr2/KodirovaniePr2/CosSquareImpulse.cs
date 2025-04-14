using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodirovaniePr2
{
    internal class CosSquareImpulse : Impulse
    {
        public CosSquareImpulse()
        {
            A = 100;
            Tu1 = 50;
            Tu2 = 50;
            DeltaN = 0;
        }

        public byte[] ImpulseCoordinations()
        {
            int j = 0;
            int middle = Tu / 2;

            for (int i = 0 + DeltaN; i < 512; i++)
            {
                if (i < DeltaN) impulseCords[i] = 0;
                else if (j < Tu)
                {
                    impulseCords[i] = PointCordination(j);
                    j++;
                }
                else impulseCords[i] = 0;
            }

            j = 0;
            for (int i = 512 + DeltaN; i < 1024; i++)
            {
                if (i < DeltaN) impulseCords[i] = 0;
                else if (j < Tu)
                {
                    impulseCords[i] = PointCordination(j);
                    j++;
                }
                else impulseCords[i] = 0;
            }

            return impulseCords;
        }

        private byte PointCordination(int t)
        {
            if (t >= 0 && t <= Tu)
                return (byte)Math.Round(A * Math.Cos((t - Tu / 2) * Math.PI / Tu));
            else
                return 0;
        }
    }
}
