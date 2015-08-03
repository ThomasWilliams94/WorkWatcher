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
            this.KeyPreview = true;
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

        private void ItsButtonAddTask_Click(object sender, EventArgs e)
        {
            // Try to add the new task. If successful, close the form and return
            // otherwise, don't do anything.
            if (itsMainPanel.AddNewTask(itsTextBoxTitle.Text.Trim(), (double) itsNumericUpDownNumHours.Value, (Topic) itsComboBoxTopic.SelectedValue, itsDateTimePicker.Value.Date) )
            {
                Close();
                return;
            }
        }

        /// <summary>
        /// If the user presses Esc, close the form.  
        /// NB: Had to set KeyPreview = true in the constructors for the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaskForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

    }
}
