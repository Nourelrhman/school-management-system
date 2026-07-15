namespace WindowsFormsApp3
{
    partial class Form3
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
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnAge = new System.Windows.Forms.Button();
            this.dgvMax = new System.Windows.Forms.DataGridView();
            this.dgvMin = new System.Windows.Forms.DataGridView();
            this.dgvAge = new System.Windows.Forms.DataGridView();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAge)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(78, 78);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(93, 23);
            this.btnMax.TabIndex = 0;
            this.btnMax.Text = "Max Score";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(340, 78);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(75, 23);
            this.btnMin.TabIndex = 1;
            this.btnMin.Text = "Min Score";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnAge
            // 
            this.btnAge.Location = new System.Drawing.Point(616, 78);
            this.btnAge.Name = "btnAge";
            this.btnAge.Size = new System.Drawing.Size(75, 23);
            this.btnAge.TabIndex = 2;
            this.btnAge.Text = "Age";
            this.btnAge.UseVisualStyleBackColor = true;
            this.btnAge.Click += new System.EventHandler(this.btnAge_Click);
            // 
            // dgvMax
            // 
            this.dgvMax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMax.Location = new System.Drawing.Point(12, 142);
            this.dgvMax.Name = "dgvMax";
            this.dgvMax.RowHeadersWidth = 51;
            this.dgvMax.RowTemplate.Height = 24;
            this.dgvMax.Size = new System.Drawing.Size(240, 150);
            this.dgvMax.TabIndex = 3;
            // 
            // dgvMin
            // 
            this.dgvMin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMin.Location = new System.Drawing.Point(272, 142);
            this.dgvMin.Name = "dgvMin";
            this.dgvMin.RowHeadersWidth = 51;
            this.dgvMin.RowTemplate.Height = 24;
            this.dgvMin.Size = new System.Drawing.Size(240, 150);
            this.dgvMin.TabIndex = 4;
            // 
            // dgvAge
            // 
            this.dgvAge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAge.Location = new System.Drawing.Point(548, 142);
            this.dgvAge.Name = "dgvAge";
            this.dgvAge.RowHeadersWidth = 51;
            this.dgvAge.RowTemplate.Height = 24;
            this.dgvAge.Size = new System.Drawing.Size(240, 150);
            this.dgvAge.TabIndex = 5;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(340, 356);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.dgvAge);
            this.Controls.Add(this.dgvMin);
            this.Controls.Add(this.dgvMax);
            this.Controls.Add(this.btnAge);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnAge;
        private System.Windows.Forms.DataGridView dgvMax;
        private System.Windows.Forms.DataGridView dgvMin;
        private System.Windows.Forms.DataGridView dgvAge;
        private System.Windows.Forms.Button btnNext;
    }
}