using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoAppA2
{
    public partial class FrmTask : Form
    {
        public Task Task = new Task();
        public FrmTask()
        {
            InitializeComponent();
        }

        private void FrmTask_Load(object sender, EventArgs e)
        {
            txtTitle.Text = Task.Title;
            txtDescription.Text = Task.Description;
            numUpDownPriority.Value = Task.Priority;
            dateTimeDueTo.Value = Task.DueTo;
            chkBoxDone.Checked = Task.Done;
        }

        private void FrmTask_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                Task.Title = txtTitle.Text;
                Task.Description = txtDescription.Text;
                Task.Priority = numUpDownPriority.Value;
                Task.DueTo = dateTimeDueTo.Value;
                Task.Done = chkBoxDone.Checked;
            }
        }
    }
}
