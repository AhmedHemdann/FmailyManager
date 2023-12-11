using FamilyManager.Animation;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Media.Animation;
using System;

namespace FamilyManager
{
    /// <summary>
    /// A base page to extend basic page functionality.
    /// </summary>
    /// <see cref="System.Windows.Controls.Page"/>
    public class BasePage : Page
    {

        #region public properties
        /// <summary>
        /// Gets or sets the animation type.
        /// </summary>
        /// <value>
        /// The animation.
        /// </value>
        public PageAnimationType Animation { get; set; } = PageAnimationType.Slide;

        /// <summary>
        /// Gets or sets the duration of the animation in seconds.
        /// </summary>
        /// <value>
        /// The animation.
        /// </value>
        public float AnimationDuration { get; set; } = 0.3f;
        #endregion

        #region Constructor

        /// <summary>
        /// Defulat Constructor.
        /// Initializes a new instance of the <see cref="BasePage"/> class.
        /// </summary>
        public BasePage() 
        {
            // implement the logic of code here.

        }

        #endregion

        #region private methods

        /// <summary>
        /// Animates the page basedon provided animation type.
        /// </summary>
        private void AnimatePage() 
        {
            // implement the logic of code here.

        }

        /// <summary>
        /// Handles the Loaded event of the BasePage control.
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event date.</param>
        private void BasePage_Loaded(object sender, RoutedEventArgs e)
        {
            AnimatePage();
        }
        #endregion


    }
}
