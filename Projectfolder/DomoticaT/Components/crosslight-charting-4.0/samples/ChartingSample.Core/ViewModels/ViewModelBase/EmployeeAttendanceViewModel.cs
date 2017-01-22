using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.UI.DataVisualization;
using System;
using System.Collections.ObjectModel;

namespace ChartingSample.ViewModels
{
    public class EmployeeAttendanceViewModel<TSeriesType> : ChartViewModelBase<TSeriesType> where TSeriesType : Series,new()
    {
        #region Methods

        protected override void InitializeChart()
        {
            this.Chart = new Chart();
            this.Chart.Title.Text = "Employee Attendance 1-7 January 2015";
            this.Chart.Title.Font.FontSize = 16;

            Series series = this.CreateSeries();
            series.Title = "Los Angeles Branch";
            series.Items = this.DataManager.GetAttendanceDataBasedOnDateAndBranch("Los Angeles Branch", new DateTime(2015, 1, 1), new DateTime(2015, 1, 7));
            this.Chart.Series.Add(series);

            series = this.CreateSeries();
            series.Title = "New York Branch";
            series.Items = this.DataManager.GetAttendanceDataBasedOnDateAndBranch("New York Branch", new DateTime(2015, 1, 1), new DateTime(2015, 1, 7));
            this.Chart.Series.Add(series);

            NumericAxis independentAxis = Axis.CreateDefaultIndependentAxis<NumericAxis>();
            DateTimeAxis dependentAxis = Axis.CreateDefaultDependentAxis<DateTimeAxis>();

            this.Chart.IndependentAxis = independentAxis;
            this.Chart.DependentAxis = dependentAxis;
        }

        protected override void ResetSeries()
        {
            ObservableCollection<Series> seriesSource = new ObservableCollection<Series>();

            Series series = this.CreateSeries();
            series.Title = "Los Angeles Branch";
            series.Items = this.DataManager.GetAttendanceDataBasedOnDateAndBranch("Los Angeles Branch", new DateTime(2015, 1, 1), new DateTime(2015, 1, 7));
            seriesSource.Add(series);

            series = this.CreateSeries();
            series.Title = "New York Branch";
            series.Items = this.DataManager.GetAttendanceDataBasedOnDateAndBranch("New York Branch", new DateTime(2015, 1, 1), new DateTime(2015, 1, 7));
            seriesSource.Add(series);

            this.Chart.Series = seriesSource;
        }

        protected override void AddSeries()
        {
            Random random = new Random();
            if (this.Chart.Series.Count < 10)
            {
                Series series = new TSeriesType();
                series.Items.Add(new DataPoint(new DateTime(2015, 1, 1), random.Next(0, 100)));
                series.Items.Add(new DataPoint(new DateTime(2015, 1, 2), random.Next(0, 100)));
                series.Items.Add(new DataPoint(new DateTime(2015, 1, 3), random.Next(0, 100)));
                series.Items.Add(new DataPoint(new DateTime(2015, 1, 4), random.Next(0, 100)));
                series.Items.Add(new DataPoint(new DateTime(2015, 1, 5), random.Next(0, 100)));
                series.Items.Add(new DataPoint(new DateTime(2015, 1, 6), random.Next(0, 100)));
                series.Items.Add(new DataPoint(new DateTime(2015, 1, 7), random.Next(0, 100)));

                this.Chart.Series.Add(series);
            }
        }

        #endregion
    }
}