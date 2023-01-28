using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class ClassForm : Form
    {
        private Golestan Golestan { get; }
        private BindingSource bsStudents;
        private bool firstAdd = true;
        public ClassForm()
        {
            InitializeComponent();
            Golestan = Manager.GolestanManager;
            Initialize();
            
        }

        private void Initialize()
        {
            comBox_field.DataSource = Enum.GetValues(typeof(FieldEnum));
            
            comBox_professor.DataSource = Golestan.Professors;
            comBox_professor.DisplayMember = "Name";
            comBox_professor.ValueMember = "IdenticalNum";
            //dataGridView_students.DataSource = Golestan.Professors;
            //dataGridView_class.DataSource = Golestan.Classes;
            bsStudents = new BindingSource();
            //dataGridView_allStudents.DataSource = Golestan.Students;
            //var firstClass = Golestan.Classes[0];
            //bsStudents.DataSource = firstClass.Students;
            //bsStudents.DataSource = Students;
            //InitBinding();
        }

        private void txtBox_name_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox_name.Text))
            {
                errorProvider1.SetError(txtBox_name, "Enter your name");
            }
            else if (!(txtBox_name.Text.Length <= 20 && txtBox_name.Text.Length >= 1))
            {
                errorProvider1.SetError(txtBox_name, "Length must between 1 and 20");
            }
            else if (!txtBox_name.Text.All(char.IsLower))
            {
                errorProvider1.SetError(txtBox_name, "Name must be all in lower case");
            }
            else
            {
                errorProvider1.SetError(txtBox_name, null);
            }
        }

        private void txtBox_classID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox_classID.Text))
            {
                errorProvider2.SetError(txtBox_classID, "Enter your classID");
            }
            else if (!(txtBox_classID.Text.Length == 10) || !txtBox_classID.Text.All(char.IsDigit))
            {
                errorProvider2.SetError(txtBox_classID, "Must be a 10 digit number");
            }
            else
            {
                errorProvider2.SetError(txtBox_classID, null);
            }
        }

        private void btn_createClass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(errorProvider1.GetError(txtBox_name)) &&
                string.IsNullOrEmpty(errorProvider2.GetError(txtBox_classID)))
                {
                string result = Golestan.MakeClass(txtBox_name.Text, txtBox_classID.Text, (int)(FieldEnum)comBox_field.SelectedItem);
                MessageBox.Show(result);
                btn_serachStudents.Enabled = true;
                //tabControl_classForm.SelectTab(3);
            }
            else
            {
                MessageBox.Show("There is an Error");
            }
        }

        private void btn_addStudent_Click(object sender, EventArgs e)
        {
            string result;
            result = Golestan.AddStudent(txtBox_studentID.Text, txtBox_studentClassID.Text);
            bsStudents.DataSource = Golestan.Classes.Find(c => c.ID == txtBox_studentClassID.Text).Students;
            MessageBox.Show(result);
        }

        private void btn_addProfessor_Click(object sender, EventArgs e)
        {
            string result = Golestan.AddProfessor(((Professor)comBox_professor.SelectedItem).IdenticalNum,
                txtBox_professorClassID.Text);
            MessageBox.Show(result);
        }

        private void btn_serachStudents_Click(object sender, EventArgs e)
        {
            bsStudents = new BindingSource();
            if (firstAdd)
            {
                groupBox_professorName.Visible = true;
                var cls1 = Golestan.Classes.Find(c => c.ID == txtBox_searchClassID.Text);
                bsStudents.DataSource = cls1.Students;
                dataGridView_students.DataSource = bsStudents;
                if (cls1.ClassProfessor != null)
                {
                    lbl_professorName.Text = cls1.ClassProfessor.Name;
                }
                else
                {
                    lbl_professorName.Text = "No One!";
                }
                
                firstAdd = false;
                return;
            }

            var cls2 = Golestan.Classes.Find(c => c.ID == txtBox_searchClassID.Text);
            bsStudents.DataSource = cls2.Students;
            if (cls2.ClassProfessor != null)
            {
                lbl_professorName.Text = cls2.ClassProfessor.Name;
            }
            else
            {
                lbl_professorName.Text = "No One!";
            }
            dataGridView_students.DataSource = bsStudents;

        }

    }

    
}
