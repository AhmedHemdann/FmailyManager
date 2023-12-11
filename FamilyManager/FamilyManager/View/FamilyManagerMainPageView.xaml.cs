using System;
using System.Windows;
using System.Windows.Controls;
using Autodesk.Revit.UI;
using FamilyManager.ViewModel;

namespace FamilyManager
{
    /// <summary>
    /// Interaction logic for FamilyManagerMainPageView.xaml
    /// </summary>
    public partial class FamilyManagerMainPageView : Page, IDisposable, IDockablePaneProvider
    {

        #region Constructor
        /// <summary>
        /// Default Constructor
        /// Initializes a new instance the <see cref="FamilyManagerMainPageView"/>
        /// </summary>
        public FamilyManagerMainPageView()
        {
            InitializeComponent();
            DataContext = new FamilyManagerMainPageViewModel();
        }


        #endregion

        #region Public methods

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void Dispose()
        {
            // implement the logic of code here.

        }


        /// <summary>
        /// Setups the dockable pane.
        /// </summary>
        /// <param name="data"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void SetupDockablePane(DockablePaneProviderData data)
        {
            // implement the logic of code here.

        }
        #endregion

    }
}
