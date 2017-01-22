using ChartingSample.Models;
using Intersoft.Crosslight.Drawing;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.UI.DataVisualization;
using Intersoft.Crosslight.ViewModels;
using System;
using System.Collections.ObjectModel;

namespace ChartingSample.ViewModels
{
    public class DataAnnotationViewModel : EmployeeAttendanceViewModel<LineSeries>
    {
        #region Methods

        protected override void ResetSeries()
        {
            base.ResetSeries();
            this.Chart.Series[0].DataAnnotations.Add(new DataAnnotation("Company Trip", 50, new DateTime(2015, 1, 6), Colors.Blue));
        }


        protected override void InitializeChart()
        {
            base.InitializeChart();
            this.Chart.Series[0].DataAnnotations.Add(new DataAnnotation("Company Trip", 50, new DateTime(2015, 1, 6), Colors.Blue));
        }

        #endregion
    }
}