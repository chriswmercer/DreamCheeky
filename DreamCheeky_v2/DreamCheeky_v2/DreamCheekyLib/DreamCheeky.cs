using DreamCheeky;
using System;

namespace DreamCheekyLib
{
    /// <summary>
    /// DreamCheeky class - to interface with the DreamCheeky DLL
    /// </summary>
    public class DreamCheeky : IDisposable
    {
        /// <summary>
        /// Local var for the big red button instance
        /// </summary>
        private BigRedButton _bigRedButton;

        /// <summary>
        /// Create a new instance of the DreamCheeky class
        /// </summary>
        /// <param name="lidClosed">The event handler to call if the lid is closed</param>
        /// <param name="lidOpen">The event handler to call if the lid is opened</param>
        /// <param name="buttonPressed">The event handler to call if the button is pressed</param>
        public DreamCheeky(EventHandler lidClosed, EventHandler lidOpen, EventHandler buttonPressed)
        {
            _bigRedButton = new BigRedButton();
            _bigRedButton.LidClosed += lidClosed;
            _bigRedButton.LidOpen += lidOpen;
            _bigRedButton.ButtonPressed += buttonPressed;
            _bigRedButton.Start();
        }

        /// <summary>
        /// Stop and remove the bigRedButton instance
        /// </summary>
        public void Dispose()
        {
            _bigRedButton.Stop();
            _bigRedButton = null;
        }
    }
}
