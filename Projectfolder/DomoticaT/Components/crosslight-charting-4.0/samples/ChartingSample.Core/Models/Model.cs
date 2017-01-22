using System;
namespace ChartingSample.Models
{
    public class IntersoftAgileData
    {
        public string Name { get; set; }

        public string Status { get; set; }

        public int Count { get; set; }
    }

    public class SurplusOrDeficitData
    {
        public string Country { get; set; }

        public int Year { get; set; }

        public string Source { get; set; }

        public double Result { get; set; }
    }

    public class EmployeeAttendanceData
    {
        public string BranchName { get; set; }

        public DateTime Date { get; set; }

        public int Count { get; set; }
    }

    public class WeightAndHeightDistributionData
    {
        public string Sex { get; set; }

        public int Weight { get; set; }

        public int Height { get; set; }
    }

    public class VehicleCountData
    {
        public string Category { get; set; }

        public DateTime DateTime { get; set; }

        public int Count { get; set; }
    }

    public class ProductSalesData
    {
        public string ProductName { get; set; }

        public DateTime Date { get; set; }

        public int Count { get; set; }
    }

    public class OlympicMedalDistributionData
    {
        public string Country { get; set; }

        public string MedalType { get; set; }

        public int Count { get; set; }
    }

    public class ExpectedOlympicMedalDistributionData
    {
        public string Country { get; set; }

        public string MedalType { get; set; }

        public int Count { get; set; }
    }

    public class PopulationCountData
    {
        public string Country { get; set; }

        public DateTime Year { get; set; }

        public int Count { get; set; }
    }

    public class WebsiteStatisticData
    {
        public string Description { get; set; }

        public DateTime Date { get; set; }

        public int Count { get; set; }
    }

    public class WebsiteDownTimeData
    {
        public string Causes { get; set; }

        public double Duration { get; set; }

        public string Month { get; set; }

        public string Period { get; set; }
    }
}
