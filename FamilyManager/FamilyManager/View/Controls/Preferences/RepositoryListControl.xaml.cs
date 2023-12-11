using System.Windows.Controls;

namespace FamilyManager
{
    /// <summary>
    /// Interaction logic for RepositoryListControl.xaml
    /// </summary>
    ///<seealso cref="System.Windows.Controls.UserControl"/>
    ///<seealso cref="System.Windows.Markup.IComponentConnector"/>
    public partial class RepositoryListControl : UserControl
    {

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// Initializes a new instance of the <see cref="RepositoryListControl"/> class.
        /// </summary>
        public RepositoryListControl()
        {
            InitializeComponent();

            DataContext = new RepositoryListViewModel();
        }

        #endregion
    }

}
