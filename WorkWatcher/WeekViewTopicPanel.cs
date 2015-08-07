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
    /// <summary>
    /// Used as a row 'header' in the first column to be displayed
    /// on a WeekViewPanel
    /// </summary>
    public partial class WeekViewTopicPanel : UserControl
    {
        #region Constructor

        /// <summary>
        /// Create a new WeekViewTopicPanel
        /// </summary>
        /// <param name="topic">The topic to use to format this instance.</param>
        public WeekViewTopicPanel(Topic topic)
        {
            InitializeComponent();

            // Change the back colour to the topic's colour
            this.BackColor = topic.Colour;

            // Change the label text to equal the topic's name and 
            // then center it
            this.itsLabelTopicName.Text = topic.Name;
            CenterTopicLabel();
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Centers the label in the control
        /// </summary>
        private void CenterTopicLabel()
        {
            itsLabelTopicName.Location = new Point(
                (this.Width - itsLabelTopicName.Width) / 2, 
                (this.Height - itsLabelTopicName.Height) / 2);
        }

        #endregion
    }
}
