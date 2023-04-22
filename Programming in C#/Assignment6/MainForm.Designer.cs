namespace Assignment6
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxPriorityType = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelPriorityType = new System.Windows.Forms.Label();
            this.labelDateAndTime = new System.Windows.Forms.Label();
            this.labelToDo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpenDataFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSaveDataFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelHour = new System.Windows.Forms.Label();
            this.labelPriority = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelToDo2 = new System.Windows.Forms.Label();
            this.labelClock = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.ItemHeight = 15;
            this.listBoxTasks.Location = new System.Drawing.Point(32, 203);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(961, 229);
            this.listBoxTasks.TabIndex = 0;
            // 
            // buttonChange
            // 
            this.buttonChange.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonChange.Location = new System.Drawing.Point(172, 446);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 1;
            this.buttonChange.Text = "buttonChange";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.Location = new System.Drawing.Point(459, 452);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "buttonDelete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Location = new System.Drawing.Point(720, 87);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "buttonAdd";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxPriorityType
            // 
            this.comboBoxPriorityType.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxPriorityType.FormattingEnabled = true;
            this.comboBoxPriorityType.Location = new System.Drawing.Point(558, 61);
            this.comboBoxPriorityType.Name = "comboBoxPriorityType";
            this.comboBoxPriorityType.Size = new System.Drawing.Size(121, 23);
            this.comboBoxPriorityType.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(152, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // labelPriorityType
            // 
            this.labelPriorityType.AutoSize = true;
            this.labelPriorityType.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPriorityType.Location = new System.Drawing.Point(426, 64);
            this.labelPriorityType.Name = "labelPriorityType";
            this.labelPriorityType.Size = new System.Drawing.Size(126, 15);
            this.labelPriorityType.TabIndex = 6;
            this.labelPriorityType.Text = "labelPriorityType";
            // 
            // labelDateAndTime
            // 
            this.labelDateAndTime.AutoSize = true;
            this.labelDateAndTime.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDateAndTime.Location = new System.Drawing.Point(15, 61);
            this.labelDateAndTime.Name = "labelDateAndTime";
            this.labelDateAndTime.Size = new System.Drawing.Size(119, 15);
            this.labelDateAndTime.TabIndex = 7;
            this.labelDateAndTime.Text = "labelDateAndTime";
            // 
            // labelToDo
            // 
            this.labelToDo.AutoSize = true;
            this.labelToDo.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelToDo.Location = new System.Drawing.Point(64, 109);
            this.labelToDo.Name = "labelToDo";
            this.labelToDo.Size = new System.Drawing.Size(70, 15);
            this.labelToDo.TabIndex = 8;
            this.labelToDo.Text = "labelToDo";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDescription.Location = new System.Drawing.Point(152, 106);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(527, 21);
            this.textBoxDescription.TabIndex = 9;
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFile,
            this.toolStripMenuItemHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1030, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuFile
            // 
            this.toolStripMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemNew,
            this.toolStripMenuItemOpenDataFile,
            this.toolStripMenuItemSaveDataFile,
            this.toolStripMenuItemExit});
            this.toolStripMenuFile.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuFile.Name = "toolStripMenuFile";
            this.toolStripMenuFile.Size = new System.Drawing.Size(138, 20);
            this.toolStripMenuFile.Text = "toolStripMenuFile";
            // 
            // toolStripMenuItemNew
            // 
            this.toolStripMenuItemNew.Name = "toolStripMenuItemNew";
            this.toolStripMenuItemNew.Size = new System.Drawing.Size(277, 22);
            this.toolStripMenuItemNew.Text = "toolStripMenuItemNew";
            this.toolStripMenuItemNew.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItemOpenDataFile
            // 
            this.toolStripMenuItemOpenDataFile.Name = "toolStripMenuItemOpenDataFile";
            this.toolStripMenuItemOpenDataFile.Size = new System.Drawing.Size(277, 22);
            this.toolStripMenuItemOpenDataFile.Text = "toolStripMenuItemOpenDataFile";
            this.toolStripMenuItemOpenDataFile.Click += new System.EventHandler(this.toolStripMenuItemOpenDataFile_Click);
            // 
            // toolStripMenuItemSaveDataFile
            // 
            this.toolStripMenuItemSaveDataFile.Name = "toolStripMenuItemSaveDataFile";
            this.toolStripMenuItemSaveDataFile.Size = new System.Drawing.Size(277, 22);
            this.toolStripMenuItemSaveDataFile.Text = "toolStripMenuItemSaveDataFile";
            this.toolStripMenuItemSaveDataFile.Click += new System.EventHandler(this.toolStripMenuItemSaveDataFile_Click);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(277, 22);
            this.toolStripMenuItemExit.Text = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(166, 20);
            this.toolStripMenuItemHelp.Text = "toolStripMenuItemHelp";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDate.Location = new System.Drawing.Point(38, 183);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(70, 15);
            this.labelDate.TabIndex = 11;
            this.labelDate.Text = "labelDate";
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHour.Location = new System.Drawing.Point(276, 186);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(70, 15);
            this.labelHour.TabIndex = 12;
            this.labelHour.Text = "labelHour";
            // 
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPriority.Location = new System.Drawing.Point(341, 186);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(98, 15);
            this.labelPriority.TabIndex = 13;
            this.labelPriority.Text = "labelPriority";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.Location = new System.Drawing.Point(541, 185);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(119, 15);
            this.labelDescription.TabIndex = 14;
            this.labelDescription.Text = "labelDescription";
            // 
            // labelToDo2
            // 
            this.labelToDo2.AutoSize = true;
            this.labelToDo2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelToDo2.Location = new System.Drawing.Point(426, 154);
            this.labelToDo2.Name = "labelToDo2";
            this.labelToDo2.Size = new System.Drawing.Size(108, 18);
            this.labelToDo2.TabIndex = 15;
            this.labelToDo2.Text = "labelToDo2";
            // 
            // labelClock
            // 
            this.labelClock.AutoSize = true;
            this.labelClock.Location = new System.Drawing.Point(895, 462);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(77, 15);
            this.labelClock.TabIndex = 16;
            this.labelClock.Text = "labelClock";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 496);
            this.Controls.Add(this.labelClock);
            this.Controls.Add(this.labelToDo2);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelPriority);
            this.Controls.Add(this.labelHour);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelToDo);
            this.Controls.Add(this.labelDateAndTime);
            this.Controls.Add(this.labelPriorityType);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxPriorityType);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.listBoxTasks);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxTasks;
        private Button buttonChange;
        private Button buttonDelete;
        private Button buttonAdd;
        private ComboBox comboBoxPriorityType;
        private DateTimePicker dateTimePicker1;
        private Label labelPriorityType;
        private Label labelDateAndTime;
        private Label labelToDo;
        private ToolTip toolTip1;
        private TextBox textBoxDescription;
        private System.Windows.Forms.Timer clockTimer;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuFile;
        private ToolStripMenuItem toolStripMenuItemNew;
        private ToolStripMenuItem toolStripMenuItemHelp;
        private ToolStripMenuItem toolStripMenuItemOpenDataFile;
        private ToolStripMenuItem toolStripMenuItemSaveDataFile;
        private ToolStripMenuItem toolStripMenuItemExit;
        private Label labelDate;
        private Label labelHour;
        private Label labelPriority;
        private Label labelDescription;
        private Label labelToDo2;
        private Label labelClock;
    }
}