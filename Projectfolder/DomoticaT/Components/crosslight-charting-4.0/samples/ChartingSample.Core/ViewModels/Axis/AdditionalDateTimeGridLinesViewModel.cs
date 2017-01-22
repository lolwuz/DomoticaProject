using ChartingSample.Models;
using Intersoft.Crosslight.Drawing;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.UI.DataVisualization;
using Intersoft.Crosslight.ViewModels;
using System;
using System.Collections.ObjectModel;

namespace ChartingSample.ViewModels
{
    public class AdditionalDateTimeGridLinesViewModel : EmployeeAttendanceViewModel<LineSeries>
    {
        #region Methods

        protected override void InitializeChart()
        {
            base.InitializeChart();

            DateTimeAxis dependentAxis = Axis.CreateDefaultDependentAxis<DateTimeAxis>
                (o=>
                    {
                        o.AdditionalGridLines.Add(new GridLine() { StartValue = new DateTime(2015, 1, 1), EndValue = new DateTime(2015, 1, 2), Color = Colors.Red });
                        o.AdditionalGridLines.Add(new GridLine() { StartValue = new DateTime(2015, 1, 2), EndValue = new DateTime(2015, 1, 3), Color = Colors.Green });
                    }
                );

            this.Chart.DependentAxis = dependentAxis;
        }

        #endregion
    }
}