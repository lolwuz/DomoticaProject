using ChartingSample.Models;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.UI.DataVisualization;
using Intersoft.Crosslight.ViewModels;
using System;
using System.Collections.ObjectModel;

namespace ChartingSample.ViewModels
{
    public class DateTimeAxisConfigurationViewModel : EmployeeAttendanceViewModel<LineSeries>
    {
        #region Methods

        protected override void InitializeChart()
        {
            base.InitializeChart();

            DateTimeAxis dependentAxis = Axis.CreateDefaultDependentAxis<DateTimeAxis>
                (o =>
                {
                    o.Maximum = new DateTime(2015, 1, 10);
                    o.Minimum = new DateTime(2014, 12, 31);
                    o.Interval = TimeSpan.FromDays(2);
                });

            this.Chart.DependentAxis = dependentAxis;
        }

        #endregion
    }
}