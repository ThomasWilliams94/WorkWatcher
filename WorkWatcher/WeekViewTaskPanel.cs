using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkWatcher
{
    public partial class WeekViewTaskPanel : UserControl
    {
        #region Constructor

        /// <summary>
        /// Create a new WeekViewTaskPanel
        /// </summary>
        /// <param name="darkOrLight">0 for dark shading, 1 for light shading</param>
        /// <param name="colour">The colour of the topic row this is in</param>
        public WeekViewTaskPanel(int darkOrLight, Color colour)
        {
            InitializeComponent();

            if (darkOrLight == 0)
            {
                // light
                this.BackColor = Color.LightGray;
            }
            else
            {
                // dark
                this.BackColor = Color.DarkGray;
            }

        }

        #endregion

        // We will need methods later on (when we have added the Day class
        // for keeping tasks and rendering them in the GUI). For now, we 
        // can just leave the panels empty, until we have created the controls
        // for displaying task information
    }
}
