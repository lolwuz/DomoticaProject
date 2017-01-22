using ChartingSample.Models;
using Intersoft.Crosslight.Drawing;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.UI.DataVisualization;
using Intersoft.Crosslight.ViewModels;
using System;
using System.Collections.ObjectModel;

namespace ChartingSample.ViewModels
{
    public class NumericAxisConfigurationViewModel : AgileSprintStatusViewModel<ColumnSeries>
    {
        #region Methods

        protected override void InitializeChart()
        {
            base.InitializeChart();

            NumericAxis independentAxis = Axis.CreateDefaultIndependentAxis<NumericAxis>
                (o =>
                {
                    o.Maximum = 100;
                    o.Minimum = 0;
                    o.Interval = 10;
                });

            this.Chart.IndependentAxis = independentAxis;
        }

        #endregion
    }
}