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

        private MainPanel itsMainPanel;

        string itsMessage = "";

        #endregion

        #region Constructor

        public TopicForm(MainPanel parentPanel)
        {
            InitializeComponent();

            itsMainPanel = parentPanel;
        }

        #endregion

        #region Private Methods

        private bool VerifyInput()
        {
            // Verify the topic name with WorkWatcherData
            bool nameOK = itsMainPanel.MainForm.WorkWatcherData.VerifyNewTopicName(itsTextBoxName.Text.Trim(), out itsMessage);

            // For now, only the name needs to be verified (colour and description can be anything). 
            return nameOK;
        }

        #endregion

        private void ItsButtonAddTopic_Click(object sender, EventArgs e)
        {
            // Verify the input
            if (VerifyInput())
            {
                // Create a new topic and add it to the WorkWatcherData, then close. 
                Topic newTopic = new Topic(itsTextBoxName.Text.Trim(), itsMainPanel.MainForm.Colours[itsMainPanel.MainForm.WorkWatcherData.Topics.Count % itsMainPanel.MainForm.Colours.Count], itsTextBoxDescription.Text);
                itsMainPanel.MainForm.WorkWatcherData.Topics.Add(newTopic);

                Close();
                return;
            }
            
            // If we get here, something was wrong with the input so display a message box 
            // so user knows what to correct.
            MessageBox.Show(itsMessage, "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }
    }
}
