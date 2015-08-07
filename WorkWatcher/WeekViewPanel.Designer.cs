namespace WorkWatcher
{
    partial class WeekViewPanel
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
            this.itsPanelColumnHeaderHolder = new System.Windows.Forms.Panel();
            this.itsPanelTopicPanelHolder = new System.Windows.Forms.Panel();
            this.itsPanelTaskPanelHolder = new System.Windows.Forms.Panel();
            this.itsPanelChangeWeekHolder = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // itsPanelColumnHeaderHolder
            // 
            this.itsPanelColumnHeaderHolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itsPanelColumnHeaderHolder.BackColor = System.Drawing.SystemColors.Control;
            this.itsPanelColumnHeaderHolder.Location = new System.Drawing.Point(156, 0);
            this.itsPanelColumnHeaderHolder.Name = "itsPanelColumnHeaderHolder";
            this.itsPanelColumnHeaderHolder.Size = new System.Drawing.Size(715, 88);
            this.itsPanelColumnHeaderHolder.TabIndex = 0;
            // 
            // itsPanelTopicPanelHolder
            // 
            this.itsPanelTopicPanelHolder.Location = new System.Drawing.Point(0, 94);
            this.itsPanelTopicPanelHolder.Name = "itsPanelTopicPanelHolder";
            this.itsPanelTopicPanelHolder.Size = new System.Drawing.Size(150, 346);
            this.itsPanelTopicPanelHolder.TabIndex = 2;
            this.itsPanelTopicPanelHolder.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.ItsPanelTopicPanelHolder_ControlAdded);
            // 
            // itsPanelTaskPanelHolder
            // 
            this.itsPanelTaskPanelHolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itsPanelTaskPanelHolder.AutoScroll = true;
            this.itsPanelTaskPanelHolder.BackColor = System.Drawing.SystemColors.Control;
            this.itsPanelTaskPanelHolder.Location = new System.Drawing.Point(156, 94);
            this.itsPanelTaskPanelHolder.Name = "itsPanelTaskPanelHolder";
            this.itsPanelTaskPanelHolder.Size = new System.Drawing.Size(715, 346);
            this.itsPanelTaskPanelHolder.TabIndex = 3;
            // 
            // itsPanelChangeWeekHolder
            // 
            this.itsPanelChangeWeekHolder.Location = new System.Drawing.Point(0, 0);
            this.itsPanelChangeWeekHolder.Name = "itsPanelChangeWeekHolder";
            this.itsPanelChangeWeekHolder.Size = new System.Drawing.Size(150, 88);
            this.itsPanelChangeWeekHolder.TabIndex = 4;
            // 
            // WeekViewPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.itsPanelChangeWeekHolder);
            this.Controls.Add(this.itsPanelTaskPanelHolder);
            this.Controls.Add(this.itsPanelTopicPanelHolder);
            this.Controls.Add(this.itsPanelColumnHeaderHolder);
            this.Name = "WeekViewPanel";
            this.Size = new System.Drawing.Size(874, 487);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel itsPanelColumnHeaderHolder;
        private System.Windows.Forms.Panel itsPanelTopicPanelHolder;
        private System.Windows.Forms.Panel itsPanelTaskPanelHolder;
        private System.Windows.Forms.Panel itsPanelChangeWeekHolder;


    }
}
