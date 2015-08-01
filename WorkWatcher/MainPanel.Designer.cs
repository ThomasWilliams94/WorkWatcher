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
            ((System.ComponentModel.ISupportInitialize)(this.itsSplitContainerVertical)).BeginInit();
            this.itsSplitContainerVertical.Panel2.SuspendLayout();
            this.itsSplitContainerVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itsSplitContainerHorizontal)).BeginInit();
            this.itsSplitContainerHorizontal.SuspendLayout();
            this.SuspendLayout();
            // 
            // itsSplitContainerVertical
            // 
            this.itsSplitContainerVertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itsSplitContainerVertical.Location = new System.Drawing.Point(0, 0);
            this.itsSplitContainerVertical.Name = "itsSplitContainerVertical";
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
            this.itsSplitContainerHorizontal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itsSplitContainerHorizontal.Location = new System.Drawing.Point(0, 0);
            this.itsSplitContainerHorizontal.Name = "itsSplitContainerHorizontal";
            this.itsSplitContainerHorizontal.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.itsSplitContainerHorizontal.Size = new System.Drawing.Size(600, 586);
            this.itsSplitContainerHorizontal.SplitterDistance = 299;
            this.itsSplitContainerHorizontal.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.itsSplitContainerVertical);
            this.Name = "MainPanel";
            this.Size = new System.Drawing.Size(877, 586);
            this.itsSplitContainerVertical.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itsSplitContainerVertical)).EndInit();
            this.itsSplitContainerVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itsSplitContainerHorizontal)).EndInit();
            this.itsSplitContainerHorizontal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer itsSplitContainerVertical;
        private System.Windows.Forms.SplitContainer itsSplitContainerHorizontal;
    }
}
