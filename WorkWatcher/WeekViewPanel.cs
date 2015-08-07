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
    /// The panel that will display tasks completed for topics in a 
    /// week-view setting
    /// </summary>
    public partial class WeekViewPanel : UserControl
    {
        #region Members

        /// <summary>
        /// The owning panel
        /// </summary>
        MainPanel itsMainPanel;

        /// <summary>
        /// The number of WeekViewTopicPanels displayed 
        /// </summary>
        int itsNumWeekViewTopicPanels = 0;

        /// <summary>
        /// The date of the Monday for the currently viewed week
        /// </summary>
        DateTime itsWeekCommencing;

        #endregion

        #region Constructor

        public WeekViewPanel(MainPanel parentPanel)
        {
            InitializeComponent();

            itsMainPanel = parentPanel;

            // Use a default week of whichever week the application is
            // opened. If 'today' is not Monday, count back until we 
            // get to Monday, then set itsWeekCommencing.
            bool isMonday = false;
            DateTime weekCommencing = DateTime.Today;
            do
            {
                if (weekCommencing.DayOfWeek == DayOfWeek.Monday)
                {
                    isMonday = true;
                }
                else
                {
                    weekCommencing = weekCommencing.AddDays(-1);
                }

            }
            while (!isMonday);

            itsWeekCommencing = weekCommencing;

            UpdateWeekViewPanel();

        }

        #endregion

        /// <summary>
        /// Use to update the entire panel, i.e. to redraw everything
        /// </summary>
        internal void UpdateWeekViewPanel()
        {
            UpdateTopicsPanelHolder();
            UpdateHeaderPanelHolder();
            UpdateTaskPanelHolder();
        }

        #region Private methods

        /// <summary>
        /// Updates the header row (that contain the days and dates
        /// of the week). 
        /// </summary>
        private void UpdateHeaderPanelHolder()
        {
            // Clear the existing controls
            itsPanelColumnHeaderHolder.Controls.Clear();
            
            // Create a new header row with itsWeekCommencing...
            WeekViewColumnHeaders columnsHeaderPanel = new WeekViewColumnHeaders(itsWeekCommencing);

            // ...and add it to the WeekViewPanel
            itsPanelColumnHeaderHolder.Controls.Add(columnsHeaderPanel);

            // Upate its layout to space out children panels 
            columnsHeaderPanel.UpdatePanelLayout();
        }

        /// <summary>
        /// Updates the topic title column 
        /// </summary>
        private void UpdateTopicsPanelHolder()
        {
            // Clear the existing controls and set the topic panels counter
            // back to 0
            itsPanelTopicPanelHolder.Controls.Clear();
            itsNumWeekViewTopicPanels = 0;

            // Now add a WeekViewTopicPanel to the holder for each topic defined
            foreach (Topic topic in itsMainPanel.MainForm.WorkWatcherData.Topics)
            {
                // Crate a new header topic panel...
                WeekViewTopicPanel newRowHeader = new WeekViewTopicPanel(topic);

                // ...position it and add it to the holder. 
                newRowHeader.Location = new Point(0, itsNumWeekViewTopicPanels * newRowHeader.Height);
                itsPanelTopicPanelHolder.Controls.Add(newRowHeader);
            }
        }

        /// <summary>
        /// Updates the panel that contains information about tasks 
        /// (the biggest panel)
        /// </summary>
        private void UpdateTaskPanelHolder()
        {
            // Clear any existing controls
            itsPanelTaskPanelHolder.Controls.Clear();

            // For each topic header that has been added, add a topic row 
            // containing information about the tasks
            for (int i = 0; i < itsNumWeekViewTopicPanels; i++)
            {
                // Create a new WeekViewTopicRow...
                WeekViewTopicRow newTopicRow = new WeekViewTopicRow(itsPanelTaskPanelHolder);

                // ...position it and add it to the task panel holder
                newTopicRow.Location = new Point(0, i * newTopicRow.Height);
                itsPanelTaskPanelHolder.Controls.Add(newTopicRow);
            }
        }

        #endregion

        private void ItsPanelTopicPanelHolder_ControlAdded(object sender, ControlEventArgs e)
        {
            // If a WeekViewTopicPanel has been added, increment 
            // the counter for it
            if (e.Control is WeekViewTopicPanel)
            {
                ++itsNumWeekViewTopicPanels;
            }
        }

    }
}
