namespace WorkWatcher
{
    partial class WeekViewHeaderPanel
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
            this.itsLabelDayOfWeek = new System.Windows.Forms.Label();
            this.itsLabelDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itsLabelDayOfWeek
            // 
            this.itsLabelDayOfWeek.AutoSize = true;
            this.itsLabelDayOfWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itsLabelDayOfWeek.Location = new System.Drawing.Point(35, 27);
            this.itsLabelDayOfWeek.Name = "itsLabelDayOfWeek";
            this.itsLabelDayOfWeek.Size = new System.Drawing.Size(80, 13);
            this.itsLabelDayOfWeek.TabIndex = 0;
            this.itsLabelDayOfWeek.Text = "Day o\' Week";
            // 
            // itsLabelDate
            // 
            this.itsLabelDate.AutoSize = true;
            this.itsLabelDate.Location = new System.Drawing.Point(43, 50);
            this.itsLabelDate.Name = "itsLabelDate";
            this.itsLabelDate.Size = new System.Drawing.Size(65, 13);
            this.itsLabelDate.TabIndex = 1;
            this.itsLabelDate.Text = "06/08/2015";
            // 
            // WeekViewHeaderPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.itsLabelDate);
            this.Controls.Add(this.itsLabelDayOfWeek);
            this.Name = "WeekViewHeaderPanel";
            this.Size = new System.Drawing.Size(150, 88);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itsLabelDayOfWeek;
        private System.Windows.Forms.Label itsLabelDate;
    }
}
