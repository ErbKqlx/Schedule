namespace Schedule_project
{
    partial class FormAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdd));
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonSave = new Button();
            buttonCancel = new Button();
            labelGroup = new Label();
            labelCabinet = new Label();
            labelNumber = new Label();
            labelDiscipline = new Label();
            labelTeacher = new Label();
            comboBoxGroups = new ComboBox();
            comboBoxDisciplines = new ComboBox();
            comboBoxTeachers = new ComboBox();
            comboBoxCabinets = new ComboBox();
            comboBoxNumbers = new ComboBox();
            labelDate = new Label();
            comboBoxDate = new ComboBox();
            labelBuilding = new Label();
            comboBoxBuildings = new ComboBox();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonSave);
            flowLayoutPanel1.Controls.Add(buttonCancel);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 373);
            flowLayoutPanel1.Margin = new Padding(5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(710, 63);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.White;
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.Location = new Point(556, 5);
            buttonSave.Margin = new Padding(5);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(149, 50);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.White;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(397, 5);
            buttonCancel.Margin = new Padding(5);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(149, 50);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = false;
            // 
            // labelGroup
            // 
            labelGroup.AutoSize = true;
            labelGroup.Location = new Point(22, 32);
            labelGroup.Name = "labelGroup";
            labelGroup.Size = new Size(77, 25);
            labelGroup.TabIndex = 1;
            labelGroup.Text = "Группа:";
            // 
            // labelCabinet
            // 
            labelCabinet.AutoSize = true;
            labelCabinet.Location = new Point(22, 225);
            labelCabinet.Name = "labelCabinet";
            labelCabinet.Size = new Size(88, 25);
            labelCabinet.TabIndex = 2;
            labelCabinet.Text = "Кабинет:";
            // 
            // labelNumber
            // 
            labelNumber.AutoSize = true;
            labelNumber.Location = new Point(22, 269);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(81, 25);
            labelNumber.TabIndex = 3;
            labelNumber.Text = "Начало:";
            // 
            // labelDiscipline
            // 
            labelDiscipline.AutoSize = true;
            labelDiscipline.Location = new Point(22, 77);
            labelDiscipline.Name = "labelDiscipline";
            labelDiscipline.Size = new Size(124, 25);
            labelDiscipline.TabIndex = 4;
            labelDiscipline.Text = "Дисциплина:";
            // 
            // labelTeacher
            // 
            labelTeacher.AutoSize = true;
            labelTeacher.Location = new Point(22, 122);
            labelTeacher.Name = "labelTeacher";
            labelTeacher.Size = new Size(151, 25);
            labelTeacher.TabIndex = 5;
            labelTeacher.Text = "Преподаватель:";
            // 
            // comboBoxGroups
            // 
            comboBoxGroups.FormattingEnabled = true;
            comboBoxGroups.Location = new Point(201, 32);
            comboBoxGroups.Name = "comboBoxGroups";
            comboBoxGroups.Size = new Size(387, 33);
            comboBoxGroups.TabIndex = 6;
            // 
            // comboBoxDisciplines
            // 
            comboBoxDisciplines.FormattingEnabled = true;
            comboBoxDisciplines.Location = new Point(201, 77);
            comboBoxDisciplines.Name = "comboBoxDisciplines";
            comboBoxDisciplines.Size = new Size(387, 33);
            comboBoxDisciplines.TabIndex = 7;
            // 
            // comboBoxTeachers
            // 
            comboBoxTeachers.FormattingEnabled = true;
            comboBoxTeachers.Location = new Point(201, 122);
            comboBoxTeachers.Name = "comboBoxTeachers";
            comboBoxTeachers.Size = new Size(387, 33);
            comboBoxTeachers.TabIndex = 8;
            // 
            // comboBoxCabinets
            // 
            comboBoxCabinets.FormattingEnabled = true;
            comboBoxCabinets.Location = new Point(201, 225);
            comboBoxCabinets.Name = "comboBoxCabinets";
            comboBoxCabinets.Size = new Size(387, 33);
            comboBoxCabinets.TabIndex = 9;
            // 
            // comboBoxNumbers
            // 
            comboBoxNumbers.FormattingEnabled = true;
            comboBoxNumbers.Location = new Point(201, 269);
            comboBoxNumbers.Name = "comboBoxNumbers";
            comboBoxNumbers.Size = new Size(387, 33);
            comboBoxNumbers.TabIndex = 10;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(22, 318);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(57, 25);
            labelDate.TabIndex = 11;
            labelDate.Text = "Дата:";
            // 
            // comboBoxDate
            // 
            comboBoxDate.FormattingEnabled = true;
            comboBoxDate.Location = new Point(201, 318);
            comboBoxDate.Name = "comboBoxDate";
            comboBoxDate.Size = new Size(387, 33);
            comboBoxDate.TabIndex = 12;
            // 
            // labelBuilding
            // 
            labelBuilding.AutoSize = true;
            labelBuilding.Location = new Point(22, 174);
            labelBuilding.Name = "labelBuilding";
            labelBuilding.Size = new Size(78, 25);
            labelBuilding.TabIndex = 13;
            labelBuilding.Text = "Корпус:";
            // 
            // comboBoxBuildings
            // 
            comboBoxBuildings.FormattingEnabled = true;
            comboBoxBuildings.Location = new Point(201, 174);
            comboBoxBuildings.Name = "comboBoxBuildings";
            comboBoxBuildings.Size = new Size(387, 33);
            comboBoxBuildings.TabIndex = 14;
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(710, 436);
            Controls.Add(comboBoxBuildings);
            Controls.Add(labelBuilding);
            Controls.Add(comboBoxDate);
            Controls.Add(labelDate);
            Controls.Add(comboBoxNumbers);
            Controls.Add(comboBoxCabinets);
            Controls.Add(comboBoxTeachers);
            Controls.Add(comboBoxDisciplines);
            Controls.Add(comboBoxGroups);
            Controls.Add(labelTeacher);
            Controls.Add(labelDiscipline);
            Controls.Add(labelNumber);
            Controls.Add(labelCabinet);
            Controls.Add(labelGroup);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "FormAdd";
            Text = "Добавление/редактирование пары";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonSave;
        private Button buttonCancel;
        private Label labelGroup;
        private Label labelCabinet;
        private Label labelNumber;
        private Label labelDiscipline;
        private Label labelTeacher;
        private ComboBox comboBoxGroups;
        private ComboBox comboBoxDisciplines;
        private ComboBox comboBoxTeachers;
        private ComboBox comboBoxCabinets;
        private ComboBox comboBoxNumbers;
        private Label labelDate;
        private ComboBox comboBoxDate;
        private Label labelBuilding;
        private ComboBox comboBoxBuildings;
    }
}