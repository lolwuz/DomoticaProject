using ChartingSample.Models;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Drawing;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.UI.DataVisualization;
using Intersoft.Crosslight.ViewModels;
using System;
using System.Collections.ObjectModel;

namespace ChartingSample.ViewModels
{
    public class NumericAxisNumberFormatViewModel : PopulationCountViewModel<StepLineSeries>
    {
        #region Methods

        protected override void ExecuteShowPresenter(object parameter)
        {
            string[] actions = new string[]
                {
                    "Change Number Format",
                    "Change Data",
                    "Add Series",
                    "Delete Series",
                    "Reset Series"
                };

            this.ActionPresenter.Show("Select Action", actions,
                                      (resultIndex) =>
                                      {
                                          if (resultIndex == 0)
                                              this.ChangeNumericFormat();
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

        private void ChangeNumericFormat()
        {
            if (((NumericAxis)this.Chart.IndependentAxis).NumberFormat == "#,##0,,M")
                ((NumericAxis)this.Chart.IndependentAxis).NumberFormat = "#,##0,K";
            else if (((NumericAxis)this.Chart.IndependentAxis).NumberFormat == "#,##0,K")
                ((NumericAxis)this.Chart.IndependentAxis).NumberFormat = "#,#";
            else if (((NumericAxis)this.Chart.IndependentAxis).NumberFormat == "#,#")
                ((NumericAxis)this.Chart.IndependentAxis).NumberFormat = "#,##0,,M";

            this.Chart.Refresh();
        }

        protected override void InitializeChart()
        {
            base.InitializeChart();

            NumericAxis independentAxis = Axis.CreateDefaultIndependentAxis<NumericAxis>
                (o =>
                {
                    o.NumberFormat = "#,##0,,M";
                });

            this.Chart.IndependentAxis = independentAxis;

        }

        #endregion
    }
}