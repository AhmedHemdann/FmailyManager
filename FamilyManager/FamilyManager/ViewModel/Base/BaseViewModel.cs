using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace FamilyManager.ViewModel.Base
{
    /// <summary>
    /// A base view model functionality for all view models.
    /// </summary>
    public class BaseViewModel : INotifyPropertyChanged
    {
        #region events
         /// <summary>
        /// Occurs when a property value change.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = (Sender, e) => { };

        #endregion

        #region methods

        /// <summary>
        /// Call this methods to raise <see cref="PropertyChanged"/> event.
        /// </summary>
        /// <param name="name">The name.</param>
        public void OnPropertyChanged(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));  
        }
        #endregion

    }
}
