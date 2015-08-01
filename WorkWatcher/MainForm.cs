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
        /// The main panel that the main form will contain
        /// </summary>
        private MainPanel itsMainPanel;

        #endregion

        #region Constructor

        
        public MainForm()
        {
            InitializeComponent();

            // Create the main panel and add it to the main form
            itsMainPanel = new MainPanel();
            itsMainPanel.Dock = DockStyle.Fill;            
            this.Controls.Add(itsMainPanel);
            itsMainPanel.BringToFront(); // This stops the panel from being covered by the tool and status strips
        }

        #endregion

        #region Events

        private void ItsFileMenuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
