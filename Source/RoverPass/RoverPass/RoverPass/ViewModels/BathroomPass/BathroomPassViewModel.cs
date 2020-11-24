using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Model = RoverPass.Models.Article;

namespace RoverPass.ViewModels.BathroomPass
{
    /// <summary>
    /// ViewModel for My Article page 
    /// </summary> 
    [Preserve(AllMembers = true)]
    public class BathroomPassViewModel : CountdownViewModel
    {
        #region Fields        

        /// <summary>
        /// Gets or sets the article list.
        /// </summary>
        private ObservableCollection<Model> articleList;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="BathroomPassViewModel" /> class
        /// </summary>
        public BathroomPassViewModel()
        {
            this.articleList = new ObservableCollection<Model>
            {
               
            };

            this.SearchCommand = new Command(this.SearchButtonClicked);
            this.ArticleListIteSelectionCommand = new Command(this.ArticleListItemClicked);

            Start(new System.TimeSpan(0, 15, 0));
        }


        #endregion

        #region Public properties

        /// <summary>
        /// Gets or sets the property has been bound with the list view which displays the my article list items.
        /// </summary>
        public ObservableCollection<Model> ArticleList
        {
            get
            {
                return this.articleList;
            }

            set
            {
                if (this.articleList == value)
                {
                    return;
                }

                this.articleList = value;
                this.NotifyPropertyChanged();
            }
        }

        #endregion

        #region Command

        /// <summary>
        /// Gets or sets the command is executed when the search button is clicked.
        /// </summary>
        public Command SearchCommand { get; set; }

        /// <summary>
        /// Gets or sets the command is executed when the article list item is clicked.
        /// </summary>
        public Command ArticleListIteSelectionCommand { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Invoked when the article list item clicked
        /// </summary>
        /// <param name="obj">The object</param>
        private void ArticleListItemClicked(object obj)
        {
            // Do something
        }

        /// <summary>
        /// Invoked when the search button clicked
        /// </summary>
        /// <param name="obj">The object</param>
        private void SearchButtonClicked(object obj)
        {
            // Do something
        }

        #endregion
    }

}
