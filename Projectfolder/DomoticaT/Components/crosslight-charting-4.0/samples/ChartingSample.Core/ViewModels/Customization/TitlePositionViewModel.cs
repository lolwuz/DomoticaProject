using Intersoft.Crosslight.UI.DataVisualization;

namespace ChartingSample.ViewModels
{
    public class TitlePositionViewModel : AgileSprintStatusViewModel<ColumnSeries>
    {
        #region Methods

        protected override void ExecuteShowPresenter(object parameter)
        {
            string[] actions = new string[]
                {
                    "Change Position",
                    "Change Data",
                    "Add Series",
                    "Delete Series",
                    "Reset Series"
                };

            this.ActionPresenter.Show("Select Action", actions,
                                      (resultIndex) =>
                                      {
                                          if (resultIndex == 0)
                                              this.ChangePosition();
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
     
        private void ChangePosition()
        {
            if(this.Chart.Title.Position == Positions.Top)
                this.Chart.Title.Position = Positions.Right;
            else if (this.Chart.Title.Position == Positions.Right)
                this.Chart.Title.Position = Positions.Bottom;
            else if (this.Chart.Title.Position == Positions.Bottom)
                this.Chart.Title.Position = Positions.Left;
            else if (this.Chart.Title.Position == Positions.Left)
                this.Chart.Title.Position = Positions.Top;

            this.Chart.Refresh();
        }

        #endregion
    }
}