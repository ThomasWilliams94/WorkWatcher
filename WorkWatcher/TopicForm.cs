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
        string itsMessage = "";

        #endregion

        #region Constructor

        public TopicForm(MainPanel parentPanel)
        {
            InitializeComponent();

            itsMainPanel = parentPanel;
        }

        #endregion

        private void ItsButtonAddTopic_Click(object sender, EventArgs e)
        {
            // Try to add the new topic. If successful, close the form and return.
            if (itsMainPanel.MainForm.WorkWatcherData.AddNewTopic(itsTextBoxName.Text.Trim(), itsMainPanel.MainForm.Colours[itsMainPanel.MainForm.WorkWatcherData.Topics.Count % itsMainPanel.MainForm.Colours.Count], itsTextBoxDescription.Text))
            {                
                Close();
                return;
            }

            // If we get here, something was wrong with the input so display a message box 
            // with the error in WorkWatcherData so user knows what to correct.
            itsMessage = itsMainPanel.MainForm.WorkWatcherData.ErrorMessage;
            MessageBox.Show(itsMessage, "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }
    }
}
