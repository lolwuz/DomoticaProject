using ChartingSample.Models;
using Intersoft.Crosslight.Drawing;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.UI.DataVisualization;
using Intersoft.Crosslight.ViewModels;
using System;
using System.Collections.ObjectModel;

namespace ChartingSample.ViewModels
{
    public class AdditionalNumericGridLinesViewModel : AgileSprintStatusViewModel<ColumnSeries>
    {
        #region Methods

        protected override void InitializeChart()
        {
            base.InitializeChart();

            NumericAxis independentAxis = Axis.CreateDefaultIndependentAxis<NumericAxis>
                (o => 
                {
                    o.AdditionalGridLines.Add(new GridLine() { StartValue = 0, EndValue = 25,Color = Colors.Red});
                    o.AdditionalGridLines.Add(new GridLine() { StartValue = 25, EndValue = 100, Color = Colors.Green });
                });

            this.Chart.IndependentAxis = independentAxis;
        }

        #endregion
    }
}