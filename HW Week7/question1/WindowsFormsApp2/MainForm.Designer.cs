namespace WindowsFormsApp2
{
    partial class MainForm
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
            this.btm_studentForm = new System.Windows.Forms.Button();
            this.btm_professorForm = new System.Windows.Forms.Button();
            this.btm_classForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btm_studentForm
            // 
            this.btm_studentForm.Location = new System.Drawing.Point(164, 169);
            this.btm_studentForm.Name = "btm_studentForm";
            this.btm_studentForm.Size = new System.Drawing.Size(138, 52);
            this.btm_studentForm.TabIndex = 1;
            this.btm_studentForm.Text = "Student Form";
            this.btm_studentForm.UseVisualStyleBackColor = true;
            this.btm_studentForm.Click += new System.EventHandler(this.btm_studentForm_Click);
            // 
            // btm_professorForm
            // 
            this.btm_professorForm.Location = new System.Drawing.Point(328, 169);
            this.btm_professorForm.Name = "btm_professorForm";
            this.btm_professorForm.Size = new System.Drawing.Size(128, 52);
            this.btm_professorForm.TabIndex = 2;
            this.btm_professorForm.Text = "Professor Form";
            this.btm_professorForm.UseVisualStyleBackColor = true;
            this.btm_professorForm.Click += new System.EventHandler(this.btm_professorForm_Click);
            // 
            // btm_classForm
            // 
            this.btm_classForm.Location = new System.Drawing.Point(479, 169);
            this.btm_classForm.Name = "btm_classForm";
            this.btm_classForm.Size = new System.Drawing.Size(136, 52);
            this.btm_classForm.TabIndex = 3;
            this.btm_classForm.Text = "Class Form";
            this.btm_classForm.UseVisualStyleBackColor = true;
            this.btm_classForm.Click += new System.EventHandler(this.btm_classForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btm_classForm);
            this.Controls.Add(this.btm_professorForm);
            this.Controls.Add(this.btm_studentForm);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btm_studentForm;
        private System.Windows.Forms.Button btm_professorForm;
        private System.Windows.Forms.Button btm_classForm;
    }
}

