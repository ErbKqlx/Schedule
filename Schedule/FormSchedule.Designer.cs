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
            labelCabinet = new Label();
            labelTeacher = new Label();
            labelDiscipline = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            labelDate = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel2 = new Panel();
            panel3 = new Panel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            panel4 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel5 = new Panel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            panel6 = new Panel();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel7 = new Panel();
            flowLayoutPanel5 = new FlowLayoutPanel();
            panel8 = new Panel();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            panel9 = new Panel();
            flowLayoutPanel6 = new FlowLayoutPanel();
            panel10 = new Panel();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            panel11 = new Panel();
            flowLayoutPanel7 = new FlowLayoutPanel();
            panel12 = new Panel();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            comboBoxGroups = new ComboBox();
            buttonAdd = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            panel12.SuspendLayout();
            SuspendLayout();
            // 
            // labelGroup
            // 
            labelGroup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelGroup.AutoSize = true;
            labelGroup.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelGroup.Location = new Point(633, 9);
            labelGroup.Margin = new Padding(5, 0, 5, 0);
            labelGroup.Name = "labelGroup";
            labelGroup.Size = new Size(89, 37);
            labelGroup.TabIndex = 0;
            labelGroup.Text = "group";
            labelGroup.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelCabinet
            // 
            labelCabinet.Dock = DockStyle.Bottom;
            labelCabinet.Location = new Point(0, 172);
            labelCabinet.Margin = new Padding(5, 0, 5, 0);
            labelCabinet.Name = "labelCabinet";
            labelCabinet.RightToLeft = RightToLeft.No;
            labelCabinet.Size = new Size(193, 25);
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(5, 35);
            flowLayoutPanel1.Margin = new Padding(5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(201, 475);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(labelCabinet);
            panel1.Controls.Add(labelTeacher);
            panel1.Controls.Add(labelDiscipline);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(195, 199);
            panel1.TabIndex = 0;
            panel1.Visible = false;
            panel1.MouseClick += Panel_MouseClick;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelDate.ImageAlign = ContentAlignment.TopLeft;
            labelDate.Location = new Point(8, 5);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(51, 25);
            labelDate.TabIndex = 9;
            labelDate.Text = "date";
            labelDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(panel2);
            flowLayoutPanel2.Controls.Add(panel3);
            flowLayoutPanel2.Controls.Add(panel5);
            flowLayoutPanel2.Controls.Add(panel7);
            flowLayoutPanel2.Controls.Add(panel9);
            flowLayoutPanel2.Controls.Add(panel11);
            flowLayoutPanel2.Location = new Point(12, 52);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1297, 527);
            flowLayoutPanel2.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(labelDate);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(210, 515);
            panel2.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.Controls.Add(flowLayoutPanel3);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(219, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(210, 515);
            panel3.TabIndex = 12;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(panel4);
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(5, 35);
            flowLayoutPanel3.Margin = new Padding(5);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(201, 475);
            flowLayoutPanel3.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label1);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.RightToLeft = RightToLeft.No;
            panel4.Size = new Size(195, 199);
            panel4.TabIndex = 0;
            panel4.Visible = false;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Bottom;
            label1.Location = new Point(0, 172);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(193, 25);
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ImageAlign = ContentAlignment.TopLeft;
            label4.Location = new Point(8, 5);
            label4.Name = "label4";
            label4.Size = new Size(51, 25);
            label4.TabIndex = 9;
            label4.Text = "date";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.Controls.Add(flowLayoutPanel4);
            panel5.Controls.Add(label8);
            panel5.Location = new Point(435, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(210, 515);
            panel5.TabIndex = 13;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(panel6);
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(5, 35);
            flowLayoutPanel4.Margin = new Padding(5);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(201, 475);
            flowLayoutPanel4.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.BackColor = Color.WhiteSmoke;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label5);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.RightToLeft = RightToLeft.No;
            panel6.Size = new Size(195, 199);
            panel6.TabIndex = 0;
            panel6.Visible = false;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Bottom;
            label5.Location = new Point(0, 172);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(193, 25);
            label5.TabIndex = 1;
            label5.Text = "cabinet";
            label5.TextAlign = ContentAlignment.BottomRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Top;
            label6.Location = new Point(0, 35);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.MaximumSize = new Size(193, 0);
            label6.Name = "label6";
            label6.Padding = new Padding(0, 0, 0, 10);
            label6.Size = new Size(75, 35);
            label6.TabIndex = 3;
            label6.Text = "teacher";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Top;
            label7.Location = new Point(0, 0);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.MaximumSize = new Size(193, 0);
            label7.Name = "label7";
            label7.Padding = new Padding(0, 0, 0, 10);
            label7.Size = new Size(92, 35);
            label7.TabIndex = 4;
            label7.Text = "discipline";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.ImageAlign = ContentAlignment.TopLeft;
            label8.Location = new Point(8, 5);
            label8.Name = "label8";
            label8.Size = new Size(51, 25);
            label8.TabIndex = 9;
            label8.Text = "date";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            panel7.Controls.Add(flowLayoutPanel5);
            panel7.Controls.Add(label12);
            panel7.Location = new Point(651, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(210, 515);
            panel7.TabIndex = 14;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(panel8);
            flowLayoutPanel5.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel5.Location = new Point(5, 35);
            flowLayoutPanel5.Margin = new Padding(5);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(201, 475);
            flowLayoutPanel5.TabIndex = 6;
            // 
            // panel8
            // 
            panel8.BackColor = Color.WhiteSmoke;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(label9);
            panel8.Controls.Add(label10);
            panel8.Controls.Add(label11);
            panel8.Location = new Point(3, 3);
            panel8.Name = "panel8";
            panel8.RightToLeft = RightToLeft.No;
            panel8.Size = new Size(195, 199);
            panel8.TabIndex = 0;
            panel8.Visible = false;
            // 
            // label9
            // 
            label9.Dock = DockStyle.Bottom;
            label9.Location = new Point(0, 172);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.No;
            label9.Size = new Size(193, 25);
            label9.TabIndex = 1;
            label9.Text = "cabinet";
            label9.TextAlign = ContentAlignment.BottomRight;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Top;
            label10.Location = new Point(0, 35);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.MaximumSize = new Size(193, 0);
            label10.Name = "label10";
            label10.Padding = new Padding(0, 0, 0, 10);
            label10.Size = new Size(75, 35);
            label10.TabIndex = 3;
            label10.Text = "teacher";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Top;
            label11.Location = new Point(0, 0);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.MaximumSize = new Size(193, 0);
            label11.Name = "label11";
            label11.Padding = new Padding(0, 0, 0, 10);
            label11.Size = new Size(92, 35);
            label11.TabIndex = 4;
            label11.Text = "discipline";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label12.ImageAlign = ContentAlignment.TopLeft;
            label12.Location = new Point(8, 5);
            label12.Name = "label12";
            label12.Size = new Size(51, 25);
            label12.TabIndex = 9;
            label12.Text = "date";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            panel9.Controls.Add(flowLayoutPanel6);
            panel9.Controls.Add(label16);
            panel9.Location = new Point(867, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(210, 515);
            panel9.TabIndex = 14;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Controls.Add(panel10);
            flowLayoutPanel6.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel6.Location = new Point(5, 35);
            flowLayoutPanel6.Margin = new Padding(5);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(201, 475);
            flowLayoutPanel6.TabIndex = 6;
            // 
            // panel10
            // 
            panel10.BackColor = Color.WhiteSmoke;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(label13);
            panel10.Controls.Add(label14);
            panel10.Controls.Add(label15);
            panel10.Location = new Point(3, 3);
            panel10.Name = "panel10";
            panel10.RightToLeft = RightToLeft.No;
            panel10.Size = new Size(195, 199);
            panel10.TabIndex = 0;
            panel10.Visible = false;
            // 
            // label13
            // 
            label13.Dock = DockStyle.Bottom;
            label13.Location = new Point(0, 172);
            label13.Margin = new Padding(5, 0, 5, 0);
            label13.Name = "label13";
            label13.RightToLeft = RightToLeft.No;
            label13.Size = new Size(193, 25);
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
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label16.ImageAlign = ContentAlignment.TopLeft;
            label16.Location = new Point(8, 5);
            label16.Name = "label16";
            label16.Size = new Size(51, 25);
            label16.TabIndex = 9;
            label16.Text = "date";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel11
            // 
            panel11.Controls.Add(flowLayoutPanel7);
            panel11.Controls.Add(label20);
            panel11.Location = new Point(1083, 3);
            panel11.Name = "panel11";
            panel11.Size = new Size(210, 515);
            panel11.TabIndex = 14;
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.Controls.Add(panel12);
            flowLayoutPanel7.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel7.Location = new Point(5, 35);
            flowLayoutPanel7.Margin = new Padding(5);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(201, 475);
            flowLayoutPanel7.TabIndex = 6;
            // 
            // panel12
            // 
            panel12.BackColor = Color.WhiteSmoke;
            panel12.BorderStyle = BorderStyle.FixedSingle;
            panel12.Controls.Add(label17);
            panel12.Controls.Add(label18);
            panel12.Controls.Add(label19);
            panel12.Location = new Point(3, 3);
            panel12.Name = "panel12";
            panel12.RightToLeft = RightToLeft.No;
            panel12.Size = new Size(195, 199);
            panel12.TabIndex = 0;
            panel12.Visible = false;
            // 
            // label17
            // 
            label17.Dock = DockStyle.Bottom;
            label17.Location = new Point(0, 172);
            label17.Margin = new Padding(5, 0, 5, 0);
            label17.Name = "label17";
            label17.RightToLeft = RightToLeft.No;
            label17.Size = new Size(193, 25);
            label17.TabIndex = 1;
            label17.Text = "cabinet";
            label17.TextAlign = ContentAlignment.BottomRight;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Dock = DockStyle.Top;
            label18.Location = new Point(0, 35);
            label18.Margin = new Padding(5, 0, 5, 0);
            label18.MaximumSize = new Size(193, 0);
            label18.Name = "label18";
            label18.Padding = new Padding(0, 0, 0, 10);
            label18.Size = new Size(75, 35);
            label18.TabIndex = 3;
            label18.Text = "teacher";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Dock = DockStyle.Top;
            label19.Location = new Point(0, 0);
            label19.Margin = new Padding(5, 0, 5, 0);
            label19.MaximumSize = new Size(193, 0);
            label19.Name = "label19";
            label19.Padding = new Padding(0, 0, 0, 10);
            label19.Size = new Size(92, 35);
            label19.TabIndex = 4;
            label19.Text = "discipline";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label20.ImageAlign = ContentAlignment.TopLeft;
            label20.Location = new Point(8, 5);
            label20.Name = "label20";
            label20.Size = new Size(51, 25);
            label20.TabIndex = 9;
            label20.Text = "date";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // comboBoxGroups
            // 
            comboBoxGroups.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxGroups.FormattingEnabled = true;
            comboBoxGroups.Location = new Point(1167, 13);
            comboBoxGroups.Name = "comboBoxGroups";
            comboBoxGroups.Size = new Size(143, 33);
            comboBoxGroups.TabIndex = 11;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.White;
            buttonAdd.Location = new Point(12, 9);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(155, 34);
            buttonAdd.TabIndex = 12;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += ButtonAdd_Click;
            // 
            // FormSchedule
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1322, 591);
            Controls.Add(buttonAdd);
            Controls.Add(comboBoxGroups);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(labelGroup);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "FormSchedule";
            Text = "Расписание";
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            flowLayoutPanel7.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelGroup;
        private Label labelCabinet;
        private Label labelTeacher;
        private Label labelDiscipline;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label labelDate;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel2;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox comboBoxGroups;
        private Button buttonAdd;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel3;
        private Panel panel4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel5;
        private FlowLayoutPanel flowLayoutPanel4;
        private Panel panel6;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Panel panel7;
        private FlowLayoutPanel flowLayoutPanel5;
        private Panel panel8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Panel panel9;
        private FlowLayoutPanel flowLayoutPanel6;
        private Panel panel10;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Panel panel11;
        private FlowLayoutPanel flowLayoutPanel7;
        private Panel panel12;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
    }
}