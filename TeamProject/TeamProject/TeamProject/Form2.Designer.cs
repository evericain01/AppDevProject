namespace TeamProject
{
    partial class studentForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentForm));
            this.studentListLabel = new System.Windows.Forms.Label();
            this.studentGrid = new System.Windows.Forms.DataGridView();
            this.addStuID = new System.Windows.Forms.TextBox();
            this.studentGradeLabel = new System.Windows.Forms.Label();
            this.addStuLabel = new System.Windows.Forms.Label();
            this.studentGradesGrid = new System.Windows.Forms.DataGridView();
            this.CategoryLetter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PointsEarned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuIDLabel = new System.Windows.Forms.Label();
            this.studentSectionNoLabel = new System.Windows.Forms.Label();
            this.addStuSecNo = new System.Windows.Forms.TextBox();
            this.stuFNameLabel = new System.Windows.Forms.Label();
            this.addStuFName = new System.Windows.Forms.TextBox();
            this.stuLNameLabel = new System.Windows.Forms.Label();
            this.addStuLName = new System.Windows.Forms.TextBox();
            this.addGradeCategoryLabel = new System.Windows.Forms.Label();
            this.addGradeLabel = new System.Windows.Forms.Label();
            this.addGradeItemlabel = new System.Windows.Forms.Label();
            this.addGradeItem = new System.Windows.Forms.TextBox();
            this.addGradePointsLabel = new System.Windows.Forms.Label();
            this.addGradePoints = new System.Windows.Forms.TextBox();
            this.addGradeBtn = new System.Windows.Forms.Button();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addGradeCategory = new System.Windows.Forms.ComboBox();
            this.addStuBtn = new System.Windows.Forms.Button();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectionNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.studentGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGradesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // studentListLabel
            // 
            this.studentListLabel.AutoSize = true;
            this.studentListLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentListLabel.Location = new System.Drawing.Point(27, 18);
            this.studentListLabel.Name = "studentListLabel";
            this.studentListLabel.Size = new System.Drawing.Size(119, 18);
            this.studentListLabel.TabIndex = 0;
            this.studentListLabel.Text = "List of Students :";
            // 
            // studentGrid
            // 
            this.studentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.SectionNumber,
            this.FirstName,
            this.LastName,
            this.FinalGrade});
            this.studentGrid.Location = new System.Drawing.Point(30, 46);
            this.studentGrid.Name = "studentGrid";
            this.studentGrid.RowHeadersWidth = 51;
            this.studentGrid.Size = new System.Drawing.Size(477, 176);
            this.studentGrid.TabIndex = 1;
            this.studentGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentGrid_CellClick);
            // 
            // addStuID
            // 
            this.addStuID.Location = new System.Drawing.Point(606, 61);
            this.addStuID.Name = "addStuID";
            this.addStuID.Size = new System.Drawing.Size(100, 20);
            this.addStuID.TabIndex = 2;
            // 
            // studentGradeLabel
            // 
            this.studentGradeLabel.AutoSize = true;
            this.studentGradeLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentGradeLabel.Location = new System.Drawing.Point(27, 232);
            this.studentGradeLabel.Name = "studentGradeLabel";
            this.studentGradeLabel.Size = new System.Drawing.Size(124, 18);
            this.studentGradeLabel.TabIndex = 3;
            this.studentGradeLabel.Text = "Student Grades:";
            // 
            // addStuLabel
            // 
            this.addStuLabel.AutoSize = true;
            this.addStuLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStuLabel.Location = new System.Drawing.Point(573, 29);
            this.addStuLabel.Name = "addStuLabel";
            this.addStuLabel.Size = new System.Drawing.Size(105, 18);
            this.addStuLabel.TabIndex = 4;
            this.addStuLabel.Text = "Add Student :";
            // 
            // studentGradesGrid
            // 
            this.studentGradesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGradesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryLetter,
            this.Item,
            this.PointsEarned});
            this.studentGradesGrid.Location = new System.Drawing.Point(30, 253);
            this.studentGradesGrid.Name = "studentGradesGrid";
            this.studentGradesGrid.RowHeadersWidth = 51;
            this.studentGradesGrid.Size = new System.Drawing.Size(428, 176);
            this.studentGradesGrid.TabIndex = 5;
            // 
            // CategoryLetter
            // 
            this.CategoryLetter.HeaderText = "Category Letter";
            this.CategoryLetter.MinimumWidth = 6;
            this.CategoryLetter.Name = "CategoryLetter";
            this.CategoryLetter.ReadOnly = true;
            this.CategoryLetter.Width = 125;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.MinimumWidth = 6;
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Width = 125;
            // 
            // PointsEarned
            // 
            this.PointsEarned.HeaderText = "Points Earned";
            this.PointsEarned.MinimumWidth = 6;
            this.PointsEarned.Name = "PointsEarned";
            this.PointsEarned.ReadOnly = true;
            this.PointsEarned.Width = 125;
            // 
            // stuIDLabel
            // 
            this.stuIDLabel.AutoSize = true;
            this.stuIDLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuIDLabel.Location = new System.Drawing.Point(517, 63);
            this.stuIDLabel.Name = "stuIDLabel";
            this.stuIDLabel.Size = new System.Drawing.Size(83, 17);
            this.stuIDLabel.TabIndex = 6;
            this.stuIDLabel.Text = "Student ID :";
            // 
            // studentSectionNoLabel
            // 
            this.studentSectionNoLabel.AutoSize = true;
            this.studentSectionNoLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentSectionNoLabel.Location = new System.Drawing.Point(521, 87);
            this.studentSectionNoLabel.Name = "studentSectionNoLabel";
            this.studentSectionNoLabel.Size = new System.Drawing.Size(78, 17);
            this.studentSectionNoLabel.TabIndex = 8;
            this.studentSectionNoLabel.Text = "Section # :";
            // 
            // addStuSecNo
            // 
            this.addStuSecNo.Location = new System.Drawing.Point(606, 87);
            this.addStuSecNo.Name = "addStuSecNo";
            this.addStuSecNo.Size = new System.Drawing.Size(100, 20);
            this.addStuSecNo.TabIndex = 7;
            // 
            // stuFNameLabel
            // 
            this.stuFNameLabel.AutoSize = true;
            this.stuFNameLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuFNameLabel.Location = new System.Drawing.Point(514, 113);
            this.stuFNameLabel.Name = "stuFNameLabel";
            this.stuFNameLabel.Size = new System.Drawing.Size(87, 17);
            this.stuFNameLabel.TabIndex = 10;
            this.stuFNameLabel.Text = "First Name :";
            // 
            // addStuFName
            // 
            this.addStuFName.Location = new System.Drawing.Point(606, 113);
            this.addStuFName.Name = "addStuFName";
            this.addStuFName.Size = new System.Drawing.Size(100, 20);
            this.addStuFName.TabIndex = 9;
            // 
            // stuLNameLabel
            // 
            this.stuLNameLabel.AutoSize = true;
            this.stuLNameLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuLNameLabel.Location = new System.Drawing.Point(513, 139);
            this.stuLNameLabel.Name = "stuLNameLabel";
            this.stuLNameLabel.Size = new System.Drawing.Size(87, 17);
            this.stuLNameLabel.TabIndex = 12;
            this.stuLNameLabel.Text = "Last Name :";
            // 
            // addStuLName
            // 
            this.addStuLName.Location = new System.Drawing.Point(606, 139);
            this.addStuLName.Name = "addStuLName";
            this.addStuLName.Size = new System.Drawing.Size(100, 20);
            this.addStuLName.TabIndex = 11;
            // 
            // addGradeCategoryLabel
            // 
            this.addGradeCategoryLabel.AutoSize = true;
            this.addGradeCategoryLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGradeCategoryLabel.Location = new System.Drawing.Point(520, 266);
            this.addGradeCategoryLabel.Name = "addGradeCategoryLabel";
            this.addGradeCategoryLabel.Size = new System.Drawing.Size(78, 17);
            this.addGradeCategoryLabel.TabIndex = 16;
            this.addGradeCategoryLabel.Text = "Category :";
            // 
            // addGradeLabel
            // 
            this.addGradeLabel.AutoSize = true;
            this.addGradeLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGradeLabel.Location = new System.Drawing.Point(586, 232);
            this.addGradeLabel.Name = "addGradeLabel";
            this.addGradeLabel.Size = new System.Drawing.Size(95, 18);
            this.addGradeLabel.TabIndex = 17;
            this.addGradeLabel.Text = "Add Grade:";
            // 
            // addGradeItemlabel
            // 
            this.addGradeItemlabel.AutoSize = true;
            this.addGradeItemlabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGradeItemlabel.Location = new System.Drawing.Point(550, 290);
            this.addGradeItemlabel.Name = "addGradeItemlabel";
            this.addGradeItemlabel.Size = new System.Drawing.Size(47, 17);
            this.addGradeItemlabel.TabIndex = 19;
            this.addGradeItemlabel.Text = "Item :";
            // 
            // addGradeItem
            // 
            this.addGradeItem.Location = new System.Drawing.Point(606, 288);
            this.addGradeItem.Name = "addGradeItem";
            this.addGradeItem.Size = new System.Drawing.Size(100, 20);
            this.addGradeItem.TabIndex = 18;
            // 
            // addGradePointsLabel
            // 
            this.addGradePointsLabel.AutoSize = true;
            this.addGradePointsLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGradePointsLabel.Location = new System.Drawing.Point(494, 318);
            this.addGradePointsLabel.Name = "addGradePointsLabel";
            this.addGradePointsLabel.Size = new System.Drawing.Size(103, 16);
            this.addGradePointsLabel.TabIndex = 21;
            this.addGradePointsLabel.Text = "Points Earned :";
            // 
            // addGradePoints
            // 
            this.addGradePoints.Location = new System.Drawing.Point(606, 314);
            this.addGradePoints.Name = "addGradePoints";
            this.addGradePoints.Size = new System.Drawing.Size(100, 20);
            this.addGradePoints.TabIndex = 20;
            // 
            // addGradeBtn
            // 
            this.addGradeBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGradeBtn.Location = new System.Drawing.Point(575, 358);
            this.addGradeBtn.Name = "addGradeBtn";
            this.addGradeBtn.Size = new System.Drawing.Size(87, 23);
            this.addGradeBtn.TabIndex = 23;
            this.addGradeBtn.Text = "Add Grade";
            this.addGradeBtn.UseVisualStyleBackColor = true;
            this.addGradeBtn.Click += new System.EventHandler(this.addGradeBtn_Click);
            // 
            // addGradeCategory
            // 
            this.addGradeCategory.FormattingEnabled = true;
            this.addGradeCategory.Location = new System.Drawing.Point(606, 262);
            this.addGradeCategory.Name = "addGradeCategory";
            this.addGradeCategory.Size = new System.Drawing.Size(100, 21);
            this.addGradeCategory.TabIndex = 24;
            // 
            // addStuBtn
            // 
            this.addStuBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStuBtn.Location = new System.Drawing.Point(575, 183);
            this.addStuBtn.Name = "addStuBtn";
            this.addStuBtn.Size = new System.Drawing.Size(88, 23);
            this.addStuBtn.TabIndex = 22;
            this.addStuBtn.Text = "Add Student";
            this.addStuBtn.UseVisualStyleBackColor = true;
            this.addStuBtn.Click += new System.EventHandler(this.addStuBtn_Click);
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "ID";
            this.StudentID.MinimumWidth = 6;
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            this.StudentID.Width = 70;
            // 
            // SectionNumber
            // 
            this.SectionNumber.HeaderText = "Section Number";
            this.SectionNumber.MinimumWidth = 6;
            this.SectionNumber.Name = "SectionNumber";
            this.SectionNumber.ReadOnly = true;
            this.SectionNumber.Width = 85;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 90;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 90;
            // 
            // FinalGrade
            // 
            this.FinalGrade.HeaderText = "Final Grade";
            this.FinalGrade.MinimumWidth = 6;
            this.FinalGrade.Name = "FinalGrade";
            this.FinalGrade.ReadOnly = true;
            this.FinalGrade.Width = 90;
            // 
            // studentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addGradeCategory);
            this.Controls.Add(this.addGradeBtn);
            this.Controls.Add(this.addStuBtn);
            this.Controls.Add(this.addGradePointsLabel);
            this.Controls.Add(this.addGradePoints);
            this.Controls.Add(this.addGradeItemlabel);
            this.Controls.Add(this.addGradeItem);
            this.Controls.Add(this.addGradeLabel);
            this.Controls.Add(this.addGradeCategoryLabel);
            this.Controls.Add(this.stuLNameLabel);
            this.Controls.Add(this.addStuLName);
            this.Controls.Add(this.stuFNameLabel);
            this.Controls.Add(this.addStuFName);
            this.Controls.Add(this.studentSectionNoLabel);
            this.Controls.Add(this.addStuSecNo);
            this.Controls.Add(this.stuIDLabel);
            this.Controls.Add(this.studentGradesGrid);
            this.Controls.Add(this.addStuLabel);
            this.Controls.Add(this.studentGradeLabel);
            this.Controls.Add(this.addStuID);
            this.Controls.Add(this.studentGrid);
            this.Controls.Add(this.studentListLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "studentForm";
            this.Text = "Student Viewer";
            this.Load += new System.EventHandler(this.studentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGradesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentListLabel;
        private System.Windows.Forms.DataGridView studentGrid;
        private System.Windows.Forms.TextBox addStuID;
        private System.Windows.Forms.Label studentGradeLabel;
        private System.Windows.Forms.Label addStuLabel;
        private System.Windows.Forms.DataGridView studentGradesGrid;
        private System.Windows.Forms.Label stuIDLabel;
        private System.Windows.Forms.Label studentSectionNoLabel;
        private System.Windows.Forms.TextBox addStuSecNo;
        private System.Windows.Forms.Label stuFNameLabel;
        private System.Windows.Forms.TextBox addStuFName;
        private System.Windows.Forms.Label stuLNameLabel;
        private System.Windows.Forms.TextBox addStuLName;
        private System.Windows.Forms.Label addGradeCategoryLabel;
        private System.Windows.Forms.Label addGradeLabel;
        private System.Windows.Forms.Label addGradeItemlabel;
        private System.Windows.Forms.TextBox addGradeItem;
        private System.Windows.Forms.Label addGradePointsLabel;
        private System.Windows.Forms.TextBox addGradePoints;
        private System.Windows.Forms.Button addGradeBtn;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryLetter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn PointsEarned;
        private System.Windows.Forms.ComboBox addGradeCategory;
        private System.Windows.Forms.Button addStuBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectionNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalGrade;
    }
}