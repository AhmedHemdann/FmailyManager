using FamilyManager.Type.FamilyManger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyManager.Helpers.Type
{
    /// <summary>
    /// Conteiner class that contains functions for getting file type for Family Manager application.
    /// </summary>
    public static class ItemTypeHelper
    {

        #region public methods

        /// <summary>
        /// Gets the type of the item based on the full path to the file.
        /// </summary>
        /// <param name="fullPath">The full path.</param>
        /// <returns></returns>
        public static ItemType GetType(string fullPath)
        {

            // implement the logic of code here.

            return ItemType.None;
                  
        }
        #endregion

    }
}
