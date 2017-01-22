using ChartingSample.Models;
using Intersoft.Crosslight.Drawing;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.UI.DataVisualization;
using Intersoft.Crosslight.ViewModels;
using System;
using System.Collections.ObjectModel;

namespace ChartingSample.ViewModels
{
    public class AxisAppearanceViewModel : AgileSprintStatusViewModel<ColumnSeries>
    {
        #region Methods

        protected override void InitializeChart()
        {
            base.InitializeChart();

            NumericAxis independentAxis = Axis.CreateDefaultIndependentAxis<NumericAxis>
                (o =>
                {
                    o.GridLinesColor = Colors.Green;
                    o.IsTickVisible = true;
                    o.IsLineVisible = true;
                    o.TickColor = Colors.Blue;
                    o.Title.Text = "Count";
                    o.Title.Margin = new Thickness(0, 0, 10, 0);
                    o.Title.Font = new Font("Helvetica Neue,16;Roboto,16");
                    o.Font = new Font("Helvetica Neue,12,Bold,#FF0000;Roboto,12,Bold,#FF0000");
                });
            CategoryAxis dependentAxis = Axis.CreateDefaultDependentAxis<CategoryAxis>
                (o =>
                {
                    o.IsGridLinesVisible = true;
                    o.IsTickVisible = true;
                    o.GridLinesColor = Colors.Blue;
                    o.IsTickVisible = true;
                    o.TickColor = Colors.Green;
                    o.Title.Text = "Category";
                    o.Title.Margin = new Thickness(0, 10, 0, 0);
                    o.Title.Font = new Font("Helvetica Neue,16;Roboto,16");
                    o.Font = new Font("Helvetica Neue,12,Italic,#0000FF;Roboto,12,Italic,#0000FF");
                });

            this.Chart.IndependentAxis = independentAxis;
            this.Chart.DependentAxis = dependentAxis;
        }

        #endregion
    }
}