using ChartingSample.Models;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.UI.DataVisualization;
using Intersoft.Crosslight.ViewModels;
using System;

namespace ChartingSample.ViewModels
{
    public class ChartViewModelBase : ViewModelBase
    {
        #region Constructors

        public ChartViewModelBase()
        {
            this.ShowPresenterCommand = new DelegateCommand(this.ExecuteShowPresenter);
            this.InitializeChart();
        }

        #endregion

        #region Fields

        private Chart _chart;
        private DataManager _dataManager;

        #endregion

        #region Properties

        public DataManager DataManager
        {
            get
            {
                if (_dataManager == null)
                    _dataManager = DataManager.Instance;

                return _dataManager;
            }
        }

        public Chart Chart
        {
            get { return _chart; }
            set
            {
                _chart = value;
                OnPropertyChanged("Chart");
            }
        }

        public DelegateCommand ShowPresenterCommand { get; set; }

        #endregion

        #region Methods

        protected virtual void ExecuteShowPresenter(object parameter)
        {
            string[] actions = new string[]
                {
                    "Change Data",
                    "Add Series",
                    "Delete Series",
                    "Reset Series"
                };

            this.ActionPresenter.Show("Select Action", actions,
                                      (resultIndex) =>
                                      {
                                          if (resultIndex == 0)
                                              this.ChangeData();
                                          else if (resultIndex == 1)
                                              this.AddSeries();
                                          else if (resultIndex == 2)
                                              this.DeleteSeries();
                                          else if (resultIndex == 3)
                                              this.ResetSeries();

                                      });
        }

        protected virtual void InitializeChart()
        {
        }

        protected virtual void ResetSeries()
        {
        }

        protected virtual void AddSeries()
        {
        }

        protected virtual void DeleteSeries()
        {
            if (this.Chart.Series.Count > 1)
                this.Chart.Series.RemoveAt(this.Chart.Series.Count - 1);
        }

        protected virtual void ChangeData()
        {
            Random random = new Random();
            foreach (Series seriesData in this.Chart.Series)
            {
                foreach (DataPoint dataPoint in seriesData.Items)
                {
                    dataPoint.IndependentValue = random.Next(0, 100);
                }
            }
            this.Chart.RefreshDataPoint();
        }

        #endregion
    }

    public class ChartViewModelBase<TSeriesType> : ChartViewModelBase where TSeriesType : Series, new()
    {
        public Series CreateSeries()
        {
            return new TSeriesType();
        }
    }
}