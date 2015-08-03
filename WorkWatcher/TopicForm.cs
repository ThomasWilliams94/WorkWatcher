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
    public partial class TopicForm : Form
    {
        #region Members

        /// <summary>
        /// The main panel, owning panel.
        /// </summary>
        private MainPanel itsMainPanel;

        /// <summary>
        /// The message to display if something goes wrong.
        /// </summary>
        private string itsMessage = "";

        /// <summary>
        /// If editing a topic, we use this to compare the input
        /// </summary>
        private Topic itsExistingTopic = null;

        #endregion

        #region Constructor

        /// <summary>
        /// This constructor is used when adding a new topic
        /// </summary>
        /// <param name="parentPanel"></param>
        public TopicForm(MainPanel parentPanel)
        {
            InitializeComponent();

            itsMainPanel = parentPanel;

            // We show the add topic button only and update the text
            itsButtonAddTopic.Visible = true;
            this.Text = "Add new topic";
        }

        /// <summary>
        /// This constructor is used when editing an existing topic
        /// </summary>
        /// <param name="parentPanel"></param>
        /// <param name="topicToEdit"></param>
        public TopicForm(MainPanel parentPanel, Topic topicToEdit)
        {
            InitializeComponent();

            itsMainPanel = parentPanel;
            itsExistingTopic = topicToEdit;
 
            // fill in the form with the existing values
            itsTextBoxName.Text = topicToEdit.Name;
            itsTextBoxDescription.Text = topicToEdit.Description;

            // We show the edit topic button only
            itsButtonEditTopic.Visible = true;
            this.Text = "Edit topic";
        }

        #endregion

        private void ItsButtonAddTopic_Click(object sender, EventArgs e)
        {
            // Try to add the new topic. If successful, close the form and return
            // otherwise, don't do anything.
            if (itsMainPanel.AddNewTopic(itsTextBoxName.Text.Trim(), itsMainPanel.MainForm.Colours[itsMainPanel.MainForm.WorkWatcherData.Topics.Count % itsMainPanel.MainForm.Colours.Count], itsTextBoxDescription.Text.Trim()))
            {                
                Close();
                return;
            }

        }

        private void ItsButtonEditTopic_Click(object sender, EventArgs e)
        {
            // We want to update an existing topic. 
            if (itsExistingTopic == null)
            {
                itsMessage = "No topic found for editing.";
                MessageBox.Show(itsMessage, "No topic found", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            // Has the name changed?
            if (itsTextBoxName.Text.Trim() != itsExistingTopic.Name)
            {
                // If the update failed, display a message box
                if (!itsMainPanel.MainForm.WorkWatcherData.UpdateTopicName(itsExistingTopic, itsTextBoxName.Text.Trim()))
                {
                    itsMessage = itsMainPanel.MainForm.WorkWatcherData.ErrorMessage;
                    MessageBox.Show(itsMessage, "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
            }            

            // Has the description changed?
            if (itsTextBoxDescription.Text.Trim() != itsExistingTopic.Description)
            {
                // If the update fails, display a message box
                if (!itsMainPanel.MainForm.WorkWatcherData.UpdateTopicDescription(itsExistingTopic, itsTextBoxDescription.Text.Trim()))
                {
                    itsMessage = itsMainPanel.MainForm.WorkWatcherData.ErrorMessage;
                    MessageBox.Show(itsMessage, "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
            }

            Close();
            return;
        }
    }
}
