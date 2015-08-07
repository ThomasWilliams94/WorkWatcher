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
    public partial class WeekViewTopicRow : UserControl
    {
        #region Members

        /// <summary>
        /// The owning panel (need to get width from this)
        /// </summary>
        Panel itsParentPanel;

        #endregion

        #region Constructor

        public WeekViewTopicRow(Panel parentPanel)
        {
            InitializeComponent();

            itsParentPanel = parentPanel;

            // We want the width to match the width of its parent
            this.Width = itsParentPanel.Width;
            // Anchor it left and right, so that the Resize event is fired
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right;

            UpdatePanelLayout();
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Repositions the children panels (by redrawing them)
        /// </summary>
        public void UpdatePanelLayout()
        {
            // Clear any existing controls 
            this.Controls.Clear();

            // Set the width for one panel by dividing the width of this
            // parent control by 7
            int widthOneDay = (int)Math.Floor(itsParentPanel.Width / 7.0);

            // Add a task panel for each day of the week 
            for (int i = 0; i < 7; i++)
            {
                // Create a new task panel...
                WeekViewTaskPanel taskPanel = new WeekViewTaskPanel(i % 2, Color.Black); // black as placeholder for now
                
                // ...set the width and location, and then add it to the 
                // parent control
                taskPanel.Width = widthOneDay;
                taskPanel.Location = new Point(i * taskPanel.Width, 0);
                this.Controls.Add(taskPanel);
            }
        }

        #endregion

        private void WeekViewTopicRow_Resize(object sender, EventArgs e)
        {
            UpdatePanelLayout();
        }
    }
}
