using ChartingSample.Models;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.UI.DataVisualization;
using Intersoft.Crosslight.ViewModels;
using System;
using System.Collections.ObjectModel;

namespace ChartingSample.ViewModels
{
    public class ZoomConfigurationViewModel : AgileSprintStatusViewModel<ColumnSeries>
    {
        #region Methods

        protected override void ExecuteShowPresenter(object parameter)
        {
            string[] actions = new string[]
                {
                    "Toggle Zoom",
                    "Change Zoom Mode",
                    "Change Maximum Zoom Scale",
                    "Change Double Tap Mode"
                };

            this.ActionPresenter.Show("Select Action", actions,
                                      (resultIndex) =>
                                      {
                                          if (resultIndex == 0)
                                              this.ToggleZoom();
                                          else if (resultIndex == 1)
                                              this.ChangeZoomMode();
                                          else if (resultIndex == 2)
                                              this.ChangeMaximumZoomScale();
                                          else if (resultIndex == 3)
                                              this.ChangeDoubleTapMode();

                                      });
        }

        private void ToggleZoom()
        {
            if (this.Chart.EnableZoom)
            {
                this.Chart.EnableZoom = false;
                this.ToastPresenter.Show("Zoom Disabled", ToastDisplayDuration.Short);
            }
            else
            {
                this.Chart.EnableZoom = true;
                this.ToastPresenter.Show("Zoom Enabled", ToastDisplayDuration.Short);
            }

            this.Chart.Refresh();

        }

        private void ChangeZoomMode()
        {
            if(this.Chart.ZoomMode == ZoomModes.Both)
            {
                this.Chart.ZoomMode = ZoomModes.X;
                this.ToastPresenter.Show("Zoom Mode : X", ToastDisplayDuration.Short);
            }
            else if (this.Chart.ZoomMode == ZoomModes.X)
            {
                this.Chart.ZoomMode = ZoomModes.Y;
                this.ToastPresenter.Show("Zoom Mode : Y", ToastDisplayDuration.Short);
            }
            else if (this.Chart.ZoomMode == ZoomModes.Y)
            {
                this.Chart.ZoomMode = ZoomModes.Both;
                this.ToastPresenter.Show("Zoom Mode : Both", ToastDisplayDuration.Short);
            }

            this.Chart.Refresh();
        }

        private void ChangeMaximumZoomScale()
        {
            if(this.Chart.MaximumZoomScale == 5)
            {
                this.Chart.MaximumZoomScale = 2;
                this.ToastPresenter.Show("Maximum Zoom Scale : 2", ToastDisplayDuration.Short);
            }
            else
            {
                this.Chart.MaximumZoomScale = 5;
                this.ToastPresenter.Show("Maximum Zoom Scale : 5", ToastDisplayDuration.Short);
            }
            this.Chart.Refresh();
        }

        private void ChangeDoubleTapMode()
        {
            if (this.Chart.DoubleTapMode == DoubleTapModes.ZoomInZoomOut)
            {
                this.Chart.DoubleTapMode = DoubleTapModes.ZoomUntilMax;
                this.ToastPresenter.Show("Double Tap Mode: Zoom Until Max", ToastDisplayDuration.Short);
            }
            else
            {
                this.Chart.DoubleTapMode = DoubleTapModes.ZoomInZoomOut;
                this.ToastPresenter.Show("Double Tap Mode: Zoom In Zoom Out", ToastDisplayDuration.Short);
            }
            this.Chart.Refresh();
        }

        #endregion
    }
}