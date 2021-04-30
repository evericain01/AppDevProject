namespace TeamProject
{
    partial class categoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(categoryForm));
            this.label1 = new System.Windows.Forms.Label();
            this.categoriesGrid = new System.Windows.Forms.DataGridView();
            this.addCategoryName = new System.Windows.Forms.TextBox();
            this.addCategoryBtn = new System.Windows.Forms.Button();
            this.addCategoryLabel = new System.Windows.Forms.Label();
            this.addCategoryNamelabel = new System.Windows.Forms.Label();
            this.addCategoryWeightLabel = new System.Windows.Forms.Label();
            this.addCategoryWeight = new System.Windows.Forms.TextBox();
            this.addCategoryNoOfAssessLabel = new System.Windows.Forms.Label();
            this.addCategoryNoOfAssessment = new System.Windows.Forms.TextBox();
            this.CategoryNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssessmentWeights = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumOfAssessments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categories:";
            // 
            // categoriesGrid
            // 
            this.categoriesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryNames,
            this.AssessmentWeights,
            this.NumOfAssessments});
            this.categoriesGrid.Location = new System.Drawing.Point(13, 49);
            this.categoriesGrid.Name = "categoriesGrid";
            this.categoriesGrid.RowHeadersWidth = 51;
            this.categoriesGrid.Size = new System.Drawing.Size(401, 228);
            this.categoriesGrid.TabIndex = 1;
            // 
            // addCategoryName
            // 
            this.addCategoryName.Location = new System.Drawing.Point(579, 98);
            this.addCategoryName.Name = "addCategoryName";
            this.addCategoryName.Size = new System.Drawing.Size(100, 20);
            this.addCategoryName.TabIndex = 2;
            // 
            // addCategoryBtn
            // 
            this.addCategoryBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addCategoryBtn.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategoryBtn.Location = new System.Drawing.Point(522, 220);
            this.addCategoryBtn.Name = "addCategoryBtn";
            this.addCategoryBtn.Size = new System.Drawing.Size(82, 23);
            this.addCategoryBtn.TabIndex = 3;
            this.addCategoryBtn.Text = "Add Category";
            this.addCategoryBtn.UseVisualStyleBackColor = false;
            this.addCategoryBtn.Click += new System.EventHandler(this.addCategoryBtn_Click);
            // 
            // addCategoryLabel
            // 
            this.addCategoryLabel.AutoSize = true;
            this.addCategoryLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategoryLabel.Location = new System.Drawing.Point(519, 63);
            this.addCategoryLabel.Name = "addCategoryLabel";
            this.addCategoryLabel.Size = new System.Drawing.Size(127, 19);
            this.addCategoryLabel.TabIndex = 4;
            this.addCategoryLabel.Text = "Add Category :";
            // 
            // addCategoryNamelabel
            // 
            this.addCategoryNamelabel.AutoSize = true;
            this.addCategoryNamelabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategoryNamelabel.Location = new System.Drawing.Point(497, 100);
            this.addCategoryNamelabel.Name = "addCategoryNamelabel";
            this.addCategoryNamelabel.Size = new System.Drawing.Size(58, 17);
            this.addCategoryNamelabel.TabIndex = 5;
            this.addCategoryNamelabel.Text = "Name :";
            // 
            // addCategoryWeightLabel
            // 
            this.addCategoryWeightLabel.AutoSize = true;
            this.addCategoryWeightLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategoryWeightLabel.Location = new System.Drawing.Point(494, 134);
            this.addCategoryWeightLabel.Name = "addCategoryWeightLabel";
            this.addCategoryWeightLabel.Size = new System.Drawing.Size(63, 17);
            this.addCategoryWeightLabel.TabIndex = 7;
            this.addCategoryWeightLabel.Text = "Weight :";
            // 
            // addCategoryWeight
            // 
            this.addCategoryWeight.Location = new System.Drawing.Point(579, 134);
            this.addCategoryWeight.Name = "addCategoryWeight";
            this.addCategoryWeight.Size = new System.Drawing.Size(100, 20);
            this.addCategoryWeight.TabIndex = 6;
            // 
            // addCategoryNoOfAssessLabel
            // 
            this.addCategoryNoOfAssessLabel.AutoSize = true;
            this.addCategoryNoOfAssessLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategoryNoOfAssessLabel.Location = new System.Drawing.Point(430, 180);
            this.addCategoryNoOfAssessLabel.Name = "addCategoryNoOfAssessLabel";
            this.addCategoryNoOfAssessLabel.Size = new System.Drawing.Size(129, 17);
            this.addCategoryNoOfAssessLabel.TabIndex = 9;
            this.addCategoryNoOfAssessLabel.Text = "# of Assessments :";
            // 
            // addCategoryNoOfAssessment
            // 
            this.addCategoryNoOfAssessment.Location = new System.Drawing.Point(579, 177);
            this.addCategoryNoOfAssessment.Name = "addCategoryNoOfAssessment";
            this.addCategoryNoOfAssessment.Size = new System.Drawing.Size(100, 20);
            this.addCategoryNoOfAssessment.TabIndex = 8;
            // 
            // CategoryNames
            // 
            this.CategoryNames.HeaderText = "Categories";
            this.CategoryNames.MinimumWidth = 6;
            this.CategoryNames.Name = "CategoryNames";
            this.CategoryNames.ReadOnly = true;
            // 
            // AssessmentWeights
            // 
            this.AssessmentWeights.HeaderText = "Assessment Weights";
            this.AssessmentWeights.MinimumWidth = 6;
            this.AssessmentWeights.Name = "AssessmentWeights";
            this.AssessmentWeights.ReadOnly = true;
            this.AssessmentWeights.Width = 125;
            // 
            // NumOfAssessments
            // 
            this.NumOfAssessments.HeaderText = "# of Assessments";
            this.NumOfAssessments.MinimumWidth = 6;
            this.NumOfAssessments.Name = "NumOfAssessments";
            this.NumOfAssessments.ReadOnly = true;
            this.NumOfAssessments.Width = 125;
            // 
            // categoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(711, 306);
            this.Controls.Add(this.addCategoryNoOfAssessLabel);
            this.Controls.Add(this.addCategoryNoOfAssessment);
            this.Controls.Add(this.addCategoryWeightLabel);
            this.Controls.Add(this.addCategoryWeight);
            this.Controls.Add(this.addCategoryNamelabel);
            this.Controls.Add(this.addCategoryLabel);
            this.Controls.Add(this.addCategoryBtn);
            this.Controls.Add(this.addCategoryName);
            this.Controls.Add(this.categoriesGrid);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "categoryForm";
            this.Text = "Category Viewer";
            this.Load += new System.EventHandler(this.categoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView categoriesGrid;
        private System.Windows.Forms.TextBox addCategoryName;
        private System.Windows.Forms.Button addCategoryBtn;
        private System.Windows.Forms.Label addCategoryLabel;
        private System.Windows.Forms.Label addCategoryNamelabel;
        private System.Windows.Forms.Label addCategoryWeightLabel;
        private System.Windows.Forms.TextBox addCategoryWeight;
        private System.Windows.Forms.Label addCategoryNoOfAssessLabel;
        private System.Windows.Forms.TextBox addCategoryNoOfAssessment;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssessmentWeights;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumOfAssessments;
    }
}