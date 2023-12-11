using FamilyManager.ViewModel.Family;
using System.Windows.Controls;

namespace FamilyManager
{

    /// <summary>
    /// Interaction logic for FamilyListControl.xaml
    /// </summary>
    ///<seealso cref="System.Windows.Controls.UserControl"/>
    ///<seealso cref="System.Windows.Markup.IComponentConnector"/>
    public partial class FamilyListControl : UserControl
    {

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// Initializes a new instance of the <see cref="FamilyListControl"/>
        /// </summary>
        public FamilyListControl()
        {
            InitializeComponent();

            // List model binded to data context.
            DataContext = new FamilyListViewModel();
        }
        #endregion

        private void FamilyItemControl_TargetUpdated(object sender, System.Windows.Data.DataTransferEventArgs e)
        {

        }
    }
}
