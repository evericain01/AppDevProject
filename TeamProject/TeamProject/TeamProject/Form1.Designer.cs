namespace TeamProject
{
    partial class courseChooserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(courseChooserForm));
            this.courseNoLabel = new System.Windows.Forms.Label();
            this.potentialCourseNo = new System.Windows.Forms.TextBox();
            this.showStudentsBtn = new System.Windows.Forms.Button();
            this.showCategoriesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // courseNoLabel
            // 
            this.courseNoLabel.AutoSize = true;
            this.courseNoLabel.Location = new System.Drawing.Point(69, 10);
            this.courseNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.courseNoLabel.Name = "courseNoLabel";
            this.courseNoLabel.Size = new System.Drawing.Size(117, 17);
            this.courseNoLabel.TabIndex = 0;
            this.courseNoLabel.Text = "Course Number:";
            // 
            // potentialCourseNo
            // 
            this.potentialCourseNo.Location = new System.Drawing.Point(63, 31);
            this.potentialCourseNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.potentialCourseNo.Name = "potentialCourseNo";
            this.potentialCourseNo.Size = new System.Drawing.Size(132, 23);
            this.potentialCourseNo.TabIndex = 1;
            // 
            // showStudentsBtn
            // 
            this.showStudentsBtn.Location = new System.Drawing.Point(16, 76);
            this.showStudentsBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showStudentsBtn.Name = "showStudentsBtn";
            this.showStudentsBtn.Size = new System.Drawing.Size(100, 28);
            this.showStudentsBtn.TabIndex = 2;
            this.showStudentsBtn.Text = "Students";
            this.showStudentsBtn.UseVisualStyleBackColor = true;
            this.showStudentsBtn.Click += new System.EventHandler(this.showStudentsBtn_Click);
            // 
            // showCategoriesBtn
            // 
            this.showCategoriesBtn.Location = new System.Drawing.Point(137, 76);
            this.showCategoriesBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showCategoriesBtn.Name = "showCategoriesBtn";
            this.showCategoriesBtn.Size = new System.Drawing.Size(100, 28);
            this.showCategoriesBtn.TabIndex = 3;
            this.showCategoriesBtn.Text = "Categories";
            this.showCategoriesBtn.UseVisualStyleBackColor = true;
            this.showCategoriesBtn.Click += new System.EventHandler(this.showCategoriesBtn_Click);
            // 
            // courseChooserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 127);
            this.Controls.Add(this.showCategoriesBtn);
            this.Controls.Add(this.showStudentsBtn);
            this.Controls.Add(this.potentialCourseNo);
            this.Controls.Add(this.courseNoLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "courseChooserForm";
            this.Text = "Course Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label courseNoLabel;
        private System.Windows.Forms.TextBox potentialCourseNo;
        private System.Windows.Forms.Button showStudentsBtn;
        private System.Windows.Forms.Button showCategoriesBtn;
    }
}

