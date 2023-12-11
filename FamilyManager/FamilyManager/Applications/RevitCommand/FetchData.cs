using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.IO;
using System.Linq;
using System.Text;


namespace FamilyManager.Applications.RevitCommand
{
    [TransactionAttribute(TransactionMode.ReadOnly)]
    public class FetchData : IExternalCommand
    {
        #region public method
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
                 
            // implement the logic of code here.

            return Result.Succeeded;
        }
        #endregion

    }
}
