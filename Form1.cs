using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OriginalL2MagicDmgCalculator
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Does whatever testing needs it to do
        /// </summary>
        /// <param name="sender">
        /// Sending object
        /// </param>
        /// <param name="e">
        /// Event's argument
        /// </param>
        private async void TEST_BUTTON_Click(object sender, EventArgs e)
        {
             // This works nicely, spaces are not actually part of the string- except for null, that's still a problem
            string test = LEVEL_MTEXTBOX.Text;
            Trace.WriteLine("Recognized length: " + test.Length);

            int content = Convert.ToInt32(LEVEL_MTEXTBOX.Text);
            Trace.WriteLine("Content: " + content);

            int contentBy2 = content / 2;
            Trace.WriteLine("Content by 2: " + contentBy2);
        }
    }
}
