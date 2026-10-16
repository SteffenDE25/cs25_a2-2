namespace ToDoAppA2
{
    partial class FrmTask
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
            lblTitle = new Label();
            lblDescription = new Label();
            lblPriority = new Label();
            lblDueTo = new Label();
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            numUpDownPriority = new NumericUpDown();
            dateTimeDueTo = new DateTimePicker();
            chkBoxDone = new CheckBox();
            btnOK = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numUpDownPriority).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(53, 45);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(44, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Titel";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(53, 140);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(102, 25);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Description";
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Location = new Point(53, 293);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(74, 25);
            lblPriority.TabIndex = 2;
            lblPriority.Text = "Priorität";
            // 
            // lblDueTo
            // 
            lblDueTo.AutoSize = true;
            lblDueTo.Location = new Point(312, 293);
            lblDueTo.Name = "lblDueTo";
            lblDueTo.Size = new Size(82, 25);
            lblDueTo.TabIndex = 3;
            lblDueTo.Text = "Fällig am";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(53, 73);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(629, 31);
            txtTitle.TabIndex = 4;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(53, 168);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(629, 86);
            txtDescription.TabIndex = 5;
            // 
            // numUpDownPriority
            // 
            numUpDownPriority.Location = new Point(53, 321);
            numUpDownPriority.Name = "numUpDownPriority";
            numUpDownPriority.Size = new Size(180, 31);
            numUpDownPriority.TabIndex = 6;
            numUpDownPriority.TextAlign = HorizontalAlignment.Center;
            // 
            // dateTimeDueTo
            // 
            dateTimeDueTo.Location = new Point(312, 321);
            dateTimeDueTo.Name = "dateTimeDueTo";
            dateTimeDueTo.Size = new Size(370, 31);
            dateTimeDueTo.TabIndex = 7;
            // 
            // chkBoxDone
            // 
            chkBoxDone.AutoSize = true;
            chkBoxDone.Location = new Point(57, 384);
            chkBoxDone.Name = "chkBoxDone";
            chkBoxDone.Size = new Size(98, 29);
            chkBoxDone.TabIndex = 8;
            chkBoxDone.Text = "Erledigt";
            chkBoxDone.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(452, 379);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(112, 34);
            btnOK.TabIndex = 9;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(570, 380);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Abbrechen";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // FrmTask
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(735, 462);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(chkBoxDone);
            Controls.Add(dateTimeDueTo);
            Controls.Add(numUpDownPriority);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Controls.Add(lblDueTo);
            Controls.Add(lblPriority);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmTask";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Aufgabe";
            FormClosing += FrmTask_FormClosing;
            Load += FrmTask_Load;
            ((System.ComponentModel.ISupportInitialize)numUpDownPriority).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblDescription;
        private Label lblPriority;
        private Label lblDueTo;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private NumericUpDown numUpDownPriority;
        private DateTimePicker dateTimeDueTo;
        private CheckBox chkBoxDone;
        private Button btnOK;
        private Button btnCancel;
    }
}