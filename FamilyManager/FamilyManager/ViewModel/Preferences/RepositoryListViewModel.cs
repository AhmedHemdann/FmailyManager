
using FamilyManager.ViewModel.Base;
using System.Collections.ObjectModel;
using System.Windows.Controls.Primitives;

namespace FamilyManager
{
    /// <summary>
    /// Repository list view model for list view in ui control.
    /// </summary>
    /// <seealso cref="BaseViewModel"/>
    public class RepositoryListViewModel : BaseViewModel
    {

        #region public properties


        /// <summary>
        /// Gets or sets the repository items.
        /// </summary>
        /// <value>
        /// The repository.
        /// </value>
        public ObservableCollection<RepositoryItem> Repository { get; set; }

        #endregion

        #region Constructor 

        /// <summary>
        /// Default Constructor
        /// Initializes a new instance of the <see cref="RepositoryListViewModel"/> class.
        /// </summary>
        public RepositoryListViewModel()
        {
            // Populate list on object construction time.
            Repository = GetRepositories();
        }

        #endregion

        #region private methods

        /// <summary>
        /// Gets the repository items.
        /// </summary>
        /// <returns></returns>
        private ObservableCollection<RepositoryItem> GetRepositories()
        {
            // implement the logic of code here.


            // Empty container to populate and return.
            var items = new ObservableCollection<RepositoryItem>();
              
            return items;
        }

        #endregion


    }
}
