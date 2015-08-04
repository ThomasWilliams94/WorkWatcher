using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

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
        /// A list of all the tasks that are defined in the application
        /// </summary>
        private List<Task> itsTasks = new List<Task>();

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

        public List<Task> Tasks
        {
            get
            {
                return itsTasks;
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

        #region Topic-related methods

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

        #region Task-related methods
        
        /// <summary>
        /// Add a new task to itsTasks
        /// </summary>
        /// <param name="title">Title of the new task.</param>
        /// <param name="timeSpent">Time spent for the new task.</param>
        /// <param name="topic">Topic for which this task was completed.</param>
        /// <param name="dateTime">The date on which the task was carried out.</param>
        /// <returns>
        /// True...
        /// </returns>
        public bool AddNewTask(string title, double timeSpent, Topic topic, DateTime dateTime)
        {
            // Confirm the title is not the empty string
            if (title == "")
            {
                itsErrorMessage = "Please enter a title for the task.";
                return false;
            }

            // Confirm that at least some time has been spent on the task
            if (timeSpent == 0)
            {
                itsErrorMessage = "Please enter the amount of time spent.";
                return false;
            }

            // Double check that a topic has been selected.
            if (topic == null)
            {
                itsErrorMessage = "Please select a topic.";
                return false;
            }
            
            // Add the task
            Task newTask = new Task(title, timeSpent, topic, dateTime);
            itsTasks.Add(newTask);

            return true;
        }

        /// <summary>
        /// Deletes the task with the specified title
        /// </summary>
        /// <param name="title">The title of the task to be deleted.</param>
        /// <returns>
        /// True if the task was successfully deleted.
        /// False if the task was not found.
        /// </returns>
        public bool DeleteTaskUsingTitle(string title) 
        {
            // Look for the topic with the specified name and delete it
            foreach (Task task in itsTasks)
            {
                if (task.Title == title)
                {
                    itsTasks.Remove(task);
                    return true;
                }
            }

            // If we get out here, the topic name was not found so something went wrong
            itsErrorMessage = "Could not find task: '" + title + "'.";
            return false;
        }

        /// <summary>
        /// Given a task, updates its title
        /// </summary>
        /// <param name="taskToUpdate">The task to update</param>
        /// <param name="newTitle">The new title for the task</param>
        /// <returns>
        /// True... 
        /// </returns>
        public bool UpdateTaskTitle(Task taskToUpdate, string newTitle)
        {
            itsTasks[itsTasks.IndexOf(taskToUpdate)].Title = newTitle;

            return true;
        }

        /// <summary>
        /// Given a task, updates its time spent
        /// </summary>
        /// <param name="taskToUpdate">The task to update</param>
        /// <param name="newTitle">The new time spent for the task</param>
        /// <returns>
        /// True... 
        /// </returns>
        public bool UpdateTaskTimeSpent(Task taskToUpdate, double newTimeSpent)
        {
            itsTasks[itsTasks.IndexOf(taskToUpdate)].TimeSpent = newTimeSpent;

            return true;
        }

        /// <summary>
        /// Given a task, updates its topic
        /// </summary>
        /// <param name="taskToUpdate">The task to update</param>
        /// <param name="newTitle">The new topic for the task</param>
        /// <returns>
        /// True... 
        /// </returns>
        public bool UpdateTaskTopic(Task taskToUpdate, Topic newTopic)
        {
            itsTasks[itsTasks.IndexOf(taskToUpdate)].Topic = newTopic;

            return true;
        }

        /// <summary>
        /// Given a task, updates its datetime
        /// </summary>
        /// <param name="taskToUpdate">The task to update</param>
        /// <param name="newTitle">The new datetime for the task</param>
        /// <returns>
        /// True... 
        /// </returns>
        public bool UpdateTaskDateTime(Task taskToUpdate, DateTime newDateTime)
        {
            itsTasks[itsTasks.IndexOf(taskToUpdate)].DateTime = newDateTime;

            return true;
        }

        #endregion

        /// <summary>
        /// Writes the data to the specified file location. It overwrites
        /// existing files.
        /// </summary>
        /// <param name="outputFileName">The location to write the data to.</param>
        public void WriteToXML(string outputFileName)
        {
            try
            {
                using (FileStream stream = new FileStream(outputFileName, FileMode.Create, FileAccess.Write))
                {
                    XmlWriterSettings settings = new XmlWriterSettings();
                    settings.Indent = true;

                    XmlWriter writer = XmlWriter.Create(stream, settings);

                    writer.WriteStartElement("WorkWatcherData");
                    {
                        //===================================================
                        //   Topics
                        //
                        writer.WriteStartElement("Topics");
                        {
                            foreach (Topic topic in itsTopics)
                            {
                                topic.WriteXML(writer);
                            }
                        }
                        writer.WriteEndElement();
                        //---------------------------------------------------


                        //===================================================
                        //   Tasks
                        //
                        writer.WriteStartElement("Tasks");
                        {
                            foreach (Task task in itsTasks)
                            {
                                task.WriteXML(writer);
                            }
                        }
                        writer.WriteEndElement();
                        //---------------------------------------------------

                    }
                    writer.WriteEndElement();

                    writer.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error when writing to file: " + outputFileName + "\n\n" + e.Message, "Error when writing to file",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        #endregion
    }
}
