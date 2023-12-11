using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyManager.Applications.RevitCommand
{
    /// <summary>
    /// Guid container that holds guid references to dockable panes.
   /// </summary>
    public static class PaneIdentifiers
    {

        #region Public methods

        /// <summary>
        /// The family manager dockable pane identifier.
        /// </summary>
        /// <returns></returns>
        public static Guid GetManagerPaneIdentifier()
        {
            return new Guid("D41D46C2-9256-42E0-A4FC-1B2EE0D0569A");
        }
        #endregion
    }
}
