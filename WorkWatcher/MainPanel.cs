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
    public partial class MainPanel : UserControl
    {
        #region Members

        /// <summary>
        /// The owning form (i.e. the MainPanel's parent).
        /// </summary>
        MainForm itsMainForm;

        #endregion

        #region Constructor

        public MainPanel(MainForm parentForm)
        {
            InitializeComponent();

            itsMainForm = parentForm;

        }

        #endregion

        #region Properties

        public MainForm MainForm
        {
            get
            {
                return itsMainForm;
            }
        }

        #endregion

        #region Internal Methods

        internal void OnAddNewTopic()
        {
            EventArgs e = new EventArgs();
            ItsGroupBoxTopicsAddNewLabel_Click(this, e);
        }

        internal bool AddNewTopic(string name, Color colour, string description)
        {
            // Attempt to add the new topic
            if(!itsMainForm.WorkWatcherData.AddNewTopic(name, colour, description))
            {
                // If we get here, something was wrong with the input so display a message box 
                // with the error in WorkWatcherData so user knows what to correct.                
                MessageBox.Show(itsMainForm.WorkWatcherData.ErrorMessage, "Invalid input", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }

            // Successfully added so update group box
            UpdateTopicsGroupBoxPanel();

            return true;
        }

        /// <summary>
        /// Updates the panel on which Topic names and descriptions appear
        /// when they have been added.
        /// </summary>
        internal void UpdateTopicsGroupBoxPanel()
        {
            itsGroupBoxTopicsPanel.Controls.Clear();

            int topicCount = 0;
            foreach (Topic topic in itsMainForm.WorkWatcherData.Topics)
            {
                //Label topicLabel = new Label();
                TopicLabelCustomControl topicLabelCustom = new TopicLabelCustomControl(this);
                topicLabelCustom.TopicLabel.Text = topic.Name;
                topicLabelCustom.TopicLabel.Location = new Point(10, 10 + topicCount * 25);
                itsGroupBoxTopicsPanel.Controls.Add(topicLabelCustom.TopicLabel);

                Label descripLabel = new Label();
                descripLabel.Text = topic.Description;
                descripLabel.Font = new Font(DefaultFont, FontStyle.Italic);
                descripLabel.AutoEllipsis = true;
                descripLabel.Location = new Point(10 + topicLabelCustom.TopicLabel.Width + 20, topicLabelCustom.TopicLabel.Location.Y);
                itsGroupBoxTopicsPanel.Controls.Add(descripLabel);

                ++topicCount;
            }
        }

        

        #endregion

        #region Private Methods

        
        #endregion

        /// <summary>
        /// Event for when the label to add a new topic is clicked. We want to add 
        /// a new topic to the WorkWatcherData, and then update the GUI to reflect
        /// this change.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItsGroupBoxTopicsAddNewLabel_Click(object sender, EventArgs e)
        {
            TopicForm newTopicForm = new TopicForm(this);
            newTopicForm.ShowDialog();
        }


    }
}
