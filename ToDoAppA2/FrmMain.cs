namespace ToDoAppA2
{
    public partial class FrmMain : Form
    {
        private List<TaskList> _taskLists;
        public FrmMain()
        {
            _taskLists = new List<TaskList>();
            InitializeComponent();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (lstBoxTaskLists.SelectedIndex < 0) return;

            FrmTask frmTask = new FrmTask();
            if (frmTask.ShowDialog() == DialogResult.OK)
            {
                _taskLists
                    .ElementAt(lstBoxTaskLists.SelectedIndex)
                    .Tasks.Add(frmTask.Task);

                UpdateTasksBox();
            }
        }

        private void btnAddTaskList_Click(object sender, EventArgs e)
        {
            FrmTaskList frmTaskList = new FrmTaskList();
            if (frmTaskList.ShowDialog() == DialogResult.OK)
            {
                _taskLists.Add(frmTaskList.TaskList);
                UpdateTaskListBox();
            }
        }

        private void lstBoxTaskLists_DoubleClick(object sender, EventArgs e)
        {
            // Wenn nichts in der Listbox ausgewählt ist, Abbruch.
            if (lstBoxTaskLists.SelectedIndex < 0) return;

            FrmTaskList frmTaskList = new FrmTaskList();
            frmTaskList.TaskList = _taskLists.ElementAt(lstBoxTaskLists.SelectedIndex);

            if (frmTaskList.ShowDialog() == DialogResult.OK)
                UpdateTaskListBox();
        }

        private void UpdateTaskListBox()
        {
            lstBoxTaskLists.Items.Clear();
            foreach (TaskList taskList in _taskLists)
                lstBoxTaskLists.Items.Add(taskList.ToString());
        }

        private void UpdateTasksBox()
        {
            chkLstBoxTasks.Items.Clear();
            foreach (Task task in
                _taskLists.ElementAt(lstBoxTaskLists.SelectedIndex).Tasks)
                chkLstBoxTasks.Items.Add(task.ToString());
        }

        private void btnRemoveTaskList_Click(object sender, EventArgs e)
        {
            if (lstBoxTaskLists.SelectedIndex < 0) return;

            _taskLists.RemoveAt(lstBoxTaskLists.SelectedIndex);
            UpdateTaskListBox();
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            if (lstBoxTaskLists.SelectedIndex < 0) return;
            if (chkLstBoxTasks.SelectedIndex < 0) return;

            FrmTask frmTask = new FrmTask();
            frmTask.Task = _taskLists
                    .ElementAt(lstBoxTaskLists.SelectedIndex)
                    .Tasks.ElementAt(chkLstBoxTasks.SelectedIndex);

            if (frmTask.ShowDialog() == DialogResult.OK)
            {
                UpdateTasksBox();
            }
        }

        private void lstBoxTaskLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTasksBox();
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            if (chkLstBoxTasks.SelectedIndex < 0) return;

            if(MessageBox.Show(
                "Soll die Aufgabe wirklich gelöscht werden?",
                "Aufgabe löschen",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _taskLists
                        .ElementAt(lstBoxTaskLists.SelectedIndex)
                        .Tasks.RemoveAt(chkLstBoxTasks.SelectedIndex);

                UpdateTasksBox();
            }
        }

    }
}
