using ChartingSample.Models;
using Intersoft.Crosslight.Drawing;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.UI.DataVisualization;
using Intersoft.Crosslight.ViewModels;
using System;
using System.Collections.ObjectModel;

namespace ChartingSample.ViewModels
{
    public class AlternatingDependentGridLinesViewModel : AgileSprintStatusViewModel<ColumnSeries>
    {
        #region Methods

        protected override void InitializeChart()
        {
            base.InitializeChart();

            CategoryAxis dependentAxis = Axis.CreateDefaultDependentAxis<CategoryAxis>(o => { o.IsAlternating = true; o.AlternatingRowColor = Colors.LightGray; });

            this.Chart.DependentAxis = dependentAxis;
        }

        #endregion
    }
}