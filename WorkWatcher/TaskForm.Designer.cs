namespace WorkWatcher
{
    partial class TaskForm
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
            this.itsTextBoxTitle = new System.Windows.Forms.TextBox();
            this.itsLabelNumHours = new System.Windows.Forms.Label();
            this.itsLabelTitle = new System.Windows.Forms.Label();
            this.itsNumericUpDownNumHours = new System.Windows.Forms.NumericUpDown();
            this.itsComboBoxTopic = new System.Windows.Forms.ComboBox();
            this.itsLabelTopic = new System.Windows.Forms.Label();
            this.itsDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.itsButtonAddTask = new System.Windows.Forms.Button();
            this.itsButtonEditTask = new System.Windows.Forms.Button();
            this.itsLabelDateTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itsNumericUpDownNumHours)).BeginInit();
            this.SuspendLayout();
            // 
            // itsTextBoxTitle
            // 
            this.itsTextBoxTitle.Location = new System.Drawing.Point(90, 15);
            this.itsTextBoxTitle.Name = "itsTextBoxTitle";
            this.itsTextBoxTitle.Size = new System.Drawing.Size(164, 20);
            this.itsTextBoxTitle.TabIndex = 7;
            // 
            // itsLabelNumHours
            // 
            this.itsLabelNumHours.AutoSize = true;
            this.itsLabelNumHours.Location = new System.Drawing.Point(12, 62);
            this.itsLabelNumHours.Name = "itsLabelNumHours";
            this.itsLabelNumHours.Size = new System.Drawing.Size(62, 13);
            this.itsLabelNumHours.TabIndex = 6;
            this.itsLabelNumHours.Text = "Time spent:";
            // 
            // itsLabelTitle
            // 
            this.itsLabelTitle.AutoSize = true;
            this.itsLabelTitle.Location = new System.Drawing.Point(44, 22);
            this.itsLabelTitle.Name = "itsLabelTitle";
            this.itsLabelTitle.Size = new System.Drawing.Size(30, 13);
            this.itsLabelTitle.TabIndex = 5;
            this.itsLabelTitle.Text = "Title:";
            // 
            // itsNumericUpDownNumHours
            // 
            this.itsNumericUpDownNumHours.DecimalPlaces = 2;
            this.itsNumericUpDownNumHours.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.itsNumericUpDownNumHours.Location = new System.Drawing.Point(90, 55);
            this.itsNumericUpDownNumHours.Name = "itsNumericUpDownNumHours";
            this.itsNumericUpDownNumHours.Size = new System.Drawing.Size(163, 20);
            this.itsNumericUpDownNumHours.TabIndex = 8;
            this.itsNumericUpDownNumHours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // itsComboBoxTopic
            // 
            this.itsComboBoxTopic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itsComboBoxTopic.FormattingEnabled = true;
            this.itsComboBoxTopic.Location = new System.Drawing.Point(90, 100);
            this.itsComboBoxTopic.Name = "itsComboBoxTopic";
            this.itsComboBoxTopic.Size = new System.Drawing.Size(163, 21);
            this.itsComboBoxTopic.TabIndex = 9;
            // 
            // itsLabelTopic
            // 
            this.itsLabelTopic.AutoSize = true;
            this.itsLabelTopic.Location = new System.Drawing.Point(37, 108);
            this.itsLabelTopic.Name = "itsLabelTopic";
            this.itsLabelTopic.Size = new System.Drawing.Size(37, 13);
            this.itsLabelTopic.TabIndex = 6;
            this.itsLabelTopic.Text = "Topic:";
            // 
            // itsDateTimePicker
            // 
            this.itsDateTimePicker.Location = new System.Drawing.Point(90, 145);
            this.itsDateTimePicker.Name = "itsDateTimePicker";
            this.itsDateTimePicker.Size = new System.Drawing.Size(164, 20);
            this.itsDateTimePicker.TabIndex = 10;
            // 
            // itsButtonAddTask
            // 
            this.itsButtonAddTask.Location = new System.Drawing.Point(178, 186);
            this.itsButtonAddTask.Name = "itsButtonAddTask";
            this.itsButtonAddTask.Size = new System.Drawing.Size(75, 23);
            this.itsButtonAddTask.TabIndex = 11;
            this.itsButtonAddTask.Text = "Add";
            this.itsButtonAddTask.UseVisualStyleBackColor = true;
            this.itsButtonAddTask.Visible = false;
            this.itsButtonAddTask.Click += new System.EventHandler(this.ItsButtonAddTask_Click);
            // 
            // itsButtonEditTask
            // 
            this.itsButtonEditTask.Location = new System.Drawing.Point(179, 186);
            this.itsButtonEditTask.Name = "itsButtonEditTask";
            this.itsButtonEditTask.Size = new System.Drawing.Size(75, 23);
            this.itsButtonEditTask.TabIndex = 12;
            this.itsButtonEditTask.Text = "Done";
            this.itsButtonEditTask.UseVisualStyleBackColor = true;
            this.itsButtonEditTask.Visible = false;
            // 
            // itsLabelDateTime
            // 
            this.itsLabelDateTime.AutoSize = true;
            this.itsLabelDateTime.Location = new System.Drawing.Point(41, 152);
            this.itsLabelDateTime.Name = "itsLabelDateTime";
            this.itsLabelDateTime.Size = new System.Drawing.Size(33, 13);
            this.itsLabelDateTime.TabIndex = 6;
            this.itsLabelDateTime.Text = "Date:";
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(266, 224);
            this.Controls.Add(this.itsButtonEditTask);
            this.Controls.Add(this.itsButtonAddTask);
            this.Controls.Add(this.itsDateTimePicker);
            this.Controls.Add(this.itsComboBoxTopic);
            this.Controls.Add(this.itsNumericUpDownNumHours);
            this.Controls.Add(this.itsTextBoxTitle);
            this.Controls.Add(this.itsLabelDateTime);
            this.Controls.Add(this.itsLabelTopic);
            this.Controls.Add(this.itsLabelNumHours);
            this.Controls.Add(this.itsLabelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaskForm";
            this.Text = "TaskForm";
            ((System.ComponentModel.ISupportInitialize)(this.itsNumericUpDownNumHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox itsTextBoxTitle;
        private System.Windows.Forms.Label itsLabelNumHours;
        private System.Windows.Forms.Label itsLabelTitle;
        private System.Windows.Forms.NumericUpDown itsNumericUpDownNumHours;
        private System.Windows.Forms.ComboBox itsComboBoxTopic;
        private System.Windows.Forms.Label itsLabelTopic;
        private System.Windows.Forms.DateTimePicker itsDateTimePicker;
        private System.Windows.Forms.Button itsButtonAddTask;
        private System.Windows.Forms.Button itsButtonEditTask;
        private System.Windows.Forms.Label itsLabelDateTime;
    }
}