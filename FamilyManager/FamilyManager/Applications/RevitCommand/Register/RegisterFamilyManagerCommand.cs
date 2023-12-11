using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using FamilyManager.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FamilyManager.Applications.RevitCommand.Register
{
    /// <summary>
    /// Register Family Manager in zero state documnet.
    /// </summary>
    /// <seealso cref="Autodesk.Revit.UI.IExternalCommand"/>
    [TransactionAttribute(TransactionMode.Manual)]
    [RegenerationAttribute(RegenerationOption.Manual)]
    public class RegisterFamilyManagerCommand : IExternalCommand
    {

        #region Public methods
        /// <summary>
        ///  Executes the specified command data.
        /// </summary>
        /// <param name="commandData">The command data</param>
        /// <param name="message">The message</param>
        /// <param name="elements">The elements</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            return Execute(commandData.Application);
        }

        /// <summary>
        /// Register dockable panle
        /// </summary>
        /// <param name="uIApplication">The u i Application</param>
        /// <returns></returns>
        public Result Execute(UIApplication uIApplication)
        {


            var data = new DockablePaneProviderData();
            var managerPage = new FamilyManagerMainPageView();

            data.FrameworkElement = managerPage as FrameworkElement;

            //Setup initial state
            var state = new DockablePaneState
            {
                DockPosition = DockPosition.Right,
            };

            // Use unique guid identifier for dockable pane.
            var dpid = new DockablePaneId(PaneIdentifiers.GetManagerPaneIdentifier());

            // Register pane.
            uIApplication.RegisterDockablePane(dpid, "Family Manager", managerPage as IDockablePaneProvider);

            return Result.Succeeded;
        }
        #endregion
    }
}
