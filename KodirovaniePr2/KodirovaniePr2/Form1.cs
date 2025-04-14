using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System.Reflection;

namespace KodirovaniePr2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ViewImpulse();
        }

        private TringleImpulse trImpulse1 = new TringleImpulse();

        private CosSquareImpulse cSImpulse = new CosSquareImpulse();
        private void amplitude_ValueChanged(object sender, EventArgs e)
        {
            trImpulse1.A = (byte)amplitude.Value;
            cSImpulse.A = (byte)amplitude.Value;

            ViewImpulse();
        }

        private void tau1_ValueChanged(object sender, EventArgs e)
        {
            trImpulse1.Tu1 = (byte)tau1.Value;
            cSImpulse.Tu1 = (byte)tau1.Value;

            ViewImpulse();
        }

        private void tau2_ValueChanged(object sender, EventArgs e)
        {
            trImpulse1.Tu2 = (byte)tau2.Value;
            cSImpulse.Tu2 = (byte)tau2.Value;

            ViewImpulse();
        }

        private void deltaN_ValueChanged(object sender, EventArgs e)
        {
            trImpulse1.DeltaN = (byte)deltaN.Value;
            cSImpulse.DeltaN = (byte)deltaN.Value;

            ViewImpulse();
        }

        private void ViewImpulse()
        {
            var modelTr = new PlotModel { Title = "Треугольный импульс" };
            var modelcS = new PlotModel { Title = "Косинусквадратный импульс" };

            AreaSeries seriesTr = new AreaSeries();
            AreaSeries seriescS = new AreaSeries();

            DiagBilder(ref seriesTr, trImpulse1.ImpulseCoordinations());
            DiagBilder(ref seriescS, cSImpulse.ImpulseCoordinations());

            modelTr.Series.Add(seriesTr);
            modelcS.Series.Add(seriescS);

            plotView1.Model = modelTr;
            plotView2.Model = modelcS;
        }

        private void DiagBilder(ref AreaSeries series, byte[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                series.Points.Add(new DataPoint(i, arr[i]));
            }
        }
    }
}
