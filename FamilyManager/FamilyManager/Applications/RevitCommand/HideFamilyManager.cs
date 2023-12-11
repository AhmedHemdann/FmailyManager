using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FamilyManager.Applications.RevitCommand
{
    /// <summary>
    /// Hide Family Manager dockable pane.
    /// </summary>
    /// <seealso cref="Autodesk.Revit.UI.IExternalCommand"/>
    [TransactionAttribute(TransactionMode.Manual)]
    [RegenerationAttribute(RegenerationOption.Manual)]
    public class HideFamilyManagerCommand : IExternalCommand
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
            var dockablePaneId = new DockablePaneId(PaneIdentifiers.GetManagerPaneIdentifier());
            var dockablePane = commandData.Application.GetDockablePane(dockablePaneId);
            dockablePane.Hide();

            return Result.Succeeded;
        }


        /// <summary>
        /// Gets the full namespace Path to this command.
        /// </summary>
        /// <returns></returns>
        public static string GetPath()
        {
            // return constructed namespace path.
            return typeof(HideFamilyManagerCommand).Namespace + "." + nameof(HideFamilyManagerCommand);
        }
        #endregion

    }
}
