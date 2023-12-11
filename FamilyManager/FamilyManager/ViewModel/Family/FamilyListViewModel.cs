using FamilyManager.Model;
using FamilyManager.ViewModel.Base;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace FamilyManager.ViewModel.Family
{
    /// <summary>
    /// A view model for list of the family items.
    /// </summary>
    /// <seealso cref="FamilyManager.ViewModel.Family.BaseViewModel"/>
    public class FamilyListViewModel : BaseViewModel
    {


        #region  public properties

        /// <summary>
        /// Gets or sets the items for the list view. 
        /// </summary>
        /// <value>
        /// The items.
        /// </value>
        public ObservableCollection<FamilyItem> Items { get; set; }

        #endregion


        #region Constructor

        /// <summary>
        /// Default Constructor.
        /// Initializes a new instance of the <see cref="FamilyListViewModel"/>
        /// </summary>
        public FamilyListViewModel() 
        {
            // Populate Item list for list control.
            Items = Populate();
        }
        #endregion


        #region private methods
        /// <summary>
        ///  Populate the list with items from provided folder paths.
        /// </summary>
        /// <returns></returns>
        private ObservableCollection<FamilyItem> Populate()
        {
            // implement the logic of code here.

            var items = new ObservableCollection<FamilyItem>();
                      
            return items;
        }
        #endregion


    }
}
