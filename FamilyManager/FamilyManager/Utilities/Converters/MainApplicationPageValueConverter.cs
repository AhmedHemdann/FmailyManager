using FamilyManager.Applications;
using FamilyManager.Type.FamilyManger;
using System;
using System.Globalization;
using System.Windows.Data;

namespace FamilyManager.Utilities.Converters
{
    /// <summary>
    /// Convert <see cref="ApplicationPageType"/> to actual page.
    /// </summary>
    /// <seealso cref="System.Windows.Data.IValueConverter"/>
    public class MainApplicationPageValueConverter : IValueConverter
    {

        #region Public methods

        /// <summary>
        /// Converts a application page to actual view page.
        /// </summary>
        /// <param name="value">The value produced by the binding source.</param>
        /// <param name="targetType">The type of the binding target property.</param>
        /// <param name="parameter">The convert parameter to use.</param>
        /// <param name="culture">The culture to use in the convert.</param>
        /// <returns>
        /// A converted value. If the method returns <see langword="null"/>, the valid null value is used.
        /// </returns>
        /// <exception cref="NotImplementedException"></exception>
        public object Convert(object value, System.Type targetType, object parameter, CultureInfo culture)
        {
            // implement the logic of code here.

            return new FamilyPage();
        }

        /// <summary>
        /// Converts a value.
        /// </summary>
        /// <param name="value">The value that is produced by the binding target</param>
        /// <param name="targetType">The type to convert to.</param>
        /// <param name="parameter">The converter parameter to use</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>
        /// A converted value. If the method returns <see langword="null"/>, the valid null value is used.
        /// </returns>
        /// <exception cref="NotImplementedException"></exception>
        public object ConvertBack(object value, System.Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        #endregion


    }
}
