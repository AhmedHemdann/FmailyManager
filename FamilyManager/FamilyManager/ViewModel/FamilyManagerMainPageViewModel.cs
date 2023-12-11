using FamilyManager.Type.FamilyManger;
using FamilyManager.Utilities.Command;
using FamilyManager.ViewModel.Base;
using System.Windows.Input;


namespace FamilyManager.ViewModel
{
    /// <summary>
    /// A view model for the main application page.
    /// </summary>
    /// <seealso cref="BaseViewModel"/>
    public class FamilyManagerMainPageViewModel : BaseViewModel
    {

        #region Public properties

        /// <summary>
        /// Gets or sets the current page of the application
        /// </summary>
        /// <value>
        /// The current page.
        /// </value>
        public ApplicationPageType CurrentPage { get; set; } = ApplicationPageType.family; 

        /// <summary>
        /// Gets or sets the family page sa current.
        /// </summary>
        /// <value>
        /// The family BTN command
        /// </value>
        public ICommand FamilyBtnCommand { get; set; }

        /// <summary>
        /// Gets or sets the Preferences page sa current.
        /// </summary>
        /// <value>
        /// The family BTN command
        /// </value>
        public ICommand PreferencesBtnCommand { get; set; }

        #endregion


        #region Constructor
        /// <summary>
        /// Default Constructor
        /// Initializes a new instance the <see cref="FamilyManagerMainPageViewModel"/>
        /// </summary>
        public FamilyManagerMainPageViewModel()
        {
            // implement the logic of code here.

        }
        #endregion


    }
}
