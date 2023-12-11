
using Autodesk.Revit.DB;
using FamilyManager.Helpers.Type;
using FamilyManager.Model;
using FamilyManager.Type.FamilyManger;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FamilyManager.ViewModel.Family
{
    /// <summary>
    /// Gets the items from the repository.
    /// </summary>
    public static class FamilyList
    {

        #region public methods

        /// <summary>
        /// Gets the items from the repository.
        /// </summary>
        /// <param name="path">The path to repository directory.</param>
        /// <returns></returns>
        public static List<FamilyItem> GetItems(string path)
        {

            // implement the logic of code here.

            var items = new List<FamilyItem>();
            
            return items;
        }

        #endregion
    }
}
