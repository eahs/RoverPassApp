using System.Collections.ObjectModel;
using RoverPass.ViewModels;
using RoverPass.Models.AboutUs;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace RoverPass.ViewModels.AboutUs
{
    /// <summary>
    /// ViewModel of AboutUs templates.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class AboutUsViewModel : BaseViewModel
    {
        #region Fields

        private string productDescription;

        private string productVersion;

        private string productIcon;

        private string cardsTopImage;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance for the <see cref="T:RoverPass.ViewModels.AboutUs.AboutUsViewModel"/> class.
        /// </summary>
        public AboutUsViewModel()
        {
            this.productDescription =
                "A group of four juniors one day decided to create a virtual hall pass app that allows for schools to further integrate technology and manage an organized hallway system. The Rover Pass app is an all electronic hall pass monitoring system which allows for an efficient and eco-friendly environment.";
            this.productIcon = App.BaseImageUrl + "Icon.png";
            this.productVersion = "1.0";
            this.cardsTopImage = "RoverBackground.png";

            this.EmployeeDetails = new ObservableCollection<AboutUsModel>
            {
                new AboutUsModel
                {
                    EmployeeName = "Taranveer Flora",
                    Image = "ProfileTaranveer.png",
                    Designation = "Scrum Master, Frontend and Backend Dev"
                },
                new AboutUsModel
                {
                    EmployeeName = "Imaan Ali",
                    Image = "ProfileImaan.png",
                    Designation = "Product Owner and Frontend Dev"
                },
                new AboutUsModel
                {
                    EmployeeName = "Aidan Fleming",
                    Image = "ProfileAidan.png",
                    Designation = "Backend Dev"
                },
                new AboutUsModel
                {
                    EmployeeName = "Josh Averion",
                    Image = "JoshProfile.png",
                    Designation = "Backend Dev"
                },
                
            };

            this.ItemSelectedCommand = new Command(this.ItemSelected);
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the top image source of the About us with cards view.
        /// </summary>
        /// <value>Image source location.</value>
        public string CardsTopImage
        {
            get
            {
                return this.cardsTopImage;
            }

            set
            {
                this.cardsTopImage = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the description of a product or a company.
        /// </summary>
        /// <value>The product description.</value>
        public string ProductDescription
        {
            get
            {
                return this.productDescription;
            }

            set
            {
                this.productDescription = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the product icon.
        /// </summary>
        /// <value>The product icon.</value>
        public string ProductIcon
        {
            get
            {
                return this.productIcon;
            }

            set
            {
                this.productIcon = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the product version.
        /// </summary>
        /// <value>The product version.</value>
        public string ProductVersion
        {
            get
            {
                return this.productVersion;
            }

            set
            {
                this.productVersion = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the employee details.
        /// </summary>
        /// <value>The employee details.</value>
        public ObservableCollection<AboutUsModel> EmployeeDetails { get; set; }

        /// <summary>
        /// Gets or sets the command that will be executed when an item is selected.
        /// </summary>
        public Command ItemSelectedCommand { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Invoked when an item is selected.
        /// </summary>
        private void ItemSelected(object selectedItem)
        {
            // Do something
        }

        #endregion
    }
}