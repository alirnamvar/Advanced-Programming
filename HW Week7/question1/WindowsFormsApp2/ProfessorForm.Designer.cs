namespace WindowsFormsApp2
{
    partial class ProfessorForm
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
            this.comBox_field = new System.Windows.Forms.ComboBox();
            this.txtBox_name = new System.Windows.Forms.TextBox();
            this.lbl_professorName = new System.Windows.Forms.Label();
            this.lbl_professorID = new System.Windows.Forms.Label();
            this.btn_registerProfessor = new System.Windows.Forms.Button();
            this.txtBox_identicalNumber = new System.Windows.Forms.TextBox();
            this.lbl_field = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBox_professorIDStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_showStatusProfessor = new System.Windows.Forms.Button();
            this.dataGridView_professorStatus = new System.Windows.Forms.DataGridView();
            this.registeredClassesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.professorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intFieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassProfessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl_studentForm.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_professorStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registeredClassesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).BeginInit();
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
            this.tabControl_studentForm.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Register Professor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comBox_field);
            this.groupBox2.Controls.Add(this.txtBox_name);
            this.groupBox2.Controls.Add(this.lbl_professorName);
            this.groupBox2.Controls.Add(this.lbl_professorID);
            this.groupBox2.Controls.Add(this.btn_registerProfessor);
            this.groupBox2.Controls.Add(this.txtBox_identicalNumber);
            this.groupBox2.Controls.Add(this.lbl_field);
            this.groupBox2.Location = new System.Drawing.Point(188, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 241);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Professor Info";
            // 
            // comBox_field
            // 
            this.comBox_field.FormattingEnabled = true;
            this.comBox_field.Location = new System.Drawing.Point(157, 131);
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
            // lbl_professorName
            // 
            this.lbl_professorName.AutoSize = true;
            this.lbl_professorName.Location = new System.Drawing.Point(94, 55);
            this.lbl_professorName.Name = "lbl_professorName";
            this.lbl_professorName.Size = new System.Drawing.Size(44, 16);
            this.lbl_professorName.TabIndex = 7;
            this.lbl_professorName.Text = "Name";
            // 
            // lbl_professorID
            // 
            this.lbl_professorID.AutoSize = true;
            this.lbl_professorID.Location = new System.Drawing.Point(30, 93);
            this.lbl_professorID.Name = "lbl_professorID";
            this.lbl_professorID.Size = new System.Drawing.Size(108, 16);
            this.lbl_professorID.TabIndex = 1;
            this.lbl_professorID.Text = "Identical Number";
            // 
            // btn_registerProfessor
            // 
            this.btn_registerProfessor.Enabled = false;
            this.btn_registerProfessor.Location = new System.Drawing.Point(157, 175);
            this.btn_registerProfessor.Name = "btn_registerProfessor";
            this.btn_registerProfessor.Size = new System.Drawing.Size(177, 27);
            this.btn_registerProfessor.TabIndex = 6;
            this.btn_registerProfessor.Text = "Register";
            this.btn_registerProfessor.UseVisualStyleBackColor = true;
            this.btn_registerProfessor.Click += new System.EventHandler(this.btn_registerProfessor_Click);
            // 
            // txtBox_identicalNumber
            // 
            this.txtBox_identicalNumber.Location = new System.Drawing.Point(157, 90);
            this.txtBox_identicalNumber.Name = "txtBox_identicalNumber";
            this.txtBox_identicalNumber.Size = new System.Drawing.Size(176, 22);
            this.txtBox_identicalNumber.TabIndex = 0;
            this.txtBox_identicalNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_identicalNumber_Validating);
            // 
            // lbl_field
            // 
            this.lbl_field.AutoSize = true;
            this.lbl_field.Location = new System.Drawing.Point(94, 134);
            this.lbl_field.Name = "lbl_field";
            this.lbl_field.Size = new System.Drawing.Size(37, 16);
            this.lbl_field.TabIndex = 2;
            this.lbl_field.Text = "Field";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.dataGridView_professorStatus);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Status";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBox_professorIDStatus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_showStatusProfessor);
            this.groupBox1.Location = new System.Drawing.Point(231, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // txtBox_professorIDStatus
            // 
            this.txtBox_professorIDStatus.Location = new System.Drawing.Point(135, 31);
            this.txtBox_professorIDStatus.Name = "txtBox_professorIDStatus";
            this.txtBox_professorIDStatus.Size = new System.Drawing.Size(123, 22);
            this.txtBox_professorIDStatus.TabIndex = 3;
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
            // btn_showStatusProfessor
            // 
            this.btn_showStatusProfessor.Location = new System.Drawing.Point(135, 59);
            this.btn_showStatusProfessor.Name = "btn_showStatusProfessor";
            this.btn_showStatusProfessor.Size = new System.Drawing.Size(123, 23);
            this.btn_showStatusProfessor.TabIndex = 2;
            this.btn_showStatusProfessor.Text = "Show Status";
            this.btn_showStatusProfessor.UseVisualStyleBackColor = true;
            this.btn_showStatusProfessor.Click += new System.EventHandler(this.btn_showStatusProfessor_Click);
            // 
            // dataGridView_professorStatus
            // 
            this.dataGridView_professorStatus.AutoGenerateColumns = false;
            this.dataGridView_professorStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_professorStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.fieldDataGridViewTextBoxColumn,
            this.intFieldDataGridViewTextBoxColumn,
            this.ClassProfessor});
            this.dataGridView_professorStatus.DataSource = this.registeredClassesBindingSource1;
            this.dataGridView_professorStatus.Location = new System.Drawing.Point(50, 128);
            this.dataGridView_professorStatus.Name = "dataGridView_professorStatus";
            this.dataGridView_professorStatus.RowHeadersWidth = 51;
            this.dataGridView_professorStatus.RowTemplate.Height = 24;
            this.dataGridView_professorStatus.Size = new System.Drawing.Size(678, 271);
            this.dataGridView_professorStatus.TabIndex = 4;
            // 
            // registeredClassesBindingSource1
            // 
            this.registeredClassesBindingSource1.DataMember = "RegisteredClasses";
            this.registeredClassesBindingSource1.DataSource = this.professorBindingSource;
            // 
            // professorBindingSource
            // 
            this.professorBindingSource.DataSource = typeof(WindowsFormsApp2.Professor);
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
            // ProfessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl_studentForm);
            this.Name = "ProfessorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfessorForm";
            this.tabControl_studentForm.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_professorStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registeredClassesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_studentForm;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comBox_field;
        private System.Windows.Forms.TextBox txtBox_name;
        private System.Windows.Forms.Label lbl_professorName;
        private System.Windows.Forms.Label lbl_professorID;
        private System.Windows.Forms.Button btn_registerProfessor;
        private System.Windows.Forms.TextBox txtBox_identicalNumber;
        private System.Windows.Forms.Label lbl_field;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBox_professorIDStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_showStatusProfessor;
        private System.Windows.Forms.DataGridView dataGridView_professorStatus;
        private System.Windows.Forms.BindingSource registeredClassesBindingSource1;
        private System.Windows.Forms.BindingSource professorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intFieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassProfessor;
    }
}