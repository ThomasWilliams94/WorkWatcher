namespace WorkWatcher
{
    partial class MainPanel
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
            this.itsSplitContainerVertical = new System.Windows.Forms.SplitContainer();
            this.itsSplitContainerHorizontal = new System.Windows.Forms.SplitContainer();
            this.itsGroupBoxTopics = new System.Windows.Forms.GroupBox();
            this.itsGroupBoxTopicsAddNewLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itsSplitContainerVertical)).BeginInit();
            this.itsSplitContainerVertical.Panel1.SuspendLayout();
            this.itsSplitContainerVertical.Panel2.SuspendLayout();
            this.itsSplitContainerVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itsSplitContainerHorizontal)).BeginInit();
            this.itsSplitContainerHorizontal.SuspendLayout();
            this.itsGroupBoxTopics.SuspendLayout();
            this.SuspendLayout();
            // 
            // itsSplitContainerVertical
            // 
            this.itsSplitContainerVertical.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itsSplitContainerVertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itsSplitContainerVertical.Location = new System.Drawing.Point(0, 0);
            this.itsSplitContainerVertical.Name = "itsSplitContainerVertical";
            // 
            // itsSplitContainerVertical.Panel1
            // 
            this.itsSplitContainerVertical.Panel1.Controls.Add(this.itsGroupBoxTopics);
            // 
            // itsSplitContainerVertical.Panel2
            // 
            this.itsSplitContainerVertical.Panel2.Controls.Add(this.itsSplitContainerHorizontal);
            this.itsSplitContainerVertical.Size = new System.Drawing.Size(877, 586);
            this.itsSplitContainerVertical.SplitterDistance = 273;
            this.itsSplitContainerVertical.TabIndex = 0;
            // 
            // itsSplitContainerHorizontal
            // 
            this.itsSplitContainerHorizontal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.itsSplitContainerHorizontal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itsSplitContainerHorizontal.Location = new System.Drawing.Point(0, 0);
            this.itsSplitContainerHorizontal.Name = "itsSplitContainerHorizontal";
            this.itsSplitContainerHorizontal.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.itsSplitContainerHorizontal.Size = new System.Drawing.Size(598, 584);
            this.itsSplitContainerHorizontal.SplitterDistance = 297;
            this.itsSplitContainerHorizontal.TabIndex = 0;
            // 
            // itsGroupBoxTopics
            // 
            this.itsGroupBoxTopics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itsGroupBoxTopics.AutoSize = true;
            this.itsGroupBoxTopics.Controls.Add(this.itsGroupBoxTopicsAddNewLabel);
            this.itsGroupBoxTopics.Location = new System.Drawing.Point(3, 3);
            this.itsGroupBoxTopics.Name = "itsGroupBoxTopics";
            this.itsGroupBoxTopics.Size = new System.Drawing.Size(265, 258);
            this.itsGroupBoxTopics.TabIndex = 0;
            this.itsGroupBoxTopics.TabStop = false;
            this.itsGroupBoxTopics.Text = "Topics";
            // 
            // itsGroupBoxTopicsAddNewLabel
            // 
            this.itsGroupBoxTopicsAddNewLabel.AutoSize = true;
            this.itsGroupBoxTopicsAddNewLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itsGroupBoxTopicsAddNewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itsGroupBoxTopicsAddNewLabel.ForeColor = System.Drawing.Color.Blue;
            this.itsGroupBoxTopicsAddNewLabel.Location = new System.Drawing.Point(17, 28);
            this.itsGroupBoxTopicsAddNewLabel.Name = "itsGroupBoxTopicsAddNewLabel";
            this.itsGroupBoxTopicsAddNewLabel.Size = new System.Drawing.Size(68, 13);
            this.itsGroupBoxTopicsAddNewLabel.TabIndex = 0;
            this.itsGroupBoxTopicsAddNewLabel.Text = "New Topic...";
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.itsSplitContainerVertical);
            this.Name = "MainPanel";
            this.Size = new System.Drawing.Size(877, 586);
            this.itsSplitContainerVertical.Panel1.ResumeLayout(false);
            this.itsSplitContainerVertical.Panel1.PerformLayout();
            this.itsSplitContainerVertical.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itsSplitContainerVertical)).EndInit();
            this.itsSplitContainerVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itsSplitContainerHorizontal)).EndInit();
            this.itsSplitContainerHorizontal.ResumeLayout(false);
            this.itsGroupBoxTopics.ResumeLayout(false);
            this.itsGroupBoxTopics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer itsSplitContainerVertical;
        private System.Windows.Forms.SplitContainer itsSplitContainerHorizontal;
        private System.Windows.Forms.GroupBox itsGroupBoxTopics;
        private System.Windows.Forms.Label itsGroupBoxTopicsAddNewLabel;
    }
}
