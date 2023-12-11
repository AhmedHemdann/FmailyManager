
namespace FamilyManager
{
    /// <summary>
    /// Interaction logic for FamilyPage.xaml
    /// </summary>
    /// <seealso cref="System.Windows.Controls.BasePage"/>
    /// <seealso cref="System.Windows.Markup.IComponentConnector"/>
    public partial class FamilyPage : BasePage
    {

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// Initializes a new instance of the <see cref="FamilyPage"/> class       
        /// </summary>
        public FamilyPage()
        {
            InitializeComponent();

           Animation = FamilyManager.Animation.PageAnimationType.Fade;
        }
        #endregion

    }
}
