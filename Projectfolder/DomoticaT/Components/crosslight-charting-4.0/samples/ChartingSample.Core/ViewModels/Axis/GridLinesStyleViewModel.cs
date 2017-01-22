using ChartingSample.Models;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.UI.DataVisualization;
using Intersoft.Crosslight.ViewModels;
using System;
using System.Collections.ObjectModel;

namespace ChartingSample.ViewModels
{
    public class GridLinesStyleViewModel : AgileSprintStatusViewModel<ColumnSeries>
    {
        #region Properties

        private GridLinesStyles GridLinesStyle { get; set; }

        #endregion

        #region Constructors

        public GridLinesStyleViewModel()
        {
            this.GridLinesStyle = GridLinesStyles.Dotted;
        }

        #endregion

        #region Methods

        protected override void ExecuteShowPresenter(object parameter)
        {
            string[] actions = new string[]
                {
                    "Change GridLines Style",
                    "Change Data",
                    "Add Series",
                    "Delete Series",
                    "Reset Series"
                };

            this.ActionPresenter.Show("Select Action", actions,
                                      (resultIndex) =>
                                      {
                                          if (resultIndex == 0)
                                              this.ChangeGridLinesStyle();
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

        private void ChangeGridLinesStyle()
        {
            if (this.GridLinesStyle == GridLinesStyles.Dotted)
            {
                this.GridLinesStyle = GridLinesStyles.Dash;
                this.ToastPresenter.Show("Dash", ToastDisplayDuration.Short);
            }
            else if (this.GridLinesStyle == GridLinesStyles.Dash)
            {
                this.GridLinesStyle = GridLinesStyles.Solid;
                this.ToastPresenter.Show("Solid", ToastDisplayDuration.Short);
            }
            else
            {
                this.GridLinesStyle = GridLinesStyles.Dotted;
                this.ToastPresenter.Show("Dotted", ToastDisplayDuration.Short);
            }

            NumericAxis independentAxis = Axis.CreateDefaultIndependentAxis<NumericAxis>
               (o =>
               {
                   o.GridLinesStyle = this.GridLinesStyle;
               });

            this.Chart.IndependentAxis = independentAxis;
            this.Chart.Refresh();
        }

        #endregion
    }
}