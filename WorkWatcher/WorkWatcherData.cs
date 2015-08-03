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

        /// <summary>
        /// A string to contain the error message when an action goes wrong
        /// </summary>
        private string itsErrorMessage = "";

        #endregion

        #region Constructor

        public WorkWatcherData()
        {

        }

        #endregion

        #region Properties

        public List<Topic> Topics
        {
            get
            {
                return itsTopics;
            }
        }

        public string ErrorMessage
        {
            get
            {
                return itsErrorMessage;
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Add a new topic to itsTopics. 
        /// </summary>
        /// <param name="name">Name of new topic</param>
        /// <param name="colour">Colour of new topic</param>
        /// <param name="description">Description of new topic</param>
        /// <returns>
        /// true   -- if the topic is successfully added
        /// false  -- if the topic is invalid and was not added.
        /// </returns>
        public bool AddNewTopic(string name, System.Drawing.Color colour, string description)
        {
            // Check that the name of the topic is valid (i.e. it cannot already
            // exist or be the empty string)
            if (!VerifyNewTopicName(name))
            {
                return false;
            }

            // Create and add the new topic
            Topic newTopic = new Topic(name, colour, description);
            itsTopics.Add(newTopic);

            return true;
        }


        /// <summary>
        /// Deletes the topic with the specified name
        /// </summary>
        /// <param name="name">The name of the topic to be deleted.</param>
        /// <returns>
        /// True if the topic was successfully deleted.
        /// False if the topic was not found.
        /// </returns>
        public bool DeleteTopicUsingName(string name)
        {
            // Look for the topic with the specified name and delete it
            foreach (Topic topic in itsTopics)
            {
                if (topic.Name == name)
                {
                    itsTopics.Remove(topic);
                    return true;
                }
            }

            // If we get out here, the topic name was not found so something went wrong
            itsErrorMessage = "Could not find topic: '" + name + "'.";
            return false;
        }

        /// <summary>
        /// Given a topic, it updates its name if the new name is valid
        /// </summary>
        /// <param name="oldTopic">The topic to update</param>
        /// <param name="newName">The new name for the topic</param>
        /// <returns>
        /// False if update was not possible
        /// True if update was successful
        /// </returns>
        public bool UpdateTopicName(Topic oldTopic, string newName)
        {
            // If the name has changed, that's okay.
            if (oldTopic.Name == newName)
            {
                // Nothing to do, so return true
                return true; 
            }

            if (VerifyNewTopicName(newName))
            {
                itsTopics[itsTopics.IndexOf(oldTopic)].Name = newName;
                return true;
            }
            
            return false;
        }

        /// <summary>
        /// Given a topic, updates its description
        /// </summary>
        /// <param name="oldTopic">The topic to update</param>
        /// <param name="newDescription">The new description for the topic</param>
        /// <returns>
        /// True... (all descriptions are valid).
        /// </returns>
        public bool UpdateTopicDescription(Topic oldTopic, string newDescription)
        {
            itsTopics[itsTopics.IndexOf(oldTopic)].Description = newDescription;
            
            return true;
        }

        /// <summary>
        /// Checks the a potential new name for a topic is valid, i.e.
        /// it cannot already exist or be the empty string
        /// </summary>
        /// <param name="potentialNewName">The potentail new name of a topic</param>
        /// <returns>
        /// False if the name already exists
        /// False if the name is the empty string
        /// True otherwise
        /// </returns>
        public bool VerifyNewTopicName(string potentialNewName)
        {
            if (potentialNewName == "")
            {
                itsErrorMessage = "Please enter a name.";
                return false;
            }

            foreach (Topic topic in itsTopics)
            {
                if(topic.Name == potentialNewName) 
                {
                    itsErrorMessage = "Topic name already exists. Please try a different name.";
                    return false;
                }   
            }

            return true;
        }

        #endregion
    }
}
