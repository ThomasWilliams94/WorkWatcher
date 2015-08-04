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
    public partial class MainForm : Form
    {
        #region Members

        /// <summary>
        /// The version number of the software
        /// </summary>
        private const string itsVersion = "0.0.0.0";

        /// <summary>
        /// The main panel that the main form will contain
        /// </summary>
        private MainPanel itsMainPanel;

        /// <summary>
        /// Instance of the WorkWatcherData class, where the information is kept
        /// for the running application
        /// </summary>
        private WorkWatcherData itsWorkWatcherData;

        /// <summary>
        /// Colours for the topics... hard code a few colours for now, 
        /// until users can select the colour themselves. It's difficult
        /// to get N distinct colours, and I don't have time to write a method
        /// for doing that just yet. 
        /// </summary>
        private List<Color> itsColours = new List<Color>();

        /// <summary>
        /// The file name of the current file (i.e. the path)
        /// </summary>
        private string itsFileName = null;

        /// <summary>
        /// Bool to highlight if the file needs to be saved or not
        /// </summary>
        private bool itsNeedsSaving = false;

        /// <summary>
        /// The part of the text (displayed in form bar) that comes
        /// before the file name
        /// </summary>
        private string itsTextPrefix = "Work Watcher " + Version + " - ";

        #endregion

        #region Constructor

        
        public MainForm(string[] args)
        {
            InitializeComponent();

            // Add colours to the list 
            AddColoursToList();

            // If no arguments given (i.e. a file not opened from outside application)
            // then create a blank file
            if (args.Length == 0)
            {
                // Create the main panel and add it to the main form
                itsMainPanel = new MainPanel(this);
                itsMainPanel.Dock = DockStyle.Fill;
                this.Controls.Add(itsMainPanel);
                itsMainPanel.BringToFront(); // This stops the panel from being covered by the tool and status strips

                // Create a WorkWatcherData instance
                itsWorkWatcherData = new WorkWatcherData();

                // Give file name of 'untitled.wwf' 
                itsFileName = "untitled.wwf";
                itsNeedsSaving = true;
            }
            else
            {
                // We will decide what to do later, but will propably involved
                // calling a LoadOnStartup() method or something along those lines                
            }

            this.Text = itsTextPrefix + itsFileName;
        }

        #endregion

        #region Properties

        static string Version
        {
            get
            {
                return itsVersion;
            }
        }

        public bool NeedsSaving
        {
            get
            {
                return itsNeedsSaving;
            }
            set
            {
                itsNeedsSaving = value;
            }
        }

        public List<Color> Colours
        {
            get
            {
                return itsColours;
            }
        }

        public WorkWatcherData WorkWatcherData
        {
            get
            {
                return itsWorkWatcherData;
            }
            set
            {
                itsWorkWatcherData = value;
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Adds a list of colours to itsColours. Add more colours using this method
        /// </summary>
        private void AddColoursToList()
        {
            itsColours.Add(Color.Beige);
            itsColours.Add(Color.White);
            itsColours.Add(Color.MistyRose);
            itsColours.Add(Color.GreenYellow);
            itsColours.Add(Color.PaleVioletRed);
            itsColours.Add(Color.PowderBlue);
            itsColours.Add(Color.PeachPuff);

        }

        /// <summary>
        /// Saves the file by calling WriteToXML in WorkWatcherData
        /// </summary>
        private void SaveFile()
        {
            WorkWatcherData.WriteToXML(itsFileName);

            // Update the text to display the new file name
            this.Text = itsTextPrefix + itsFileName;
        }

        #endregion

        #region Events

        private void ItsFileMenuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        private void ItsEditMenuItemNewTopic_Click(object sender, EventArgs e)
        {
            itsMainPanel.OnAddNewTopic();
        }

        private void ItsEditMenuItemNewTask_Click(object sender, EventArgs e)
        {
            itsMainPanel.OnAddNewTask();
        }

        private void ItsFileMenuItemSave_Click(object sender, EventArgs e)
        {
            // If file name is 'untitled.wwf' (we set this on start up) 
            // need to do a 'save as'
            if (itsFileName == "untitled.wwf")
            {
                ItsFileMenuItemSaveAs_Click(sender, e);
                return;
            }

            SaveFile();
        }

        private void ItsFileMenuItemSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDlg = new SaveFileDialog();

            saveFileDlg.Filter = "Work Watcher Files (*.wwf)|*.wwf|All files (*.*)|*.*";
            saveFileDlg.FilterIndex = 1;

            if (saveFileDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                itsFileName = saveFileDlg.FileName;

                SaveFile();
            }
        }
    }
}
