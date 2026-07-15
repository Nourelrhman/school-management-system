namespace WindowsFormsApp3
{
    partial class Form5
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
            this.btnInner = new System.Windows.Forms.Button();
            this.btnOuter = new System.Windows.Forms.Button();
            this.dgvInner = new System.Windows.Forms.DataGridView();
            this.dgvOuter = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOuter)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInner
            // 
            this.btnInner.Location = new System.Drawing.Point(119, 76);
            this.btnInner.Name = "btnInner";
            this.btnInner.Size = new System.Drawing.Size(75, 23);
            this.btnInner.TabIndex = 0;
            this.btnInner.Text = "inner join";
            this.btnInner.UseVisualStyleBackColor = true;
            this.btnInner.Click += new System.EventHandler(this.btnInner_Click);
            // 
            // btnOuter
            // 
            this.btnOuter.Location = new System.Drawing.Point(590, 76);
            this.btnOuter.Name = "btnOuter";
            this.btnOuter.Size = new System.Drawing.Size(75, 23);
            this.btnOuter.TabIndex = 1;
            this.btnOuter.Text = "outer join";
            this.btnOuter.UseVisualStyleBackColor = true;
            this.btnOuter.Click += new System.EventHandler(this.btnOuter_Click);
            // 
            // dgvInner
            // 
            this.dgvInner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInner.Location = new System.Drawing.Point(12, 105);
            this.dgvInner.Name = "dgvInner";
            this.dgvInner.RowHeadersWidth = 51;
            this.dgvInner.RowTemplate.Height = 24;
            this.dgvInner.Size = new System.Drawing.Size(357, 333);
            this.dgvInner.TabIndex = 2;
            // 
            // dgvOuter
            // 
            this.dgvOuter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOuter.Location = new System.Drawing.Point(431, 105);
            this.dgvOuter.Name = "dgvOuter";
            this.dgvOuter.RowHeadersWidth = 51;
            this.dgvOuter.RowTemplate.Height = 24;
            this.dgvOuter.Size = new System.Drawing.Size(357, 333);
            this.dgvOuter.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.dgvOuter);
            this.Controls.Add(this.dgvInner);
            this.Controls.Add(this.btnOuter);
            this.Controls.Add(this.btnInner);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOuter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInner;
        private System.Windows.Forms.Button btnOuter;
        private System.Windows.Forms.DataGridView dgvInner;
        private System.Windows.Forms.DataGridView dgvOuter;
        private System.Windows.Forms.Button btnLogout;
    }
}