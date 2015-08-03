using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkWatcher
{
    public partial class TaskForm : Form
    {
        #region Members 

        /// <summary>
        /// The owning panel.
        /// </summary>
        private MainPanel itsMainPanel;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor to use when adding a new task
        /// </summary>
        /// <param name="parentPanel"></param>
        public TaskForm(MainPanel parentPanel)
        {
            InitializeComponent();

            itsMainPanel = parentPanel;

            BindTopicsToDropDown(); // Set the data for the drop down.

            // We show the add task button only and update the text
            itsButtonAddTask.Visible = true;
            this.Text = "Add new task";
            this.AcceptButton = itsButtonAddTask;
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Binds the topics from WorkWatcherData to the drop down list
        /// </summary>
        private void BindTopicsToDropDown()
        {
            itsComboBoxTopic.DataSource = itsMainPanel.MainForm.WorkWatcherData.Topics;
            itsComboBoxTopic.DisplayMember = "Name";
        }

        #endregion
    }
}
