namespace ToDoAppA2
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStripMain = new MenuStrip();
            programmToolStripMenuItem = new ToolStripMenuItem();
            beendenToolStripMenuItem = new ToolStripMenuItem();
            lstBoxTaskLists = new ListBox();
            chkLstBoxTasks = new CheckedListBox();
            btnAddTaskList = new Button();
            btnRemoveTaskList = new Button();
            btnAddTask = new Button();
            btnRemoveTask = new Button();
            lblTaskLists = new Label();
            lblTasks = new Label();
            menuStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMain
            // 
            menuStripMain.ImageScalingSize = new Size(24, 24);
            menuStripMain.Items.AddRange(new ToolStripItem[] { programmToolStripMenuItem });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(989, 33);
            menuStripMain.TabIndex = 0;
            menuStripMain.Text = "menuStrip1";
            // 
            // programmToolStripMenuItem
            // 
            programmToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { beendenToolStripMenuItem });
            programmToolStripMenuItem.Name = "programmToolStripMenuItem";
            programmToolStripMenuItem.Size = new Size(113, 29);
            programmToolStripMenuItem.Text = "Programm";
            // 
            // beendenToolStripMenuItem
            // 
            beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            beendenToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            beendenToolStripMenuItem.Size = new Size(249, 34);
            beendenToolStripMenuItem.Text = "Beenden";
            // 
            // lstBoxTaskLists
            // 
            lstBoxTaskLists.FormattingEnabled = true;
            lstBoxTaskLists.Location = new Point(40, 104);
            lstBoxTaskLists.Name = "lstBoxTaskLists";
            lstBoxTaskLists.Size = new Size(390, 479);
            lstBoxTaskLists.TabIndex = 1;
            // 
            // chkLstBoxTasks
            // 
            chkLstBoxTasks.FormattingEnabled = true;
            chkLstBoxTasks.Location = new Point(476, 104);
            chkLstBoxTasks.Name = "chkLstBoxTasks";
            chkLstBoxTasks.Size = new Size(475, 480);
            chkLstBoxTasks.TabIndex = 2;
            // 
            // btnAddTaskList
            // 
            btnAddTaskList.Location = new Point(40, 601);
            btnAddTaskList.Name = "btnAddTaskList";
            btnAddTaskList.Size = new Size(112, 34);
            btnAddTaskList.TabIndex = 3;
            btnAddTaskList.Text = "Hinzufügen";
            btnAddTaskList.UseVisualStyleBackColor = true;
            // 
            // btnRemoveTaskList
            // 
            btnRemoveTaskList.Location = new Point(318, 601);
            btnRemoveTaskList.Name = "btnRemoveTaskList";
            btnRemoveTaskList.Size = new Size(112, 34);
            btnRemoveTaskList.TabIndex = 4;
            btnRemoveTaskList.Text = "Löschen";
            btnRemoveTaskList.UseVisualStyleBackColor = true;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(476, 601);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(112, 34);
            btnAddTask.TabIndex = 5;
            btnAddTask.Text = "Hinzufügen";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // btnRemoveTask
            // 
            btnRemoveTask.Location = new Point(839, 601);
            btnRemoveTask.Name = "btnRemoveTask";
            btnRemoveTask.Size = new Size(112, 34);
            btnRemoveTask.TabIndex = 6;
            btnRemoveTask.Text = "Löschen";
            btnRemoveTask.UseVisualStyleBackColor = true;
            // 
            // lblTaskLists
            // 
            lblTaskLists.AutoSize = true;
            lblTaskLists.Location = new Point(40, 64);
            lblTaskLists.Name = "lblTaskLists";
            lblTaskLists.Size = new Size(131, 25);
            lblTaskLists.TabIndex = 7;
            lblTaskLists.Text = "Aufgabenlisten";
            // 
            // lblTasks
            // 
            lblTasks.AutoSize = true;
            lblTasks.Location = new Point(476, 64);
            lblTasks.Name = "lblTasks";
            lblTasks.Size = new Size(90, 25);
            lblTasks.TabIndex = 8;
            lblTasks.Text = "Aufgaben";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 668);
            Controls.Add(lblTasks);
            Controls.Add(lblTaskLists);
            Controls.Add(btnRemoveTask);
            Controls.Add(btnAddTask);
            Controls.Add(btnRemoveTaskList);
            Controls.Add(btnAddTaskList);
            Controls.Add(chkLstBoxTasks);
            Controls.Add(lstBoxTaskLists);
            Controls.Add(menuStripMain);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStripMain;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LFH ToDoApp A2";
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripMain;
        private ListBox lstBoxTaskLists;
        private CheckedListBox chkLstBoxTasks;
        private Button btnAddTaskList;
        private Button btnRemoveTaskList;
        private Button btnAddTask;
        private Button btnRemoveTask;
        private Label lblTaskLists;
        private Label lblTasks;
        private ToolStripMenuItem programmToolStripMenuItem;
        private ToolStripMenuItem beendenToolStripMenuItem;
    }
}
