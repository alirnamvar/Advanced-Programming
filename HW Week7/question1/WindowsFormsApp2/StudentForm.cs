using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class StudentForm : Form
    {

        private Golestan Golestan { get; }
        private BindingSource bsClasses;
        public StudentForm()
        {
            InitializeComponent();
            comBox_field.DataSource = Enum.GetValues(typeof(FieldEnum));
            Golestan = Manager.GolestanManager;
            bsClasses = new BindingSource();
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

        private void txtBox_studentID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox_identicalNumber.Text))
            {
                errorProvider2.SetError(txtBox_identicalNumber, "Enter your Identical Number");
            }
            else if (!(txtBox_identicalNumber.Text.Length <= 10) || !txtBox_identicalNumber.Text.All(char.IsDigit))
            {
                errorProvider2.SetError(txtBox_identicalNumber, "Maximum 10 digit");
            }
            else
            {
                errorProvider2.SetError(txtBox_identicalNumber, null);
            }
        }

        private void btn_registerStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(errorProvider1.GetError(txtBox_name)) &&
               string.IsNullOrEmpty(errorProvider2.GetError(txtBox_identicalNumber)))
            {
                string result = Golestan.RegisterStudent(txtBox_name.Text, txtBox_identicalNumber.Text,
                    (int)numericUpDown_enteringYear.Value, (int)(FieldEnum)comBox_field.SelectedItem);
                MessageBox.Show(result);
                //tabControl_studentForm.SelectTab(1);
            }
            else
            {
                MessageBox.Show("There is an Error");
            }
        }

        private void txtBox_name_MouseEnter(object sender, EventArgs e)
        {
            btn_registerStudent.Enabled = true;
        }

        private void btn_showStatus_Click(object sender, EventArgs e)
        {
            string result = Golestan.StudentStatus(txtBox_studentIDStatus.Text);
            MessageBox.Show(result);
            Student s = Golestan.GetStudent(txtBox_studentIDStatus.Text);
            if (s != null)
            {
                bsClasses.DataSource = s.RegisteredClasses;
                dataGridView_studentsStatus.DataSource = bsClasses;
            }
            
            //dataGridView_studentsStatus.DataSource= result;
        }
    }
}
