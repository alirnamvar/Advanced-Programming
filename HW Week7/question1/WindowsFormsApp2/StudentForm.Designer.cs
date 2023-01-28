namespace WindowsFormsApp2
{
    partial class StudentForm
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
            this.tabControl_studentForm = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_enteringYear = new System.Windows.Forms.NumericUpDown();
            this.comBox_field = new System.Windows.Forms.ComboBox();
            this.txtBox_name = new System.Windows.Forms.TextBox();
            this.lbl_enteringYear = new System.Windows.Forms.Label();
            this.lbl_studentName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_registerStudent = new System.Windows.Forms.Button();
            this.txtBox_identicalNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBox_studentIDStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_showStatus = new System.Windows.Forms.Button();
            this.dataGridView_studentsStatus = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.registeredClassesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intFieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassProfessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl_studentForm.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_enteringYear)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_studentsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registeredClassesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_studentForm
            // 
            this.tabControl_studentForm.Controls.Add(this.tabPage1);
            this.tabControl_studentForm.Controls.Add(this.tabPage2);
            this.tabControl_studentForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_studentForm.Location = new System.Drawing.Point(0, 0);
            this.tabControl_studentForm.Name = "tabControl_studentForm";
            this.tabControl_studentForm.SelectedIndex = 0;
            this.tabControl_studentForm.Size = new System.Drawing.Size(800, 450);
            this.tabControl_studentForm.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Register Student";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown_enteringYear);
            this.groupBox2.Controls.Add(this.comBox_field);
            this.groupBox2.Controls.Add(this.txtBox_name);
            this.groupBox2.Controls.Add(this.lbl_enteringYear);
            this.groupBox2.Controls.Add(this.lbl_studentName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn_registerStudent);
            this.groupBox2.Controls.Add(this.txtBox_identicalNumber);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(192, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 292);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Info";
            // 
            // numericUpDown_enteringYear
            // 
            this.numericUpDown_enteringYear.Location = new System.Drawing.Point(157, 130);
            this.numericUpDown_enteringYear.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numericUpDown_enteringYear.Minimum = new decimal(new int[] {
            1300,
            0,
            0,
            0});
            this.numericUpDown_enteringYear.Name = "numericUpDown_enteringYear";
            this.numericUpDown_enteringYear.Size = new System.Drawing.Size(176, 22);
            this.numericUpDown_enteringYear.TabIndex = 12;
            this.numericUpDown_enteringYear.Value = new decimal(new int[] {
            1300,
            0,
            0,
            0});
            // 
            // comBox_field
            // 
            this.comBox_field.FormattingEnabled = true;
            this.comBox_field.Location = new System.Drawing.Point(157, 170);
            this.comBox_field.Name = "comBox_field";
            this.comBox_field.Size = new System.Drawing.Size(177, 24);
            this.comBox_field.TabIndex = 11;
            // 
            // txtBox_name
            // 
            this.txtBox_name.Location = new System.Drawing.Point(157, 49);
            this.txtBox_name.Name = "txtBox_name";
            this.txtBox_name.Size = new System.Drawing.Size(176, 22);
            this.txtBox_name.TabIndex = 10;
            this.txtBox_name.MouseEnter += new System.EventHandler(this.txtBox_name_MouseEnter);
            this.txtBox_name.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_name_Validating);
            // 
            // lbl_enteringYear
            // 
            this.lbl_enteringYear.AutoSize = true;
            this.lbl_enteringYear.Location = new System.Drawing.Point(50, 136);
            this.lbl_enteringYear.Name = "lbl_enteringYear";
            this.lbl_enteringYear.Size = new System.Drawing.Size(88, 16);
            this.lbl_enteringYear.TabIndex = 9;
            this.lbl_enteringYear.Text = "Entering Year";
            // 
            // lbl_studentName
            // 
            this.lbl_studentName.AutoSize = true;
            this.lbl_studentName.Location = new System.Drawing.Point(94, 55);
            this.lbl_studentName.Name = "lbl_studentName";
            this.lbl_studentName.Size = new System.Drawing.Size(44, 16);
            this.lbl_studentName.TabIndex = 7;
            this.lbl_studentName.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Identical Number";
            // 
            // btn_registerStudent
            // 
            this.btn_registerStudent.Enabled = false;
            this.btn_registerStudent.Location = new System.Drawing.Point(157, 214);
            this.btn_registerStudent.Name = "btn_registerStudent";
            this.btn_registerStudent.Size = new System.Drawing.Size(177, 27);
            this.btn_registerStudent.TabIndex = 6;
            this.btn_registerStudent.Text = "Register";
            this.btn_registerStudent.UseVisualStyleBackColor = true;
            this.btn_registerStudent.Click += new System.EventHandler(this.btn_registerStudent_Click);
            // 
            // txtBox_identicalNumber
            // 
            this.txtBox_identicalNumber.Location = new System.Drawing.Point(157, 90);
            this.txtBox_identicalNumber.Name = "txtBox_identicalNumber";
            this.txtBox_identicalNumber.Size = new System.Drawing.Size(176, 22);
            this.txtBox_identicalNumber.TabIndex = 0;
            this.txtBox_identicalNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_studentID_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Field";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.dataGridView_studentsStatus);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Status";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBox_studentIDStatus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_showStatus);
            this.groupBox1.Location = new System.Drawing.Point(237, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // txtBox_studentIDStatus
            // 
            this.txtBox_studentIDStatus.Location = new System.Drawing.Point(135, 31);
            this.txtBox_studentIDStatus.Name = "txtBox_studentIDStatus";
            this.txtBox_studentIDStatus.Size = new System.Drawing.Size(123, 22);
            this.txtBox_studentIDStatus.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Identical Number";
            // 
            // btn_showStatus
            // 
            this.btn_showStatus.Location = new System.Drawing.Point(135, 59);
            this.btn_showStatus.Name = "btn_showStatus";
            this.btn_showStatus.Size = new System.Drawing.Size(123, 23);
            this.btn_showStatus.TabIndex = 2;
            this.btn_showStatus.Text = "Show Status";
            this.btn_showStatus.UseVisualStyleBackColor = true;
            this.btn_showStatus.Click += new System.EventHandler(this.btn_showStatus_Click);
            // 
            // dataGridView_studentsStatus
            // 
            this.dataGridView_studentsStatus.AutoGenerateColumns = false;
            this.dataGridView_studentsStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_studentsStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.fieldDataGridViewTextBoxColumn,
            this.intFieldDataGridViewTextBoxColumn,
            this.ClassProfessor});
            this.dataGridView_studentsStatus.DataSource = this.registeredClassesBindingSource;
            this.dataGridView_studentsStatus.Location = new System.Drawing.Point(66, 112);
            this.dataGridView_studentsStatus.Name = "dataGridView_studentsStatus";
            this.dataGridView_studentsStatus.RowHeadersWidth = 51;
            this.dataGridView_studentsStatus.RowTemplate.Height = 24;
            this.dataGridView_studentsStatus.Size = new System.Drawing.Size(673, 271);
            this.dataGridView_studentsStatus.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // registeredClassesBindingSource
            // 
            this.registeredClassesBindingSource.DataMember = "RegisteredClasses";
            this.registeredClassesBindingSource.DataSource = this.studentBindingSource;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(WindowsFormsApp2.Student);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 124;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 124;
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
            // ClassProfessor
            // 
            this.ClassProfessor.DataPropertyName = "ClassProfessor";
            this.ClassProfessor.HeaderText = "ClassProfessor";
            this.ClassProfessor.MinimumWidth = 6;
            this.ClassProfessor.Name = "ClassProfessor";
            this.ClassProfessor.Width = 124;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl_studentForm);
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentForm";
            this.tabControl_studentForm.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_enteringYear)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_studentsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registeredClassesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_studentForm;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_studentName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_registerStudent;
        private System.Windows.Forms.TextBox txtBox_identicalNumber;
        private System.Windows.Forms.ComboBox comBox_field;
        private System.Windows.Forms.TextBox txtBox_name;
        private System.Windows.Forms.Label lbl_enteringYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.NumericUpDown numericUpDown_enteringYear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBox_studentIDStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_showStatus;
        private System.Windows.Forms.DataGridView dataGridView_studentsStatus;
        private System.Windows.Forms.BindingSource registeredClassesBindingSource;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intFieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassProfessor;
    }
}