
using Autodesk.Revit.UI;
using FamilyManager.Utilities.Command;
using FamilyManager.ViewModel.Base;
using System.Windows.Forms;
using System.Windows.Input;

namespace FamilyManager
{
    /// <summary>
    /// Preferences Page View Model.
    /// </summary>
    /// <seealso cref="FamilyManager.ViewModel.Base.BaseViewModel">
    public class PreferencesPageViewModel : BaseViewModel
    {

        #region Properties

        /// <summary>
        /// Gets or sets the add repository Command
        /// </summary>
        /// <value>
        /// The Add epository command
        /// </value>
        public ICommand AddRepositoryCommand { get; set; }

        /// <summary>
        /// Gets or sets the remove repository Command
        /// </summary>
        /// <value>
        /// The remove repository command
        /// </value>
        public ICommand RemoveRepositoryCommand { get; set; }
        #endregion


        #region Constructor

        /// <summary>
        /// Default Constructor.
        /// Initializes a new instance of the <see cref="PreferencesPageViewModel"/> class.
        /// </summary>
        public PreferencesPageViewModel()
        {
            // Commands routing.
            AddRepositoryCommand = new RouteCommands(AddRepositoryCmdFunc);
           RemoveRepositoryCommand = new RouteCommands(RemoveRepositoryCmdFunc);
        }

        #endregion


        #region private methods

        /// <summary>
        /// AddRepositoryCommand execution method.
        /// </summary>
        private void AddRepositoryCmdFunc() 
        {
            // implement the logic of code here.
        }



        /// <summary>
        /// RemoveRepositoryCommand execution method.
        /// </summary>
        private void RemoveRepositoryCmdFunc() 
        { 
            TaskDialog.Show("Info", "remove repository");
        }
        

        #endregion
    }
}
