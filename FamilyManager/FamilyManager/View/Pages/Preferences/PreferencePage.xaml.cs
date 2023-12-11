
namespace FamilyManager
{

    /// <summary>
    /// Interaction logic for PreferencePage.xaml
    /// </summary>
    /// <seealso cref="System.Windows.Control.BasePage"/>
    /// <seealso cref="System.Windows.Markup.IComponentConnector"/>
    /// <seealso cref="BasePage"/>
    public partial class PreferencePage : BasePage
    {
        #region Constructor 

        /// <summary>
        /// Default Constructor
        /// Initilaizes a new instance of the <see cref="PreferencePage"/> class.
        /// </summary>
        public PreferencePage()
        {
            InitializeComponent();
            DataContext = new PreferencesPageViewModel();
            Animation = FamilyManager.Animation.PageAnimationType.Fade;
        }
        #endregion
    }
}
