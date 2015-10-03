using DreamCheeky;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamCheekyLib
{
    public class DreamCheeky : IDisposable
    {
        private BigRedButton bigRedButton;

        public DreamCheeky(EventHandler lidClosed, EventHandler lidOpen, EventHandler buttonPressed)
        {
            bigRedButton = new BigRedButton();
            bigRedButton.LidClosed += lidClosed;
            bigRedButton.LidOpen += lidOpen;
            bigRedButton.ButtonPressed += buttonPressed;
            bigRedButton.Start();
        }

        public void Dispose()
        {
            bigRedButton.Stop();
            bigRedButton = null;
        }
    }
}
