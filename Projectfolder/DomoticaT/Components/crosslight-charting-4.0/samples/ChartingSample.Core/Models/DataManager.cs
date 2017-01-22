using Intersoft.Crosslight.UI.DataVisualization;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ChartingSample.Models
{
    public class DataManager
    {
        #region Singleton

        private static DataManager _instance;

        public static DataManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DataManager();

                return _instance;
            }
        }

        #endregion

        #region Fields

        private ObservableCollection<IntersoftAgileData> _agileSprintStatus;
        private ObservableCollection<SurplusOrDeficitData> _surplusOrDeficitData;
        private ObservableCollection<EmployeeAttendanceData> _employeeAttendanceData;
        private ObservableCollection<WeightAndHeightDistributionData> _weightAndHeightDistributionData;
        private ObservableCollection<VehicleCountData> _vehicleCountData;
        private ObservableCollection<ProductSalesData> _productSalesData;
        private ObservableCollection<OlympicMedalDistributionData> _olympicMedalDistributionData;
        private ObservableCollection<ExpectedOlympicMedalDistributionData> _expectedOlympicMedalDistributionData;
        private ObservableCollection<PopulationCountData> _populationCountData;
        private ObservableCollection<WebsiteStatisticData> _webstieStatisticData;
        private ObservableCollection<WebsiteDownTimeData> _websiteDownTimeData;

        #endregion

        #region Properties

        public ObservableCollection<WebsiteDownTimeData> WebsiteDownTimeData
        {
            get
            {
                if (_websiteDownTimeData == null)
                    _websiteDownTimeData = new ObservableCollection<WebsiteDownTimeData>();

                return _websiteDownTimeData;
            }
        }

        public ObservableCollection<WebsiteStatisticData> WebsiteStatisticData
        {
            get
            {
                if (_webstieStatisticData == null)
                    _webstieStatisticData = new ObservableCollection<WebsiteStatisticData>();

                return _webstieStatisticData;
            }
        }

        public ObservableCollection<PopulationCountData> PopulationCountData
        {
            get
            {
                if (_populationCountData == null)
                    _populationCountData = new ObservableCollection<PopulationCountData>();

                return _populationCountData;
            }
        }

        public ObservableCollection<ExpectedOlympicMedalDistributionData> ExpectedOlympicMedalDistributionData
        {
            get
            {
                if (_expectedOlympicMedalDistributionData == null)
                    _expectedOlympicMedalDistributionData = new ObservableCollection<ExpectedOlympicMedalDistributionData>();

                return _expectedOlympicMedalDistributionData;
            }
        }

        public ObservableCollection<OlympicMedalDistributionData> OlympicMedalDistributionData
        {
            get
            {
                if (_olympicMedalDistributionData == null)
                    _olympicMedalDistributionData = new ObservableCollection<OlympicMedalDistributionData>();

                return _olympicMedalDistributionData;
            }
        }

        public ObservableCollection<ProductSalesData> ProductSalesData
        {
            get
            {
                if (_productSalesData == null)
                    _productSalesData = new ObservableCollection<ProductSalesData>();

                return _productSalesData;
            }
        }

        public ObservableCollection<VehicleCountData> VehicleCountData
        {
            get
            {
                if (_vehicleCountData == null)
                    _vehicleCountData = new ObservableCollection<VehicleCountData>();

                return _vehicleCountData;
            }
        }

        public ObservableCollection<WeightAndHeightDistributionData> WeightAndHeightDistributionData
        {
            get
            {
                if (_weightAndHeightDistributionData == null)
                    _weightAndHeightDistributionData = new ObservableCollection<WeightAndHeightDistributionData>();

                return _weightAndHeightDistributionData;
            }
        }

        public ObservableCollection<EmployeeAttendanceData> EmployeeAttendanceData
        {
            get
            {
                if (_employeeAttendanceData == null)
                    _employeeAttendanceData = new ObservableCollection<EmployeeAttendanceData>();

                return _employeeAttendanceData;
            }
        }

        public ObservableCollection<IntersoftAgileData> AgileSprintStatus 
        {
            get
            {
                if (_agileSprintStatus == null)
                    _agileSprintStatus = new ObservableCollection<IntersoftAgileData>();

                return _agileSprintStatus;
            }
        }

        public ObservableCollection<SurplusOrDeficitData> SurplusOrDeficitData
        {
            get
            {
                if (_surplusOrDeficitData == null)
                    _surplusOrDeficitData = new ObservableCollection<SurplusOrDeficitData>();

                return _surplusOrDeficitData;
            }
        }

        #endregion

        #region Constructors

        public DataManager()
        {
            this.InitializeIntersoftAgileData();
            this.InitializeSurplusOrDeficitData();
            this.InitializeEmployeeAttendanceData();
            this.InitializeWeightAndHeightDistributionData();
            this.InitializeVehicleCountData();
            this.InitializeProductSalesData();
            this.InitializeOlympicMedalDistributionData();
            this.InitializeExpectedOlympicMedalDistributionData();
            this.InitializePopuationCountData();
            this.InitializeWebsiteStatisticData();
            this.InitializeDownTimeData();
        }

        #endregion

        #region Methods

        private void InitializeDownTimeData()
        {
           
            this.WebsiteDownTimeData.Add(new WebsiteDownTimeData() { Causes = "Maintenance", Duration = 0.3 * 160, Period = this.GeneratePeriod(), Month = "January" });
            this.WebsiteDownTimeData.Add(new WebsiteDownTimeData() { Causes = "Maintenance", Duration = 0.3 * 180, Period = this.GeneratePeriod(), Month = "February" });
            this.WebsiteDownTimeData.Add(new WebsiteDownTimeData() { Causes = "Maintenance", Duration = 0.3 * 40, Period = this.GeneratePeriod(), Month = "March" });
            this.WebsiteDownTimeData.Add(new WebsiteDownTimeData() { Causes = "Maintenance", Duration = 0.3 * 190, Period = this.GeneratePeriod(), Month = "April" });
            this.WebsiteDownTimeData.Add(new WebsiteDownTimeData() { Causes = "Maintenance", Duration = 0.3 * 170, Period = this.GeneratePeriod(), Month = "Mei" });
            this.WebsiteDownTimeData.Add(new WebsiteDownTimeData() { Causes = "Server Failure", Duration = 0.25 * 160, Period = this.GeneratePeriod(), Month = "January" });
            this.WebsiteDownTimeData.Add(new WebsiteDownTimeData() { Causes = "Server Failure", Duration = 0.25 * 180, Period = this.GeneratePeriod(), Month = "February" });
            this.WebsiteDownTimeData.Add(new WebsiteDownTimeData() { Causes = "Server Failure", Duration = 0.25 * 40, Period = this.GeneratePeriod(), Month = "March" });
            this.WebsiteDownTimeData.Add(new WebsiteDownTimeData() { Causes = "Server Failure", Duration = 0.25 * 190, Period = this.GeneratePeriod(), Month = "April" });
            this.WebsiteDownTimeData.Add(new WebsiteDownTimeData() { Causes = "Server Failure", Duration = 0.25 * 170, Period = this.GeneratePeriod(), Month = "Mei" });
            this.WebsiteDownTimeData.Add(new WebsiteDownTimeData() { Causes = "Network Failure", Duration = 0.45 * 160, Period = this.GeneratePeriod(), Month = "January" });
            this.WebsiteDownTimeData.Add(new WebsiteDownTimeData() { Causes = "Network Failure", Duration = 0.45 * 180, Period = this.GeneratePeriod(), Month = "February" });
            this.WebsiteDownTimeData.Add(new WebsiteDownTimeData() { Causes = "Network Failure", Duration = 0.45 * 40, Period = this.GeneratePeriod(), Month = "March" });
            this.WebsiteDownTimeData.Add(new WebsiteDownTimeData() { Causes = "Network Failure", Duration = 0.45 * 190, Period = this.GeneratePeriod(), Month = "April" });
            this.WebsiteDownTimeData.Add(new WebsiteDownTimeData() { Causes = "Network Failure", Duration = 0.45 * 170, Period = this.GeneratePeriod(), Month = "Mei" });
        }

        private string GeneratePeriod()
        {
            Random random = new Random();
            int a = 0;
            string period = "";

            a = random.Next(0, 4);
            if (a == 0)
                period = "00.00 - 06.00";
            else if(a==1)
                period = "06.00 - 12.00";
            else if (a == 2)
                period = "12.00 - 18.00";
            else if (a == 3)
                period = "18.00 - 24.00";

            return period;
        }

        private void InitializeWebsiteStatisticData()
        {
            this.WebsiteStatisticData.Add(new WebsiteStatisticData() { Description = "User", Date = new DateTime(2015, 1, 1), Count = 300 });
            this.WebsiteStatisticData.Add(new WebsiteStatisticData() { Description = "User", Date = new DateTime(2015, 1, 2), Count = 500 });
            this.WebsiteStatisticData.Add(new WebsiteStatisticData() { Description = "User", Date = new DateTime(2015, 1, 3), Count = 400 });
            this.WebsiteStatisticData.Add(new WebsiteStatisticData() { Description = "User", Date = new DateTime(2015, 1, 4), Count = 800 });
            this.WebsiteStatisticData.Add(new WebsiteStatisticData() { Description = "User", Date = new DateTime(2015, 1, 5), Count = 87 });
            this.WebsiteStatisticData.Add(new WebsiteStatisticData() { Description = "Download", Date = new DateTime(2015, 1, 1), Count = 250 });
            this.WebsiteStatisticData.Add(new WebsiteStatisticData() { Description = "Download", Date = new DateTime(2015, 1, 2), Count = 350 });
            this.WebsiteStatisticData.Add(new WebsiteStatisticData() { Description = "Download", Date = new DateTime(2015, 1, 3), Count = 450 });
            this.WebsiteStatisticData.Add(new WebsiteStatisticData() { Description = "Download", Date = new DateTime(2015, 1, 4), Count = 200 });
            this.WebsiteStatisticData.Add(new WebsiteStatisticData() { Description = "Download", Date = new DateTime(2015, 1, 5), Count = 309 });
            this.WebsiteStatisticData.Add(new WebsiteStatisticData() { Description = "Upload", Date = new DateTime(2015, 1, 1), Count = 210 });
            this.WebsiteStatisticData.Add(new WebsiteStatisticData() { Description = "Upload", Date = new DateTime(2015, 1, 2), Count = 170 });
            this.WebsiteStatisticData.Add(new WebsiteStatisticData() { Description = "Upload", Date = new DateTime(2015, 1, 3), Count = 180 });
            this.WebsiteStatisticData.Add(new WebsiteStatisticData() { Description = "Upload", Date = new DateTime(2015, 1, 4), Count = 200 });
            this.WebsiteStatisticData.Add(new WebsiteStatisticData() { Description = "Upload", Date = new DateTime(2015, 1, 5), Count = 198 });
            this.WebsiteStatisticData.Add(new WebsiteStatisticData() { Description = "Crashes", Date = new DateTime(2015, 1, 1), Count = 24 });
            this.WebsiteStatisticData.Add(new WebsiteStatisticData() { Description = "Crashes", Date = new DateTime(2015, 1, 2), Count = 30 });
            this.WebsiteStatisticData.Add(new WebsiteStatisticData() { Description = "Crashes", Date = new DateTime(2015, 1, 3), Count = 26 });
            this.WebsiteStatisticData.Add(new WebsiteStatisticData() { Description = "Crashes", Date = new DateTime(2015, 1, 4), Count = 28 });
            this.WebsiteStatisticData.Add(new WebsiteStatisticData() { Description = "Crashes", Date = new DateTime(2015, 1, 5), Count = 27 });
        }

        private void InitializePopuationCountData()
        {
            this.PopulationCountData.Add(new PopulationCountData() { Country = "United States", Year = new DateTime(2006, 1, 1), Count = 298379912 });
            this.PopulationCountData.Add(new PopulationCountData() { Country = "United States", Year = new DateTime(2007, 1, 1), Count = 301231207 });
            this.PopulationCountData.Add(new PopulationCountData() { Country = "United States", Year = new DateTime(2008, 1, 1), Count = 304093966 });
            this.PopulationCountData.Add(new PopulationCountData() { Country = "United States", Year = new DateTime(2009, 1, 1), Count = 306771529 });
            this.PopulationCountData.Add(new PopulationCountData() { Country = "United States", Year = new DateTime(2010, 1, 1), Count = 309326295 });
            this.PopulationCountData.Add(new PopulationCountData() { Country = "United States", Year = new DateTime(2011, 1, 1), Count = 311582564 });
            this.PopulationCountData.Add(new PopulationCountData() { Country = "United States", Year = new DateTime(2012, 1, 1), Count = 313873685 });
            this.PopulationCountData.Add(new PopulationCountData() { Country = "United States", Year = new DateTime(2013, 1, 1), Count = 316128839 });
            this.PopulationCountData.Add(new PopulationCountData() { Country = "United States", Year = new DateTime(2014, 1, 1), Count = 326128839 });
            this.PopulationCountData.Add(new PopulationCountData() { Country = "United States", Year = new DateTime(2015, 1, 1), Count = 336128839 });
            this.PopulationCountData.Add(new PopulationCountData() { Country = "United Kingdom", Year = new DateTime(2006, 1, 1), Count = 60846820 });
            this.PopulationCountData.Add(new PopulationCountData() { Country = "United Kingdom", Year = new DateTime(2007, 1, 1), Count = 61322463 });
            this.PopulationCountData.Add(new PopulationCountData() { Country = "United Kingdom", Year = new DateTime(2008, 1, 1), Count = 61806995 });
            this.PopulationCountData.Add(new PopulationCountData() { Country = "United Kingdom", Year = new DateTime(2009, 1, 1), Count = 62276270 });
            this.PopulationCountData.Add(new PopulationCountData() { Country = "United Kingdom", Year = new DateTime(2010, 1, 1), Count = 62766365 });
            this.PopulationCountData.Add(new PopulationCountData() { Country = "United Kingdom", Year = new DateTime(2011, 1, 1), Count = 63258918 });
            this.PopulationCountData.Add(new PopulationCountData() { Country = "United Kingdom", Year = new DateTime(2012, 1, 1), Count = 63695687 });
            this.PopulationCountData.Add(new PopulationCountData() { Country = "United Kingdom", Year = new DateTime(2013, 1, 1), Count = 64097085 });
            this.PopulationCountData.Add(new PopulationCountData() { Country = "United Kingdom", Year = new DateTime(2014, 1, 1), Count = 65097085 });
            this.PopulationCountData.Add(new PopulationCountData() { Country = "United Kingdom", Year = new DateTime(2015, 1, 1), Count = 66097085 });
        }

        private void InitializeOlympicMedalDistributionData()
        {
            this.OlympicMedalDistributionData.Add(new OlympicMedalDistributionData() { Country = "Indonesia", MedalType = "Gold", Count = 72 });
            this.OlympicMedalDistributionData.Add(new OlympicMedalDistributionData() { Country = "Indonesia", MedalType = "Silver", Count = 52 });
            this.OlympicMedalDistributionData.Add(new OlympicMedalDistributionData() { Country = "Singapore", MedalType = "Gold", Count = 42 });
            this.OlympicMedalDistributionData.Add(new OlympicMedalDistributionData() { Country = "Singapore", MedalType = "Silver", Count = 32 });
            this.OlympicMedalDistributionData.Add(new OlympicMedalDistributionData() { Country = "Malaysia", MedalType = "Gold", Count = 20 });
            this.OlympicMedalDistributionData.Add(new OlympicMedalDistributionData() { Country = "Malaysia", MedalType = "Silver", Count = 40 });
            this.OlympicMedalDistributionData.Add(new OlympicMedalDistributionData() { Country = "Australia", MedalType = "Gold", Count = 42 });
            this.OlympicMedalDistributionData.Add(new OlympicMedalDistributionData() { Country = "Australia", MedalType = "Silver", Count = 60 });
            this.OlympicMedalDistributionData.Add(new OlympicMedalDistributionData() { Country = "Brunei", MedalType = "Gold", Count = 52 });
            this.OlympicMedalDistributionData.Add(new OlympicMedalDistributionData() { Country = "Brunei", MedalType = "Silver", Count = 32 });
        }

        private void InitializeExpectedOlympicMedalDistributionData()
        {
            this.ExpectedOlympicMedalDistributionData.Add(new ExpectedOlympicMedalDistributionData() { Country = "Indonesia", MedalType = "Gold", Count = 60 });
            this.ExpectedOlympicMedalDistributionData.Add(new ExpectedOlympicMedalDistributionData() { Country = "Indonesia", MedalType = "Silver", Count = 70 });
            this.ExpectedOlympicMedalDistributionData.Add(new ExpectedOlympicMedalDistributionData() { Country = "Singapore", MedalType = "Gold", Count = 50 });
            this.ExpectedOlympicMedalDistributionData.Add(new ExpectedOlympicMedalDistributionData() { Country = "Singapore", MedalType = "Silver", Count = 30 });
            this.ExpectedOlympicMedalDistributionData.Add(new ExpectedOlympicMedalDistributionData() { Country = "Malaysia", MedalType = "Gold", Count = 20 });
            this.ExpectedOlympicMedalDistributionData.Add(new ExpectedOlympicMedalDistributionData() { Country = "Malaysia", MedalType = "Silver", Count = 45 });
            this.ExpectedOlympicMedalDistributionData.Add(new ExpectedOlympicMedalDistributionData() { Country = "Australia", MedalType = "Gold", Count = 40 });
            this.ExpectedOlympicMedalDistributionData.Add(new ExpectedOlympicMedalDistributionData() { Country = "Australia", MedalType = "Silver", Count = 64 });
            this.ExpectedOlympicMedalDistributionData.Add(new ExpectedOlympicMedalDistributionData() { Country = "Brunei", MedalType = "Gold", Count = 42 });
            this.ExpectedOlympicMedalDistributionData.Add(new ExpectedOlympicMedalDistributionData() { Country = "Brunei", MedalType = "Silver", Count = 24 });
        }

        private void InitializeProductSalesData()
        {
            this.ProductSalesData.Add(new ProductSalesData() { ProductName = "Crosslight", Date = new DateTime(2014, 1, 1), Count = 72 });
            this.ProductSalesData.Add(new ProductSalesData() { ProductName = "ClientUI", Date = new DateTime(2014, 1, 1), Count = 42 });
            this.ProductSalesData.Add(new ProductSalesData() { ProductName = "WebGrid", Date = new DateTime(2014, 1, 1), Count = 64 });
            this.ProductSalesData.Add(new ProductSalesData() { ProductName = "Crosslight", Date = new DateTime(2014, 2, 1), Count = 65 });
            this.ProductSalesData.Add(new ProductSalesData() { ProductName = "ClientUI", Date = new DateTime(2014, 2, 1), Count = 26 });
            this.ProductSalesData.Add(new ProductSalesData() { ProductName = "WebGrid", Date = new DateTime(2014, 2, 1), Count = 52 });
            this.ProductSalesData.Add(new ProductSalesData() { ProductName = "Crosslight", Date = new DateTime(2014, 3, 1), Count = 42 });
            this.ProductSalesData.Add(new ProductSalesData() { ProductName = "ClientUI", Date = new DateTime(2014, 3, 1), Count = 63 });
            this.ProductSalesData.Add(new ProductSalesData() { ProductName = "WebGrid", Date = new DateTime(2014, 3, 1), Count = 25 });
            this.ProductSalesData.Add(new ProductSalesData() { ProductName = "Crosslight", Date = new DateTime(2014, 4, 1), Count = 51 });
            this.ProductSalesData.Add(new ProductSalesData() { ProductName = "ClientUI", Date = new DateTime(2014, 4, 1), Count = 52 });
            this.ProductSalesData.Add(new ProductSalesData() { ProductName = "WebGrid", Date = new DateTime(2014, 4, 1), Count = 41 });
            this.ProductSalesData.Add(new ProductSalesData() { ProductName = "Crosslight", Date = new DateTime(2014, 5, 1), Count = 32 });
            this.ProductSalesData.Add(new ProductSalesData() { ProductName = "ClientUI", Date = new DateTime(2014, 5, 1), Count = 26 });
            this.ProductSalesData.Add(new ProductSalesData() { ProductName = "WebGrid", Date = new DateTime(2014, 5, 1), Count = 29 });
            this.ProductSalesData.Add(new ProductSalesData() { ProductName = "Crosslight", Date = new DateTime(2014, 6, 1), Count = 20 });
            this.ProductSalesData.Add(new ProductSalesData() { ProductName = "ClientUI", Date = new DateTime(2014, 6, 1), Count = 40 });
            this.ProductSalesData.Add(new ProductSalesData() { ProductName = "WebGrid", Date = new DateTime(2014, 6, 1), Count = 60 });
            this.ProductSalesData.Add(new ProductSalesData() { ProductName = "Crosslight", Date = new DateTime(2014, 7, 1), Count = 62 });
            this.ProductSalesData.Add(new ProductSalesData() { ProductName = "ClientUI", Date = new DateTime(2014, 7, 1), Count = 52 });
            this.ProductSalesData.Add(new ProductSalesData() { ProductName = "WebGrid", Date = new DateTime(2014, 7, 1), Count = 45 });
            this.ProductSalesData.Add(new ProductSalesData() { ProductName = "Crosslight", Date = new DateTime(2014, 8, 1), Count = 63 });
            this.ProductSalesData.Add(new ProductSalesData() { ProductName = "ClientUI", Date = new DateTime(2014, 8, 1), Count = 52 });
            this.ProductSalesData.Add(new ProductSalesData() { ProductName = "WebGrid", Date = new DateTime(2014, 8, 1), Count = 24 });
            this.ProductSalesData.Add(new ProductSalesData() { ProductName = "Crosslight", Date = new DateTime(2014, 9, 1), Count = 22 });
            this.ProductSalesData.Add(new ProductSalesData() { ProductName = "ClientUI", Date = new DateTime(2014, 9, 1), Count = 51 });
            this.ProductSalesData.Add(new ProductSalesData() { ProductName = "WebGrid", Date = new DateTime(2014, 9, 1), Count = 41 });
            this.ProductSalesData.Add(new ProductSalesData() { ProductName = "Crosslight", Date = new DateTime(2014, 10, 1), Count = 62 });
            this.ProductSalesData.Add(new ProductSalesData() { ProductName = "ClientUI", Date = new DateTime(2014, 10, 1), Count = 31 });
            this.ProductSalesData.Add(new ProductSalesData() { ProductName = "WebGrid", Date = new DateTime(2014, 10, 1), Count = 46 });
            this.ProductSalesData.Add(new ProductSalesData() { ProductName = "Crosslight", Date = new DateTime(2014, 11, 1), Count = 61 });
            this.ProductSalesData.Add(new ProductSalesData() { ProductName = "ClientUI", Date = new DateTime(2014, 11, 1), Count = 25 });
            this.ProductSalesData.Add(new ProductSalesData() { ProductName = "WebGrid", Date = new DateTime(2014, 11, 1), Count = 51 });
            this.ProductSalesData.Add(new ProductSalesData() { ProductName = "Crosslight", Date = new DateTime(2014, 12, 1), Count = 25 });
            this.ProductSalesData.Add(new ProductSalesData() { ProductName = "ClientUI", Date = new DateTime(2014, 12, 1), Count = 21 });
            this.ProductSalesData.Add(new ProductSalesData() { ProductName = "WebGrid", Date = new DateTime(2014, 12, 1), Count = 32 });
        }

        private void InitializeVehicleCountData()
        {
            this.VehicleCountData.Add(new VehicleCountData() { Category = "Car", DateTime = new DateTime(2015, 1, 12, 4, 0, 0), Count = 40 });
            this.VehicleCountData.Add(new VehicleCountData() { Category = "Truck", DateTime = new DateTime(2015, 1, 12, 4, 0, 0), Count = 20 });
            this.VehicleCountData.Add(new VehicleCountData() { Category = "Car", DateTime = new DateTime(2015, 1, 12, 8, 0, 0), Count = 60 });
            this.VehicleCountData.Add(new VehicleCountData() { Category = "Truck", DateTime = new DateTime(2015, 1, 12, 8, 0, 0), Count = 30 });
            this.VehicleCountData.Add(new VehicleCountData() { Category = "Car", DateTime = new DateTime(2015, 1, 12, 12, 0, 0), Count = 30 });
            this.VehicleCountData.Add(new VehicleCountData() { Category = "Truck", DateTime = new DateTime(2015, 1, 12, 12, 0, 0), Count = 25 });
            this.VehicleCountData.Add(new VehicleCountData() { Category = "Car", DateTime = new DateTime(2015, 1, 12, 16, 0, 0), Count = 50 });
            this.VehicleCountData.Add(new VehicleCountData() { Category = "Truck", DateTime = new DateTime(2015, 1, 12, 16, 0, 0), Count = 40 });
            this.VehicleCountData.Add(new VehicleCountData() { Category = "Car", DateTime = new DateTime(2015, 1, 12, 20, 0, 0), Count = 44 });
            this.VehicleCountData.Add(new VehicleCountData() { Category = "Truck", DateTime = new DateTime(2015, 1, 12, 20, 0, 0), Count = 26 });
        }

        private void InitializeWeightAndHeightDistributionData()
        {
            this.WeightAndHeightDistributionData.Add(new WeightAndHeightDistributionData() { Sex = "Male", Weight = 60, Height = 170 });
            this.WeightAndHeightDistributionData.Add(new WeightAndHeightDistributionData() { Sex = "Male", Weight = 62, Height = 173 });
            this.WeightAndHeightDistributionData.Add(new WeightAndHeightDistributionData() { Sex = "Male", Weight = 64, Height = 174 });
            this.WeightAndHeightDistributionData.Add(new WeightAndHeightDistributionData() { Sex = "Male", Weight = 66, Height = 178 });
            this.WeightAndHeightDistributionData.Add(new WeightAndHeightDistributionData() { Sex = "Female", Weight = 50, Height = 150 });
            this.WeightAndHeightDistributionData.Add(new WeightAndHeightDistributionData() { Sex = "Female", Weight = 52, Height = 153 });
            this.WeightAndHeightDistributionData.Add(new WeightAndHeightDistributionData() { Sex = "Female", Weight = 54, Height = 154 });
            this.WeightAndHeightDistributionData.Add(new WeightAndHeightDistributionData() { Sex = "Female", Weight = 56, Height = 158 });
        }

        private void InitializeEmployeeAttendanceData()
        {
            this.EmployeeAttendanceData.Add(new EmployeeAttendanceData() { BranchName = "Los Angeles Branch", Date = new DateTime(2015, 1, 1), Count = 64 });
            this.EmployeeAttendanceData.Add(new EmployeeAttendanceData() { BranchName = "New York Branch", Date = new DateTime(2015, 1, 1), Count = 32 });
            this.EmployeeAttendanceData.Add(new EmployeeAttendanceData() { BranchName = "Los Angeles Branch", Date = new DateTime(2015, 1, 2), Count = 64 });
            this.EmployeeAttendanceData.Add(new EmployeeAttendanceData() { BranchName = "New York Branch", Date = new DateTime(2015, 1, 2), Count = 28 });
            this.EmployeeAttendanceData.Add(new EmployeeAttendanceData() { BranchName = "Los Angeles Branch", Date = new DateTime(2015, 1, 3), Count = 62 });
            this.EmployeeAttendanceData.Add(new EmployeeAttendanceData() { BranchName = "New York Branch", Date = new DateTime(2015, 1, 3), Count = 30 });
            this.EmployeeAttendanceData.Add(new EmployeeAttendanceData() { BranchName = "Los Angeles Branch", Date = new DateTime(2015, 1, 4), Count = 60 });
            this.EmployeeAttendanceData.Add(new EmployeeAttendanceData() { BranchName = "New York Branch", Date = new DateTime(2015, 1, 4), Count = 29 });
            this.EmployeeAttendanceData.Add(new EmployeeAttendanceData() { BranchName = "Los Angeles Branch", Date = new DateTime(2015, 1, 5), Count = 63 });
            this.EmployeeAttendanceData.Add(new EmployeeAttendanceData() { BranchName = "New York Branch", Date = new DateTime(2015, 1, 5), Count = 27 });
            this.EmployeeAttendanceData.Add(new EmployeeAttendanceData() { BranchName = "New York Branch", Date = new DateTime(2015, 1, 6), Count = 32 });
            this.EmployeeAttendanceData.Add(new EmployeeAttendanceData() { BranchName = "Los Angeles Branch", Date = new DateTime(2015, 1, 7), Count = 58 });
            this.EmployeeAttendanceData.Add(new EmployeeAttendanceData() { BranchName = "New York Branch", Date = new DateTime(2015, 1, 7), Count = 30 });
        }

        private void InitializeSurplusOrDeficitData()
        {
            this.SurplusOrDeficitData.Add(new SurplusOrDeficitData() {Country="Indonesia", Year=2014, Source="Oil",Result=-20 });
            this.SurplusOrDeficitData.Add(new SurplusOrDeficitData() { Country = "Indonesia", Year = 2014, Source = "Coal", Result = 12 });
            this.SurplusOrDeficitData.Add(new SurplusOrDeficitData() { Country = "Singapore", Year = 2014, Source = "Oil", Result = 24 });
            this.SurplusOrDeficitData.Add(new SurplusOrDeficitData() { Country = "Singapore", Year = 2014, Source = "Coal", Result = 10 });
            this.SurplusOrDeficitData.Add(new SurplusOrDeficitData() { Country = "Malaysia", Year = 2014, Source = "Oil", Result = 10 });
            this.SurplusOrDeficitData.Add(new SurplusOrDeficitData() { Country = "Malaysia", Year = 2014, Source = "Coal", Result = -12 });
            this.SurplusOrDeficitData.Add(new SurplusOrDeficitData() { Country = "Australia", Year = 2014, Source = "Oil", Result = 4 });
            this.SurplusOrDeficitData.Add(new SurplusOrDeficitData() { Country = "Australia", Year = 2014, Source = "Coal", Result = 8 });
            this.SurplusOrDeficitData.Add(new SurplusOrDeficitData() { Country = "Brunei", Year = 2014, Source = "Oil", Result = -8 });
            this.SurplusOrDeficitData.Add(new SurplusOrDeficitData() { Country = "Brunei", Year = 2014, Source = "Coal", Result = -22 });
        }

        private void InitializeIntersoftAgileData()
        {
            this.AgileSprintStatus.Add(new IntersoftAgileData() { Name = "Android", Status = "Open", Count = 40 });
            this.AgileSprintStatus.Add(new IntersoftAgileData() { Name = "Android", Status = "InProgress", Count = 72 });
            this.AgileSprintStatus.Add(new IntersoftAgileData() { Name = "Android", Status = "Resolved", Count = 52 });
            this.AgileSprintStatus.Add(new IntersoftAgileData() { Name = "iOS", Status = "Open", Count = 20 });
            this.AgileSprintStatus.Add(new IntersoftAgileData() { Name = "iOS", Status = "InProgress", Count = 42 });
            this.AgileSprintStatus.Add(new IntersoftAgileData() { Name = "iOS", Status = "Resolved", Count = 32 });
            this.AgileSprintStatus.Add(new IntersoftAgileData() { Name = "Windows Phone", Status = "Open", Count = 32 });
            this.AgileSprintStatus.Add(new IntersoftAgileData() { Name = "Windows Phone", Status = "InProgress", Count = 20 });
            this.AgileSprintStatus.Add(new IntersoftAgileData() { Name = "Windows Phone", Status = "Resolved", Count = 40 });
            this.AgileSprintStatus.Add(new IntersoftAgileData() { Name = "Data", Status = "Open", Count = 12 });
            this.AgileSprintStatus.Add(new IntersoftAgileData() { Name = "Data", Status = "InProgress", Count = 60 });
            this.AgileSprintStatus.Add(new IntersoftAgileData() { Name = "Data", Status = "Resolved", Count = 50 });
            this.AgileSprintStatus.Add(new IntersoftAgileData() { Name = "Framework", Status = "Open", Count = 32 });
            this.AgileSprintStatus.Add(new IntersoftAgileData() { Name = "Framework", Status = "InProgress", Count = 52 });
            this.AgileSprintStatus.Add(new IntersoftAgileData() { Name = "Framework", Status = "Resolved", Count = 32 });
        }

        public List<DataPoint> GetWeightAndHeightDistributionDataBasedOnSex(string sex)
        {
            List<DataPoint> dataPoints = new List<DataPoint>();
            foreach (WeightAndHeightDistributionData data in this.WeightAndHeightDistributionData)
            {
                if (data.Sex.Equals(sex))
                    dataPoints.Add(new DataPoint(data.Weight, data.Height));
            }

            return dataPoints;
        }

        public List<DataPoint> GetAgileDataBasedOnStatus(string status)
        {
            List<DataPoint> dataPoints = new List<DataPoint>();
            foreach(IntersoftAgileData data in this.AgileSprintStatus)
            {
                if(data.Status.Equals(status))
                    dataPoints.Add(new DataPoint(data.Name, data.Count));
            }

            return dataPoints;
        }

        public List<DataPoint> GetOlympicMedalDistributionDataBasedOnMedalType(string medalType)
        {
            List<DataPoint> dataPoints = new List<DataPoint>();
            foreach (OlympicMedalDistributionData data in this.OlympicMedalDistributionData)
            {
                if (data.MedalType.Equals(medalType))
                    dataPoints.Add(new DataPoint(data.Country, data.Count));
            }

            return dataPoints;
        }

        public List<DataPoint> GetExpectedOlympicMedalDistributionDataBasedOnMedalType(string medalType)
        {
            List<DataPoint> dataPoints = new List<DataPoint>();
            foreach (ExpectedOlympicMedalDistributionData data in this.ExpectedOlympicMedalDistributionData)
            {
                if (data.MedalType.Equals(medalType))
                    dataPoints.Add(new DataPoint(data.Country, data.Count));
            }

            return dataPoints;
        }

        public List<DataPoint> GetSurplusOrDeficitDataBasedOnYearAndSource(string source,int year)
        {
            List<DataPoint> dataPoints = new List<DataPoint>();
            foreach (SurplusOrDeficitData data in this.SurplusOrDeficitData)
            {
                if (data.Source.Equals(source) && data.Year == year)
                    dataPoints.Add(new DataPoint(data.Country, data.Result));
            }

            return dataPoints;
        }

        public List<DataPoint> GetAttendanceDataBasedOnDateAndBranch(string branchName, DateTime? from, DateTime? to)
        {
            List<DataPoint> dataPoints = new List<DataPoint>();
            foreach (EmployeeAttendanceData data in this.EmployeeAttendanceData)
            {
                if (data.Date >= from && data.Date <= to && data.BranchName.Equals(branchName))
                    dataPoints.Add(new DataPoint(data.Date, data.Count));
            }

            return dataPoints;
        }

        public List<DataPoint> GetWebsiteStatisticDataBasedOnDescriptionAndDate(string description, DateTime from, DateTime to)
        {
            List<DataPoint> dataPoints = new List<DataPoint>();
            foreach (WebsiteStatisticData data in this.WebsiteStatisticData)
            {
                if (data.Date >= from && data.Date <= to && data.Description.Equals(description))
                    dataPoints.Add(new DataPoint(data.Date, data.Count));
            }

            return dataPoints;
        }

        public List<DataPoint> GetVehicleCountDataBasedOnCategoryAndDay(string category, DateTime day)
        {
            List<DataPoint> dataPoints = new List<DataPoint>();
            DateTime from = new DateTime(day.Year, day.Month, day.Day, 0, 0, 0);
            DateTime to = new DateTime(day.Year, day.Month, day.Day, 23, 59, 59);
            foreach (VehicleCountData data in this.VehicleCountData)
            {
                if (data.DateTime >= from && data.DateTime <= to && data.Category.Equals(category))
                    dataPoints.Add(new DataPoint(data.DateTime, data.Count));
            }

            return dataPoints;
        }

        public List<DataPoint> GetProductSalesDataBasedOnCategoryAndYear(string category, int year)
        {
            List<DataPoint> dataPoints = new List<DataPoint>();
            foreach (ProductSalesData data in this.ProductSalesData)
            {
                if (data.Date.Year == year && data.ProductName.Equals(category))
                    dataPoints.Add(new DataPoint(data.Date, data.Count));
            }

            return dataPoints;
        }

        public List<DataPoint> GetPopulationCountBasedOnCountry(string country)
        {
            List<DataPoint> dataPoints = new List<DataPoint>();
            foreach (PopulationCountData data in this.PopulationCountData)
            {
                if (data.Country.Equals(country))
                    dataPoints.Add(new DataPoint(data.Year, data.Count));
            }

            return dataPoints;
        }

        public List<DataPoint> GetDownTimeDataBasedOnCauses(string causes)
        {
            List<DataPoint> dataPoints = new List<DataPoint>();
            foreach (WebsiteDownTimeData data in this.WebsiteDownTimeData)
            {
                if (data.Causes.Equals(causes))
                    dataPoints.Add(new DataPoint(data.Month, data.Duration));
            }

            return dataPoints;
        }

        public List<DataPoint> GetMonthlyTotalDownTimeData()
        {
            List<DataPoint> dataPoints = new List<DataPoint>();
            double january = 0;
            double february = 0;
            double march = 0;
            double april = 0;
            double mei = 0;

            foreach (WebsiteDownTimeData data in this.WebsiteDownTimeData)
            {
                if (data.Month.Equals("January"))
                    january += data.Duration;
                if (data.Month.Equals("February"))
                    february += data.Duration;
                if (data.Month.Equals("March"))
                    march += data.Duration;
                if (data.Month.Equals("April"))
                    april += data.Duration;
                if (data.Month.Equals("Mei"))
                    mei += data.Duration;
            }

            dataPoints.Add(new DataPoint("January", january));
            dataPoints.Add(new DataPoint("February", february));
            dataPoints.Add(new DataPoint("March", march));
            dataPoints.Add(new DataPoint("April", april));
            dataPoints.Add(new DataPoint("Mei", mei));

            return dataPoints;
        }

        public List<DataPoint> GetTotalDownTimeData()
        {
            List<DataPoint> dataPoints = new List<DataPoint>();
            double maintenance = 0;
            double networkFailure = 0;
            double serverFailure = 0;
            foreach (WebsiteDownTimeData data in this.WebsiteDownTimeData)
            {
                if (data.Causes.Equals("Maintenance"))
                    maintenance += data.Duration;
                if (data.Causes.Equals("Network Failure"))
                    networkFailure += data.Duration;
                if (data.Causes.Equals("Server Failure"))
                    serverFailure += data.Duration;
            }

            dataPoints.Add(new DataPoint("Maintenance", maintenance));
            dataPoints.Add(new DataPoint("Network Failure", networkFailure));
            dataPoints.Add(new DataPoint("Server Failure", serverFailure));

            return dataPoints;

        }

        public List<DataPoint> GetPeriodicDownTimeData()
        {
            List<DataPoint> dataPoints = new List<DataPoint>();
            double a = 0;
            double b = 0;
            double c = 0;
            double d = 0;

            foreach (WebsiteDownTimeData data in this.WebsiteDownTimeData)
            {
                if (data.Period.Equals("00.00 - 06.00"))
                    a += data.Duration;
                if (data.Period.Equals("06.00 - 12.00"))
                    b += data.Duration;
                if (data.Period.Equals("12.00 - 18.00"))
                    c += data.Duration;
                if (data.Period.Equals("18.00 - 24.00"))
                    d += data.Duration;
            }

            dataPoints.Add(new DataPoint("00.00 - 06.00", a));
            dataPoints.Add(new DataPoint("06.00 - 12.00", b));
            dataPoints.Add(new DataPoint("12.00 - 18.00", c));
            dataPoints.Add(new DataPoint("18.00 - 24.00", d));

            return dataPoints;

        }

        #endregion
    }
}
