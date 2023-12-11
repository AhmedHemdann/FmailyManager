
using Autodesk.Revit.UI;
using FamilyManager.Utilities.Command;
using System.IO;
using System.Text;
using System.Windows.Input;

namespace FamilyManager
{
    /// <summary>
    /// Represents a repository location folder with metadata attached to it.
    /// A folder that contains Revit relevant files/Items.
    /// </summary>
    public class RepositoryItem
    {

        #region public properties

        /// <summary>
        /// Gets or sets the full path.
        /// </summary>
        /// <value>
        /// The full path.
        /// </value>
        public string FullPath { get; set; }

        /// <summary>
        /// Gets the name of the repository folder.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name => PathHelpers.GetFolderName(FullPath);

        #endregion

        #region commands

        public ICommand AddRepositoryCommand { get; set; }
        public ICommand RemoveRepositoryCommand { get; set; }
        public ICommand PropertiesRepositoryCommand { get; set; }


        #endregion

        #region Constructor 

        /// <summary>
        /// Default Constructor
        /// Initializes a new instance of the <see cref="RepositoryItem"/> class.
        /// </summary>
        public RepositoryItem()
        {
            AddRepositoryCommand = new RouteCommands(AddRepositoryCmdFunc);
            RemoveRepositoryCommand = new RouteCommands(RemoveRepositoryCmdFunc);
            PropertiesRepositoryCommand = new RouteCommands(PropertiesRepositoryCmdFunc);
        }

        #endregion

        #region private methods

        /// <summary>
        /// AddRepositoryCommand execute method.
        /// </summary>
        private void AddRepositoryCmdFunc()
        {
            // implement the logic of code here.
        }

        /// <summary>
        /// RemoveRepositoryCommand execute method.
        /// </summary>
        private void RemoveRepositoryCmdFunc()
        {
            // implement the logic of code here.
        }

        /// <summary>
        /// PropertiesRepositoryCommand execute method.
        /// </summary>
        private void PropertiesRepositoryCmdFunc()
        {
            // implement the logic of code here.
        }

        #endregion

    }
}
