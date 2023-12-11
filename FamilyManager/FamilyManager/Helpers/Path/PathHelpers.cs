using Autodesk.Revit.DB;
using System.IO;

namespace FamilyManager
{
   
    /// <summary>
    /// A helper class that contains funcations for dealing with phisycal files on disk.
    /// </summary>
    public static class PathHelpers
    {

        #region public methods

        /// <summary>
        /// Gets the name of the file from provided full path.
        /// </summary>
        /// <param name="fullpath">The full path to the item.</param>
        /// <returns></returns>
        public static string GetFileName(string fullpath)
        {

            // implement the logic of code here.

            var lastIndex = fullpath;
            
            // Return file name without extensions.
            return lastIndex;
        }


        /// <summary>
        /// Gets the name of the folder from provided full path to it.
        /// </summary>
        /// <param name="path">The full path to the folder.</param>
        /// <returns></returns>
        public static string GetFolderName(string fullpath) 
        {
            // implement the logic of code here.

            var lastIndex = fullpath;

            // Return file name without extensions.
            return lastIndex;
        }

        #endregion

    }
}
