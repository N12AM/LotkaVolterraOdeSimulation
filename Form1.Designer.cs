
namespace LotkaVolterraOdeSimulation
{
      partial class Form1
      {
            /// <summary>
            /// Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;

            /// <summary>
            /// Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            protected override void Dispose(bool disposing)
            {
                  if (disposing && (components != null))
                  {
                        components.Dispose();
                  }
                  base.Dispose(disposing);
            }

            #region Windows Form Designer generated code

            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
                  this.components = new System.ComponentModel.Container();
                  System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
                  System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
                  System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
                  System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
                  this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
                  this.Timer = new System.Windows.Forms.Timer(this.components);
                  ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
                  this.SuspendLayout();
                  // 
                  // chart1
                  // 
                  chartArea1.Name = "ChartArea1";
                  this.chart1.ChartAreas.Add(chartArea1);
                  legend1.Name = "Legend1";
                  this.chart1.Legends.Add(legend1);
                  this.chart1.Location = new System.Drawing.Point(0, 0);
                  this.chart1.Name = "chart1";
                  series1.BorderWidth = 10;
                  series1.ChartArea = "ChartArea1";
                  series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                  series1.IsVisibleInLegend = false;
                  series1.LabelBorderWidth = 0;
                  series1.Legend = "Legend1";
                  series1.MarkerBorderWidth = 0;
                  series1.Name = "Prey";
                  series1.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.No;
                  series1.SmartLabelStyle.CalloutLineAnchorCapStyle = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.None;
                  series1.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.Transparent;
                  series1.SmartLabelStyle.CalloutLineWidth = 0;
                  series1.SmartLabelStyle.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.LabelCalloutStyle.None;
                  series2.BorderWidth = 10;
                  series2.ChartArea = "ChartArea1";
                  series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                  series2.LabelBorderWidth = 5;
                  series2.Legend = "Legend1";
                  series2.MarkerBorderWidth = 0;
                  series2.Name = "Predator";
                  this.chart1.Series.Add(series1);
                  this.chart1.Series.Add(series2);
                  this.chart1.Size = new System.Drawing.Size(1920, 1080);
                  this.chart1.TabIndex = 0;
                  this.chart1.Text = "chart1";
                  this.chart1.Click += new System.EventHandler(this.chart1_Click);
                  // 
                  // Form1
                  // 
                  this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                  this.ClientSize = new System.Drawing.Size(1904, 1041);
                  this.Controls.Add(this.chart1);
                  this.MaximizeBox = false;
                  this.Name = "Form1";
                  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                  this.Text = "Form1";
                  this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                  ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
                  this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
            private System.Windows.Forms.Timer Timer;
      }
}

