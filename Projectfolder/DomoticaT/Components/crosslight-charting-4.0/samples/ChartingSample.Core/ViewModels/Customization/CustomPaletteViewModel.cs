using ChartingSample.Models;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.UI.DataVisualization;
using Intersoft.Crosslight.ViewModels;
using System;
using System.Collections.ObjectModel;

namespace ChartingSample.ViewModels
{
    public class CustomPaletteViewModel : AgileSprintStatusViewModel<ColumnSeries>
    {
        #region Methods

        protected override void InitializeChart()
        {
            base.InitializeChart();

            this.Chart.ColorPalette.Palette = PaletteTypes.Custom;
            this.Chart.ColorPalette.CustomPaletteName = "Default";
            this.Chart.ColorPalette.CustomPalette.Add(this.GenerateCustomPalette());
            this.Chart.ColorPalette.PaletteOrder = PaletteOrders.Custom;
            this.Chart.ColorPalette.PaletteOrderSequence="1,2,3,0";
        }

        private Palette GenerateCustomPalette()
        {
            Palette customPalette=new Palette();

            customPalette.Name = "Default";
            SolidColor solidColor = new SolidColor();

            solidColor = new SolidColor();
            solidColor.Color = Intersoft.Crosslight.Drawing.Color.FromArgb(255, 255,0,0);
            customPalette.Resources.Add(new PaletteResources(solidColor));

            solidColor = new SolidColor();
            solidColor.Color = Intersoft.Crosslight.Drawing.Color.FromArgb(255, 0,255,0);
            customPalette.Resources.Add(new PaletteResources(solidColor));

            solidColor = new SolidColor();
            solidColor.Color = Intersoft.Crosslight.Drawing.Color.FromArgb(255, 0,0,255);
            customPalette.Resources.Add(new PaletteResources(solidColor));

            return customPalette;
        }

        #endregion
    }
}