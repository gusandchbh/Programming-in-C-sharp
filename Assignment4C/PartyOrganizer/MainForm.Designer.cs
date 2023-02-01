namespace PartyOrganizer
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
            this.GroupBoxNewParty = new System.Windows.Forms.GroupBox();
            this.LabelFeePerPerson = new System.Windows.Forms.Label();
            this.ButtonCreateList = new System.Windows.Forms.Button();
            this.LabelCostPerPerson = new System.Windows.Forms.Label();
            this.InputFeePerPerson = new System.Windows.Forms.TextBox();
            this.LabelMaxGuests = new System.Windows.Forms.Label();
            this.InputCostPerPerson = new System.Windows.Forms.TextBox();
            this.InputMaxGuests = new System.Windows.Forms.TextBox();
            this.GroupBoxInviteGuest = new System.Windows.Forms.GroupBox();
            this.LabelLastName = new System.Windows.Forms.Label();
            this.LabelFirstName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.InputLastName = new System.Windows.Forms.TextBox();
            this.InputFirstName = new System.Windows.Forms.TextBox();
            this.GroupBoxNumberOfGuests = new System.Windows.Forms.GroupBox();
            this.LabelSurplusOutput = new System.Windows.Forms.Label();
            this.LabelTotalFeesOutput = new System.Windows.Forms.Label();
            this.LabelTotalCostOutput = new System.Windows.Forms.Label();
            this.LabelNumberOfGuestsOutput = new System.Windows.Forms.Label();
            this.LabelSurplus = new System.Windows.Forms.Label();
            this.LabelTotalFees = new System.Windows.Forms.Label();
            this.LabelTotalCost = new System.Windows.Forms.Label();
            this.LabelNumberOfGuests = new System.Windows.Forms.Label();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.LabelGuestList = new System.Windows.Forms.Label();
            this.ListBoxGuestList = new System.Windows.Forms.ListBox();
            this.GroupBoxNewParty.SuspendLayout();
            this.GroupBoxInviteGuest.SuspendLayout();
            this.GroupBoxNumberOfGuests.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxNewParty
            // 
            this.GroupBoxNewParty.Controls.Add(this.LabelFeePerPerson);
            this.GroupBoxNewParty.Controls.Add(this.ButtonCreateList);
            this.GroupBoxNewParty.Controls.Add(this.LabelCostPerPerson);
            this.GroupBoxNewParty.Controls.Add(this.InputFeePerPerson);
            this.GroupBoxNewParty.Controls.Add(this.LabelMaxGuests);
            this.GroupBoxNewParty.Controls.Add(this.InputCostPerPerson);
            this.GroupBoxNewParty.Controls.Add(this.InputMaxGuests);
            this.GroupBoxNewParty.Location = new System.Drawing.Point(21, 22);
            this.GroupBoxNewParty.Name = "GroupBoxNewParty";
            this.GroupBoxNewParty.Size = new System.Drawing.Size(323, 154);
            this.GroupBoxNewParty.TabIndex = 0;
            this.GroupBoxNewParty.TabStop = false;
            this.GroupBoxNewParty.Text = "GroupBoxNewParty";
            this.GroupBoxNewParty.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LabelFeePerPerson
            // 
            this.LabelFeePerPerson.AutoSize = true;
            this.LabelFeePerPerson.Location = new System.Drawing.Point(6, 101);
            this.LabelFeePerPerson.Name = "LabelFeePerPerson";
            this.LabelFeePerPerson.Size = new System.Drawing.Size(106, 15);
            this.LabelFeePerPerson.TabIndex = 7;
            this.LabelFeePerPerson.Text = "LabelFeePerPerson";
            this.LabelFeePerPerson.UseMnemonic = false;
            // 
            // ButtonCreateList
            // 
            this.ButtonCreateList.Location = new System.Drawing.Point(107, 130);
            this.ButtonCreateList.Name = "ButtonCreateList";
            this.ButtonCreateList.Size = new System.Drawing.Size(75, 23);
            this.ButtonCreateList.TabIndex = 5;
            this.ButtonCreateList.Text = "ButtonCreateList";
            this.ButtonCreateList.UseVisualStyleBackColor = true;
            this.ButtonCreateList.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // LabelCostPerPerson
            // 
            this.LabelCostPerPerson.AutoSize = true;
            this.LabelCostPerPerson.Location = new System.Drawing.Point(6, 63);
            this.LabelCostPerPerson.Name = "LabelCostPerPerson";
            this.LabelCostPerPerson.Size = new System.Drawing.Size(112, 15);
            this.LabelCostPerPerson.TabIndex = 6;
            this.LabelCostPerPerson.Text = "LabelCostPerPerson";
            // 
            // InputFeePerPerson
            // 
            this.InputFeePerPerson.Location = new System.Drawing.Point(150, 101);
            this.InputFeePerPerson.Name = "InputFeePerPerson";
            this.InputFeePerPerson.Size = new System.Drawing.Size(100, 23);
            this.InputFeePerPerson.TabIndex = 2;
            // 
            // LabelMaxGuests
            // 
            this.LabelMaxGuests.AutoSize = true;
            this.LabelMaxGuests.Location = new System.Drawing.Point(6, 25);
            this.LabelMaxGuests.Name = "LabelMaxGuests";
            this.LabelMaxGuests.Size = new System.Drawing.Size(93, 15);
            this.LabelMaxGuests.TabIndex = 5;
            this.LabelMaxGuests.Text = "LabelMaxGuests";
            this.LabelMaxGuests.Click += new System.EventHandler(this.label1_Click);
            // 
            // InputCostPerPerson
            // 
            this.InputCostPerPerson.Location = new System.Drawing.Point(150, 63);
            this.InputCostPerPerson.Name = "InputCostPerPerson";
            this.InputCostPerPerson.Size = new System.Drawing.Size(100, 23);
            this.InputCostPerPerson.TabIndex = 1;
            this.InputCostPerPerson.TextChanged += new System.EventHandler(this.InputCostPerPerson_TextChanged);
            // 
            // InputMaxGuests
            // 
            this.InputMaxGuests.Location = new System.Drawing.Point(150, 22);
            this.InputMaxGuests.Name = "InputMaxGuests";
            this.InputMaxGuests.Size = new System.Drawing.Size(100, 23);
            this.InputMaxGuests.TabIndex = 0;
            this.InputMaxGuests.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // GroupBoxInviteGuest
            // 
            this.GroupBoxInviteGuest.Controls.Add(this.LabelLastName);
            this.GroupBoxInviteGuest.Controls.Add(this.LabelFirstName);
            this.GroupBoxInviteGuest.Controls.Add(this.button1);
            this.GroupBoxInviteGuest.Controls.Add(this.InputLastName);
            this.GroupBoxInviteGuest.Controls.Add(this.InputFirstName);
            this.GroupBoxInviteGuest.Location = new System.Drawing.Point(21, 182);
            this.GroupBoxInviteGuest.Name = "GroupBoxInviteGuest";
            this.GroupBoxInviteGuest.Size = new System.Drawing.Size(323, 103);
            this.GroupBoxInviteGuest.TabIndex = 1;
            this.GroupBoxInviteGuest.TabStop = false;
            this.GroupBoxInviteGuest.Text = "GroupBoxInviteGuest";
            // 
            // LabelLastName
            // 
            this.LabelLastName.AutoSize = true;
            this.LabelLastName.Location = new System.Drawing.Point(15, 45);
            this.LabelLastName.Name = "LabelLastName";
            this.LabelLastName.Size = new System.Drawing.Size(88, 15);
            this.LabelLastName.TabIndex = 9;
            this.LabelLastName.Text = "LabelLastName";
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.AutoSize = true;
            this.LabelFirstName.Location = new System.Drawing.Point(15, 21);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(89, 15);
            this.LabelFirstName.TabIndex = 8;
            this.LabelFirstName.Text = "LabelFirstName";
            this.LabelFirstName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InputLastName
            // 
            this.InputLastName.Location = new System.Drawing.Point(131, 42);
            this.InputLastName.Name = "InputLastName";
            this.InputLastName.Size = new System.Drawing.Size(183, 23);
            this.InputLastName.TabIndex = 4;
            // 
            // InputFirstName
            // 
            this.InputFirstName.Location = new System.Drawing.Point(131, 13);
            this.InputFirstName.Name = "InputFirstName";
            this.InputFirstName.Size = new System.Drawing.Size(183, 23);
            this.InputFirstName.TabIndex = 3;
            // 
            // GroupBoxNumberOfGuests
            // 
            this.GroupBoxNumberOfGuests.Controls.Add(this.LabelSurplusOutput);
            this.GroupBoxNumberOfGuests.Controls.Add(this.LabelTotalFeesOutput);
            this.GroupBoxNumberOfGuests.Controls.Add(this.LabelTotalCostOutput);
            this.GroupBoxNumberOfGuests.Controls.Add(this.LabelNumberOfGuestsOutput);
            this.GroupBoxNumberOfGuests.Controls.Add(this.LabelSurplus);
            this.GroupBoxNumberOfGuests.Controls.Add(this.LabelTotalFees);
            this.GroupBoxNumberOfGuests.Controls.Add(this.LabelTotalCost);
            this.GroupBoxNumberOfGuests.Controls.Add(this.LabelNumberOfGuests);
            this.GroupBoxNumberOfGuests.Location = new System.Drawing.Point(21, 291);
            this.GroupBoxNumberOfGuests.Name = "GroupBoxNumberOfGuests";
            this.GroupBoxNumberOfGuests.Size = new System.Drawing.Size(376, 147);
            this.GroupBoxNumberOfGuests.TabIndex = 2;
            this.GroupBoxNumberOfGuests.TabStop = false;
            // 
            // LabelSurplusOutput
            // 
            this.LabelSurplusOutput.AutoSize = true;
            this.LabelSurplusOutput.Location = new System.Drawing.Point(193, 107);
            this.LabelSurplusOutput.Name = "LabelSurplusOutput";
            this.LabelSurplusOutput.Size = new System.Drawing.Size(112, 15);
            this.LabelSurplusOutput.TabIndex = 12;
            this.LabelSurplusOutput.Text = "LabelSurplusOutput";
            // 
            // LabelTotalFeesOutput
            // 
            this.LabelTotalFeesOutput.AutoSize = true;
            this.LabelTotalFeesOutput.Location = new System.Drawing.Point(193, 78);
            this.LabelTotalFeesOutput.Name = "LabelTotalFeesOutput";
            this.LabelTotalFeesOutput.Size = new System.Drawing.Size(0, 15);
            this.LabelTotalFeesOutput.TabIndex = 11;
            // 
            // LabelTotalCostOutput
            // 
            this.LabelTotalCostOutput.AutoSize = true;
            this.LabelTotalCostOutput.Location = new System.Drawing.Point(192, 52);
            this.LabelTotalCostOutput.Name = "LabelTotalCostOutput";
            this.LabelTotalCostOutput.Size = new System.Drawing.Size(0, 15);
            this.LabelTotalCostOutput.TabIndex = 10;
            // 
            // LabelNumberOfGuestsOutput
            // 
            this.LabelNumberOfGuestsOutput.AutoSize = true;
            this.LabelNumberOfGuestsOutput.Location = new System.Drawing.Point(192, 28);
            this.LabelNumberOfGuestsOutput.Name = "LabelNumberOfGuestsOutput";
            this.LabelNumberOfGuestsOutput.Size = new System.Drawing.Size(0, 15);
            this.LabelNumberOfGuestsOutput.TabIndex = 6;
            // 
            // LabelSurplus
            // 
            this.LabelSurplus.AutoSize = true;
            this.LabelSurplus.Location = new System.Drawing.Point(15, 107);
            this.LabelSurplus.Name = "LabelSurplus";
            this.LabelSurplus.Size = new System.Drawing.Size(74, 15);
            this.LabelSurplus.TabIndex = 9;
            this.LabelSurplus.Text = "LabelSurplus";
            // 
            // LabelTotalFees
            // 
            this.LabelTotalFees.AutoSize = true;
            this.LabelTotalFees.Location = new System.Drawing.Point(15, 78);
            this.LabelTotalFees.Name = "LabelTotalFees";
            this.LabelTotalFees.Size = new System.Drawing.Size(83, 15);
            this.LabelTotalFees.TabIndex = 8;
            this.LabelTotalFees.Text = "LabelTotalFees";
            // 
            // LabelTotalCost
            // 
            this.LabelTotalCost.AutoSize = true;
            this.LabelTotalCost.Location = new System.Drawing.Point(15, 52);
            this.LabelTotalCost.Name = "LabelTotalCost";
            this.LabelTotalCost.Size = new System.Drawing.Size(84, 15);
            this.LabelTotalCost.TabIndex = 7;
            this.LabelTotalCost.Text = "LabelTotalCost";
            // 
            // LabelNumberOfGuests
            // 
            this.LabelNumberOfGuests.AutoSize = true;
            this.LabelNumberOfGuests.Location = new System.Drawing.Point(15, 28);
            this.LabelNumberOfGuests.Name = "LabelNumberOfGuests";
            this.LabelNumberOfGuests.Size = new System.Drawing.Size(127, 15);
            this.LabelNumberOfGuests.TabIndex = 6;
            this.LabelNumberOfGuests.Text = "LabelNumberOfGuests";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(563, 339);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(84, 23);
            this.ButtonDelete.TabIndex = 4;
            this.ButtonDelete.Text = "ButtonDelete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // LabelGuestList
            // 
            this.LabelGuestList.AutoSize = true;
            this.LabelGuestList.Location = new System.Drawing.Point(564, 22);
            this.LabelGuestList.Name = "LabelGuestList";
            this.LabelGuestList.Size = new System.Drawing.Size(83, 15);
            this.LabelGuestList.TabIndex = 10;
            this.LabelGuestList.Text = "LabelGuestList";
            // 
            // ListBoxGuestList
            // 
            this.ListBoxGuestList.FormattingEnabled = true;
            this.ListBoxGuestList.ItemHeight = 15;
            this.ListBoxGuestList.Location = new System.Drawing.Point(512, 40);
            this.ListBoxGuestList.Name = "ListBoxGuestList";
            this.ListBoxGuestList.Size = new System.Drawing.Size(210, 244);
            this.ListBoxGuestList.TabIndex = 11;
            this.ListBoxGuestList.SelectedIndexChanged += new System.EventHandler(this.ListBoxGuestList_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListBoxGuestList);
            this.Controls.Add(this.LabelGuestList);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.GroupBoxNumberOfGuests);
            this.Controls.Add(this.GroupBoxInviteGuest);
            this.Controls.Add(this.GroupBoxNewParty);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.GroupBoxNewParty.ResumeLayout(false);
            this.GroupBoxNewParty.PerformLayout();
            this.GroupBoxInviteGuest.ResumeLayout(false);
            this.GroupBoxInviteGuest.PerformLayout();
            this.GroupBoxNumberOfGuests.ResumeLayout(false);
            this.GroupBoxNumberOfGuests.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox GroupBoxNewParty;
        private GroupBox GroupBoxInviteGuest;
        private GroupBox GroupBoxNumberOfGuests;
        private TextBox InputFeePerPerson;
        private TextBox InputCostPerPerson;
        private TextBox InputMaxGuests;
        private Button ButtonCreateList;
        private TextBox InputLastName;
        private TextBox InputFirstName;
        private Label LabelMaxGuests;
        private Button ButtonDelete;
        private Label LabelFeePerPerson;
        private Label LabelCostPerPerson;
        private Label LabelSurplusOutput;
        private Label LabelTotalFeesOutput;
        private Label LabelTotalCostOutput;
        private Label LabelNumberOfGuestsOutput;
        private Label LabelSurplus;
        private Label LabelTotalFees;
        private Label LabelTotalCost;
        private Label LabelNumberOfGuests;
        private Button button1;
        private Label LabelLastName;
        private Label LabelFirstName;
        private Label LabelGuestList;
        private ListBox ListBoxGuestList;
    }
}