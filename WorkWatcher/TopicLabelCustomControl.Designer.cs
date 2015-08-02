namespace WorkWatcher
{
    partial class TopicLabelCustomControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.itsTopicLabel = new System.Windows.Forms.Label();
            this.itsContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itsContextMenuEditTopic = new System.Windows.Forms.ToolStripMenuItem();
            this.itsContextMenuDeleteTopic = new System.Windows.Forms.ToolStripMenuItem();
            this.itsContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // itsTopicLabel
            // 
            this.itsTopicLabel.AutoSize = true;
            this.itsTopicLabel.ContextMenuStrip = this.itsContextMenu;
            this.itsTopicLabel.Location = new System.Drawing.Point(0, 0);
            this.itsTopicLabel.Name = "itsTopicLabel";
            this.itsTopicLabel.Size = new System.Drawing.Size(100, 23);
            this.itsTopicLabel.TabIndex = 0;
            this.itsTopicLabel.Text = "Topic Custom Label";
            // 
            // itsContextMenu
            // 
            this.itsContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itsContextMenuEditTopic,
            this.itsContextMenuDeleteTopic});
            this.itsContextMenu.Name = "itsContextMenu";
            this.itsContextMenu.Size = new System.Drawing.Size(141, 48);
            // 
            // itsContextMenuEditTopic
            // 
            this.itsContextMenuEditTopic.Name = "itsContextMenuEditTopic";
            this.itsContextMenuEditTopic.Size = new System.Drawing.Size(140, 22);
            this.itsContextMenuEditTopic.Text = "Edit Topic";
            // 
            // itsContextMenuDeleteTopic
            // 
            this.itsContextMenuDeleteTopic.Name = "itsContextMenuDeleteTopic";
            this.itsContextMenuDeleteTopic.Size = new System.Drawing.Size(140, 22);
            this.itsContextMenuDeleteTopic.Text = "Delete Topic";
            this.itsContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label itsTopicLabel;
        private System.Windows.Forms.ContextMenuStrip itsContextMenu;
        private System.Windows.Forms.ToolStripMenuItem itsContextMenuEditTopic;
        private System.Windows.Forms.ToolStripMenuItem itsContextMenuDeleteTopic;
    }
}
