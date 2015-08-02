namespace WorkWatcher
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.itsStatusStrip = new System.Windows.Forms.StatusStrip();
            this.itsMenuStrip = new System.Windows.Forms.MenuStrip();
            this.itsMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.itsFileMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.itsMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.itsEditMenuItemNewTopic = new System.Windows.Forms.ToolStripMenuItem();
            this.itsMenuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.itsMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.itsMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // itsStatusStrip
            // 
            this.itsStatusStrip.Location = new System.Drawing.Point(0, 549);
            this.itsStatusStrip.Name = "itsStatusStrip";
            this.itsStatusStrip.Size = new System.Drawing.Size(859, 22);
            this.itsStatusStrip.TabIndex = 0;
            this.itsStatusStrip.Text = "itsStatusBar";
            // 
            // itsMenuStrip
            // 
            this.itsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itsMenuItemFile,
            this.itsMenuItemEdit,
            this.itsMenuItemView,
            this.itsMenuItemHelp});
            this.itsMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.itsMenuStrip.Name = "itsMenuStrip";
            this.itsMenuStrip.Size = new System.Drawing.Size(859, 24);
            this.itsMenuStrip.TabIndex = 1;
            this.itsMenuStrip.Text = "itsMenuStrip";
            // 
            // itsMenuItemFile
            // 
            this.itsMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itsFileMenuItemExit});
            this.itsMenuItemFile.Name = "itsMenuItemFile";
            this.itsMenuItemFile.Size = new System.Drawing.Size(37, 20);
            this.itsMenuItemFile.Text = "File";
            // 
            // itsFileMenuItemExit
            // 
            this.itsFileMenuItemExit.Name = "itsFileMenuItemExit";
            this.itsFileMenuItemExit.Size = new System.Drawing.Size(92, 22);
            this.itsFileMenuItemExit.Text = "Exit";
            this.itsFileMenuItemExit.Click += new System.EventHandler(this.ItsFileMenuItemExit_Click);
            // 
            // itsMenuItemEdit
            // 
            this.itsMenuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itsEditMenuItemNewTopic});
            this.itsMenuItemEdit.Name = "itsMenuItemEdit";
            this.itsMenuItemEdit.Size = new System.Drawing.Size(39, 20);
            this.itsMenuItemEdit.Text = "Edit";
            // 
            // itsEditMenuItemNewTopic
            // 
            this.itsEditMenuItemNewTopic.Name = "itsEditMenuItemNewTopic";
            this.itsEditMenuItemNewTopic.Size = new System.Drawing.Size(165, 22);
            this.itsEditMenuItemNewTopic.Text = "Add New Topic...";
            this.itsEditMenuItemNewTopic.Click += new System.EventHandler(this.ItsEditMenuItemNewTopic_Click);
            // 
            // itsMenuItemView
            // 
            this.itsMenuItemView.Name = "itsMenuItemView";
            this.itsMenuItemView.Size = new System.Drawing.Size(44, 20);
            this.itsMenuItemView.Text = "View";
            // 
            // itsMenuItemHelp
            // 
            this.itsMenuItemHelp.Name = "itsMenuItemHelp";
            this.itsMenuItemHelp.Size = new System.Drawing.Size(44, 20);
            this.itsMenuItemHelp.Text = "Help";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 571);
            this.Controls.Add(this.itsStatusStrip);
            this.Controls.Add(this.itsMenuStrip);
            this.MainMenuStrip = this.itsMenuStrip;
            this.Name = "MainForm";
            this.Text = "Work Watcher ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.itsMenuStrip.ResumeLayout(false);
            this.itsMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip itsStatusStrip;
        private System.Windows.Forms.MenuStrip itsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem itsMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem itsFileMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem itsMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem itsMenuItemView;
        private System.Windows.Forms.ToolStripMenuItem itsMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem itsEditMenuItemNewTopic;
    }
}

