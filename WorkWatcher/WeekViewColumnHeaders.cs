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
    public partial class WeekViewColumnHeaders : UserControl
    {
        #region Members

        /// <summary>
        /// The week commencing for the currently displayed week
        /// </summary>
        DateTime itsWeekCommencing;

        #endregion

        #region Constructor

        /// <summary>
        /// Create a new WeekViewColumnHeaders
        /// </summary>
        /// <param name="weekCommencing">The date of the Monday beginning the currently displayed week</param>
        public WeekViewColumnHeaders(DateTime weekCommencing)
        {
            InitializeComponent();
            
            this.Dock = DockStyle.Fill; // Fill the 'holder' panel
            itsWeekCommencing = weekCommencing;
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Updates the layout to reposition the controls evenly across
        /// the holding panel (as best as possible)
        /// </summary>
        public void UpdatePanelLayout()
        {
            // Clear any existing controls
            this.Controls.Clear();

            // Determine the width for individual header panels by 
            // dividing the width of this control by seven (we are 
            // displaying all seven days of the week)
            int widthOneDay = (int)Math.Floor(this.Width / 7.0);

            // Now add a header for each day of the week
            for (int i = 0; i < 7; i++)
            {                
                // Create a new header panel (add i onto weekcommencing to get
                // the days of the week)
                WeekViewHeaderPanel headerPanel = new WeekViewHeaderPanel(itsWeekCommencing.AddDays(i));

                // Colour them alternatingly dark and light
                if(i % 2 == 0) 
                {
                    headerPanel.BackColor = Color.LightGray;
                }
                else
                {
                    headerPanel.BackColor = Color.DarkGray;
                }
                
                // Set the calculated width, center labels due to new width,
                // and determine location. Then add to this control. 
                headerPanel.Width = widthOneDay; 
                headerPanel.CenterLabels();
                headerPanel.Location = new Point(i * headerPanel.Width, 0);
                this.Controls.Add(headerPanel);
            }
        }

        #endregion

        private void WeekViewColumnHeaders_Resize(object sender, EventArgs e)
        {
            UpdatePanelLayout();
        }
    }
}
