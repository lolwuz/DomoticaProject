using ChartingSample.Models;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.UI.DataVisualization;
using Intersoft.Crosslight.ViewModels;
using System;
using System.Collections.ObjectModel;

namespace ChartingSample.ViewModels
{
    public class DateTimeAxisDateFormatViewModel : EmployeeAttendanceViewModel<LineSeries>
    {
        #region Methods

        protected override void ExecuteShowPresenter(object parameter)
        {
            string[] actions = new string[]
                {
                    "Change Date Format",
                    "Change Data",
                    "Add Series",
                    "Delete Series",
                    "Reset Series"
                };

            this.ActionPresenter.Show("Select Action", actions,
                                      (resultIndex) =>
                                      {
                                          if (resultIndex == 0)
                                              this.ChangeDateFormat();
                                          else if (resultIndex == 1)
                                              this.ChangeData();
                                          else if (resultIndex == 2)
                                              this.AddSeries();
                                          else if (resultIndex == 3)
                                              this.DeleteSeries();
                                          else if (resultIndex == 4)
                                              this.ResetSeries();

                                      });
        }

        private void ChangeDateFormat()
        {
            if (((DateTimeAxis)this.Chart.DependentAxis).DateFormat == "dd-MM-yyyy")
                ((DateTimeAxis)this.Chart.DependentAxis).DateFormat = "dd-MMMM-yyyy";
            else if (((DateTimeAxis)this.Chart.DependentAxis).DateFormat == "dd-MMMM-yyyy")
                ((DateTimeAxis)this.Chart.DependentAxis).DateFormat = "dd-MMM-yyyy";
            else if (((DateTimeAxis)this.Chart.DependentAxis).DateFormat == "dd-MMM-yyyy")
                ((DateTimeAxis)this.Chart.DependentAxis).DateFormat = "dd-MM-yyyy";

            this.Chart.Refresh();
        }

        #endregion
    }
}