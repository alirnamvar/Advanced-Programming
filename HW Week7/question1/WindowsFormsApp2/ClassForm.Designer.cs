namespace WindowsFormsApp2
{
    partial class ClassForm
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl_classForm = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comBox_field = new System.Windows.Forms.ComboBox();
            this.btn_createClass = new System.Windows.Forms.Button();
            this.txtBox_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_classID = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_addStudent = new System.Windows.Forms.Button();
            this.txtBox_studentID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBox_studentClassID = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comBox_professor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_addProfessor = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBox_professorClassID = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox_professorName = new System.Windows.Forms.GroupBox();
            this.lbl_professorName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_serachStudents = new System.Windows.Forms.Button();
            this.txtBox_searchClassID = new System.Windows.Forms.TextBox();
            this.dataGridView_students = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identicalNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intFieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enteringYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.tabControl_classForm.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox_professorName.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // tabControl_classForm
            // 
            this.tabControl_classForm.Controls.Add(this.tabPage1);
            this.tabControl_classForm.Controls.Add(this.tabPage2);
            this.tabControl_classForm.Controls.Add(this.tabPage3);
            this.tabControl_classForm.Controls.Add(this.tabPage4);
            this.tabControl_classForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_classForm.Location = new System.Drawing.Point(0, 0);
            this.tabControl_classForm.Name = "tabControl_classForm";
            this.tabControl_classForm.SelectedIndex = 0;
            this.tabControl_classForm.Size = new System.Drawing.Size(800, 450);
            this.tabControl_classForm.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create Class";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comBox_field);
            this.groupBox1.Controls.Add(this.btn_createClass);
            this.groupBox1.Controls.Add(this.txtBox_name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBox_classID);
            this.groupBox1.Location = new System.Drawing.Point(196, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 223);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // comBox_field
            // 
            this.comBox_field.FormattingEnabled = true;
            this.comBox_field.Location = new System.Drawing.Point(122, 116);
            this.comBox_field.Name = "comBox_field";
            this.comBox_field.Size = new System.Drawing.Size(177, 24);
            this.comBox_field.TabIndex = 8;
            // 
            // btn_createClass
            // 
            this.btn_createClass.Location = new System.Drawing.Point(122, 156);
            this.btn_createClass.Name = "btn_createClass";
            this.btn_createClass.Size = new System.Drawing.Size(177, 27);
            this.btn_createClass.TabIndex = 6;
            this.btn_createClass.Text = "Create";
            this.btn_createClass.UseVisualStyleBackColor = true;
            this.btn_createClass.Click += new System.EventHandler(this.btn_createClass_Click);
            // 
            // txtBox_name
            // 
            this.txtBox_name.Location = new System.Drawing.Point(122, 45);
            this.txtBox_name.Name = "txtBox_name";
            this.txtBox_name.Size = new System.Drawing.Size(176, 22);
            this.txtBox_name.TabIndex = 0;
            this.txtBox_name.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_name_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Field";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Class ID";
            // 
            // txtBox_classID
            // 
            this.txtBox_classID.Location = new System.Drawing.Point(122, 78);
            this.txtBox_classID.Name = "txtBox_classID";
            this.txtBox_classID.Size = new System.Drawing.Size(177, 22);
            this.txtBox_classID.TabIndex = 4;
            this.txtBox_classID.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_classID_Validating);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Student";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn_addStudent);
            this.groupBox2.Controls.Add(this.txtBox_studentID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtBox_studentClassID);
            this.groupBox2.Location = new System.Drawing.Point(216, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 187);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Identical Number";
            // 
            // btn_addStudent
            // 
            this.btn_addStudent.Location = new System.Drawing.Point(154, 115);
            this.btn_addStudent.Name = "btn_addStudent";
            this.btn_addStudent.Size = new System.Drawing.Size(177, 27);
            this.btn_addStudent.TabIndex = 6;
            this.btn_addStudent.Text = "Add to Class";
            this.btn_addStudent.UseVisualStyleBackColor = true;
            this.btn_addStudent.Click += new System.EventHandler(this.btn_addStudent_Click);
            // 
            // txtBox_studentID
            // 
            this.txtBox_studentID.Location = new System.Drawing.Point(154, 45);
            this.txtBox_studentID.Name = "txtBox_studentID";
            this.txtBox_studentID.Size = new System.Drawing.Size(176, 22);
            this.txtBox_studentID.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Class ID";
            // 
            // txtBox_studentClassID
            // 
            this.txtBox_studentClassID.Location = new System.Drawing.Point(153, 78);
            this.txtBox_studentClassID.Name = "txtBox_studentClassID";
            this.txtBox_studentClassID.Size = new System.Drawing.Size(177, 22);
            this.txtBox_studentClassID.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Add Professor";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comBox_professor);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btn_addProfessor);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtBox_professorClassID);
            this.groupBox3.Location = new System.Drawing.Point(211, 105);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(366, 187);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Professor Info";
            // 
            // comBox_professor
            // 
            this.comBox_professor.FormattingEnabled = true;
            this.comBox_professor.Location = new System.Drawing.Point(153, 74);
            this.comBox_professor.Name = "comBox_professor";
            this.comBox_professor.Size = new System.Drawing.Size(177, 24);
            this.comBox_professor.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Professor";
            // 
            // btn_addProfessor
            // 
            this.btn_addProfessor.Location = new System.Drawing.Point(153, 113);
            this.btn_addProfessor.Name = "btn_addProfessor";
            this.btn_addProfessor.Size = new System.Drawing.Size(177, 27);
            this.btn_addProfessor.TabIndex = 6;
            this.btn_addProfessor.Text = "Add to Class";
            this.btn_addProfessor.UseVisualStyleBackColor = true;
            this.btn_addProfessor.Click += new System.EventHandler(this.btn_addProfessor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Class ID";
            // 
            // txtBox_professorClassID
            // 
            this.txtBox_professorClassID.Location = new System.Drawing.Point(153, 40);
            this.txtBox_professorClassID.Name = "txtBox_professorClassID";
            this.txtBox_professorClassID.Size = new System.Drawing.Size(177, 22);
            this.txtBox_professorClassID.TabIndex = 4;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox_professorName);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Controls.Add(this.dataGridView_students);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 421);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Class Information";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox_professorName
            // 
            this.groupBox_professorName.Controls.Add(this.lbl_professorName);
            this.groupBox_professorName.Controls.Add(this.label9);
            this.groupBox_professorName.Location = new System.Drawing.Point(414, 6);
            this.groupBox_professorName.Name = "groupBox_professorName";
            this.groupBox_professorName.Size = new System.Drawing.Size(323, 84);
            this.groupBox_professorName.TabIndex = 10;
            this.groupBox_professorName.TabStop = false;
            this.groupBox_professorName.Visible = false;
            // 
            // lbl_professorName
            // 
            this.lbl_professorName.AutoSize = true;
            this.lbl_professorName.Location = new System.Drawing.Point(177, 39);
            this.lbl_professorName.Name = "lbl_professorName";
            this.lbl_professorName.Size = new System.Drawing.Size(40, 16);
            this.lbl_professorName.TabIndex = 1;
            this.lbl_professorName.Text = "None";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(93, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Professor:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.btn_serachStudents);
            this.groupBox4.Controls.Add(this.txtBox_searchClassID);
            this.groupBox4.Location = new System.Drawing.Point(62, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(346, 84);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Class ID";
            // 
            // btn_serachStudents
            // 
            this.btn_serachStudents.Location = new System.Drawing.Point(101, 50);
            this.btn_serachStudents.Name = "btn_serachStudents";
            this.btn_serachStudents.Size = new System.Drawing.Size(177, 30);
            this.btn_serachStudents.TabIndex = 9;
            this.btn_serachStudents.Text = "Search";
            this.btn_serachStudents.UseVisualStyleBackColor = true;
            this.btn_serachStudents.Click += new System.EventHandler(this.btn_serachStudents_Click);
            // 
            // txtBox_searchClassID
            // 
            this.txtBox_searchClassID.Location = new System.Drawing.Point(101, 22);
            this.txtBox_searchClassID.Name = "txtBox_searchClassID";
            this.txtBox_searchClassID.Size = new System.Drawing.Size(177, 22);
            this.txtBox_searchClassID.TabIndex = 8;
            // 
            // dataGridView_students
            // 
            this.dataGridView_students.AutoGenerateColumns = false;
            this.dataGridView_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_students.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.identicalNumDataGridViewTextBoxColumn,
            this.fieldDataGridViewTextBoxColumn,
            this.intFieldDataGridViewTextBoxColumn,
            this.enteringYearDataGridViewTextBoxColumn});
            this.dataGridView_students.DataSource = this.studentBindingSource;
            this.dataGridView_students.Location = new System.Drawing.Point(62, 96);
            this.dataGridView_students.Name = "dataGridView_students";
            this.dataGridView_students.RowHeadersWidth = 51;
            this.dataGridView_students.RowTemplate.Height = 24;
            this.dataGridView_students.Size = new System.Drawing.Size(675, 311);
            this.dataGridView_students.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 124;
            // 
            // identicalNumDataGridViewTextBoxColumn
            // 
            this.identicalNumDataGridViewTextBoxColumn.DataPropertyName = "IdenticalNum";
            this.identicalNumDataGridViewTextBoxColumn.HeaderText = "IdenticalNum";
            this.identicalNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.identicalNumDataGridViewTextBoxColumn.Name = "identicalNumDataGridViewTextBoxColumn";
            this.identicalNumDataGridViewTextBoxColumn.Width = 124;
            // 
            // fieldDataGridViewTextBoxColumn
            // 
            this.fieldDataGridViewTextBoxColumn.DataPropertyName = "Field";
            this.fieldDataGridViewTextBoxColumn.HeaderText = "Field";
            this.fieldDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fieldDataGridViewTextBoxColumn.Name = "fieldDataGridViewTextBoxColumn";
            this.fieldDataGridViewTextBoxColumn.Width = 124;
            // 
            // intFieldDataGridViewTextBoxColumn
            // 
            this.intFieldDataGridViewTextBoxColumn.DataPropertyName = "IntField";
            this.intFieldDataGridViewTextBoxColumn.HeaderText = "IntField";
            this.intFieldDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.intFieldDataGridViewTextBoxColumn.Name = "intFieldDataGridViewTextBoxColumn";
            this.intFieldDataGridViewTextBoxColumn.Width = 124;
            // 
            // enteringYearDataGridViewTextBoxColumn
            // 
            this.enteringYearDataGridViewTextBoxColumn.DataPropertyName = "EnteringYear";
            this.enteringYearDataGridViewTextBoxColumn.HeaderText = "EnteringYear";
            this.enteringYearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.enteringYearDataGridViewTextBoxColumn.Name = "enteringYearDataGridViewTextBoxColumn";
            this.enteringYearDataGridViewTextBoxColumn.Width = 124;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(WindowsFormsApp2.Student);
            // 
            // ClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl_classForm);
            this.Name = "ClassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClassForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.tabControl_classForm.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox_professorName.ResumeLayout(false);
            this.groupBox_professorName.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_students)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.TabControl tabControl_classForm;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comBox_field;
        private System.Windows.Forms.Button btn_createClass;
        private System.Windows.Forms.TextBox txtBox_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_classID;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_addStudent;
        private System.Windows.Forms.TextBox txtBox_studentID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBox_studentClassID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_addProfessor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBox_professorClassID;
        private System.Windows.Forms.ComboBox comBox_professor;
        private System.Windows.Forms.DataGridView dataGridView_students;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_serachStudents;
        private System.Windows.Forms.TextBox txtBox_searchClassID;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.GroupBox groupBox_professorName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn identicalNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intFieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enteringYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbl_professorName;
    }
}