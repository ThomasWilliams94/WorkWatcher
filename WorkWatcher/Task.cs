using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWatcher
{
    public class Task
    {
        #region Members

        /// <summary>
        /// The title of the task (e.g. 'Problem Sheet')
        /// </summary>
        private string itsTitle;

        /// <summary>
        /// The number of hours spent doing this task
        /// </summary>
        private double itsTimeSpent;

        /// <summary>
        /// The topic for which this task was completed 
        /// </summary>
        private Topic itsTopic;

        /// <summary>
        /// The DateTime object, to contain information about the day this task was completed
        /// </summary>
        private DateTime itsDateTime;

        #endregion 

        #region Constructor

        /// <summary>
        /// Constructor for the Task class
        /// </summary>
        /// <param name="title">The title of the task.</param>
        /// <param name="timeSpent">The number of hours spent doing this task.</param>
        /// <param name="topic">The topic for which this task was completed.</param>
        /// <param name="dateTime">The day/time this task was completed</param>
        public Task(string title, double timeSpent, Topic topic, DateTime dateTime)
        {
            itsTitle = title;
            itsTimeSpent = timeSpent;
            itsTopic = topic;
            itsDateTime = dateTime;
        }

        #endregion

        #region Properties

        public string Title
        {
            get
            {
                return itsTitle;
            }
            set
            {
                itsTitle = value;
            }
        }

        public double TimeSpent
        {
            get
            {
                return itsTimeSpent;
            }
            set
            {
                itsTimeSpent = value;
            }
        }

        public Topic Topic
        {
            get
            {
                return itsTopic;
            }
            set
            {
                itsTopic = value;
            }
        }

        public DateTime DateTime
        {
            get
            {
                return itsDateTime;
            }
            set
            {
                itsDateTime = value;
            }
        }

        #endregion
    }
}
