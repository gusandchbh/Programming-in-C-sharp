namespace Assignment5_ABC
{
    partial class Mainform
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelNames = new System.Windows.Forms.Label();
            this.labelOfficePhone = new System.Windows.Forms.Label();
            this.labelOfficeEmail = new System.Windows.Forms.Label();
            this.labelContactDetails = new System.Windows.Forms.Label();
            this.textBoxContactDetails = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(93, 364);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(104, 44);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "buttonAdd";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(299, 362);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(96, 44);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "buttonEdit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(506, 362);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(107, 44);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "buttonDelete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(12, 39);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(704, 319);
            this.listBox.TabIndex = 5;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(17, 18);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(42, 15);
            this.labelId.TabIndex = 6;
            this.labelId.Text = "labelId";
            // 
            // labelNames
            // 
            this.labelNames.AutoSize = true;
            this.labelNames.Location = new System.Drawing.Point(151, 21);
            this.labelNames.Name = "labelNames";
            this.labelNames.Size = new System.Drawing.Size(69, 15);
            this.labelNames.TabIndex = 7;
            this.labelNames.Text = "labelNames";
            // 
            // labelOfficePhone
            // 
            this.labelOfficePhone.AutoSize = true;
            this.labelOfficePhone.Location = new System.Drawing.Point(332, 21);
            this.labelOfficePhone.Name = "labelOfficePhone";
            this.labelOfficePhone.Size = new System.Drawing.Size(98, 15);
            this.labelOfficePhone.TabIndex = 8;
            this.labelOfficePhone.Text = "labelOfficePhone";
            // 
            // labelOfficeEmail
            // 
            this.labelOfficeEmail.AutoSize = true;
            this.labelOfficeEmail.Location = new System.Drawing.Point(506, 21);
            this.labelOfficeEmail.Name = "labelOfficeEmail";
            this.labelOfficeEmail.Size = new System.Drawing.Size(93, 15);
            this.labelOfficeEmail.TabIndex = 9;
            this.labelOfficeEmail.Text = "labelOfficeEmail";
            // 
            // labelContactDetails
            // 
            this.labelContactDetails.AutoSize = true;
            this.labelContactDetails.Location = new System.Drawing.Point(790, 21);
            this.labelContactDetails.Name = "labelContactDetails";
            this.labelContactDetails.Size = new System.Drawing.Size(109, 15);
            this.labelContactDetails.TabIndex = 10;
            this.labelContactDetails.Text = "labelContactDetails";
            // 
            // textBoxContactDetails
            // 
            this.textBoxContactDetails.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxContactDetails.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxContactDetails.Location = new System.Drawing.Point(744, 39);
            this.textBoxContactDetails.Multiline = true;
            this.textBoxContactDetails.Name = "textBoxContactDetails";
            this.textBoxContactDetails.ReadOnly = true;
            this.textBoxContactDetails.Size = new System.Drawing.Size(215, 319);
            this.textBoxContactDetails.TabIndex = 11;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 574);
            this.Controls.Add(this.textBoxContactDetails);
            this.Controls.Add(this.labelContactDetails);
            this.Controls.Add(this.labelOfficeEmail);
            this.Controls.Add(this.labelOfficePhone);
            this.Controls.Add(this.labelNames);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Name = "Mainform";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
        private ListBox listBox;
        private Label labelId;
        private Label labelNames;
        private Label labelOfficePhone;
        private Label labelOfficeEmail;
        private Label labelContactDetails;
        private TextBox textBoxContactDetails;
    }
}