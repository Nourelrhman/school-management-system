namespace WindowsFormsApp3
{
    partial class Form4
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
            this.btnSub1 = new System.Windows.Forms.Button();
            this.btnSub2 = new System.Windows.Forms.Button();
            this.btnSub3 = new System.Windows.Forms.Button();
            this.dgvSub1 = new System.Windows.Forms.DataGridView();
            this.dgvSub2 = new System.Windows.Forms.DataGridView();
            this.dgvSub3 = new System.Windows.Forms.DataGridView();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSub1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSub2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSub3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSub1
            // 
            this.btnSub1.Location = new System.Drawing.Point(46, 51);
            this.btnSub1.Name = "btnSub1";
            this.btnSub1.Size = new System.Drawing.Size(131, 23);
            this.btnSub1.TabIndex = 0;
            this.btnSub1.Text = "More Than AVG";
            this.btnSub1.UseVisualStyleBackColor = true;
            this.btnSub1.Click += new System.EventHandler(this.btnSub1_Click);
            // 
            // btnSub2
            // 
            this.btnSub2.Location = new System.Drawing.Point(332, 51);
            this.btnSub2.Name = "btnSub2";
            this.btnSub2.Size = new System.Drawing.Size(126, 23);
            this.btnSub2.TabIndex = 1;
            this.btnSub2.Text = "Subj After 2020";
            this.btnSub2.UseVisualStyleBackColor = true;
            this.btnSub2.Click += new System.EventHandler(this.btnSub2_Click);
            // 
            // btnSub3
            // 
            this.btnSub3.Location = new System.Drawing.Point(630, 51);
            this.btnSub3.Name = "btnSub3";
            this.btnSub3.Size = new System.Drawing.Size(135, 23);
            this.btnSub3.TabIndex = 2;
            this.btnSub3.Text = "Student Enrollment";
            this.btnSub3.UseVisualStyleBackColor = true;
            this.btnSub3.Click += new System.EventHandler(this.btnSub3_Click);
            // 
            // dgvSub1
            // 
            this.dgvSub1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSub1.Location = new System.Drawing.Point(2, 149);
            this.dgvSub1.Name = "dgvSub1";
            this.dgvSub1.RowHeadersWidth = 51;
            this.dgvSub1.RowTemplate.Height = 24;
            this.dgvSub1.Size = new System.Drawing.Size(240, 150);
            this.dgvSub1.TabIndex = 3;
            // 
            // dgvSub2
            // 
            this.dgvSub2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSub2.Location = new System.Drawing.Point(276, 149);
            this.dgvSub2.Name = "dgvSub2";
            this.dgvSub2.RowHeadersWidth = 51;
            this.dgvSub2.RowTemplate.Height = 24;
            this.dgvSub2.Size = new System.Drawing.Size(240, 150);
            this.dgvSub2.TabIndex = 4;
            // 
            // dgvSub3
            // 
            this.dgvSub3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSub3.Location = new System.Drawing.Point(559, 149);
            this.dgvSub3.Name = "dgvSub3";
            this.dgvSub3.RowHeadersWidth = 51;
            this.dgvSub3.RowTemplate.Height = 24;
            this.dgvSub3.Size = new System.Drawing.Size(240, 150);
            this.dgvSub3.TabIndex = 5;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(353, 363);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.dgvSub3);
            this.Controls.Add(this.dgvSub2);
            this.Controls.Add(this.dgvSub1);
            this.Controls.Add(this.btnSub3);
            this.Controls.Add(this.btnSub2);
            this.Controls.Add(this.btnSub1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSub1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSub2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSub3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSub1;
        private System.Windows.Forms.Button btnSub2;
        private System.Windows.Forms.Button btnSub3;
        private System.Windows.Forms.DataGridView dgvSub1;
        private System.Windows.Forms.DataGridView dgvSub2;
        private System.Windows.Forms.DataGridView dgvSub3;
        private System.Windows.Forms.Button btnNext;
    }
}