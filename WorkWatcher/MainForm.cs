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

        #endregion

        #region Constructor

        public MainForm()
        {
            InitializeComponent();
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
