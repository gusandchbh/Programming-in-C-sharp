﻿namespace Assignment3.Forms
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.groupBoxAnimalSpecifications = new System.Windows.Forms.GroupBox();
            this.buttonDeleteAnimal = new System.Windows.Forms.Button();
            this.buttonDeleteFoodItem = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.labelFoodItemsIngredients = new System.Windows.Forms.Label();
            this.labelFoodItemsName = new System.Windows.Forms.Label();
            this.buttonFoodItems = new System.Windows.Forms.Button();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.labelWeight = new System.Windows.Forms.Label();
            this.textBoxSpecific2 = new System.Windows.Forms.TextBox();
            this.textBoxSpecific1 = new System.Windows.Forms.TextBox();
            this.labelSpecific2 = new System.Windows.Forms.Label();
            this.labelSpecific1 = new System.Windows.Forms.Label();
            this.labelSpecifications = new System.Windows.Forms.Label();
            this.labelGenderType = new System.Windows.Forms.Label();
            this.listBoxGenderType = new System.Windows.Forms.ListBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.listBoxAnimalObject = new System.Windows.Forms.ListBox();
            this.listBoxCategoryType = new System.Windows.Forms.ListBox();
            this.labelAnimalAge = new System.Windows.Forms.Label();
            this.labelAnimalName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelAnimalGender = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.labelEaterType = new System.Windows.Forms.Label();
            this.labelEaterTypeOutput = new System.Windows.Forms.Label();
            this.labelList = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpenTextFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpenJson = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpenBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveAsTextFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveAsJson = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveAsBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileXML = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxAnimalSpecifications.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(297, 258);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(71, 38);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "buttonAdd";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(120, 29);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 23);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(120, 65);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 23);
            this.textBoxAge.TabIndex = 2;
            // 
            // groupBoxAnimalSpecifications
            // 
            this.groupBoxAnimalSpecifications.Controls.Add(this.buttonDeleteAnimal);
            this.groupBoxAnimalSpecifications.Controls.Add(this.buttonDeleteFoodItem);
            this.groupBoxAnimalSpecifications.Controls.Add(this.listBox3);
            this.groupBoxAnimalSpecifications.Controls.Add(this.labelFoodItemsIngredients);
            this.groupBoxAnimalSpecifications.Controls.Add(this.labelFoodItemsName);
            this.groupBoxAnimalSpecifications.Controls.Add(this.buttonFoodItems);
            this.groupBoxAnimalSpecifications.Controls.Add(this.textBoxWeight);
            this.groupBoxAnimalSpecifications.Controls.Add(this.labelWeight);
            this.groupBoxAnimalSpecifications.Controls.Add(this.textBoxSpecific2);
            this.groupBoxAnimalSpecifications.Controls.Add(this.textBoxSpecific1);
            this.groupBoxAnimalSpecifications.Controls.Add(this.labelSpecific2);
            this.groupBoxAnimalSpecifications.Controls.Add(this.labelSpecific1);
            this.groupBoxAnimalSpecifications.Controls.Add(this.labelSpecifications);
            this.groupBoxAnimalSpecifications.Controls.Add(this.labelGenderType);
            this.groupBoxAnimalSpecifications.Controls.Add(this.listBoxGenderType);
            this.groupBoxAnimalSpecifications.Controls.Add(this.labelAge);
            this.groupBoxAnimalSpecifications.Controls.Add(this.labelName);
            this.groupBoxAnimalSpecifications.Controls.Add(this.listBoxAnimalObject);
            this.groupBoxAnimalSpecifications.Controls.Add(this.listBoxCategoryType);
            this.groupBoxAnimalSpecifications.Controls.Add(this.textBoxName);
            this.groupBoxAnimalSpecifications.Controls.Add(this.buttonAdd);
            this.groupBoxAnimalSpecifications.Controls.Add(this.textBoxAge);
            this.groupBoxAnimalSpecifications.Location = new System.Drawing.Point(12, 27);
            this.groupBoxAnimalSpecifications.Name = "groupBoxAnimalSpecifications";
            this.groupBoxAnimalSpecifications.Size = new System.Drawing.Size(807, 318);
            this.groupBoxAnimalSpecifications.TabIndex = 3;
            this.groupBoxAnimalSpecifications.TabStop = false;
            this.groupBoxAnimalSpecifications.Text = "groupBoxAnimalSpecifications";
            // 
            // buttonDeleteAnimal
            // 
            this.buttonDeleteAnimal.Location = new System.Drawing.Point(385, 258);
            this.buttonDeleteAnimal.Name = "buttonDeleteAnimal";
            this.buttonDeleteAnimal.Size = new System.Drawing.Size(74, 38);
            this.buttonDeleteAnimal.TabIndex = 24;
            this.buttonDeleteAnimal.Text = "Delete Animal";
            this.buttonDeleteAnimal.UseVisualStyleBackColor = true;
            this.buttonDeleteAnimal.Click += new System.EventHandler(this.buttonDeleteAnimal_Click);
            // 
            // buttonDeleteFoodItem
            // 
            this.buttonDeleteFoodItem.Location = new System.Drawing.Point(639, 192);
            this.buttonDeleteFoodItem.Name = "buttonDeleteFoodItem";
            this.buttonDeleteFoodItem.Size = new System.Drawing.Size(111, 36);
            this.buttonDeleteFoodItem.TabIndex = 23;
            this.buttonDeleteFoodItem.Text = "Delete";
            this.buttonDeleteFoodItem.UseVisualStyleBackColor = true;
            this.buttonDeleteFoodItem.Click += new System.EventHandler(this.buttonDeleteFoodItem_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 15;
            this.listBox3.Location = new System.Drawing.Point(525, 40);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(225, 139);
            this.listBox3.TabIndex = 22;
            // 
            // labelFoodItemsIngredients
            // 
            this.labelFoodItemsIngredients.AutoSize = true;
            this.labelFoodItemsIngredients.Location = new System.Drawing.Point(654, 18);
            this.labelFoodItemsIngredients.Name = "labelFoodItemsIngredients";
            this.labelFoodItemsIngredients.Size = new System.Drawing.Size(66, 15);
            this.labelFoodItemsIngredients.TabIndex = 21;
            this.labelFoodItemsIngredients.Text = "Ingredients";
            // 
            // labelFoodItemsName
            // 
            this.labelFoodItemsName.AutoSize = true;
            this.labelFoodItemsName.Location = new System.Drawing.Point(531, 16);
            this.labelFoodItemsName.Name = "labelFoodItemsName";
            this.labelFoodItemsName.Size = new System.Drawing.Size(39, 15);
            this.labelFoodItemsName.TabIndex = 20;
            this.labelFoodItemsName.Text = "Name";
            // 
            // buttonFoodItems
            // 
            this.buttonFoodItems.Location = new System.Drawing.Point(545, 191);
            this.buttonFoodItems.Name = "buttonFoodItems";
            this.buttonFoodItems.Size = new System.Drawing.Size(88, 37);
            this.buttonFoodItems.TabIndex = 18;
            this.buttonFoodItems.Text = "Food Items";
            this.buttonFoodItems.UseVisualStyleBackColor = true;
            this.buttonFoodItems.Click += new System.EventHandler(this.buttonFoodItems_Click);
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(120, 104);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(100, 23);
            this.textBoxWeight.TabIndex = 17;
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(16, 104);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(70, 15);
            this.labelWeight.TabIndex = 16;
            this.labelWeight.Text = "labelWeight";
            // 
            // textBoxSpecific2
            // 
            this.textBoxSpecific2.Location = new System.Drawing.Point(155, 273);
            this.textBoxSpecific2.Name = "textBoxSpecific2";
            this.textBoxSpecific2.Size = new System.Drawing.Size(100, 23);
            this.textBoxSpecific2.TabIndex = 15;
            // 
            // textBoxSpecific1
            // 
            this.textBoxSpecific1.Location = new System.Drawing.Point(155, 241);
            this.textBoxSpecific1.Name = "textBoxSpecific1";
            this.textBoxSpecific1.Size = new System.Drawing.Size(100, 23);
            this.textBoxSpecific1.TabIndex = 14;
            // 
            // labelSpecific2
            // 
            this.labelSpecific2.AutoSize = true;
            this.labelSpecific2.Location = new System.Drawing.Point(16, 273);
            this.labelSpecific2.Name = "labelSpecific2";
            this.labelSpecific2.Size = new System.Drawing.Size(79, 15);
            this.labelSpecific2.TabIndex = 13;
            this.labelSpecific2.Text = "labelSpecific2";
            // 
            // labelSpecific1
            // 
            this.labelSpecific1.AutoSize = true;
            this.labelSpecific1.Location = new System.Drawing.Point(18, 244);
            this.labelSpecific1.Name = "labelSpecific1";
            this.labelSpecific1.Size = new System.Drawing.Size(79, 15);
            this.labelSpecific1.TabIndex = 12;
            this.labelSpecific1.Text = "labelSpecific1";
            // 
            // labelSpecifications
            // 
            this.labelSpecifications.AutoSize = true;
            this.labelSpecifications.Location = new System.Drawing.Point(15, 213);
            this.labelSpecifications.Name = "labelSpecifications";
            this.labelSpecifications.Size = new System.Drawing.Size(105, 15);
            this.labelSpecifications.TabIndex = 11;
            this.labelSpecifications.Text = "labelSpecifications";
            // 
            // labelGenderType
            // 
            this.labelGenderType.AutoSize = true;
            this.labelGenderType.Location = new System.Drawing.Point(16, 144);
            this.labelGenderType.Name = "labelGenderType";
            this.labelGenderType.Size = new System.Drawing.Size(94, 15);
            this.labelGenderType.TabIndex = 10;
            this.labelGenderType.Text = "labelGenderType";
            // 
            // listBoxGenderType
            // 
            this.listBoxGenderType.FormattingEnabled = true;
            this.listBoxGenderType.ItemHeight = 15;
            this.listBoxGenderType.Location = new System.Drawing.Point(120, 143);
            this.listBoxGenderType.Name = "listBoxGenderType";
            this.listBoxGenderType.Size = new System.Drawing.Size(126, 34);
            this.listBoxGenderType.TabIndex = 9;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(18, 65);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(53, 15);
            this.labelAge.TabIndex = 8;
            this.labelAge.Text = "labelAge";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(18, 29);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(64, 15);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "labelName";
            // 
            // listBoxAnimalObject
            // 
            this.listBoxAnimalObject.FormattingEnabled = true;
            this.listBoxAnimalObject.ItemHeight = 15;
            this.listBoxAnimalObject.Location = new System.Drawing.Point(374, 40);
            this.listBoxAnimalObject.Name = "listBoxAnimalObject";
            this.listBoxAnimalObject.Size = new System.Drawing.Size(120, 94);
            this.listBoxAnimalObject.TabIndex = 6;
            this.listBoxAnimalObject.SelectedIndexChanged += new System.EventHandler(this.listBoxAnimalObject_SelectedIndexChanged);
            // 
            // listBoxCategoryType
            // 
            this.listBoxCategoryType.FormattingEnabled = true;
            this.listBoxCategoryType.ItemHeight = 15;
            this.listBoxCategoryType.Location = new System.Drawing.Point(248, 40);
            this.listBoxCategoryType.Name = "listBoxCategoryType";
            this.listBoxCategoryType.Size = new System.Drawing.Size(120, 94);
            this.listBoxCategoryType.TabIndex = 5;
            this.listBoxCategoryType.SelectedIndexChanged += new System.EventHandler(this.listBoxCategoryType_SelectedIndexChanged);
            // 
            // labelAnimalAge
            // 
            this.labelAnimalAge.AutoSize = true;
            this.labelAnimalAge.Location = new System.Drawing.Point(454, 348);
            this.labelAnimalAge.Name = "labelAnimalAge";
            this.labelAnimalAge.Size = new System.Drawing.Size(91, 15);
            this.labelAnimalAge.TabIndex = 6;
            this.labelAnimalAge.Text = "labelAnimalAge";
            // 
            // labelAnimalName
            // 
            this.labelAnimalName.AutoSize = true;
            this.labelAnimalName.Location = new System.Drawing.Point(350, 348);
            this.labelAnimalName.Name = "labelAnimalName";
            this.labelAnimalName.Size = new System.Drawing.Size(102, 15);
            this.labelAnimalName.TabIndex = 12;
            this.labelAnimalName.Text = "labelAnimalName";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(301, 348);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(43, 15);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "labelID";
            // 
            // labelAnimalGender
            // 
            this.labelAnimalGender.AutoSize = true;
            this.labelAnimalGender.Location = new System.Drawing.Point(537, 348);
            this.labelAnimalGender.Name = "labelAnimalGender";
            this.labelAnimalGender.Size = new System.Drawing.Size(108, 15);
            this.labelAnimalGender.TabIndex = 8;
            this.labelAnimalGender.Text = "labelAnimalGender";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(301, 369);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(305, 154);
            this.listBox1.TabIndex = 13;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(612, 371);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(207, 154);
            this.listBox2.TabIndex = 14;
            // 
            // labelEaterType
            // 
            this.labelEaterType.AutoSize = true;
            this.labelEaterType.Location = new System.Drawing.Point(619, 351);
            this.labelEaterType.Name = "labelEaterType";
            this.labelEaterType.Size = new System.Drawing.Size(60, 15);
            this.labelEaterType.TabIndex = 15;
            this.labelEaterType.Text = "Eater Type";
            // 
            // labelEaterTypeOutput
            // 
            this.labelEaterTypeOutput.AutoSize = true;
            this.labelEaterTypeOutput.Location = new System.Drawing.Point(723, 351);
            this.labelEaterTypeOutput.Name = "labelEaterTypeOutput";
            this.labelEaterTypeOutput.Size = new System.Drawing.Size(0, 15);
            this.labelEaterTypeOutput.TabIndex = 16;
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Location = new System.Drawing.Point(18, 351);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(50, 15);
            this.labelList.TabIndex = 17;
            this.labelList.Text = "labelList";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 371);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 152);
            this.textBox1.TabIndex = 18;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(831, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(831, 24);
            this.menuStrip2.TabIndex = 20;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.mnuFileOpen,
            this.mnuFileSave,
            this.mnuFileSaveAs,
            this.mnuFileXML,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.Size = new System.Drawing.Size(180, 22);
            this.mnuFileNew.Text = "New";
            this.mnuFileNew.Click += new System.EventHandler(this.mnuFileNew_Click);
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileOpenTextFile,
            this.mnuFileOpenJson,
            this.mnuFileOpenBinary});
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Size = new System.Drawing.Size(180, 22);
            this.mnuFileOpen.Text = "Open ...";
            // 
            // mnuFileOpenTextFile
            // 
            this.mnuFileOpenTextFile.Name = "mnuFileOpenTextFile";
            this.mnuFileOpenTextFile.Size = new System.Drawing.Size(116, 22);
            this.mnuFileOpenTextFile.Text = "Text File";
            this.mnuFileOpenTextFile.Click += new System.EventHandler(this.mnuFileOpenTextFile_Click);
            // 
            // mnuFileOpenJson
            // 
            this.mnuFileOpenJson.Name = "mnuFileOpenJson";
            this.mnuFileOpenJson.Size = new System.Drawing.Size(116, 22);
            this.mnuFileOpenJson.Text = "Json";
            this.mnuFileOpenJson.Click += new System.EventHandler(this.mnuFileOpenJson_Click);
            // 
            // mnuFileOpenBinary
            // 
            this.mnuFileOpenBinary.Name = "mnuFileOpenBinary";
            this.mnuFileOpenBinary.Size = new System.Drawing.Size(116, 22);
            this.mnuFileOpenBinary.Text = "Binary";
            this.mnuFileOpenBinary.Click += new System.EventHandler(this.mnuFileOpenBinary_Click);
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.Size = new System.Drawing.Size(180, 22);
            this.mnuFileSave.Text = "Save";
            this.mnuFileSave.Click += new System.EventHandler(this.mnuFileSave_Click);
            // 
            // mnuFileSaveAs
            // 
            this.mnuFileSaveAs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileSaveAsTextFile,
            this.mnuFileSaveAsJson,
            this.mnuFileSaveAsBinary});
            this.mnuFileSaveAs.Name = "mnuFileSaveAs";
            this.mnuFileSaveAs.Size = new System.Drawing.Size(180, 22);
            this.mnuFileSaveAs.Text = "Save as ...";
            // 
            // mnuFileSaveAsTextFile
            // 
            this.mnuFileSaveAsTextFile.Name = "mnuFileSaveAsTextFile";
            this.mnuFileSaveAsTextFile.Size = new System.Drawing.Size(180, 22);
            this.mnuFileSaveAsTextFile.Text = "Text File";
            this.mnuFileSaveAsTextFile.Click += new System.EventHandler(this.mnuFileSaveAsTextFile_Click);
            // 
            // mnuFileSaveAsJson
            // 
            this.mnuFileSaveAsJson.Name = "mnuFileSaveAsJson";
            this.mnuFileSaveAsJson.Size = new System.Drawing.Size(180, 22);
            this.mnuFileSaveAsJson.Text = "Json";
            this.mnuFileSaveAsJson.Click += new System.EventHandler(this.mnuFileSaveAsJson_Click);
            // 
            // mnuFileSaveAsBinary
            // 
            this.mnuFileSaveAsBinary.Name = "mnuFileSaveAsBinary";
            this.mnuFileSaveAsBinary.Size = new System.Drawing.Size(180, 22);
            this.mnuFileSaveAsBinary.Text = "Binary";
            this.mnuFileSaveAsBinary.Click += new System.EventHandler(this.mnuFileSaveAsBinary_Click);
            // 
            // mnuFileXML
            // 
            this.mnuFileXML.Name = "mnuFileXML";
            this.mnuFileXML.Size = new System.Drawing.Size(180, 22);
            this.mnuFileXML.Text = "XML";
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(180, 22);
            this.mnuFileExit.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 545);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelList);
            this.Controls.Add(this.labelEaterTypeOutput);
            this.Controls.Add(this.labelEaterType);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelAnimalName);
            this.Controls.Add(this.labelAnimalAge);
            this.Controls.Add(this.labelAnimalGender);
            this.Controls.Add(this.groupBoxAnimalSpecifications);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mainform";
            this.Text = "Form1";
            this.groupBoxAnimalSpecifications.ResumeLayout(false);
            this.groupBoxAnimalSpecifications.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonAdd;
        private TextBox textBoxName;
        private TextBox textBoxAge;
        private GroupBox groupBoxAnimalSpecifications;
        private ListBox listBoxAnimalObject;
        private ListBox listBoxCategoryType;
        private Label labelGenderType;
        private ListBox listBoxGenderType;
        private Label labelAge;
        private Label labelName;
        private TextBox textBoxSpecific2;
        private TextBox textBoxSpecific1;
        private Label labelSpecific2;
        private Label labelSpecific1;
        private Label labelSpecifications;
        private TextBox textBoxWeight;
        private Label labelWeight;
        private Label labelAnimalName;
        private Label labelID;
        private Label labelAnimalAge;
        private Label labelAnimalGender;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label labelEaterType;
        private Label labelEaterTypeOutput;
        private Label labelList;
        private TextBox textBox1;
        private Label labelFoodItemsIngredients;
        private Label labelFoodItemsName;
        private TextBox textBox2;
        private Button buttonFoodItems;
        private ListBox listBox3;
        private Button buttonDeleteFoodItem;
        private Button buttonDeleteAnimal;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuFileNew;
        private ToolStripMenuItem mnuFileOpen;
        private ToolStripMenuItem mnuFileSave;
        private ToolStripMenuItem mnuFileSaveAs;
        private ToolStripMenuItem mnuFileXML;
        private ToolStripMenuItem mnuFileExit;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem mnuFileOpenTextFile;
        private ToolStripMenuItem mnuFileOpenJson;
        private ToolStripMenuItem mnuFileOpenBinary;
        private ToolStripMenuItem mnuFileSaveAsTextFile;
        private ToolStripMenuItem mnuFileSaveAsJson;
        private ToolStripMenuItem mnuFileSaveAsBinary;
    }
}