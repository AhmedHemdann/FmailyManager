using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;


namespace FamilyManager
{
 
    /// <summary>
    /// Preferences options stored in this date model. 
    /// </summary>
    public class Preferences
    {
        #region private members

        /// <summary>
        /// The Preferences file name. 
        /// </summary>
        private string file = "prefs.cbb";
        #endregion


        #region  public properties

        /// <summary>
        /// Gets or sets the repository location.
        /// </summary>
        /// <value>
        /// The repository directories.
        /// </value>
        public List<string> Repository { get; set; }

        #endregion


        #region Constructor

        /// <summary>
        /// Default Constructor.
        /// Initializes a new instance of the <see cref="Preferences"/> class.
        /// </summary>
        public Preferences()
        {
            
        }

        #endregion


        #region public methods

        /// <summary>
        /// Saves this instance of  preferences in the .cbb file as xml structured data.
        /// </summary>
        /// 
        public void Save()
        {
            // implement the logic of code here.

        }

        /// <summary>
        /// Loads this instance data from Serialized file.
        /// </summary>
        /// <returns></returns>
        public static Preferences Load()
        {
            // Store file in the location relative to the core executing assembly.
            var dataFile = Path.Combine(Path.GetDirectoryName(CoreAssembly.GetAssemblyLocation().ToString()), "prefs.cbb");

            using (var Stream = new FileStream(dataFile, FileMode.Open))
            {
                // Loads save serialized data and return it as Preferences object.
                var deserializer = new XmlSerializer(typeof(Preferences));
                return (Preferences)deserializer.Deserialize(Stream);
            }
        }
        #endregion
    }
}
