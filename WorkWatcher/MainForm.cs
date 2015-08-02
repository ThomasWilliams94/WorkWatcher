using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WorkWatcher
{
    public partial class MainForm : Form
    {
        #region Members

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

        #endregion

        #region Constructor

        
        public MainForm()
        {
            InitializeComponent();

            // Add colours to the list 
            AddColoursToList();

            // Create the main panel and add it to the main form
            itsMainPanel = new MainPanel(this);
            itsMainPanel.Dock = DockStyle.Fill;            
            this.Controls.Add(itsMainPanel);
            itsMainPanel.BringToFront(); // This stops the panel from being covered by the tool and status strips

            // Create a WorkWatcherData instance
            itsWorkWatcherData = new WorkWatcherData();
        }

        #endregion

        #region Properties

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

        #endregion

        #region Events

        private void ItsFileMenuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        private void ItsEditMenuItemNewTopic_Click(object sender, EventArgs e)
        {
            // Fire the Click event in MainPanel that adds a new topic
            itsMainPanel.OnAddNewTopic();
        }


    }
}
