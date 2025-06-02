namespace Schedule_project
{
    partial class FormSchedule
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSchedule));
            labelGroup = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            comboBoxGroups = new ComboBox();
            buttonAdd = new Button();
            panel13 = new Panel();
            buttonCheckWorkload = new Button();
            panel1 = new Panel();
            labelCabinet = new Label();
            labelTeacher = new Label();
            labelDiscipline = new Label();
            labelDate1 = new Label();
            tableLayoutPanelSchedule = new TableLayoutPanel();
            sixth = new Label();
            fifth = new Label();
            fourth = new Label();
            third = new Label();
            second = new Label();
            labelDate6 = new Label();
            labelDate5 = new Label();
            labelDate4 = new Label();
            labelDate3 = new Label();
            labelDate2 = new Label();
            panel6 = new Panel();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            panel5 = new Panel();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            panel4 = new Panel();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            first = new Label();
            panel13.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanelSchedule.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // labelGroup
            // 
            labelGroup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelGroup.AutoSize = true;
            labelGroup.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelGroup.Location = new Point(734, 10);
            labelGroup.Margin = new Padding(5, 0, 5, 0);
            labelGroup.Name = "labelGroup";
            labelGroup.Size = new Size(89, 37);
            labelGroup.TabIndex = 0;
            labelGroup.Text = "group";
            labelGroup.TextAlign = ContentAlignment.TopCenter;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // comboBoxGroups
            // 
            comboBoxGroups.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxGroups.FormattingEnabled = true;
            comboBoxGroups.Location = new Point(1275, 11);
            comboBoxGroups.Name = "comboBoxGroups";
            comboBoxGroups.Size = new Size(133, 33);
            comboBoxGroups.TabIndex = 11;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.White;
            buttonAdd.Location = new Point(4, 11);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(155, 39);
            buttonAdd.TabIndex = 12;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += ButtonAdd_Click;
            // 
            // panel13
            // 
            panel13.Controls.Add(buttonCheckWorkload);
            panel13.Controls.Add(buttonAdd);
            panel13.Controls.Add(labelGroup);
            panel13.Controls.Add(comboBoxGroups);
            panel13.Dock = DockStyle.Top;
            panel13.Location = new Point(10, 10);
            panel13.Name = "panel13";
            panel13.Padding = new Padding(5);
            panel13.Size = new Size(1412, 59);
            panel13.TabIndex = 13;
            // 
            // buttonCheckWorkload
            // 
            buttonCheckWorkload.BackColor = Color.White;
            buttonCheckWorkload.Location = new Point(165, 11);
            buttonCheckWorkload.Name = "buttonCheckWorkload";
            buttonCheckWorkload.Size = new Size(290, 39);
            buttonCheckWorkload.TabIndex = 13;
            buttonCheckWorkload.Text = "Проверить нагрузку по часам";
            buttonCheckWorkload.UseVisualStyleBackColor = false;
            buttonCheckWorkload.Click += ButtonCheckWorkload_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(labelCabinet);
            panel1.Controls.Add(labelTeacher);
            panel1.Controls.Add(labelDiscipline);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(30, 30);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(227, 225);
            panel1.TabIndex = 14;
            panel1.Visible = false;
            // 
            // labelCabinet
            // 
            labelCabinet.AutoSize = true;
            labelCabinet.Dock = DockStyle.Bottom;
            labelCabinet.Location = new Point(0, 198);
            labelCabinet.Margin = new Padding(5, 0, 5, 0);
            labelCabinet.Name = "labelCabinet";
            labelCabinet.RightToLeft = RightToLeft.No;
            labelCabinet.Size = new Size(74, 25);
            labelCabinet.TabIndex = 1;
            labelCabinet.Text = "cabinet";
            labelCabinet.TextAlign = ContentAlignment.BottomRight;
            // 
            // labelTeacher
            // 
            labelTeacher.AutoSize = true;
            labelTeacher.Dock = DockStyle.Top;
            labelTeacher.Location = new Point(0, 35);
            labelTeacher.Margin = new Padding(5, 0, 5, 0);
            labelTeacher.MaximumSize = new Size(193, 0);
            labelTeacher.Name = "labelTeacher";
            labelTeacher.Padding = new Padding(0, 0, 0, 10);
            labelTeacher.Size = new Size(75, 35);
            labelTeacher.TabIndex = 3;
            labelTeacher.Text = "teacher";
            // 
            // labelDiscipline
            // 
            labelDiscipline.AutoSize = true;
            labelDiscipline.Dock = DockStyle.Top;
            labelDiscipline.Location = new Point(0, 0);
            labelDiscipline.Margin = new Padding(5, 0, 5, 0);
            labelDiscipline.MaximumSize = new Size(193, 0);
            labelDiscipline.Name = "labelDiscipline";
            labelDiscipline.Padding = new Padding(0, 0, 0, 10);
            labelDiscipline.Size = new Size(92, 35);
            labelDiscipline.TabIndex = 4;
            labelDiscipline.Text = "discipline";
            // 
            // labelDate1
            // 
            labelDate1.AutoSize = true;
            labelDate1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelDate1.ImageAlign = ContentAlignment.TopLeft;
            labelDate1.Location = new Point(30, 1);
            labelDate1.Name = "labelDate1";
            labelDate1.Size = new Size(51, 25);
            labelDate1.TabIndex = 15;
            labelDate1.Text = "date";
            labelDate1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelSchedule
            // 
            tableLayoutPanelSchedule.AutoScroll = true;
            tableLayoutPanelSchedule.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanelSchedule.ColumnCount = 7;
            tableLayoutPanelSchedule.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            tableLayoutPanelSchedule.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelSchedule.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelSchedule.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelSchedule.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelSchedule.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelSchedule.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelSchedule.Controls.Add(sixth, 0, 6);
            tableLayoutPanelSchedule.Controls.Add(fifth, 0, 5);
            tableLayoutPanelSchedule.Controls.Add(fourth, 0, 4);
            tableLayoutPanelSchedule.Controls.Add(third, 0, 3);
            tableLayoutPanelSchedule.Controls.Add(second, 0, 2);
            tableLayoutPanelSchedule.Controls.Add(labelDate6, 6, 0);
            tableLayoutPanelSchedule.Controls.Add(labelDate5, 5, 0);
            tableLayoutPanelSchedule.Controls.Add(labelDate4, 4, 0);
            tableLayoutPanelSchedule.Controls.Add(labelDate3, 3, 0);
            tableLayoutPanelSchedule.Controls.Add(labelDate2, 2, 0);
            tableLayoutPanelSchedule.Controls.Add(panel6, 6, 1);
            tableLayoutPanelSchedule.Controls.Add(panel5, 5, 1);
            tableLayoutPanelSchedule.Controls.Add(panel4, 4, 1);
            tableLayoutPanelSchedule.Controls.Add(panel3, 3, 1);
            tableLayoutPanelSchedule.Controls.Add(panel2, 2, 1);
            tableLayoutPanelSchedule.Controls.Add(panel1, 1, 1);
            tableLayoutPanelSchedule.Controls.Add(labelDate1, 1, 0);
            tableLayoutPanelSchedule.Controls.Add(first, 0, 1);
            tableLayoutPanelSchedule.Dock = DockStyle.Fill;
            tableLayoutPanelSchedule.Location = new Point(10, 69);
            tableLayoutPanelSchedule.Name = "tableLayoutPanelSchedule";
            tableLayoutPanelSchedule.RowCount = 7;
            tableLayoutPanelSchedule.RowStyles.Add(new RowStyle());
            tableLayoutPanelSchedule.RowStyles.Add(new RowStyle());
            tableLayoutPanelSchedule.RowStyles.Add(new RowStyle());
            tableLayoutPanelSchedule.RowStyles.Add(new RowStyle());
            tableLayoutPanelSchedule.RowStyles.Add(new RowStyle());
            tableLayoutPanelSchedule.RowStyles.Add(new RowStyle());
            tableLayoutPanelSchedule.RowStyles.Add(new RowStyle());
            tableLayoutPanelSchedule.Size = new Size(1412, 512);
            tableLayoutPanelSchedule.TabIndex = 16;
            // 
            // sixth
            // 
            sixth.Dock = DockStyle.Fill;
            sixth.Location = new Point(4, 1187);
            sixth.Name = "sixth";
            sixth.Size = new Size(19, 231);
            sixth.TabIndex = 31;
            sixth.Text = "6";
            sixth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fifth
            // 
            fifth.Dock = DockStyle.Fill;
            fifth.Location = new Point(4, 955);
            fifth.Name = "fifth";
            fifth.Size = new Size(19, 231);
            fifth.TabIndex = 30;
            fifth.Text = "5";
            fifth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fourth
            // 
            fourth.Dock = DockStyle.Fill;
            fourth.Location = new Point(4, 723);
            fourth.Name = "fourth";
            fourth.Size = new Size(19, 231);
            fourth.TabIndex = 29;
            fourth.Text = "4";
            fourth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // third
            // 
            third.Dock = DockStyle.Fill;
            third.Location = new Point(4, 491);
            third.Name = "third";
            third.Size = new Size(19, 231);
            third.TabIndex = 28;
            third.Text = "3";
            third.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // second
            // 
            second.Dock = DockStyle.Fill;
            second.Location = new Point(4, 259);
            second.Name = "second";
            second.Size = new Size(19, 231);
            second.TabIndex = 27;
            second.Text = "2";
            second.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDate6
            // 
            labelDate6.AutoSize = true;
            labelDate6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelDate6.ImageAlign = ContentAlignment.TopLeft;
            labelDate6.Location = new Point(1200, 1);
            labelDate6.Name = "labelDate6";
            labelDate6.Size = new Size(51, 25);
            labelDate6.TabIndex = 25;
            labelDate6.Text = "date";
            labelDate6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDate5
            // 
            labelDate5.AutoSize = true;
            labelDate5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelDate5.ImageAlign = ContentAlignment.TopLeft;
            labelDate5.Location = new Point(966, 1);
            labelDate5.Name = "labelDate5";
            labelDate5.Size = new Size(51, 25);
            labelDate5.TabIndex = 24;
            labelDate5.Text = "date";
            labelDate5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDate4
            // 
            labelDate4.AutoSize = true;
            labelDate4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelDate4.ImageAlign = ContentAlignment.TopLeft;
            labelDate4.Location = new Point(732, 1);
            labelDate4.Name = "labelDate4";
            labelDate4.Size = new Size(51, 25);
            labelDate4.TabIndex = 23;
            labelDate4.Text = "date";
            labelDate4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDate3
            // 
            labelDate3.AutoSize = true;
            labelDate3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelDate3.ImageAlign = ContentAlignment.TopLeft;
            labelDate3.Location = new Point(498, 1);
            labelDate3.Name = "labelDate3";
            labelDate3.Size = new Size(51, 25);
            labelDate3.TabIndex = 22;
            labelDate3.Text = "date";
            labelDate3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDate2
            // 
            labelDate2.AutoSize = true;
            labelDate2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelDate2.ImageAlign = ContentAlignment.TopLeft;
            labelDate2.Location = new Point(264, 1);
            labelDate2.Name = "labelDate2";
            labelDate2.Size = new Size(51, 25);
            labelDate2.TabIndex = 21;
            labelDate2.Text = "date";
            labelDate2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.BackColor = Color.WhiteSmoke;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label13);
            panel6.Controls.Add(label14);
            panel6.Controls.Add(label15);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(1200, 30);
            panel6.Name = "panel6";
            panel6.RightToLeft = RightToLeft.No;
            panel6.Size = new Size(316, 225);
            panel6.TabIndex = 20;
            panel6.Visible = false;
            // 
            // label13
            // 
            label13.Dock = DockStyle.Bottom;
            label13.Location = new Point(0, 198);
            label13.Margin = new Padding(5, 0, 5, 0);
            label13.Name = "label13";
            label13.RightToLeft = RightToLeft.No;
            label13.Size = new Size(314, 25);
            label13.TabIndex = 1;
            label13.Text = "cabinet";
            label13.TextAlign = ContentAlignment.BottomRight;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Dock = DockStyle.Top;
            label14.Location = new Point(0, 35);
            label14.Margin = new Padding(5, 0, 5, 0);
            label14.MaximumSize = new Size(193, 0);
            label14.Name = "label14";
            label14.Padding = new Padding(0, 0, 0, 10);
            label14.Size = new Size(75, 35);
            label14.TabIndex = 3;
            label14.Text = "teacher";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Dock = DockStyle.Top;
            label15.Location = new Point(0, 0);
            label15.Margin = new Padding(5, 0, 5, 0);
            label15.MaximumSize = new Size(193, 0);
            label15.Name = "label15";
            label15.Padding = new Padding(0, 0, 0, 10);
            label15.Size = new Size(92, 35);
            label15.TabIndex = 4;
            label15.Text = "discipline";
            // 
            // panel5
            // 
            panel5.BackColor = Color.WhiteSmoke;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(label12);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(966, 30);
            panel5.Name = "panel5";
            panel5.RightToLeft = RightToLeft.No;
            panel5.Size = new Size(227, 225);
            panel5.TabIndex = 19;
            panel5.Visible = false;
            // 
            // label10
            // 
            label10.Dock = DockStyle.Bottom;
            label10.Location = new Point(0, 198);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.No;
            label10.Size = new Size(225, 25);
            label10.TabIndex = 1;
            label10.Text = "cabinet";
            label10.TextAlign = ContentAlignment.BottomRight;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Top;
            label11.Location = new Point(0, 35);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.MaximumSize = new Size(193, 0);
            label11.Name = "label11";
            label11.Padding = new Padding(0, 0, 0, 10);
            label11.Size = new Size(75, 35);
            label11.TabIndex = 3;
            label11.Text = "teacher";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Top;
            label12.Location = new Point(0, 0);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.MaximumSize = new Size(193, 0);
            label12.Name = "label12";
            label12.Padding = new Padding(0, 0, 0, 10);
            label12.Size = new Size(92, 35);
            label12.TabIndex = 4;
            label12.Text = "discipline";
            // 
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label9);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(732, 30);
            panel4.Name = "panel4";
            panel4.RightToLeft = RightToLeft.No;
            panel4.Size = new Size(227, 225);
            panel4.TabIndex = 18;
            panel4.Visible = false;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Bottom;
            label7.Location = new Point(0, 198);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(225, 25);
            label7.TabIndex = 1;
            label7.Text = "cabinet";
            label7.TextAlign = ContentAlignment.BottomRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Top;
            label8.Location = new Point(0, 35);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.MaximumSize = new Size(193, 0);
            label8.Name = "label8";
            label8.Padding = new Padding(0, 0, 0, 10);
            label8.Size = new Size(75, 35);
            label8.TabIndex = 3;
            label8.Text = "teacher";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Top;
            label9.Location = new Point(0, 0);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.MaximumSize = new Size(193, 0);
            label9.Name = "label9";
            label9.Padding = new Padding(0, 0, 0, 10);
            label9.Size = new Size(92, 35);
            label9.TabIndex = 4;
            label9.Text = "discipline";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(498, 30);
            panel3.Name = "panel3";
            panel3.RightToLeft = RightToLeft.No;
            panel3.Size = new Size(227, 225);
            panel3.TabIndex = 17;
            panel3.Visible = false;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Bottom;
            label4.Location = new Point(0, 198);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(225, 25);
            label4.TabIndex = 1;
            label4.Text = "cabinet";
            label4.TextAlign = ContentAlignment.BottomRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Location = new Point(0, 35);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.MaximumSize = new Size(193, 0);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 0, 0, 10);
            label5.Size = new Size(75, 35);
            label5.TabIndex = 3;
            label5.Text = "teacher";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Top;
            label6.Location = new Point(0, 0);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.MaximumSize = new Size(193, 0);
            label6.Name = "label6";
            label6.Padding = new Padding(0, 0, 0, 10);
            label6.Size = new Size(92, 35);
            label6.TabIndex = 4;
            label6.Text = "discipline";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(264, 30);
            panel2.Name = "panel2";
            panel2.RightToLeft = RightToLeft.No;
            panel2.Size = new Size(227, 225);
            panel2.TabIndex = 16;
            panel2.Visible = false;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Bottom;
            label1.Location = new Point(0, 198);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(225, 25);
            label1.TabIndex = 1;
            label1.Text = "cabinet";
            label1.TextAlign = ContentAlignment.BottomRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(0, 35);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.MaximumSize = new Size(193, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 0, 10);
            label2.Size = new Size(75, 35);
            label2.TabIndex = 3;
            label2.Text = "teacher";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.MaximumSize = new Size(193, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 0, 0, 10);
            label3.Size = new Size(92, 35);
            label3.TabIndex = 4;
            label3.Text = "discipline";
            // 
            // first
            // 
            first.Dock = DockStyle.Fill;
            first.Location = new Point(4, 27);
            first.Name = "first";
            first.Size = new Size(19, 231);
            first.TabIndex = 26;
            first.Text = "1";
            first.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormSchedule
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1432, 591);
            Controls.Add(tableLayoutPanelSchedule);
            Controls.Add(panel13);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "FormSchedule";
            Padding = new Padding(10);
            Text = "Расписание";
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanelSchedule.ResumeLayout(false);
            tableLayoutPanelSchedule.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelGroup;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox comboBoxGroups;
        private Button buttonAdd;
        private Panel panel13;
        private Panel panel1;
        private Label labelCabinet;
        private Label labelTeacher;
        private Label labelDiscipline;
        private Label labelDate1;
        private TableLayoutPanel tableLayoutPanelSchedule;
        private Panel panel6;
        private Label label13;
        private Label label14;
        private Label label15;
        private Panel panel5;
        private Label label10;
        private Label label11;
        private Label label12;
        private Panel panel4;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel panel3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelDate6;
        private Label labelDate5;
        private Label labelDate4;
        private Label labelDate3;
        private Label labelDate2;
        private Label first;
        private Label second;
        private Label third;
        private Label sixth;
        private Label fifth;
        private Label fourth;
        private Button buttonCheckWorkload;
    }
}