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

    }
}
