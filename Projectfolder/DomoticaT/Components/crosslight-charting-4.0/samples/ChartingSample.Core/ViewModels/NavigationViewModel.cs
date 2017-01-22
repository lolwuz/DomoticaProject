using Intersoft.Crosslight;
using Intersoft.Crosslight.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace ChartingSample.ViewModels
{
    public class NavigationViewModel : ListViewModelBase<NavigationItem>
    {
        #region Constructors

        public NavigationViewModel()
        {
            List<NavigationItem> items = new List<NavigationItem>();

            items.Add(new NavigationItem("Downtime Statistics", "Reference Sample", typeof(ReferenceSample2ViewModel)));
            items.Add(new NavigationItem("Website Activities", "Reference Sample", typeof(ReferenceSampleViewModel)));

            items.Add(new NavigationItem("Doughnut ", "Series Type", typeof(DoughnutViewModel)));
            items.Add(new NavigationItem("Pie ", "Series Type", typeof(PieViewModel)));
            items.Add(new NavigationItem("Column ", "Series Type", typeof(ColumnViewModel)));
            items.Add(new NavigationItem("Bar ", "Series Type", typeof(BarViewModel)));
			items.Add(new NavigationItem("Line ", "Series Type", typeof(LineViewModel)));
			items.Add(new NavigationItem("Area ", "Series Type", typeof(AreaViewModel)));
            items.Add(new NavigationItem("Smooth Line ", "Series Type", typeof(SmoothLineViewModel)));
            items.Add(new NavigationItem("Step Line ", "Series Type", typeof(StepLineViewModel)));
            items.Add(new NavigationItem("Step Area ", "Series Type", typeof(StepAreaViewModel)));
            items.Add(new NavigationItem("Smooth Area ", "Series Type", typeof(SmoothAreaViewModel)));
			items.Add(new NavigationItem("Scatter ", "Series Type", typeof(ScatterViewModel)));
			items.Add(new NavigationItem("Stacked Column ", "Series Type", typeof(StackedColumnViewModel)));
            items.Add(new NavigationItem("Stacked 100 Column ", "Series Type", typeof(Stacked100ColumnViewModel)));
            items.Add(new NavigationItem("Stacked Bar ", "Series Type", typeof(StackedBarViewModel)));
            items.Add(new NavigationItem("Stacked 100 Bar ", "Series Type", typeof(Stacked100BarViewModel)));
            items.Add(new NavigationItem("Stacked Line ", "Series Type", typeof(StackedLineViewModel)));
            items.Add(new NavigationItem("Stacked 100 Line ", "Series Type", typeof(Stacked100LineViewModel)));
            items.Add(new NavigationItem("Stacked Area ", "Series Type", typeof(StackedAreaViewModel)));
            items.Add(new NavigationItem("Stacked 100 Area ", "Series Type", typeof(Stacked100AreaViewModel)));

            items.Add(new NavigationItem("Column and Smooth Line", "Multiple Series", typeof(ColumnAndLineViewModel)));

            items.Add(new NavigationItem("Numeric Axis ", "Axis", typeof(NumericAxisViewModel)));
            items.Add(new NavigationItem("Category Axis ", "Axis", typeof(CategoryAxisViewModel)));
            items.Add(new NavigationItem("DateTime Axis ", "Axis", typeof(DateTimeAxisViewModel)));
            items.Add(new NavigationItem("Numeric Axis NumberFormat ", "Axis", typeof(NumericAxisNumberFormatViewModel)));
            items.Add(new NavigationItem("DateTime Axis DateFormat ", "Axis", typeof(DateTimeAxisDateFormatViewModel)));
            items.Add(new NavigationItem("Alternating Independent GridLines", "Axis", typeof(AlternatingIndependentGridLinesViewModel)));
            items.Add(new NavigationItem("Alternating Dependent GridLines", "Axis", typeof(AlternatingDependentGridLinesViewModel)));
            items.Add(new NavigationItem("Additional Numeric GridLines", "Axis", typeof(AdditionalNumericGridLinesViewModel)));
            items.Add(new NavigationItem("Additional DateTime GridLines", "Axis", typeof(AdditionalDateTimeGridLinesViewModel)));
            items.Add(new NavigationItem("Axis Position", "Axis", typeof(AxisPositionViewModel)));
            items.Add(new NavigationItem("Axis Appearance", "Axis", typeof(AxisAppearanceViewModel)));
            items.Add(new NavigationItem("Numeric Axis Configuration", "Axis", typeof(NumericAxisConfigurationViewModel)));
            items.Add(new NavigationItem("DateTime Axis Configuration", "Axis", typeof(DateTimeAxisConfigurationViewModel)));
            items.Add(new NavigationItem("GridLines Style", "Axis", typeof(GridLinesStyleViewModel)));

            items.Add(new NavigationItem("Title Appearance ", "Customization", typeof(TitleAppearanceViewModel)));
            items.Add(new NavigationItem("Legend Appearance ", "Customization", typeof(LegendAppearanceViewModel)));
            items.Add(new NavigationItem("Title Position ", "Customization", typeof(TitlePositionViewModel)));
            items.Add(new NavigationItem("Legend Position ", "Customization", typeof(LegendPositionViewModel)));
            items.Add(new NavigationItem("Data Annotation ", "Customization", typeof(DataAnnotationViewModel)));
            items.Add(new NavigationItem("Palette Types", "Customization", typeof(PaletteTypesViewModel)));
            items.Add(new NavigationItem("Palette Order", "Customization", typeof(PaletteOrderViewModel)));
            items.Add(new NavigationItem("Custom Palette", "Customization", typeof(CustomPaletteViewModel)));
            items.Add(new NavigationItem("ColumnBar Fill Style", "Customization", typeof(ColumnBarFillStyleViewModel)));
            items.Add(new NavigationItem("Area Fill Style", "Customization", typeof(AreaFillStyleViewModel)));
            items.Add(new NavigationItem("Data Point Style Selector", "Customization", typeof(DataPointStyleSelectorViewModel)));
            items.Add(new NavigationItem("Initial Zoom ", "Customization", typeof(InitialZoomViewModel)));
            items.Add(new NavigationItem("Zoom Configuration ", "Customization", typeof(ZoomConfigurationViewModel)));

            this.SourceItems = items;
            this.RefreshGroupItems();
        }

        #endregion

        #region Methods

        public override void RefreshGroupItems()
        {
            if (this.Items != null)
                this.GroupItems = this.Items.GroupBy(o => o.Group).Select(o => new GroupItem<NavigationItem>(o)).ToList();
        }


        #endregion
    }
}