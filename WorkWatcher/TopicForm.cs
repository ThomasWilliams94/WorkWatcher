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
            this.AcceptButton = itsButtonAddTopic;
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
            this.AcceptButton = itsButtonEditTopic;
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

            string newName;
            Color newColour;
            string newDescription;

            // Use existing name if they are the same
            newName = (itsTextBoxName.Text.Trim() != itsExistingTopic.Name) 
                ? itsTextBoxName.Text.Trim() : itsExistingTopic.Name;

            newColour = Color.Black; // not allowing colour changes yet so just choose black

            // Use existing colour if they are the same
            newDescription = (itsTextBoxDescription.Text.Trim() != itsExistingTopic.Description) 
                ? itsTextBoxDescription.Text.Trim() : itsExistingTopic.Description;

            // Try to update the topic. If successful, close the form and return
            // otherwise, don't do anything.
            if (itsMainPanel.UpdateTopic(itsExistingTopic, newName, newColour, newDescription))
            {
                Close();
                return;
            }                  
        }
    }
}
