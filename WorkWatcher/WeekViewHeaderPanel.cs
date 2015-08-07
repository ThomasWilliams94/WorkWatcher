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
    public partial class WeekViewHeaderPanel : UserControl
    {
        #region Constructor

        /// <summary>
        /// Create a new instance of WeekViewHeaderPanel
        /// </summary>
        /// <param name="dateTime">The date of the day for this header panel</param>
        public WeekViewHeaderPanel(DateTime dateTime)
        {
            InitializeComponent();

            // Set the text properties for each label
            itsLabelDayOfWeek.Text = dateTime.DayOfWeek.ToString();
            itsLabelDate.Text = dateTime.Date.ToShortDateString();

            // Center the labels in the panel
            CenterLabels();
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Centers the labels horizontally in the control
        /// </summary>
        public void CenterLabels()
        {
            itsLabelDate.Location = new Point((this.Width - itsLabelDate.Width) / 2, itsLabelDate.Location.Y);
            itsLabelDayOfWeek.Location = new Point((this.Width - itsLabelDayOfWeek.Width) / 2, itsLabelDayOfWeek.Location.Y);
        }

        #endregion

    }
}
