namespace WorkWatcher
{
    partial class WeekViewTopicPanel
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
            this.itsLabelTopicName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itsLabelTopicName
            // 
            this.itsLabelTopicName.AutoSize = true;
            this.itsLabelTopicName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itsLabelTopicName.Location = new System.Drawing.Point(38, 38);
            this.itsLabelTopicName.Name = "itsLabelTopicName";
            this.itsLabelTopicName.Size = new System.Drawing.Size(75, 13);
            this.itsLabelTopicName.TabIndex = 0;
            this.itsLabelTopicName.Text = "Topic Name";
            // 
            // WeekViewTopicPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.itsLabelTopicName);
            this.Name = "WeekViewTopicPanel";
            this.Size = new System.Drawing.Size(150, 88);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itsLabelTopicName;
    }
}
