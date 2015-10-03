using DreamCheekyLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DreamCheeky_v2
{
    public partial class frmMain : Form
    {
        private void LidClosed(object sender, EventArgs e)
        {
            Console.WriteLine("CLOSED");
        }

        private void LidOpen(object sender, EventArgs e)
        {
            Console.WriteLine("OPEN");
        }

        private void ButtonPressed(object sender, EventArgs e)
        {
            Console.WriteLine("PRESSED");
        }

        public frmMain()
        {
            InitializeComponent();
            DreamCheeky brb = new DreamCheeky(new EventHandler(this.LidClosed), new EventHandler(this.LidOpen), new EventHandler(this.ButtonPressed));
            }
        }
    }
}
