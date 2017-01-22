using ChartingSample.Models;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.UI.DataVisualization;
using Intersoft.Crosslight.ViewModels;
using System;
using System.Collections.ObjectModel;

namespace ChartingSample.ViewModels
{
    public class AxisPositionViewModel : AgileSprintStatusViewModel<ColumnSeries>
    {
        #region Methods

        protected override void InitializeChart()
        {
            base.InitializeChart();

            NumericAxis independentAxis = Axis.CreateDefaultIndependentAxis<NumericAxis>
                (o =>
                {
                    o.AxisPosition = AxisPositions.Right;
                });
            CategoryAxis dependentAxis = Axis.CreateDefaultDependentAxis<CategoryAxis>
                (o =>
                {
                    o.AxisPosition = AxisPositions.Top;
                });

            this.Chart.IndependentAxis = independentAxis;
            this.Chart.DependentAxis = dependentAxis;
        }

        #endregion
    }
}