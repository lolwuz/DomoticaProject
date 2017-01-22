using ChartingSample.Models;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.UI.DataVisualization;
using Intersoft.Crosslight.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace ChartingSample.ViewModels
{
    public class AreaFillStyleViewModel : AgileSprintStatusViewModel<SmoothAreaSeries>
    {
        #region Properties

        private int ColorIndex { get; set; }

        #endregion

        #region Constructors

        public AreaFillStyleViewModel()
        {
            this.ColorIndex = 1;
        }

        #endregion

        #region Methods

        protected override void ExecuteShowPresenter(object parameter)
        {
            string[] actions = new string[]
                {
                    "Change Color",
                    "Change FillStyle",
                    "Change Palette",
                    "Change Data",
                    "Reset Series"
                };

            this.ActionPresenter.Show("Select Action", actions,
                                      (resultIndex) =>
                                      {
                                          if (resultIndex == 0)
                                              this.ChangeColor();
                                          else if (resultIndex == 1)
                                              this.ChangeFillStyle();
                                          else if (resultIndex == 2)
                                              this.ChangePalette();
                                          else if (resultIndex == 3)
                                              this.ChangeData();
                                          else if (resultIndex == 4)
                                              this.ResetSeries();

                                      });
        }

        private void ChangeColor()
        {
            if (this.ColorIndex < 10)
                this.ColorIndex++;
            else
                this.ColorIndex = 1;

            this.Chart.ColorPalette.PaletteOrderSequence = this.ColorIndex.ToString();
            this.Chart.Refresh();
        }

        private void ChangeFillStyle()
        {
            foreach (SmoothAreaSeries series in this.Chart.Series.OfType<SmoothAreaSeries>())
            {
                if (series.FillStyle == AreaFillStyle.Gradient)
                    series.FillStyle = AreaFillStyle.GradientTransparent;
                else if (series.FillStyle == AreaFillStyle.GradientTransparent)
                    series.FillStyle = AreaFillStyle.Flat;
                else if (series.FillStyle == AreaFillStyle.Flat)
                    series.FillStyle = AreaFillStyle.Gradient;
            }

            SmoothAreaSeries columnSeries = this.Chart.Series.OfType<SmoothAreaSeries>().FirstOrDefault();
            if (columnSeries != null)
            {
                if (columnSeries.FillStyle == AreaFillStyle.Gradient)
                    this.ToastPresenter.Show("Gradient", ToastDisplayDuration.Short);
                if (columnSeries.FillStyle == AreaFillStyle.GradientTransparent)
                    this.ToastPresenter.Show("Gradient Transparent", ToastDisplayDuration.Short);
                if (columnSeries.FillStyle == AreaFillStyle.Flat)
                    this.ToastPresenter.Show("Flat", ToastDisplayDuration.Short);
            }

            this.Chart.Refresh();
        }

        private void ChangePalette()
        {
            if (this.Chart.ColorPalette.Palette == PaletteTypes.Default)
                this.Chart.ColorPalette.Palette = PaletteTypes.EarthColor;
            else if (this.Chart.ColorPalette.Palette == PaletteTypes.EarthColor)
                this.Chart.ColorPalette.Palette = PaletteTypes.Pastel;
            else if (this.Chart.ColorPalette.Palette == PaletteTypes.Pastel)
                this.Chart.ColorPalette.Palette = PaletteTypes.Vivid;
            else if (this.Chart.ColorPalette.Palette == PaletteTypes.Vivid)
                this.Chart.ColorPalette.Palette = PaletteTypes.Default;

            if (this.Chart.ColorPalette.Palette == PaletteTypes.Default)
                this.ToastPresenter.Show("Default", ToastDisplayDuration.Short);
            if (this.Chart.ColorPalette.Palette == PaletteTypes.EarthColor)
                this.ToastPresenter.Show("Earth Color", ToastDisplayDuration.Short);
            if (this.Chart.ColorPalette.Palette == PaletteTypes.Pastel)
                this.ToastPresenter.Show("Pastel", ToastDisplayDuration.Short);
            if (this.Chart.ColorPalette.Palette == PaletteTypes.Vivid)
                this.ToastPresenter.Show("Vivid", ToastDisplayDuration.Short);

            this.Chart.Refresh();
        }

        protected override void InitializeChart()
        {
            base.InitializeChart();
            this.Chart.ColorPalette.PaletteOrder = PaletteOrders.Custom;
            this.Chart.ColorPalette.PaletteOrderSequence = "1";
        }

        #endregion
    }
}