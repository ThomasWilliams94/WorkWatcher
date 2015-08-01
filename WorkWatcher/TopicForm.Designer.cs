namespace WorkWatcher
{
    partial class TopicForm
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
            this.itsLabelName = new System.Windows.Forms.Label();
            this.itsLabelDescription = new System.Windows.Forms.Label();
            this.itsTextBoxName = new System.Windows.Forms.TextBox();
            this.itsTextBoxDescription = new System.Windows.Forms.TextBox();
            this.itsButtonAddTopic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itsLabelName
            // 
            this.itsLabelName.AutoSize = true;
            this.itsLabelName.Location = new System.Drawing.Point(30, 19);
            this.itsLabelName.Name = "itsLabelName";
            this.itsLabelName.Size = new System.Drawing.Size(41, 13);
            this.itsLabelName.TabIndex = 0;
            this.itsLabelName.Text = "Name: ";
            // 
            // itsLabelDescription
            // 
            this.itsLabelDescription.AutoSize = true;
            this.itsLabelDescription.Location = new System.Drawing.Point(8, 63);
            this.itsLabelDescription.Name = "itsLabelDescription";
            this.itsLabelDescription.Size = new System.Drawing.Size(63, 13);
            this.itsLabelDescription.TabIndex = 2;
            this.itsLabelDescription.Text = "Description:";
            // 
            // itsTextBoxName
            // 
            this.itsTextBoxName.Location = new System.Drawing.Point(90, 16);
            this.itsTextBoxName.Name = "itsTextBoxName";
            this.itsTextBoxName.Size = new System.Drawing.Size(164, 20);
            this.itsTextBoxName.TabIndex = 3;
            // 
            // itsTextBoxDescription
            // 
            this.itsTextBoxDescription.Location = new System.Drawing.Point(90, 60);
            this.itsTextBoxDescription.Name = "itsTextBoxDescription";
            this.itsTextBoxDescription.Size = new System.Drawing.Size(164, 20);
            this.itsTextBoxDescription.TabIndex = 4;
            // 
            // itsButtonAddTopic
            // 
            this.itsButtonAddTopic.Location = new System.Drawing.Point(179, 103);
            this.itsButtonAddTopic.Name = "itsButtonAddTopic";
            this.itsButtonAddTopic.Size = new System.Drawing.Size(75, 23);
            this.itsButtonAddTopic.TabIndex = 5;
            this.itsButtonAddTopic.Text = "Add Topic";
            this.itsButtonAddTopic.UseVisualStyleBackColor = true;
            this.itsButtonAddTopic.Click += new System.EventHandler(this.ItsButtonAddTopic_Click);
            // 
            // TopicForm
            // 
            this.AcceptButton = this.itsButtonAddTopic;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 138);
            this.Controls.Add(this.itsButtonAddTopic);
            this.Controls.Add(this.itsTextBoxDescription);
            this.Controls.Add(this.itsTextBoxName);
            this.Controls.Add(this.itsLabelDescription);
            this.Controls.Add(this.itsLabelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TopicForm";
            this.Text = "Add new topic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itsLabelName;
        private System.Windows.Forms.Label itsLabelDescription;
        private System.Windows.Forms.TextBox itsTextBoxName;
        private System.Windows.Forms.TextBox itsTextBoxDescription;
        private System.Windows.Forms.Button itsButtonAddTopic;
    }
}