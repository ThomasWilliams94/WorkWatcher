﻿using System;
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
    public partial class TopicLabelCustomControl : Control
    {
        #region Members

        /// <summary>
        /// The main panel, owning panel.
        /// </summary>
        MainPanel itsMainPanel;

        #endregion

        #region Constructor

        public TopicLabelCustomControl(MainPanel parentPanel)
        {
            InitializeComponent();

            itsMainPanel = parentPanel;

            // Set some of the properties for itsTopicLabel
            itsTopicLabel.AutoSize = false;
            itsTopicLabel.Width = 100;

            // Set up event handlers for context menu item clicks
            itsContextMenuEditTopic.Click += new EventHandler(ItsContextMenuEditTopic_Click);
            itsContextMenuDeleteTopic.Click += new EventHandler(ItsContextMenuDeleteTopic_Click);
        }

        #endregion

        #region Properties

        public Label TopicLabel
        {
            get
            {
                return itsTopicLabel;
            }
        }

        #endregion

        #region Override Methods

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Event handler for clicking the Edit context menu item. We display a 
        /// topic form so the user can change details about the selected topic.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="me"></param>
        private void ItsContextMenuEditTopic_Click(Object sender, EventArgs me)
        {
            // find the topic to update
            foreach (Topic topic in itsMainPanel.MainForm.WorkWatcherData.Topics)
            {
                if (topic.Name == itsTopicLabel.Text)
                {
                    // Show a topicform, giving it two arguments so that it knows
                    // this is an edit not an add.
                    TopicForm newTopicForm = new TopicForm(itsMainPanel, topic);
                    newTopicForm.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Event handler for clicking the Delete context menu item. We ask 
        /// WorkWatcherData to delete the selected topic. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="me"></param>
        private void ItsContextMenuDeleteTopic_Click(Object sender, EventArgs me)
        {
            // Ask for the topic to be deleted
            if (itsMainPanel.DeleteTopicUsingName(itsTopicLabel.Text))
            {                
                return;
            }
        }

        #endregion

    }
}
