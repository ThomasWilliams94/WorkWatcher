using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWatcher
{
    /// <summary>
    /// Contains all the data for the application, including details of 
    /// Topics, Tasks, Days, etc.
    /// </summary>
    public class WorkWatcherData
    {
        #region Members

        /// <summary>
        /// A list of all the topics that are defined in the application
        /// </summary>
        private List<Topic> itsTopics = new List<Topic>();

        #endregion

        #region Constructor

        public WorkWatcherData()
        {

        }

        #endregion

    }
}
