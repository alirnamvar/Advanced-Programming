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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btm_studentForm_Click(object sender, EventArgs e)
        {
            StudentForm sf = new StudentForm();
            sf.ShowDialog();
        }

        private void btm_professorForm_Click(object sender, EventArgs e)
        {
            ProfessorForm pf = new ProfessorForm();
            pf.ShowDialog();
        }

        private void btm_classForm_Click(object sender, EventArgs e)
        {
            ClassForm cf = new ClassForm();
            cf.ShowDialog();
        }
    }
}
