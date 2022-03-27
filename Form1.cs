using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace LotkaVolterraOdeSimulation
{
      public partial class Form1 : Form
      {
            private LotkaVolterraOde lotkaVolterraOde;

            private bool isChartAlreadyDisplayed = false;
            public Form1()
            {

                  InitializeComponent();

                  InitializeLocalComponents();

                  Timer.Interval = 60;
                  Timer.Tick += chart1_Click;
                  Timer.Start();
            }

            private void InitializeLocalComponents()
            {
                  lotkaVolterraOde = new LotkaVolterraOde();
                  chart1.Series[0].ChartType = SeriesChartType.Line;
                  chart1.Series[0].IsValueShownAsLabel = true;
                  chart1.Series[1].ChartType = SeriesChartType.Line;
                  chart1.Series[1].IsValueShownAsLabel = true;

/*                  chart1.Series[0].SmartLabelStyle.CalloutLineAnchorCapStyle = LineAnchorCapStyle.None;
*/
                  lotkaVolterraOde.LVOde();
            }

            private void chart1_Click(object sender, EventArgs e)
            {
                  ShowInLineChart();
            }

            private void ShowInLineChart()
            {
                  if (isChartAlreadyDisplayed)
                  {
                        return;
                  }
                  if (lotkaVolterraOde.isCalculationDone)
                  {
                        List<double> rPreys = lotkaVolterraOde.LVPreyOde();
                        List<double> rPredators = lotkaVolterraOde.LVPredatorOde();

                        for (int i =0; i< rPreys.Count(); i++)
                        {
                        chart1.Series[0].Points.AddXY(lotkaVolterraOde.iteration[i], rPreys[i]);
                        chart1.Series[1].Points.AddXY(lotkaVolterraOde.iteration[i], rPredators[i]);
                        }

                        isChartAlreadyDisplayed = true;
                  }
            }
      }
}
