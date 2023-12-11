using System;
using System.Windows.Data;
using System.Globalization;
using FamilyManager.Model;
using System.Windows.Media;
using FamilyManager.Type.FamilyManger;

namespace FamilyManager.Utilities.Converters
{
    /// <summary>
    /// Convert item type to <see cref="SolidColorBrush"/> color for ui as visual type indicator.
    /// </summary>
    /// <seealso cref="System.Windows.Data.IValueConverter"/>
    [ValueConversion(typeof(FamilyItem), typeof(SolidColorBrush))]
    public class ItemTypeToColorValueConverter : IValueConverter
    {

        #region public methods

        /// <summary>
        /// Converts a value.
        /// </summary>
        /// <param name="value">The value produced by the binding source.</param>
        /// <param name="targetType">The type of the binding target property.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>
        /// A converted value. If the methods returns <see cref="null"/>, the valid null value is used.
        /// </returns>
        /// <exception cref="NotImplementedException"></exception>
        public object Convert(object value, System.Type targetType, object parameter, CultureInfo culture)
        {

            // implement the logic of code here.

            return new SolidColorBrush(Colors.Magenta);
        }

        /// <summary>
        /// Converts a value.
        /// </summary>
        /// <param name="value">The value produced by the binding target.</param>
        /// <param name="targetType">The type to converter to.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public object ConvertBack(object value, System.Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
