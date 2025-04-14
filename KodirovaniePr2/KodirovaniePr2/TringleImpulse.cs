namespace KodirovaniePr2
{
    internal class TringleImpulse : Impulse
    {
        public TringleImpulse()
        {
            A = 100;
            Tu1 = 50;
            Tu2 = 50;
            DeltaN = 0;
        }

        public byte[] ImpulseCoordinations()
        {
            int j = 0;
            for (int i = 0 + DeltaN; i < 1024; i++)
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
            if (t < 0 || t > Tu) return 0;
            else if (t >= 0 && t <= Tu1) return (byte)Math.Round((double)A * t / Tu1);
            else return (byte)Math.Round(A * (1 - ((t - Tu1) / (double)(Tu2))));

        }
    }
}
