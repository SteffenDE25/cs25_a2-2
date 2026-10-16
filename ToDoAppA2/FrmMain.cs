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

        }
    }
}
