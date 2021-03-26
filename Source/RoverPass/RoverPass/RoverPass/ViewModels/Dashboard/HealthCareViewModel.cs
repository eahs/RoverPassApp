using RoverPass.Models;
using RoverPass.Models.Dashboard;
using Syncfusion.SfChart.XForms;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace RoverPass.ViewModels.Dashboard
{
    /// <summary>
    /// ViewModel for stock overview page.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class HealthCareViewModel : BaseViewModel
    {
        #region Field

        /// <summary>
        /// To store the health care data collection.
        /// </summary>
        private ObservableCollection<HealthCare> cardItems;

        /// <summary>
        /// To store the health care data collection.
        /// </summary>
        private ObservableCollection<HealthCare> listItems;

        /// <summary>
        /// To store the heart rate data collection.
        /// </summary>
        private ObservableCollection<ChartDataPoint> heartRateData;

        /// <summary>
        /// To store the calories burned data collection.
        /// </summary>
        private ObservableCollection<ChartDataPoint> caloriesBurnedData;

        /// <summary>
        /// To store the sleep time data collection.
        /// </summary>
        private ObservableCollection<ChartDataPoint> sleepTimeData;

        /// <summary>
        /// To store the water consumed data collection.
        /// </summary>
        private ObservableCollection<ChartDataPoint> waterConsumedData;

        #endregion

        #region Constructor
        public ICommand ButtonTapped { private set; get; }
        /// <summary>
        /// Initializes a new instance for the <see cref="HealthCareViewModel" /> class.
        /// </summary>
        public HealthCareViewModel()
        {
            GetChartData();
            cardItems = new ObservableCollection<HealthCare>()
            {
                new HealthCare()
                {
                    Category = "HEART RATE",
                    CategoryValue = "New Pass",
                    ChartData = sleepTimeData,
                    BackgroundGradientStart = "#f59083",
                    BackgroundGradientEnd = "#fae188",
                },
                new HealthCare()
                {
                    Category = "CALORIES BURNED",
                    CategoryValue = "Future Pass",
                    ChartData = sleepTimeData,
                    BackgroundGradientStart = "#ff7272",
                    BackgroundGradientEnd = "#f650c5"
                },
                new HealthCare()
                {
                    Category = "SLEEP TIME",
                    CategoryValue = "Hall Monitor",
                    ChartData = sleepTimeData,
                    BackgroundGradientStart = "#5e7cea",
                    BackgroundGradientEnd = "#1dcce3"
                },
                new HealthCare()
                {
                    Category = "WATER CONSUMED",
                    CategoryValue = "Add Class",
                    ChartData = sleepTimeData,
                    BackgroundGradientStart = "#255ea6",
                    BackgroundGradientEnd = "#b350d1"
                }
            };

            listItems = new ObservableCollection<HealthCare>()
            {
                new HealthCare()
                {
                    Category = "Libary Pass Aproved",
                    CategoryValue = "12:10",
                    CategoryPercentage = "Mrs.Klein",
                    BackgroundGradientStart = "#cf86ff"
                },
                new HealthCare()
                {
                    Category = "Math Lab Pass Declined",
                    CategoryValue = "1:00",
                    CategoryPercentage = "Mrs.Charnley",
                    BackgroundGradientStart = "#8691ff"
                },
                new HealthCare()
                {
                    Category = "Main Office Pass Accepted",
                    CategoryValue = "10:05",
                    CategoryPercentage = "Mrs.Jayant",
                    BackgroundGradientStart = "#ff9686"
                },
                new HealthCare()
                {
                    Category = "Guidance Pass Accepted",
                    CategoryValue = "10:35",
                    CategoryPercentage = "Mrs.Koser",
                    BackgroundGradientStart = "#ff9686"
                },
                new HealthCare()
                {
                    Category = "Math Lab Pass Accepted",
                    CategoryValue = "12:05",
                    CategoryPercentage = "Mrs.Flood",
                    BackgroundGradientStart = "#ff9686"
                }
            };

            this.ProfileImage = App.BaseImageUrl + "Profile_Lebron.png";
            ButtonTapped = new Command(HandleButton);
        }
        private async void HandleButton(object obj)
        {
            HealthCare c = obj as HealthCare;

            // c is the class they clicked on
            await Shell.Current.GoToAsync("DestinationPage");
        }
        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the profile image path.
        /// </summary>
        public string ProfileImage { get; set; }

        /// <summary>
        /// Gets or sets the health care items collection.
        /// </summary>
        public ObservableCollection<HealthCare> CardItems
        {
            get
            {
                return this.cardItems;
            }

            set
            {
                this.cardItems = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the health care items collection.
        /// </summary>
        public ObservableCollection<HealthCare> ListItems
        {
            get
            {
                return this.listItems;
            }

            set
            {
                this.listItems = value;
                this.NotifyPropertyChanged();
            }
        }

        #endregion

        #region Comments

        /// <summary>
        /// Gets or sets the command that will be executed when the menu button is clicked.
        /// </summary>
        public Command MenuCommand { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Chart Data Collection
        /// </summary>
        private void GetChartData()
        {
            DateTime dateTime = new DateTime(2019, 5, 1);

            heartRateData = new ObservableCollection<ChartDataPoint>()
            {
                new ChartDataPoint(dateTime, 15),
                new ChartDataPoint(dateTime.AddMonths(1), 20),
                new ChartDataPoint(dateTime.AddMonths(2), 17),
                new ChartDataPoint(dateTime.AddMonths(3), 23),
                new ChartDataPoint(dateTime.AddMonths(4), 18),
                new ChartDataPoint(dateTime.AddMonths(5), 25),
                new ChartDataPoint(dateTime.AddMonths(6), 19),
                new ChartDataPoint(dateTime.AddMonths(7), 21),
            };

            caloriesBurnedData = new ObservableCollection<ChartDataPoint>()
            {
                new ChartDataPoint(dateTime, 940),
                new ChartDataPoint(dateTime.AddMonths(1), 960),
                new ChartDataPoint(dateTime.AddMonths(2), 942),
                new ChartDataPoint(dateTime.AddMonths(3), 957),
                new ChartDataPoint(dateTime.AddMonths(4), 940),
                new ChartDataPoint(dateTime.AddMonths(5), 942),
            };

            sleepTimeData = new ObservableCollection<ChartDataPoint>()
            {
                new ChartDataPoint(dateTime, 7.8),
                new ChartDataPoint(dateTime.AddMonths(1), 7.2),
                new ChartDataPoint(dateTime.AddMonths(2), 8.0),
                new ChartDataPoint(dateTime.AddMonths(3), 6.8),
                new ChartDataPoint(dateTime.AddMonths(4), 7.6),
                new ChartDataPoint(dateTime.AddMonths(5), 7.0),
                new ChartDataPoint(dateTime.AddMonths(6), 7.5),
            };

            waterConsumedData = new ObservableCollection<ChartDataPoint>()
            {
                new ChartDataPoint(dateTime, 36),
                new ChartDataPoint(dateTime.AddMonths(1), 41),
                new ChartDataPoint(dateTime.AddMonths(2), 38),
                new ChartDataPoint(dateTime.AddMonths(3), 41),
                new ChartDataPoint(dateTime.AddMonths(4), 35),
                new ChartDataPoint(dateTime.AddMonths(5), 37),
                new ChartDataPoint(dateTime.AddMonths(6), 38),
                new ChartDataPoint(dateTime.AddMonths(7), 36),
            };
        }

        /// <summary>
        /// Invoked when the menu button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private void MenuClicked(object obj)
        {
            // Do something
        }

        #endregion
    }
}
