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
    public partial class FrmTaskList : Form
    {
        public TaskList TaskList = new TaskList();
        public FrmTaskList()
        {
            InitializeComponent();
        }

        private void FrmTaskList_Load(object sender, EventArgs e)
        {
            txtName.Text = TaskList.Name;
        }

        private void FrmTaskList_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.DialogResult == DialogResult.OK)
                TaskList.Name = txtName.Text;
        }
    }
}
