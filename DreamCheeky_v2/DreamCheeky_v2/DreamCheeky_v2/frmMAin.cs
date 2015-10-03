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
            Console.WriteLine("Closed action thrown");
        }

        private void LidOpen(object sender, EventArgs e)
        {
            Console.WriteLine("Open Action Thrown");
        }

        private void ButtonPressed(object sender, EventArgs e)
        {
            Console.WriteLine("Pressed action thrown");
        }

        public frmMain()
        {
            InitializeComponent();
            DreamCheeky brb = new DreamCheeky(new EventHandler(this.LidClosed), new EventHandler(this.LidOpen), new EventHandler(this.ButtonPressed));
        }
    }
}
